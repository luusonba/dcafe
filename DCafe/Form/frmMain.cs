using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DCafe
{
    public partial class frmMain : Form
    {
        public SqlConnection sqlCon;
        public ClsNhanvien clsNhanvien;
        public frmMain()
        {
            InitializeComponent();
            Conn conn = new Conn();
            sqlCon = conn.createConn();
            clsNhanvien = new ClsNhanvien();
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        
        private void btnThanhpham_Click(object sender, EventArgs e)
        {
            tabPages.SelectedTab = tabSanpham;
        }

        private void btnChebien_Click(object sender, EventArgs e)
        {
            tabPages.SelectedTab = tabChebien;
        }

        private void btnHoadon_Click(object sender, EventArgs e)
        {
            tabPages.SelectedTab = tabHoadon;
        }
        
        #region Nhan vien

        private void btnNhanvien_Click(object sender, EventArgs e)
        {
            tabPages.SelectedTab = tabNhanvien;
        }

        public void Load_Nhanvien(string where)
        {
            string mk = "SELECT ma_nv, password, RTRIM(ten_nhanvien) AS ten_nhanvien, gioitinh, ma_kv, is_admin FROM T_Nhanvien " + where;
            SqlDataAdapter ada = new SqlDataAdapter(mk, sqlCon);
            sqlCon.Open();
            DataTable dt = new DataTable();
            ada.Fill(dt);

            grdDsnhanvien.DataSource = dt;
            sqlCon.Close();
        }

        public void Load_Khuvuc()
        {
            string mk = "SELECT ma_kv, RTRIM(ten_kv) AS ten_kv FROM T_Khuvuc";
            SqlDataAdapter ada = new SqlDataAdapter(mk, sqlCon);
            sqlCon.Open();
            DataTable dt = new DataTable();
            ada.Fill(dt);

            cbMa_kv.DataSource = dt;
            cbMa_kv.DisplayMember = "ten_kv";
            cbMa_kv.ValueMember = "ma_kv";
            sqlCon.Close();
        }

        public void Save_Nhanvien()
        {
            SqlCommand cmd = sqlCon.CreateCommand();
            sqlCon.Open();
            if (checkExistNhanvien(txtMa_nv.Text))
            {
                //Edit
                cmd.CommandText = "UPDATE T_Nhanvien SET ten_nhanvien  = @ten_nhanvien, password=@password, gioitinh = @gioitinh, ma_kv = @ma_kv, is_admin = @is_admin WHERE ma_nv = @ma_nv";

                cmd.Parameters.AddWithValue("@ten_nhanvien", txtTen_nv.Text);
                cmd.Parameters.AddWithValue("@password", txtMk.Text);
                if (rbNam.Checked)
                {
                    cmd.Parameters.AddWithValue("@gioitinh", true);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@gioitinh", false);
                }

                cmd.Parameters.AddWithValue("@ma_kv", cbMa_kv.SelectedValue);
                cmd.Parameters.AddWithValue("@is_admin", ckAdmin.Checked);
                cmd.Parameters.AddWithValue("@ma_nv", txtMa_nv.Text);

                cmd.ExecuteNonQuery();
            }
            else
            {
                //Add
                cmd.CommandText = "INSERT INTO T_Nhanvien (ma_nv, ten_nhanvien, password, gioitinh, ma_kv, is_admin) VALUES (@ma_nv, @ten_nhanvien, @password, @gioitinh, @ma_kv, @is_admin)";

                cmd.Parameters.AddWithValue("@ma_nv", txtMa_nv.Text);
                cmd.Parameters.AddWithValue("@ten_nhanvien", txtTen_nv.Text);
                cmd.Parameters.AddWithValue("@password", txtMk.Text);
                if (rbNam.Checked)
                {
                    cmd.Parameters.AddWithValue("@gioitinh", true);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@gioitinh", false);
                }

                cmd.Parameters.AddWithValue("@ma_kv", cbMa_kv.SelectedValue);
                cmd.Parameters.AddWithValue("@is_admin", ckAdmin.Checked);

                cmd.ExecuteNonQuery();
            }
            sqlCon.Close();
        }

        public bool checkExistNhanvien(string ma_nv)
        {
            string sql = "SELECT ma_nv FROM T_Nhanvien WHERE (ma_nv =@ma_nv)";
            bool isExist = false;
            SqlCommand cmd = new SqlCommand(sql, sqlCon);
            cmd.Parameters.AddWithValue("ma_nv", ma_nv);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                isExist = true;
            }
            dr.Close();
            return isExist;
        }

        private void grdDsnhanvien_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in grdDsnhanvien.SelectedRows)
            {
                clsNhanvien.Ma_Nv = row.Cells[0].Value.ToString();
                clsNhanvien.Password = row.Cells[1].Value.ToString();
                clsNhanvien.Ten_Nv = row.Cells[2].Value.ToString();
                clsNhanvien.Gioitinh = Convert.ToBoolean(row.Cells[3].Value);
                clsNhanvien.Ma_Kv = row.Cells[4].Value.ToString();
                clsNhanvien.Is_Admin = Convert.ToBoolean(row.Cells[5].Value);
            }

            txtMa_nv.Text = clsNhanvien.Ma_Nv;
            txtTen_nv.Text = clsNhanvien.Ten_Nv;

            if (clsNhanvien.Gioitinh)
            {
                rbNam.Checked = true;
            }
            else
            {
                rbNu.Checked = true;
            }

            cbMa_kv.SelectedValue = clsNhanvien.Ma_Kv;

            if (clsNhanvien.Is_Admin)
            {
                ckAdmin.Checked = true;
            }
            else
            {
                ckAdmin.Checked = false;
            }
        }

        #endregion

        #region Nguyen lieu

        private void btnNguyenlieu_Click(object sender, EventArgs e)
        {
            tabPages.SelectedTab = tabNguyenlieu;
            Load_Nguyenlieu("");
        }

        public void Load_Nguyenlieu(string where)
        {
            string sql = "SELECT ma_nguyenlieu, RTRIM(ten_nguyenlieu) as ten_nguyenlieu, dongia, donvi, thoidiem FROM T_Nguyenlieu " + where;
            SqlDataAdapter ada = new SqlDataAdapter(sql, sqlCon);
            sqlCon.Open();
            DataTable dt = new DataTable();
            ada.Fill(dt);

            grdDsNguyenlieu.DataSource = dt;
            sqlCon.Close();
        }

        #endregion

        private void frmMain_Load(object sender, EventArgs e)
        {
            Load_Nhanvien("");
            Load_Khuvuc();
            rbNam.Checked = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tabPages.SelectedTab == tabNhanvien)
            {
                Save_Nhanvien();
                Load_Nhanvien("");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = sqlCon.CreateCommand();
            sqlCon.Open();
            
            cmd.CommandText = "DELETE FROM T_Nhanvien WHERE ma_nv = @ma_nv";
                        
            cmd.Parameters.AddWithValue("@ma_nv", txtMa_nv.Text);

            cmd.ExecuteNonQuery();

            sqlCon.Close();

            Load_Nhanvien("");            
        }
    }
}
