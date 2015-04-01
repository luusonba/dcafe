using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using DCafe;
namespace DCafe
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
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
                    string mk = "SELECT ma_nv, ten_nhanvien, password, is_admin FROM T_Nhanvien WHERE (password =@password and ma_nv =@ma_nv)";
                    Conn conn = new Conn();
                    SqlConnection con = conn.createConn();
                    con.Open();
                    SqlCommand cmd = new SqlCommand(mk, con);
                    cmd.Parameters.AddWithValue("password", txt_mk.Text);
                    cmd.Parameters.AddWithValue("ma_nv", txt_tk.Text);
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {                        
                        frmMain f = new frmMain();
                        f.lblUsername.Text = dr[1].ToString();
                        f.isAdmin = Convert.ToBoolean(dr[3].ToString());
                        f.Show();
                        this.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Tên hoặc mật khẩu không đúng", "THÔNG BÁO", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                        txt_mk.Text = "";                        
                        txt_mk.Focus();
                    }
                    con.Close();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public string _txt_tk
        {
            get { return txt_tk.Text; }
        }
    }
}
