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
    public partial class Dang_nhap : Form
    {
        public Dang_nhap()
        {
            InitializeComponent();
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case (Keys.Enter):
                    btn_dn_Click(null, null);
                    break;
                case (Keys.Escape):
                    btn_huy_Click(null, null);
                    break;

            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
        

        private void btn_dn_Click(object sender, EventArgs e)
        {
            try
            {

                if (txt_tk.Text.Length == 0)
                {
                    MessageBox.Show("Vui lòng nhập tên tài khoản", "THÔNG BÁO", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    txt_tk.Text = "";
                    txt_mk.Text = "";
                    txt_tk.Focus();
                }
                else if (txt_mk.Text.Length == 0)
                {
                    MessageBox.Show("Vui lòng nhập Mật khẩu", "THÔNG BÁO", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    txt_tk.Text = "";
                    txt_mk.Text = "";
                    txt_tk.Focus();
                }
                else
                {
                    string mk = "Select PASS from NHANVIEN where (PASS='" + txt_mk.Text + "' and manv='" + txt_tk.Text + "')";
                    string show = "Select HOTEN from NHANVIEN where (PASS='" + txt_mk.Text + "' and manv='" + txt_tk.Text + "')";
                    conn con = new conn();
                    SqlConnection con1 = con.con();
                    con1.Open();
                    SqlCommand cmd = new SqlCommand(mk, con1);
                    SqlDataAdapter da = new SqlDataAdapter(show, con1);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    string tmp = dt.Rows[0][0].ToString();
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        Main f = new Main();
                        f._txttk = tmp;
                        f.Show();
                        this.Visible = false;
                        
                    }
                    else
                    {
                        MessageBox.Show("Tên hoặc mật khẩu không đúng", "THÔNG BÁO", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                        txt_mk.Text = "";
                        txt_tk.Text = "";
                        txt_tk.Focus();
                    }
                    con1.Close();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public string _txt_tk
        {
            get { return txt_tk.Text; }
        }
    }
}
