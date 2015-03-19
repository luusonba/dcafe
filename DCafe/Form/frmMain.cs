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
        public ClsNguyenlieu clsNguyenlieu;
        public ClsThanhpham clsThanhpham;
        public frmMain()
        {
            InitializeComponent();
            Conn conn = new Conn();
            sqlCon = conn.createConn();
            clsNhanvien = new ClsNhanvien();
            clsNguyenlieu = new ClsNguyenlieu();
            clsThanhpham = new ClsThanhpham();
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
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
            string mk = "SELECT ma_nv, password, RTRIM(ten_nhanvien) AS ten_nhanvien, gioitinh = case gioitinh when 'True' then 'Male' else 'Female' end, ma_kv, is_admin FROM T_Nhanvien " + where;
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
                cmd.Parameters.AddWithValue("@gioitinh", rbNam.Checked);
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
                cmd.Parameters.AddWithValue("@gioitinh", rbNam.Checked);               

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
                if (row.Cells[3].Value.ToString() == "Male")
                {
                    clsNhanvien.Gioitinh = true;
                }
                else
                {
                    clsNhanvien.Gioitinh = false;
                }                
                clsNhanvien.Ma_Kv = row.Cells[4].Value.ToString();
                clsNhanvien.Is_Admin = Convert.ToBoolean(row.Cells[5].Value);
            }

            txtMa_nv.Text = clsNhanvien.Ma_Nv;
            txtTen_nv.Text = clsNhanvien.Ten_Nv;
            rbNam.Checked = clsNhanvien.Gioitinh;
            rbNu.Checked = !clsNhanvien.Gioitinh;            
            cbMa_kv.SelectedValue = clsNhanvien.Ma_Kv;
            ckAdmin.Checked = clsNhanvien.Is_Admin;

        }

        #endregion

        #region Nguyen lieu

        private void btnNguyenlieu_Click(object sender, EventArgs e)
        {
            tabPages.SelectedTab = tabNguyenlieu;
            Load_Nguyenlieu("");
            Load_Donvi();   
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

        public void Load_Donvi()
        {
            string mk = "SELECT ma_donvi, RTRIM(ten_donvi) AS ten_donvi FROM T_Donvi WHERE loai_donvi = 'NL'";
            SqlDataAdapter ada = new SqlDataAdapter(mk, sqlCon);
            sqlCon.Open();
            DataTable dt = new DataTable();
            ada.Fill(dt);

            cbDonvi.DataSource = dt;
            cbDonvi.DisplayMember = "ten_donvi";
            cbDonvi.ValueMember = "ma_donvi";
            sqlCon.Close();
        }

        public void Save_Nguyenlieu()
        {
            SqlCommand cmd = sqlCon.CreateCommand();
            sqlCon.Open();
            if (checkExistNguyenlieu(txtMaNl.Text))
            {
                //Edit
                cmd.CommandText = "UPDATE T_Nguyenlieu SET ten_nguyenlieu  = @ten_nguyenlieu, dongia=@dongia, donvi = @donvi, thoidiem = @thoidiem WHERE ma_nguyenlieu = @ma_nguyenlieu";

                cmd.Parameters.AddWithValue("@ten_nguyenlieu", txtTenNl.Text);
                cmd.Parameters.AddWithValue("@dongia", txtDongia.Text);

                cmd.Parameters.AddWithValue("@donvi", cbDonvi.SelectedValue);
                cmd.Parameters.AddWithValue("@thoidiem", dtThoidiem.Value.ToString());
                cmd.Parameters.AddWithValue("@ma_nguyenlieu", txtMaNl.Text);

                cmd.ExecuteNonQuery();
            }
            else
            {
                //Add
                cmd.CommandText = "INSERT INTO T_Nguyenlieu (ma_nguyenlieu, ten_nguyenlieu, dongia, donvi, thoidiem) VALUES (@ma_nguyenlieu, @ten_nguyenlieu, @dongia, @donvi, @thoidiem)";

                cmd.Parameters.AddWithValue("@ma_nguyenlieu", txtMaNl.Text);
                cmd.Parameters.AddWithValue("@ten_nguyenlieu", txtTenNl.Text);
                cmd.Parameters.AddWithValue("@dongia", int.Parse(txtDongia.Text));
                cmd.Parameters.AddWithValue("@donvi", cbDonvi.SelectedValue);
                cmd.Parameters.AddWithValue("@thoidiem", dtThoidiem.Value.ToString());
                cmd.ExecuteNonQuery();
            }
            sqlCon.Close();
        }
        public bool checkExistNguyenlieu(string ma_nguyenlieu)
        {
            string sql = "SELECT ma_nguyenlieu FROM T_Nguyenlieu WHERE (ma_nguyenlieu =@ma_nguyenlieu)";
            bool isExist = false;
            SqlCommand cmd = new SqlCommand(sql, sqlCon);
            cmd.Parameters.AddWithValue("ma_nguyenlieu", ma_nguyenlieu);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                isExist = true;
            }
            dr.Close();
            return isExist;
        }

        private void grdDsNguyenlieu_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in grdDsNguyenlieu.SelectedRows)
            {
                clsNguyenlieu.Ma_Nguyenlieu = row.Cells[0].Value.ToString();
                clsNguyenlieu.Ten_Nguyenlieu = row.Cells[1].Value.ToString();
                clsNguyenlieu.Dongia = Convert.ToInt32(row.Cells[2].Value);
                clsNguyenlieu.Donvi = row.Cells[3].Value.ToString();
                clsNguyenlieu.Thoidiem = Convert.ToDateTime(row.Cells[4].Value);
            }

            txtMaNl.Text = clsNguyenlieu.Ma_Nguyenlieu;
            txtTenNl.Text = clsNguyenlieu.Ten_Nguyenlieu;
            txtDongia.Text = clsNguyenlieu.Dongia.ToString();
            cbDonvi.SelectedValue = clsNguyenlieu.Donvi;
        }

        #endregion

        #region Thanh pham

        private void btnThanhpham_Click(object sender, EventArgs e)
        {
            tabPages.SelectedTab = tabSanpham;
            Load_Thanhpham("");
            Load_DonviSP();
        }

        public void Load_Thanhpham(string where)
         {
             string sql = "SELECT ma_thanhpham, RTRIM(ten_thanhpham) as ten_thanhpham, dongia, giaban, donvi, thoidiem FROM T_Thanhpham " + where;
            SqlDataAdapter ada = new SqlDataAdapter(sql, sqlCon);
            sqlCon.Open();
            DataTable dt = new DataTable();
            ada.Fill(dt);

            grdDsSanpham.DataSource = dt;
            sqlCon.Close();
        }

        public void Load_DonviSP()
        {
            string mk = "SELECT ma_donvi, RTRIM(ten_donvi) AS ten_donvi FROM T_Donvi WHERE loai_donvi = 'TP'";
            SqlDataAdapter ada = new SqlDataAdapter(mk, sqlCon);
            sqlCon.Open();
            DataTable dt = new DataTable();
            ada.Fill(dt);

            cbDonviSP.DataSource = dt;
            cbDonviSP.DisplayMember = "ten_donvi";
            cbDonviSP.ValueMember = "ma_donvi";
            sqlCon.Close();
        }

        public void Save_Thanhpham()
        {
            SqlCommand cmd = sqlCon.CreateCommand();
            sqlCon.Open();
            if (checkExistThanhpham(txtMa_Sanpham.Text))
            {
                //Edit
                cmd.CommandText = "UPDATE T_Thanhpham SET ten_thanhpham  = @ten_thanhpham, dongia=@dongia, giaban = @giaban, donvi = @donvi, thoidiem = @thoidiem WHERE ma_thanhpham = @ma_thanhpham";

                cmd.Parameters.AddWithValue("@ten_thanhpham", txtTen_Sanpham.Text);
                cmd.Parameters.AddWithValue("@dongia", txtDongiaSP.Text);
                cmd.Parameters.AddWithValue("@giaban", txtGiaban.Text);
                cmd.Parameters.AddWithValue("@donvi", cbDonviSP.SelectedValue);
                cmd.Parameters.AddWithValue("@thoidiem", dtThoidiem.Value.ToString());
                cmd.Parameters.AddWithValue("@ma_thanhpham", txtMa_Sanpham.Text);

                cmd.ExecuteNonQuery();
            }
            else
            {
                //Add
                cmd.CommandText = "INSERT INTO T_Thanhpham (ma_thanhpham, ten_thanhpham, dongia, giaban, donvi, thoidiem) VALUES (@ma_thanhpham, @ten_thanhpham, @dongia, @giaban, @donvi, @thoidiem)";

                cmd.Parameters.AddWithValue("@ma_thanhpham", txtMa_Sanpham.Text);
                cmd.Parameters.AddWithValue("@ten_thanhpham", txtTen_Sanpham.Text);
                cmd.Parameters.AddWithValue("@dongia", int.Parse(txtDongiaSP.Text));
                cmd.Parameters.AddWithValue("@giaban", int.Parse(txtDongiaSP.Text));
                cmd.Parameters.AddWithValue("@donvi", cbDonviSP.SelectedValue);
                cmd.Parameters.AddWithValue("@thoidiem", dtThoidiemSP.Value.ToString());
                cmd.ExecuteNonQuery();
            }
            sqlCon.Close();
        }
        public bool checkExistThanhpham(string ma_thanhpham)
        {
            string sql = "SELECT ma_thanhpham FROM T_Thanhpham WHERE (ma_thanhpham =@ma_thanhpham)";
            bool isExist = false;
            SqlCommand cmd = new SqlCommand(sql, sqlCon);
            cmd.Parameters.AddWithValue("ma_thanhpham", ma_thanhpham);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                isExist = true;
            }
            dr.Close();
            return isExist;
        }

        private void grdDsSanpham_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in grdDsSanpham.SelectedRows)
            {
                clsThanhpham.Ma_Thanhpham = row.Cells[0].Value.ToString();
                clsThanhpham.Ten_Thanhpham = row.Cells[1].Value.ToString();
                clsThanhpham.Dongia = Convert.ToInt16(row.Cells[2].Value);
                clsThanhpham.Giaban = Convert.ToInt16(row.Cells[3].Value);
                clsThanhpham.Donvi = row.Cells[4].Value.ToString();
                clsThanhpham.Thoidiem = Convert.ToDateTime(row.Cells[5].Value);
            }

            txtMa_Sanpham.Text = clsThanhpham.Ma_Thanhpham;
            txtTen_Sanpham.Text = clsThanhpham.Ten_Thanhpham;
            txtDongiaSP.Text = clsThanhpham.Dongia.ToString();
            txtGiaban.Text = clsThanhpham.Giaban.ToString();
            cbDonviSP.SelectedValue = clsThanhpham.Donvi;
            dtThoidiemSP.Value = clsThanhpham.Thoidiem;
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
            else if (tabPages.SelectedTab == tabNguyenlieu)
            {
                Save_Nguyenlieu();
                Load_Nguyenlieu("");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = sqlCon.CreateCommand();
            sqlCon.Open();
            if (tabPages.SelectedTab == tabNhanvien)
            {
                cmd.CommandText = "DELETE FROM T_Nhanvien WHERE ma_nv = @ma_nv";
                cmd.Parameters.AddWithValue("@ma_nv", txtMa_nv.Text);
                cmd.ExecuteNonQuery();
                Load_Nhanvien("");
            }
            else if (tabPages.SelectedTab == tabNguyenlieu)
            {
                cmd.CommandText = "DELETE FROM T_Nguyenlieu WHERE ma_nguyenlieu = @ma_nguyenlieu";
                cmd.Parameters.AddWithValue("@ma_nguyenlieu", txtMaNl.Text);
                cmd.ExecuteNonQuery();
                Load_Nguyenlieu("");
            }
            else if (tabPages.SelectedTab == tabSanpham)
            {
                cmd.CommandText = "DELETE FROM T_Thanhpham WHERE ma_thanhpham = @ma_thanhpham";
                cmd.Parameters.AddWithValue("@ma_thanhpham", txtMa_Sanpham.Text);
                cmd.ExecuteNonQuery();
                Load_Thanhpham("");
            }
            
            sqlCon.Close();

            Load_Nhanvien("");
        }     
        
    }
}
