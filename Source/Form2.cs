using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TTTT
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        string stt_nhap() {
            try
            {
                conn con = new conn();
                SqlConnection con1 = con.con();
                con1.Open();
                string str1 = "select  convert(varchar, getdate(), 12),count(STT_pn)+1 from phieunhap where LEFT(STT_pn,6)=convert(varchar, getdate(), 12)";
                SqlDataAdapter dl = new SqlDataAdapter(str1, con1);
                DataTable b1 = new DataTable();
                dl.Fill(b1);
                string str = b1.Rows[0][0].ToString();
                string a = b1.Rows[0][1].ToString();
                if (a.Length == 1) str = str + "00" + a;
                if (a.Length == 2) str = str + "0" + a;
                if (a.Length == 3) str = str + a;
                con1.Close();
                return str;
            }
            catch
            {
                return "0";
            }
        }
        void dvt_kho() {
            conn con = new conn();
            SqlConnection con1 = con.con();
            string str = "select DIEN_GIAI,dvt,ten_hh from hanghoa,KHO where ma_hh='" + mh.Text + "' and HANGHOA.MA_VTK=KHO.MA_VTK";
            th.Text = "";
            //vt.Items.Clear();
            con1.Open();
            SqlDataAdapter dl = new SqlDataAdapter(str, con1);
            DataTable b1 = new DataTable();
            dl.Fill(b1);

            
            vt.Text = b1.Rows[0][0].ToString();
            dvt.Text = b1.Rows[0][1].ToString();
            th.Text = b1.Rows[0][2].ToString();
            con1.Close();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            nhap.Text = stt_nhap();
            load_mh();
            load_ncc();
            load_kho();
            
            //nhap.Text = stt_nhap();
            nv.Text = "NV001";
            tong.Text = "0";
        }
        void load_mh() {
            conn con = new conn();
            SqlConnection con1 = con.con();
            string str = "select MA_HH,ma_vach from HANGHOA";
            //mh.Text = "";
            mh.Items.Clear();
            //mv.Text = "";
            mv.Items.Clear();
            
            con1.Open();
            SqlDataAdapter dl = new SqlDataAdapter(str, con1);
            DataTable b1 = new DataTable();
            dl.Fill(b1);
            for (int i = 0; i < b1.Rows.Count; i++)
            {
                mh.Items.Add(b1.Rows[i][0].ToString());
                mv.Items.Add(b1.Rows[i][1].ToString());
            }

            mh.Text = b1.Rows[0][0].ToString();
            //mv.Text = b1.Rows[0][1].ToString();

            con1.Close();
        }
        void load_mh(string a)
        {
            /*conn con = new conn();
            SqlConnection con1 = con.con();
            string str = "select MA_HH from HANGHOA ma_hh like('%"+a+"%')";
            mh.Text = "";
            mh.Items.Clear();
            con1.Open();
            SqlDataAdapter dl = new SqlDataAdapter(str, con1);
            DataTable b1 = new DataTable();
            dl.Fill(b1);
            for (int i = 0; i < b1.Rows.Count; i++)
            {
                mh.Items.Add(b1.Rows[i][0].ToString());
            }

            mh.Text = b1.Rows[0][0].ToString();

            con1.Close();*/
        }
        void load_ncc() {
            conn con = new conn();
            SqlConnection con1 = con.con();
            string str = "select MA_NCC from nha_cung_cap";
            mncc.Text = "";
            mncc.Items.Clear();
            con1.Open();
            SqlDataAdapter dl = new SqlDataAdapter(str, con1);
            DataTable b1 = new DataTable();
            dl.Fill(b1);
            for (int i = 0; i < b1.Rows.Count; i++)
            {
                mncc.Items.Add(b1.Rows[i][0].ToString());
            }
            mncc.Text = b1.Rows[0][0].ToString();
            //.Items.Add("");

            con1.Close();
        }

        void load_kho() {
            conn con = new conn();
            SqlConnection con1 = con.con();
            string str = "select * from kho";
            vt.Text = "";
            vt.Items.Clear();
            con1.Open();
            SqlDataAdapter dl = new SqlDataAdapter(str, con1);
            DataTable b1 = new DataTable();
            dl.Fill(b1);
            for (int i = 0; i < b1.Rows.Count; i++)
            {
                vt.Items.Add(b1.Rows[i][1].ToString());
            }
            vt.Text = b1.Rows[0][1].ToString();
            //.Items.Add("");

            con1.Close();
        }

        private void mncc_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn con = new conn();
            SqlConnection con1 = con.con();
            string str = "select ten_ncc from nha_cung_cap where ma_ncc='"+mncc.Text+"'";
            tncc.Text = "";
            //vt.Items.Clear();
            con1.Open();
            SqlDataAdapter dl = new SqlDataAdapter(str, con1);
            DataTable b1 = new DataTable();
            dl.Fill(b1);

            tncc.Text = b1.Rows[0][0].ToString();
            

            con1.Close();
        }

        private void mh_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn con = new conn();
            SqlConnection con1 = con.con();
            load_mh(mh.Text);
            string str = "select ten_hh,thue,DIEN_GIAI,dvt,ma_vach from hanghoa,KHO where ma_hh='" + mh.Text + "' and HANGHOA.MA_VTK=KHO.MA_VTK";
            th.Text = "";
            //vt.Items.Clear();
            con1.Open();
            SqlDataAdapter dl = new SqlDataAdapter(str, con1);
            DataTable b1 = new DataTable();
            dl.Fill(b1);

            th.Text = b1.Rows[0][0].ToString();
            thue.Text = b1.Rows[0][1].ToString();
            vt.Text = b1.Rows[0][2].ToString();
            dvt.Text = b1.Rows[0][3].ToString();
            mv.Text = b1.Rows[0][4].ToString();
            con1.Close();
        }
        void load_data() {
            try
            {
                conn con = new conn();
                SqlConnection con1 = con.con();
                con1.Open();
                //string str1 = "drop table #a";
                string str = "select hanghoa.MA_HH,TEN_HH,SL_NHAP,DG_NHAP,THUE,convert(int,SL_NHAP*DG_NHAP*(100+thue)/100) from NHAP,HANGHOA where NHAP.MA_HH=HANGHOA.MA_HH and nhap.stt_pn='"+nhap.Text+"'";
                int a;
                SqlDataAdapter da = new SqlDataAdapter(str, con1);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataTable table = new DataTable();
                table.Columns.Add("STT", typeof(object));
                table.Columns.Add("Mã hàng", typeof(object));
                table.Columns.Add("Tên hàng", typeof(object));
                table.Columns.Add("Số lượng", typeof(object));
                table.Columns.Add("Đơn giá", typeof(object));
                table.Columns.Add("Thuế", typeof(object));
                table.Columns.Add("Thành tiền", typeof(object));
                for (a = 0; a < dt.Rows.Count; a++)
                {
                    table.Rows.Add(a + 1, dt.Rows[a][0], dt.Rows[a][1], dt.Rows[a][2], dt.Rows[a][3], dt.Rows[a][4], con.cachso(dt.Rows[a][5].ToString()));
                }
                DATA.DataSource = table;
                
                
                con1.Close();
            }
            catch { }
        }
        void them_nhap() {
            conn con = new conn();
            SqlConnection con1 = con.con();
            con1.Open();
            string str1 = "select COUNT(*) from nhap where STT_pn='" + nhap.Text + "' and ma_hh='" + mh.Text + "'";
            string str = "insert into nhap values('" + mh.Text + "','" + nhap.Text + "'," + sl.Text + "," + gia.Text + ")";
            string str2 = "update nhap set sl_nhap=sl_nhap+" + sl.Text + " where ma_hh='" + mh.Text + "' and stt_pn='" + nhap.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(str1, con1);
            DataTable dt = new DataTable();
            da.Fill(dt);

            int a = Convert.ToInt32(dt.Rows[0][0].ToString());
            if (a == 0)
            {


                SqlCommand c1 = new SqlCommand(str, con1); c1.ExecuteNonQuery();
                kho kh = new kho();

                kh.tang(mh.Text, Convert.ToInt32(sl.Text));
            }
            else
            {


                SqlCommand c1 = new SqlCommand(str2, con1); c1.ExecuteNonQuery();
                kho kh = new kho();

                kh.tang(mh.Text, Convert.ToInt32(sl.Text));
            }
            string str3 = "update HANGHOA set HAN_SD='"+hsd.Text+"' where ma_hh='"+mh.Text+"'";
            SqlCommand c3 = new SqlCommand(str3, con1); c3.ExecuteNonQuery();
            con1.Close();
        }
        void them_pn() {
            try
            {
                conn con = new conn();
                SqlConnection con1 = con.con();
                con1.Open();
                string str1 = "select COUNT(stt_pn) from phieunhap where STT_pn='" + nhap.Text + "'";
                SqlDataAdapter da = new SqlDataAdapter(str1, con1);
                DataTable dt = new DataTable();
                da.Fill(dt);
                int a = Convert.ToInt32(dt.Rows[0][0].ToString());
                if (a == 0)
                {
                    string str2 = "insert into phieunhap values('" + nhap.Text + "','" + nv.Text + "',getdate())";
                    SqlCommand c1 = new SqlCommand(str2, con1); c1.ExecuteNonQuery();
                    them_cungcap_hh();
                    them_nhap();
                }
                else them_nhap();
                con1.Close();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
        void set() {
            mh.Text = "";
            th.Text = "";
            sl.Text = "";
            gia.Text = "";
            dvt.Text = "";
            thue.Text = "";
            vt.Text = "";
        }
        void them_cungcap_hh() {
            try
            {
                conn con = new conn();
                SqlConnection con1 = con.con();
                con1.Open();


                string str2 = "insert into cung_cap_hh values('" +mncc.Text + "','" + nhap.Text + "')";
                SqlCommand c1 = new SqlCommand(str2, con1); c1.ExecuteNonQuery();
                //sl.Text = str2;
                con1.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            them_pn();
            class1.stt_pn = nhap.Text;
            load_data();
            load_tong();
            set();
        }
        string cat_tong(string a)
        {
            string b = "";
            int c;

            for (c = 0; c < a.Length; c++)
            {
                if (Convert.ToString(a[c]) == ",") break;
                b = b + a[c];
            }
            conn con = new conn();
            string e = con.cachso(b);
            return e;

        }
        void load_tong() {
            conn con = new conn();
            SqlConnection con1 = con.con();
            con1.Open();

            string str1 = "select COUNT(*) from nhap where STT_pn='" + nhap.Text + "'";
            SqlDataAdapter da1 = new SqlDataAdapter(str1, con1);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            int a = Convert.ToInt32(dt1.Rows[0][0].ToString());
            if (a != 0)
            {
                string str = "select sum(SL_NHAP*DG_NHAP*(100+thue)/100) from NHAP,HANGHOA where NHAP.MA_HH=HANGHOA.MA_HH and nhap.stt_pn='" + nhap.Text + "'";


                SqlDataAdapter da = new SqlDataAdapter(str, con1);
                DataTable dt = new DataTable();
                da.Fill(dt);
                tong.Text = cat_tong(dt.Rows[0][0].ToString());
            }
            else tong.Text = "0";
            con1.Close();
        }
        void xoa_nhap()
        {
            
                conn con = new conn();
                SqlConnection con1 = con.con(); con1.Open();
                string str = "delete from nhap where STT_pn='" + nhap.Text + "' AND MA_HH='" + mh.Text + "' ";
                //sl.Text = str;
                SqlCommand c1 = new SqlCommand(str, con1); c1.ExecuteNonQuery();
                kho kh = new kho();
                kh.giam(mh.Text, Convert.ToInt32(sl.Text));
                con1.Close();
            
        }
        void xoa_cua() {
            conn con = new conn();
            SqlConnection con1 = con.con(); con1.Open();
            string str = "delete from cung_cap_hh where STT_pn='" + nhap.Text + "'";
            //sl.Text = str;
            SqlCommand c1 = new SqlCommand(str, con1); c1.ExecuteNonQuery();

            con1.Close();
        }
        void xoa_pn()
        {
            try
            {
                conn con = new conn();
                SqlConnection con1 = con.con();
                string str = "select COUNT(*) from nhap where STT_pn='" + nhap.Text + "' ";
                con1.Open();
                SqlDataAdapter dl = new SqlDataAdapter(str, con1);
                DataTable b1 = new DataTable();
                dl.Fill(b1);
                if (b1.Rows.Count == 1)
                {
                    xoa_nhap();
                    xoa_cua();
                    string str1 = "delete from phieunhap where STT_pn='" + nhap.Text + "' ";
                    SqlCommand c1 = new SqlCommand(str1, con1); c1.ExecuteNonQuery();
                    
                }
                else xoa_nhap();
                //con1.Open();
                load_data();
                con1.Close();
                set();
            }
            catch(Exception ex){
                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            xoa_pn();
        }
        void lay_dl()
        {
            mh.Text = DATA.CurrentRow.Cells[0].Value.ToString();
            th.Text = DATA.CurrentRow.Cells[1].Value.ToString();
            sl.Text = DATA.CurrentRow.Cells[2].Value.ToString();
            gia.Text = DATA.CurrentRow.Cells[3].Value.ToString();
            thue.Text = DATA.CurrentRow.Cells[4].Value.ToString();
            dvt_kho(); 
            load_data();

        }

        private void DATA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lay_dl();
        }
        void load_dvt() {
            conn con = new conn();
            SqlConnection con1 = con.con();
            string str = "select distinct dvt from HANGHOA";
            dvt.Text = "";
            dvt.Items.Clear();
            con1.Open();
            SqlDataAdapter dl = new SqlDataAdapter(str, con1);
            DataTable b1 = new DataTable();
            dl.Fill(b1);
            for (int i = 0; i < b1.Rows.Count; i++)
            {
                dvt.Items.Add(b1.Rows[i][0].ToString());
            }
            dvt.Text = b1.Rows[0][0].ToString();
            //.Items.Add("");

            con1.Close();
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case (Keys.Escape):
                    button4_Click(null, null);
                    break;
                case (Keys.Delete):
                    button5_Click(null, null);
                    break;
                case (Keys.Enter):
                    button3_Click(null, null);
                    break;
                case (Keys.F2):
                    button6_Click(null, null);
                    break;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FormPN fpn = new FormPN();
            fpn.ShowDialog();
        }

        private void tong_TextChanged(object sender, EventArgs e)
        {

        }

        private void mv_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn con = new conn();
            SqlConnection con1 = con.con();
            //load_mh(mh.Text);
            string str = "select ten_hh,thue,DIEN_GIAI,dvt,ma_hh from hanghoa,KHO where ma_vach='" + mv.Text + "' and HANGHOA.MA_VTK=KHO.MA_VTK";
            //th.Text = "";
            //vt.Items.Clear();
            con1.Open();
            SqlDataAdapter dl = new SqlDataAdapter(str, con1);
            DataTable b1 = new DataTable();
            dl.Fill(b1);

            th.Text = b1.Rows[0][0].ToString();
            thue.Text = b1.Rows[0][1].ToString();
            vt.Text = b1.Rows[0][2].ToString();
            dvt.Text = b1.Rows[0][3].ToString();
            mh.Text = b1.Rows[0][4].ToString();
            con1.Close();
        }
       
        
    }
}
