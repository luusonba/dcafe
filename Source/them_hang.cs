using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TTTT
{
    public partial class them_hang : Form
    {
        public them_hang()
        {
            InitializeComponent();
        }
        void load_mh_th()
        {
            conn con = new conn();
            SqlConnection conn = con.con();
            conn.Open();
            mahang.Items.Clear();
            tenhang.Items.Clear();
            mv.Items.Clear();
            string str = "select MA_HH,rtrim(TEN_HH),ma_vach from HANGHOA";
            SqlDataAdapter dl = new SqlDataAdapter(str, conn);
            DataTable b1 = new DataTable();

            dl.Fill(b1);
            for (int i = 0; i < b1.Rows.Count; i++)
            {
                mahang.Items.Add(b1.Rows[i][0].ToString());
                tenhang.Items.Add(b1.Rows[i][1].ToString());
                mv.Items.Add(b1.Rows[i][2].ToString());

            }
            mahang.Text = b1.Rows[0][0].ToString();
            conn.Close();
        }
        void load(){
            conn con = new conn();
            SqlConnection conn = con.con();
            conn.Open();
            
            chungloai.Items.Clear();
            dvt.Items.Clear();
            vtk.Items.Clear();
            
            string str = "select distinct rtrim(chung_loai) from hanghoa";
            SqlDataAdapter dl1 = new SqlDataAdapter(str, conn);
            DataTable b2 = new DataTable();
            dl1.Fill(b2);
            for (int i = 0; i < b2.Rows.Count; i++)
            {
                chungloai.Items.Add(b2.Rows[i][0].ToString());
            }
            str = "select distinct rtrim(DVT) from hanghoa";
            SqlDataAdapter dl2 = new SqlDataAdapter(str, conn);
            DataTable b3 = new DataTable();
            dl2.Fill(b3);
            for (int i = 0; i < b3.Rows.Count; i++)
            {
                dvt.Items.Add(b3.Rows[i][0].ToString());
            }
            str = "select distinct rtrim(dien_giai) from kho";
            SqlDataAdapter dl3 = new SqlDataAdapter(str, conn);
            DataTable b4 = new DataTable();
            dl3.Fill(b4);
            for (int i = 0; i < b4.Rows.Count; i++)
            {
                vtk.Items.Add(b4.Rows[i][0].ToString());
            }
            conn.Close();
        }
        string mvtk() {
            conn con = new conn();
            SqlConnection conn1 = con.con();
            conn1.Open();
            string str = "select distinct ma_vtk from kho where dien_giai='"+vtk.Text+"'";
            SqlDataAdapter dl3 = new SqlDataAdapter(str, conn1);
            DataTable b4 = new DataTable();
            dl3.Fill(b4);
            conn1.Close();
            return b4.Rows[0][0].ToString();
        }
        string mahg() {
            string mh="",cl="",th="";
            int a;
            cl = Convert.ToString(chungloai.Text[0]);
            for (a = 0; a < chungloai.Text.Length; a++) if (Convert.ToString(chungloai.Text[a]) == " ") break;
            cl = cl + Convert.ToString(chungloai.Text[a+1]);
            th = Convert.ToString(tenhang.Text[0]);
            for (a = 0; a < tenhang.Text.Length; a++) if (Convert.ToString(tenhang.Text[a]) == " ") break;
            th = th + Convert.ToString(tenhang.Text[a + 1]);
            mh=cl+th;
            conn con = new conn();
            SqlConnection conn1 = con.con();
            conn1.Open();
            string str = "select COUNT(*) from HANGHOA where MA_HH like('"+mh+"%')";
            SqlDataAdapter dl3 = new SqlDataAdapter(str, conn1);
            DataTable b4 = new DataTable();
            dl3.Fill(b4);
            a = Convert.ToInt32(b4.Rows[0][0].ToString());
            if (a < 9) mh = mh + "00" + (a + 1);
            else if (a < 99) mh = mh + "0" + (a + 1);
            else mh = mh + (a+1);
            conn1.Close();
            return mh;
        }
        int kt = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            mo();
            kt = 1;
            /*conn con = new conn();
            SqlConnection conn = con.con();
            conn.Open();
            string str = "select MA_HH,rtrim(TEN_HH) from hanghoa";
            SqlDataAdapter da = new SqlDataAdapter(str, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            
            conn.Close();*/
        }

        private void them_hang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_in.HANGHOA' table. You can move, or remove it, as needed.
            load_mh_th();
            load_dshh();
            load_dvt_kho();
        }
        void load_dshh() {
            conn con = new conn();
            SqlConnection conn = con.con();
            conn.Open();
            string str = "select MA_HH,rtrim(TEN_HH),rtrim(CHUNG_LOAI),rtrim(DVT),SL_TK,rtrim(CONVERT(char,HAN_SD,3)),THUE,DIEN_GIAI,MA_VACH from HANGHOA,KHO where HANGHOA.MA_VTK=KHO.MA_VTK";
            SqlDataAdapter da = new SqlDataAdapter(str, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dshh.DataSource = dt;
            dshh.Columns[0].HeaderText = "Mã hàng";
            dshh.Columns[1].HeaderText = "Tên hàng";
            dshh.Columns[2].HeaderText = "Chủng loại";
            dshh.Columns[3].HeaderText = "Đơn vị tính";
            dshh.Columns[4].HeaderText = "Số lượng";
            dshh.Columns[5].HeaderText = "HSD";
            dshh.Columns[6].HeaderText = "Thuế";
            dshh.Columns[7].HeaderText = "Vị trí";
            dshh.Columns[8].HeaderText = "Mã vạch";
            conn.Close();
        }
        void mo(){
            chungloai.Enabled = true;
            dvt.Enabled = true;
            thue.Enabled = true;
            vtk.Enabled = true;
            mv.Enabled = true;
            mahang.Enabled = false;
            tenhang.Text = "";
            mahang.Text = "";
            load();
        }
        void khoa()
        {
            chungloai.Enabled = false;
            dvt.Enabled = false;
            thue.Enabled = false;
            vtk.Enabled = false;
            mv.Enabled = false;
            mahang.Enabled = true;
        }
        private void mahang_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string str = "select rtrim(ten_hh),rtrim(chung_loai),rtrim(dvt),thue,rtrim(dien_giai),ma_vach from HANGHOA,kho where ma_HH='" + mahang.Text + "' and hanghoa.ma_vtk=kho.ma_vtk";
                conn con = new conn();
                SqlConnection conn = con.con();
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(str, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                tenhang.Text = dt.Rows[0][0].ToString();
                chungloai.Text = dt.Rows[0][1].ToString();
                dvt.Text = dt.Rows[0][2].ToString();
                thue.Text = dt.Rows[0][3].ToString();
                vtk.Text = dt.Rows[0][4].ToString();
                mv.Text = dt.Rows[0][5].ToString();
                conn.Close();
            }
            catch { }
        }

        private void tenhang_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (kt == 0)
                {
                    string str = "select ma_hh,rtrim(chung_loai),rtrim(dvt),thue,rtrim(dien_giai),ma_vach from HANGHOA,kho where TEN_HH='" + tenhang.Text + "' and hanghoa.ma_vtk=kho.ma_vtk";
                    conn con = new conn();
                    SqlConnection conn = con.con();
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter(str, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    mahang.Text = dt.Rows[0][0].ToString();
                    chungloai.Text = dt.Rows[0][1].ToString();
                    dvt.Text = dt.Rows[0][2].ToString();
                    thue.Text = dt.Rows[0][3].ToString();
                    vtk.Text = dt.Rows[0][4].ToString();
                    mv.Text = dt.Rows[0][5].ToString();
                    conn.Close();
                }
            }
            catch { }

        }
        void load_dvt_kho() {
            conn con = new conn();
            SqlConnection conn = con.con();
            conn.Open();
            dvt.Items.Clear();
            vtk.Items.Clear();
            
            string str = "select rtrim(dvt) from HANGHOA";
            SqlDataAdapter dl = new SqlDataAdapter(str, conn);
            DataTable b1 = new DataTable();

            dl.Fill(b1);
            for (int i = 0; i < b1.Rows.Count; i++)
            {
                dvt.Items.Add(b1.Rows[i][0].ToString());
                

            }
            str = "select rtrim(dien_giai) from kho";
            SqlDataAdapter dl1 = new SqlDataAdapter(str, conn);
            DataTable b11 = new DataTable();

            dl1.Fill(b11);
            for (int i = 0; i < b11.Rows.Count; i++)
            {
                vtk.Items.Add(b11.Rows[i][0].ToString());


            }
            conn.Close();
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case (Keys.Escape):
                    button6_Click(null, null);
                    break;
                case (Keys.Enter):
                    button1_Click(null, null);
                    break;
                case (Keys.Insert):
                    button2_Click(null, null);
                    break;
                case (Keys.F2):
                    //button6_Click(null, null);
                    break;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (kt != 0)
            {
                khoa();
                if (kt == 1) mahang.Text = mahg();
                them(); //if(kt==3)
                load_dshh();
                kt = 0;
            }
        }

        private void dshh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            mahang.Text = dshh.CurrentRow.Cells[0].Value.ToString();
            tenhang.Text = dshh.CurrentRow.Cells[1].Value.ToString();
            chungloai.Text = dshh.CurrentRow.Cells[2].Value.ToString();
            dvt.Text = dshh.CurrentRow.Cells[3].Value.ToString();
            thue.Text = dshh.CurrentRow.Cells[6].Value.ToString();
            vtk.Text = dshh.CurrentRow.Cells[7].Value.ToString();
            mv.Text = dshh.CurrentRow.Cells[8].Value.ToString();

        }

        private void mv_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (kt == 0)
                {
                    string str = "select ma_hh,rtrim(chung_loai),rtrim(dvt),thue,rtrim(dien_giai),rtrim(ten_hh) from HANGHOA,kho where ma_vach='" + mv.Text + "' and hanghoa.ma_vtk=kho.ma_vtk";
                    conn con = new conn();
                    SqlConnection conn = con.con();
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter(str, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    mahang.Text = dt.Rows[0][0].ToString();
                    chungloai.Text = dt.Rows[0][1].ToString();
                    dvt.Text = dt.Rows[0][2].ToString();
                    thue.Text = dt.Rows[0][3].ToString();
                    vtk.Text = dt.Rows[0][4].ToString();
                    tenhang.Text = dt.Rows[0][5].ToString();
                    conn.Close();
                }
            }
            catch { }
        }
        void them() {
            conn con = new conn();
            SqlConnection conn = con.con();
            conn.Open();
            string b = mvtk();
            string str = "";
            string str1 = "";
            if (kt == 1) {
                str = "insert into hanghoa values('"+mahang.Text+"','"+b+"',4/30/1975,'"+mv.Text+"','"+dvt.Text+"','"+chungloai.Text+"',"+thue.Text+",0,'"+tenhang.Text+"')";
                str1 = "insert into luocsu_gia values('" + mahang.Text + "',getdate(),0,0)";
                SqlCommand c = new SqlCommand(str1, conn); c.ExecuteNonQuery();
                //SqlCommand c = new SqlCommand(str, conn); c1.ExecuteNonQuery();
                SqlCommand c1 = new SqlCommand(str, conn); c1.ExecuteNonQuery();
            }
            if (kt == 2) {
                str = "update hanghoa set ten_hh='"+tenhang.Text+"',chung_loai='"+chungloai.Text+"',dvt='"+dvt.Text+"',thue="+thue.Text+",ma_vtk='"+b+"' where ma_hh='"+mahang.Text+"'";
                SqlCommand c1 = new SqlCommand(str, conn); c1.ExecuteNonQuery();
            }
            
            conn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            kt = 2;
            if (mahang.Text != "")
            {
                mahang.Enabled = false;
                mv.Enabled = false;
                tenhang.Enabled = true;
                chungloai.Enabled = true;
                dvt.Enabled = true;
                thue.Enabled = true;
                vtk.Enabled = true;
            }
            else {
                MessageBox.Show("Yêu cầu chọn mã hàng!", "Thông báo!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            conn con = new conn();
            SqlConnection conn = con.con();
            conn.Open();   
            string str = "delete from hanghoa where ma_hh='"+mahang.Text+"'";
            string str1 = "delete from luocsu_gia where ma_hh='" + mahang.Text + "'";
            SqlCommand c = new SqlCommand(str, conn); c.ExecuteNonQuery();
            //SqlCommand c = new SqlCommand(str, conn); c1.ExecuteNonQuery();
            SqlCommand c1 = new SqlCommand(str1, conn); c1.ExecuteNonQuery();
            conn.Close();
            load_dshh();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormQLHH f = new FormQLHH();
            f.ShowDialog();
        }
    }
}
