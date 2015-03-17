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
    public partial class Quan_ly_gia : Form
    {
        public Quan_ly_gia()
        {
            InitializeComponent();
            load_gia();
            load_form();
           // load();
        }
        void load_gia() {
            try
            {
                conn con = new conn();
                SqlConnection con1 = con.con();
                con1.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con1;
                string show = "select*from LUOCSU_GIA";
                cmd.CommandText = show;
                SqlDataAdapter da = new SqlDataAdapter(show, con1);
                DataSet ds = new DataSet();
                // Fill date to ds
                da.Fill(ds);
                // Fill Dato from DataSet to DataGridView
                bang_qlgia.DataSource = ds.Tables[0];
                bang_qlgia.Columns[0].HeaderText = "Mã hàng hóa";
                bang_qlgia.Columns[1].HeaderText = "Ngày thay đổi";
                bang_qlgia.Columns[2].HeaderText = "Giá cũ";
                bang_qlgia.Columns[3].HeaderText = "Giá hiện tại";
                con1.Close();
            }
            catch { }
        }
        void load_form() {
            try
            {
                conn con = new conn();
                SqlConnection con1 = con.con();
                con1.Open();
                SqlCommand cmdhh = new SqlCommand();                
                cmdhh.Connection = con1;
                string showcb = "select rtrim(MA_HH) as ma_hh,RTRIM(TEN_HH) as ten_hh from HANGHOA";
                cmdhh.CommandText = showcb;
                SqlDataAdapter dacb = new SqlDataAdapter(showcb, con1);                
                DataTable dt = new DataTable();
                dacb.Fill(dt);                
                cbmhh.DataSource = dt;
                cbmhh.DisplayMember = "MA_HH";
                cbmhh.ValueMember = "MA_HH";
                cbthang.DataSource = dt;
                cbthang.DisplayMember = "TEN_HH";
                cbthang.ValueMember = "ten_HH";
                con1.Close();
            }
            catch { }
        }
        
        void load() {
            try
            {

                conn con = new conn();
                SqlConnection con1 = con.con();
                string str = "select * from LUOCSU_GIA where MA_HH= '" + cbmhh.Text + "'";
                con1.Open();
                SqlDataAdapter dl = new SqlDataAdapter(str, con1);
                DataTable b1 = new DataTable();
                dl.Fill(b1);
                               
                con1.Close();
            }
            catch { }
        }        
        
        void add_gia() {
            try
            {
                conn con = new conn();
                SqlConnection con1 = con.con();
                con1.Open();
                string add = "insert into LUOCSU_GIA(MA_HH,NGAYTHAYDOI,GIACU,GIAMOI) values('" + cbmhh.Text + "','" + dateTimePicker1.Text + "','" + txtgiacu.Text + "','" + txtgiamoi.Text + "')";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con1;
                cmd.CommandText = add;
                cmd.ExecuteNonQuery();
                con1.Close();
            }
            catch { }
        }
        
        private void ResetFieldsAdd()
        {
            cbmhh.Text = "";
            cbthang.Text = "";
            txtgiacu.Text = "";
            txtgiamoi.Text = "";
        }
        void sua_gia() {
            try
            {

                conn con = new conn();
                SqlConnection con1 = con.con();
                con1.Open();
                string updatedata = "insert luocsu_gia values('"+cbmhh.Text+"',GETDATE(),"+txtgiacu.Text+","+txtgiamoi.Text+")";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con1;
                cmd.CommandText = updatedata;
                cmd.ExecuteNonQuery();
            }
            catch { }
        }
        private void btn_sua_Click(object sender, EventArgs e)
        {
            try
            {
                sua_gia();
                load_form();
                load_gia();
                ResetFieldsAdd();
            }
            catch
            {
                MessageBox.Show("Co loi xay ra!", "Thong bao loi");
            }
        }
        void xoa_gia() {
            try
            {
                conn con = new conn();
                SqlConnection con1 = con.con();
                con1.Open();
                string delete = "delete from LUOCSU_GIA where MA_HH='" + cbmhh.Text + "'";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con1;
                cmd.CommandText = delete;
                cmd.ExecuteNonQuery();
            }
            catch { }
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case (Keys.Escape):
                btn_thoat_Click(null, null);
                    break;
                case (Keys.F3):
                    btn_sua_Click(null, null);
                    break;
                
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_thoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbmhh_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                conn con = new conn();
                SqlConnection con1 = con.con();
                string str = "select * from LUOCSU_GIA where MA_HH='" + cbmhh.Text.ToString() + "' and ngaythaydoi=(select max(ngaythaydoi) from luocsu_gia where ma_hh='"+cbmhh.Text+"' )";
                con1.Open();
                SqlDataAdapter da = new SqlDataAdapter(str, con1);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dateTimePicker1.Text = dt.Rows[0][1].ToString();
                txtgiacu.Text = dt.Rows[0][2].ToString();
                txtgiamoi.Text = dt.Rows[0][3].ToString();
                con1.Close();
            }
            catch { }
        }
        
        
    }
}

