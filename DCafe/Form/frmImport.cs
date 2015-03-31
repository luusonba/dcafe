using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DCafe
{
    public partial class frmImport : Form
    {
        public SqlConnection sqlCon;
        private bool add = false;

        public frmImport()
        {
            InitializeComponent();
        }

        private void Load_Nguyenlieu()
        {
            string mk = "SELECT ma_nguyenlieu, RTRIM(ten_nguyenlieu) AS ten_nguyenlieu, dongia FROM T_Nguyenlieu";
            SqlDataAdapter ada = new SqlDataAdapter(mk, sqlCon);
            sqlCon.Open();
            DataTable dt = new DataTable();
            ada.Fill(dt);

            cbNguyenlieu.DataSource = dt;
            cbNguyenlieu.DisplayMember = "ten_nguyenlieu";
            cbNguyenlieu.ValueMember = "ma_nguyenlieu";
            sqlCon.Close();
        }

        private void frmImport_Load(object sender, EventArgs e)
        {
            Conn conn = new Conn();
            sqlCon = conn.createConn();
            Load_Nguyenlieu();
            Load_Nhaphang("");
            EditMode(false);
        }

        private void btnAddNV_Click(object sender, EventArgs e)
        {
            add = true;
            EditMode(true);
            RefreshNH();
        }

        private void btnEditNV_Click(object sender, EventArgs e)
        {
            add = false;
            EditMode(true);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = sqlCon.CreateCommand();
            sqlCon.Open();
            if (MessageBox.Show("Bạn muốn thực hiện thao tác này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cmd.CommandText = "DELETE FROM T_Nhaphang WHERE id_nhaphang = @id_nhaphang";
                cmd.Parameters.AddWithValue("@id_nhaphang", grdNhaphang.CurrentRow.Cells["cIdnhaphang"].Value);
                cmd.ExecuteNonQuery();
            }            
            sqlCon.Close();
            Load_Nhaphang("");
        }

        private bool Validate()
        {
            bool rs = true;
            if (String.IsNullOrEmpty(txtSoluong.Text))
            {
                rs = false;
            }
            return rs;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!txtSoluong.ReadOnly)
            {                
                if (Validate())
                {
                    SqlCommand cmd = sqlCon.CreateCommand();
                    sqlCon.Open();

                    if (!add)
                    {
                        //Edit
                        cmd.CommandText = "UPDATE T_Nhaphang SET ma_nguyenlieu  = @ma_nguyenlieu, soluong = @soluong, thoidiem = @thoidiem WHERE id_nhaphang = @id_nhaphang";

                        cmd.Parameters.AddWithValue("@ma_nguyenlieu", cbNguyenlieu.SelectedValue);
                        cmd.Parameters.AddWithValue("@soluong", txtSoluong.Text);
                        cmd.Parameters.AddWithValue("@thoidiem", dtThoidiem.Value);
                        cmd.Parameters.AddWithValue("@id_nhaphang", grdNhaphang.CurrentRow.Cells["cIdnhaphang"].Value);
                            
                        cmd.ExecuteNonQuery();
                    }
                    else
                    {
                        //Add
                        cmd.CommandText = "INSERT INTO T_Nhaphang (ma_nguyenlieu, soluong, thoidiem) VALUES (@ma_nguyenlieu, @soluong, @thoidiem)";

                        cmd.Parameters.AddWithValue("@ma_nguyenlieu", cbNguyenlieu.SelectedValue);
                        cmd.Parameters.AddWithValue("@soluong", txtSoluong.Text);
                        cmd.Parameters.AddWithValue("@thoidiem", dtThoidiem.Value);

                        cmd.ExecuteNonQuery();
                    }
                    sqlCon.Close();
                    EditMode(false);
                    Refresh();
                    Load_Nhaphang("");
                }
                else
                {
                    MessageBox.Show("Thông tin nhập vào không đúng.");
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn thao tác Thêm hoặc Sửa.");
            }
        }

        private void Load_Nhaphang(string where)
        {
            string mk = "SELECT id_nhaphang, RTRIM(t2.ten_nguyenlieu) as ten_nguyenlieu, soluong, t1.thoidiem, t1.soluong * t2.dongia as thanhtien, t1.ma_nguyenlieu as ma_nguyenlieu, t2.dongia FROM T_Nhaphang t1 LEFT OUTER JOIN T_Nguyenlieu t2 ON t1.ma_nguyenlieu = t2.ma_nguyenlieu" + where;
            SqlDataAdapter ada = new SqlDataAdapter(mk, sqlCon);
            sqlCon.Open();
            DataTable dt = new DataTable();
            ada.Fill(dt);

            grdNhaphang.DataSource = dt;
            sqlCon.Close();
        }

        private void EditMode(bool check)
        {
            dtThoidiem.Enabled = false;
            txtSoluong.ReadOnly = !check;
            cbNguyenlieu.Enabled = check;
        }

        private void RefreshNH()
        {
            dtThoidiem.Value = DateTime.Now;
            txtSoluong.Text = "";
            cbNguyenlieu.SelectedIndex = 0;
        }

        private void grdNhaphang_SelectionChanged(object sender, EventArgs e)
        {
            dtThoidiem.Value = Convert.ToDateTime(grdNhaphang.CurrentRow.Cells["cThoidiem"].Value);
            txtSoluong.Text = Convert.ToDouble(grdNhaphang.CurrentRow.Cells["cSoluong"].Value).ToString();            
            cbNguyenlieu.SelectedValue = grdNhaphang.CurrentRow.Cells["cManguyenlieu"].Value;
            EditMode(false);
        }

        private void frmImport_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form frm = (Form)Application.OpenForms["frmMain"];
            frm.Visible = true;
        }
    }
}