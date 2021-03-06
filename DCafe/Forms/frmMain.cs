﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using DCafe.Reports;
using DCafe.Forms;

namespace DCafe
{
    public partial class frmMain : Form
    {
        private SqlConnection sqlCon;
        private ClsNhanvien clsNhanvien;
        private ClsNguyenlieu clsNguyenlieu;
        private ClsThanhpham clsThanhpham;
        private ClsHoadon clsHoadon;
        private ClsCTHoadon clsCTHoadon;
        DataTable dtNLCB;
        DataTable dtNL;
        private bool add = false;
        public bool isAdmin = false;
                
        #region Common

        private void nhapHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmImport f = new frmImport();
            f.Show();
            this.Visible = false;
        }

        private void hoTroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSupport f = new frmSupport();
            f.Show();
            this.Visible = false;
        }

        private void kinhDoanhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAccounting f = new frmAccounting();
            f.Show();
            this.Visible = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (tabPages.SelectedTab == tabHoadon)
            {
                RefreshHD();
                cbSanpham.SelectedIndex = 0;
            }
            else if (tabPages.SelectedTab == tabChebien)
            {
                RefreshCB();
            }
            else if (tabPages.SelectedTab == tabNhanvien)
            {
                if (!txtTen_nv.ReadOnly)
                {
                    Refresh_NV(add);
                }
            }
            else if (tabPages.SelectedTab == tabNguyenlieu)
            {
                Refresh_NL();
            }
            else if (tabPages.SelectedTab == tabSanpham)
            {
                Refresh_TP();
            }            
        }

        public frmMain()
        {
            InitializeComponent();
            Conn conn = new Conn();
            sqlCon = conn.createConn();
            clsNhanvien = new ClsNhanvien();
            clsNguyenlieu = new ClsNguyenlieu();
            clsThanhpham = new ClsThanhpham();
            clsHoadon = new ClsHoadon();
            clsCTHoadon = new ClsCTHoadon();
            dtNLCB = new DataTable();
            dtNL = new DataTable();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Load_TabHoadon();
            if (!isAdmin)
            {
                btnNguyenlieu.Visible = false;
                btnNhanvien.Visible = false;
                btnThanhpham.Visible = false;
                btnChebien.Visible = false;
                menuStrip1.Visible = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tabPages.SelectedTab == tabNhanvien)
            {
                Save_Nhanvien();                
            }
            else if (tabPages.SelectedTab == tabNguyenlieu)
            {
                Save_Nguyenlieu();
                Load_Nguyenlieu("");
            }
            else if (tabPages.SelectedTab == tabSanpham)
            {
                Save_Thanhpham();
                Load_Thanhpham("");
            }
            else if (tabPages.SelectedTab == tabHoadon)
            {
                if (grdHoadon.Rows.Count > 0)
                {
                    Save_Hoadon();
                    Save_CTHoadon();
                    RefreshHD();
                }
                else
                {
                    MessageBox.Show("Chưa chọn sản phẩm.");
                    return;
                }
            }
            else if (tabPages.SelectedTab == tabChebien)
            {
                if (grdNguyenlieuSPCB.Rows.Count > 0)
                {
                    Save_CTSanpham();
                }
                else
                {
                    MessageBox.Show("Chưa chọn nguyên liệu.");
                    return;
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = sqlCon.CreateCommand();
            sqlCon.Open();
            if (tabPages.SelectedTab == tabNhanvien)
            {
                if (MessageBox.Show("Bạn muốn thực hiện thao tác này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cmd.CommandText = "DELETE FROM T_Nhanvien WHERE ma_nv = @ma_nv";
                    cmd.Parameters.AddWithValue("@ma_nv", txtMa_nv.Text);
                    cmd.ExecuteNonQuery();
                }
            }
            else if (tabPages.SelectedTab == tabNguyenlieu)
            {
                cmd.CommandText = "DELETE FROM T_Nguyenlieu WHERE ma_nguyenlieu = @ma_nguyenlieu";
                cmd.Parameters.AddWithValue("@ma_nguyenlieu", txtMaNl.Text);
                cmd.ExecuteNonQuery();                
            }
            else if (tabPages.SelectedTab == tabSanpham)
            {
                cmd.CommandText = "DELETE FROM T_Thanhpham WHERE ma_thanhpham = @ma_thanhpham";
                cmd.Parameters.AddWithValue("@ma_thanhpham", txtMa_Sanpham.Text);
                cmd.ExecuteNonQuery();                
            }

            sqlCon.Close();

            if (tabPages.SelectedTab == tabNhanvien)
            {
                Load_Nhanvien("");
            }
            else if (tabPages.SelectedTab == tabNguyenlieu)
            {
                Load_Nguyenlieu("");
            }
            else if (tabPages.SelectedTab == tabSanpham)
            {
                Load_Thanhpham("");
            }
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        #endregion

        #region Nhan vien

        private void Refresh_NV(bool add)
        {
            if (add)
            {
                txtMa_nv.Text = "";
            }
            txtTen_nv.Text = "";
            dtNgaysinh.Value = DateTime.Now;
            txtDiachi.Text = "";
            dtNgayvaolam.Value = DateTime.Now;
            txtSdt.Text = "";
            txtMk.Text = "";
            txtComfirm.Text = "";
            rbNam.Checked = true;
            rbNu.Checked = false;
            cbMa_kv.SelectedIndex = 0;
            ckAdmin.Checked = false;
        }

        private void btnAddNV_Click(object sender, EventArgs e)
        {
            add = true;
            EditMode_NV(true);
            Refresh_NV(add);
        }

        private void btnEditNV_Click(object sender, EventArgs e)
        {
            add = false;
            EditMode_NV(true);
            txtMa_nv.ReadOnly = true;
            BindTextNhanvien();
        }

        private void BindTextNhanvien()
        {
            clsNhanvien.Ma_Nv = grdDsnhanvien.CurrentRow.Cells[0].Value.ToString();
            clsNhanvien.Password = grdDsnhanvien.CurrentRow.Cells[1].Value.ToString();
            clsNhanvien.Ten_Nv = grdDsnhanvien.CurrentRow.Cells[2].Value.ToString();
            if (grdDsnhanvien.CurrentRow.Cells[3].Value.ToString() == "Male")
            {
                clsNhanvien.Gioitinh = true;
            }
            else
            {
                clsNhanvien.Gioitinh = false;
            }
            clsNhanvien.Ma_Kv = grdDsnhanvien.CurrentRow.Cells[4].Value.ToString();
            clsNhanvien.Is_Admin = Convert.ToBoolean(grdDsnhanvien.CurrentRow.Cells[5].Value);
            clsNhanvien.Sdt = grdDsnhanvien.CurrentRow.Cells["cSdt"].Value.ToString();
            clsNhanvien.Ngaysinh = Convert.ToDateTime(grdDsnhanvien.CurrentRow.Cells["cNgaysinh"].Value.ToString());
            clsNhanvien.Ngayvaolam = Convert.ToDateTime(grdDsnhanvien.CurrentRow.Cells["cNgayvaolam"].Value.ToString());
            clsNhanvien.Diachi = grdDsnhanvien.CurrentRow.Cells["cDiachi"].Value.ToString();

            txtMa_nv.Text = clsNhanvien.Ma_Nv;
            txtTen_nv.Text = clsNhanvien.Ten_Nv;
            rbNam.Checked = clsNhanvien.Gioitinh;
            rbNu.Checked = !clsNhanvien.Gioitinh;
            cbMa_kv.SelectedValue = clsNhanvien.Ma_Kv;
            ckAdmin.Checked = clsNhanvien.Is_Admin;
            txtSdt.Text = clsNhanvien.Sdt;
            txtDiachi.Text = clsNhanvien.Diachi;
            dtNgaysinh.Value = clsNhanvien.Ngaysinh;
            dtNgayvaolam.Value = clsNhanvien.Ngayvaolam;
        }

        private void EditMode_NV(bool check)
        { 
            txtMa_nv.ReadOnly = !check;
            txtTen_nv.ReadOnly = !check;
            dtNgaysinh.Enabled = check;
            txtDiachi.ReadOnly = !check;
            dtNgayvaolam.Enabled = check;
            txtSdt.ReadOnly = !check;
            txtMk.ReadOnly = !check;
            txtComfirm.ReadOnly = !check;
            rbNam.Enabled = check;
            rbNu.Enabled = check;
            cbMa_kv.Enabled = check;
            ckAdmin.Enabled = check;

            txtMk.Text = "";
            txtComfirm.Text = "";
        }

        private bool ValidateNhanvien()
        {
            bool rs = true;
            if (String.IsNullOrEmpty(txtMa_nv.Text) || String.IsNullOrEmpty(txtTen_nv.Text) || dtNgaysinh.Value == null || String.IsNullOrEmpty(txtDiachi.Text) ||
                dtNgayvaolam.Value == null || String.IsNullOrEmpty(txtSdt.Text) || String.IsNullOrEmpty(txtMk.Text) || String.IsNullOrEmpty(txtComfirm.Text) || cbMa_kv.SelectedValue == null)
            {
                rs = false;
            }
            if (txtComfirm.Text != txtMk.Text)
            {
                rs = false;
            }
            
            return rs;
        }

        private void btnNhanvien_Click(object sender, EventArgs e)
        {
            btnDelete.Visible = true;
            btnIn.Visible = false;
            Load_Nhanvien("");
            Load_Khuvuc();
            EditMode_NV(false);
            rbNam.Checked = true;
            tabPages.SelectedTab = tabNhanvien;
        }

        private void Load_Nhanvien(string where)
        {
            string mk = "SELECT ma_nv, password, RTRIM(ten_nhanvien) AS ten_nhanvien, gioitinh = case gioitinh when 'True' then 'Male' else 'Female' end, ma_kv, is_admin, sdt, diachi, ngaysinh, ngayvaolam FROM T_Nhanvien " + where;
            SqlDataAdapter ada = new SqlDataAdapter(mk, sqlCon);
            sqlCon.Open();
            DataTable dt = new DataTable();
            ada.Fill(dt);

            grdDsnhanvien.DataSource = dt;
            sqlCon.Close();
        }

        private void Load_Khuvuc()
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

        private void Save_Nhanvien()
        {
            if (!txtTen_nv.ReadOnly)
            {
                if (MessageBox.Show("Bạn muốn thực hiện thao tác này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (ValidateNhanvien())
                    {
                        SqlCommand cmd = sqlCon.CreateCommand();
                        sqlCon.Open();

                        if (checkExistNhanvien(txtMa_nv.Text))
                        {
                            //Edit
                            cmd.CommandText = "UPDATE T_Nhanvien SET ten_nhanvien  = @ten_nhanvien, password=@password, gioitinh = @gioitinh, ma_kv = @ma_kv, is_admin = @is_admin, sdt = @sdt, diachi = @diachi, ngaysinh = @ngaysinh, ngayvaolam = @ngayvaolam WHERE ma_nv = @ma_nv";

                            cmd.Parameters.AddWithValue("@ten_nhanvien", txtTen_nv.Text);
                            cmd.Parameters.AddWithValue("@password", txtMk.Text);
                            cmd.Parameters.AddWithValue("@gioitinh", rbNam.Checked);
                            cmd.Parameters.AddWithValue("@ma_kv", cbMa_kv.SelectedValue);
                            cmd.Parameters.AddWithValue("@is_admin", ckAdmin.Checked);
                            cmd.Parameters.AddWithValue("@ma_nv", txtMa_nv.Text);

                            cmd.Parameters.AddWithValue("@sdt", txtSdt.Text);
                            cmd.Parameters.AddWithValue("@diachi", txtDiachi.Text);
                            cmd.Parameters.AddWithValue("@ngaysinh", dtNgaysinh.Value);
                            cmd.Parameters.AddWithValue("@ngayvaolam", dtNgayvaolam.Value);

                            cmd.ExecuteNonQuery();
                        }
                        else
                        {
                            //Add
                            cmd.CommandText = "INSERT INTO T_Nhanvien (ma_nv, ten_nhanvien, password, gioitinh, ma_kv, is_admin, sdt, diachi, ngaysinh, ngayvaolam) VALUES (@ma_nv, @ten_nhanvien, @password, @gioitinh, @ma_kv, @is_admin, @sdt, @diachi, @ngaysinh, @ngayvaolam)";

                            cmd.Parameters.AddWithValue("@ma_nv", txtMa_nv.Text);
                            cmd.Parameters.AddWithValue("@ten_nhanvien", txtTen_nv.Text);
                            cmd.Parameters.AddWithValue("@password", txtMk.Text);
                            cmd.Parameters.AddWithValue("@gioitinh", rbNam.Checked);

                            cmd.Parameters.AddWithValue("@ma_kv", cbMa_kv.SelectedValue);
                            cmd.Parameters.AddWithValue("@is_admin", ckAdmin.Checked);
                            cmd.Parameters.AddWithValue("@sdt", txtSdt.Text);
                            cmd.Parameters.AddWithValue("@diachi", txtDiachi.Text);
                            cmd.Parameters.AddWithValue("@ngaysinh", dtNgaysinh.Value);
                            cmd.Parameters.AddWithValue("@ngayvaolam", dtNgayvaolam.Value);

                            cmd.ExecuteNonQuery();
                        }
                        sqlCon.Close();
                        EditMode_NV(false);
                        Load_Nhanvien("");
                    }
                    else
                    {
                        MessageBox.Show("Thông tin nhập vào không đúng.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn thao tác Thêm hoặc Sửa.");
            }
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
            BindTextNhanvien();
            EditMode_NV(false);
        }

        #endregion

        #region Nguyen lieu

        private void Refresh_NL()
        {
            txtMaNl.Text = "";
            txtTenNl.Text = "";
            txtDongia.Text = "";
            cbDonvi.SelectedIndex = 0;
            dtThoidiem.Value = DateTime.Now;
        }
        
        private void btnNguyenlieu_Click(object sender, EventArgs e)
        {
            btnDelete.Visible = true;
            btnIn.Visible = false;
            tabPages.SelectedTab = tabNguyenlieu;
            Load_Nguyenlieu("");
            Load_Donvi();
        }

        private void Load_Nguyenlieu(string where)
        {		
            string sql = "SELECT ma_nguyenlieu, RTRIM(ten_nguyenlieu) as ten_nguyenlieu, dongia, t2.ten_donvi as donvi, thoidiem FROM T_Nguyenlieu t1 LEFT OUTER JOIN T_Donvi t2 ON t1.donvi = t2.ma_donvi " + where;
            SqlDataAdapter ada = new SqlDataAdapter(sql, sqlCon);
            sqlCon.Open();
            DataTable dt = new DataTable();
            ada.Fill(dt);

            grdDsNguyenlieu.DataSource = dt;
            sqlCon.Close();
        }

        private void Load_Donvi()
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

        private void Save_Nguyenlieu()
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
            txtDongia.Text = string.Format("{0:#,##0}", double.Parse(clsNguyenlieu.Dongia.ToString()));
            cbDonvi.SelectedValue = clsNguyenlieu.Donvi;
        }

        #endregion

        #region Thanh pham

        private void Refresh_TP()
        {
            txtMa_Sanpham.Text = "";
            txtTen_Sanpham.Text = "";
            txtDongiaSP.Text = "";
            txtGiaban.Text = "";
            cbDonviSP.SelectedIndex = 0;
            dtThoidiemSP.Value = DateTime.Now;
        }

        private void btnThanhpham_Click(object sender, EventArgs e)
        {
            btnDelete.Visible = true;
            btnIn.Visible = false;
            tabPages.SelectedTab = tabSanpham;
            Load_Thanhpham("");
            Load_DonviSP();
        }

        private void Load_Thanhpham(string where)
        {
            string sql = "SELECT ma_thanhpham, RTRIM(ten_thanhpham) as ten_thanhpham, dongia, giaban, t2.ten_donvi as ten_donvi, thoidiem, t1.donvi as donvi FROM T_Thanhpham t1 LEFT OUTER JOIN T_Donvi t2 ON t1.donvi = t2.ma_donvi " + where;
            SqlDataAdapter ada = new SqlDataAdapter(sql, sqlCon);
            sqlCon.Open();
            DataTable dt = new DataTable();
            ada.Fill(dt);

            grdDsSanpham.DataSource = dt;
            sqlCon.Close();
        }

        private void Load_DonviSP()
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

        private void Save_Thanhpham()
        {
            SqlCommand cmd = sqlCon.CreateCommand();
            sqlCon.Open();
            if (checkExistThanhpham(txtMa_Sanpham.Text))
            {
                //Edit
                //cmd.CommandText = "UPDATE T_Thanhpham SET ten_thanhpham  = @ten_thanhpham, dongia=@dongia, giaban = @giaban, donvi = @donvi, thoidiem = @thoidiem WHERE ma_thanhpham = @ma_thanhpham";
                cmd.CommandText = "UPDATE T_Thanhpham SET ten_thanhpham  = @ten_thanhpham, giaban = @giaban, donvi = @donvi, thoidiem = @thoidiem WHERE ma_thanhpham = @ma_thanhpham";

                cmd.Parameters.AddWithValue("@ten_thanhpham", txtTen_Sanpham.Text);
                //cmd.Parameters.AddWithValue("@dongia", int.Parse(txtDongiaSP.Text));
                cmd.Parameters.AddWithValue("@giaban", int.Parse(txtGiaban.Text));
                cmd.Parameters.AddWithValue("@donvi", cbDonviSP.SelectedValue);
                cmd.Parameters.AddWithValue("@thoidiem", dtThoidiem.Value);
                cmd.Parameters.AddWithValue("@ma_thanhpham", txtMa_Sanpham.Text);

                cmd.ExecuteNonQuery();
            }
            else
            {
                //Add
                cmd.CommandText = "INSERT INTO T_Thanhpham (ma_thanhpham, ten_thanhpham, dongia, giaban, donvi, thoidiem) VALUES (@ma_thanhpham, @ten_thanhpham, @dongia, @giaban, @donvi, @thoidiem)";

                cmd.Parameters.AddWithValue("@ma_thanhpham", txtMa_Sanpham.Text);
                cmd.Parameters.AddWithValue("@ten_thanhpham", txtTen_Sanpham.Text);
                //cmd.Parameters.AddWithValue("@dongia", int.Parse(txtDongiaSP.Text));
                cmd.Parameters.AddWithValue("@dongia", 0);
                cmd.Parameters.AddWithValue("@giaban", int.Parse(txtGiaban.Text));
                cmd.Parameters.AddWithValue("@donvi", cbDonviSP.SelectedValue);
                cmd.Parameters.AddWithValue("@thoidiem", dtThoidiemSP.Value);
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
                clsThanhpham.Dongia = Convert.ToInt32(row.Cells[2].Value);
                clsThanhpham.Giaban = Convert.ToInt32(row.Cells[3].Value);
                clsThanhpham.Donvi = row.Cells[6].Value.ToString();
                clsThanhpham.Thoidiem = Convert.ToDateTime(row.Cells[5].Value);
            }

            txtMa_Sanpham.Text = clsThanhpham.Ma_Thanhpham;
            txtTen_Sanpham.Text = clsThanhpham.Ten_Thanhpham;
            txtDongiaSP.Text = string.Format("{0:#,##0}", double.Parse(clsThanhpham.Dongia.ToString()));
            txtGiaban.Text = clsThanhpham.Giaban.ToString();
            cbDonviSP.SelectedValue = clsThanhpham.Donvi;
            dtThoidiemSP.Value = clsThanhpham.Thoidiem;
        }

        #endregion

        #region Che bien

        private void txtSoluongSPCB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void RefreshCB()
        {
            cbNguyenlieuSPCB.SelectedIndex = 0;
            txtSoluongSPCB.Text = "";
        }

        private void Load_SanphamCB()
        {
            string mk = "SELECT ma_thanhpham, RTRIM(ten_thanhpham) AS ten_thanhpham FROM T_Thanhpham";
            SqlDataAdapter ada = new SqlDataAdapter(mk, sqlCon);
            sqlCon.Open();
            DataTable dt = new DataTable();
            ada.Fill(dt);

            cbTenSPCB.DataSource = dt;
            cbTenSPCB.DisplayMember = "ten_thanhpham";
            cbTenSPCB.ValueMember = "ma_thanhpham";
            sqlCon.Close();
        }

        private void Load_DonviSPCB()
        {
            string mk = "SELECT ma_donvi, RTRIM(ten_donvi) AS ten_donvi FROM T_Donvi where loai_donvi = 'TP'";
            SqlDataAdapter ada = new SqlDataAdapter(mk, sqlCon);
            sqlCon.Open();
            DataTable dt = new DataTable();
            ada.Fill(dt);

            cbDonviSPCB.DataSource = dt;
            cbDonviSPCB.DisplayMember = "ten_donvi";
            cbDonviSPCB.ValueMember = "ma_donvi";
            sqlCon.Close();
        }

        private void fillAllTheRest(String ma_thanhpham)
        {
            string mk = "SELECT ma_thanhpham, dongia, giaban, thoidiem, RTRIM(ten_donvi) AS ten_donvi, donvi FROM T_Thanhpham, T_Donvi WHERE T_Thanhpham.donvi = T_Donvi.ma_donvi AND T_Donvi.loai_donvi = 'TP' AND ma_thanhpham='" + ma_thanhpham + "'";
            SqlDataAdapter ada = new SqlDataAdapter(mk, sqlCon);
            sqlCon.Open();
            DataTable dt = new DataTable();
            ada.Fill(dt);
            txtMaSPCB.Text = (dt.Rows[0]["ma_thanhpham"].ToString());
            txtGiabanSPCB.Text = string.Format("{0:#,##0}", double.Parse(dt.Rows[0]["giaban"].ToString()));
            cbDonviSPCB.SelectedValue = dt.Rows[0]["donvi"];
            dtThoidiemSPCB.Value = Convert.ToDateTime((dt.Rows[0]["thoidiem"].ToString()));
            sqlCon.Close();
        }

        private void Load_DSNLSave(String ma_thanhpham)
        {
            string mk = "SELECT ma_thanhpham, T_Nguyenlieu.ma_nguyenlieu, RTRIM(ten_nguyenlieu) AS ten_nguyenlieu, soluong, soluong * T_Nguyenlieu.dongia as dongia, T_Nguyenlieu.dongia  as dongia_nl FROM T_Chebien, T_Nguyenlieu  WHERE T_Chebien.ma_nguyenlieu = T_Nguyenlieu.ma_nguyenlieu AND T_Chebien.ma_thanhpham = '" + ma_thanhpham + "'";
            SqlDataAdapter ada = new SqlDataAdapter(mk, sqlCon);            
            try
            {
                dtNLCB.Clear();
            }
            catch (DataException e)
            {

            }
            ada.Fill(dtNLCB);
            grdNguyenlieuSPCB.DataSource = dtNLCB;

            LoadTongDongia();
        }

        private void LoadTongDongia()
        {
            int tong = 0;
            foreach (DataGridViewRow row in grdNguyenlieuSPCB.Rows)
            {
                tong = tong + Convert.ToInt32(row.Cells[4].Value);
            }
            txtTongDongia.Text = string.Format("{0:#,##0}", double.Parse(tong.ToString()));
        }

        private void Load_DSNL(String ma_thanhpham)
        {
            string mk = "SELECT ma_thanhpham, T_Nguyenlieu.ma_nguyenlieu, RTRIM(ten_nguyenlieu) AS ten_nguyenlieu, soluong, soluong * T_Nguyenlieu.dongia as dongia, T_Nguyenlieu.dongia  as dongia_nl FROM T_Chebien, T_Nguyenlieu  WHERE T_Chebien.ma_nguyenlieu = T_Nguyenlieu.ma_nguyenlieu AND T_Chebien.ma_thanhpham = '" + ma_thanhpham + "'";
            SqlDataAdapter ada = new SqlDataAdapter(mk, sqlCon);            
            sqlCon.Open();
            try
            {
                dtNLCB.Clear();
            }
            catch (DataException e)
            {
              
            }
            ada.Fill(dtNLCB);
            grdNguyenlieuSPCB.DataSource = dtNLCB;
            sqlCon.Close();

            LoadTongDongia();
        }

        private void Load_NguyenlieuSPCB()
        {
            string mk = "SELECT ma_nguyenlieu, RTRIM(ten_nguyenlieu) AS ten_nguyenlieu, dongia FROM T_Nguyenlieu";
            SqlDataAdapter ada = new SqlDataAdapter(mk, sqlCon);
            sqlCon.Open();
            dtNL = new DataTable();
            ada.Fill(dtNL);

            cbNguyenlieuSPCB.DataSource = dtNL;
            cbNguyenlieuSPCB.DisplayMember = "ten_nguyenlieu";
            cbNguyenlieuSPCB.ValueMember = "ma_nguyenlieu";
            sqlCon.Close();
        }

        private void btnChebien_Click(object sender, EventArgs e)
        {
            btnDelete.Visible = false;
            btnIn.Visible = false;
            tabPages.SelectedTab = tabChebien;
            Load_SanphamCB();
            Load_DonviSPCB();
            fillAllTheRest(cbTenSPCB.SelectedValue.ToString());
            Load_DSNL(cbTenSPCB.SelectedValue.ToString());
            Load_NguyenlieuSPCB();
        }

        private void Save_CTSanpham()
        {
            SqlCommand cmd = sqlCon.CreateCommand();
            sqlCon.Open();
            cmd.Parameters.Add(new SqlParameter("@ma_thanhpham", SqlDbType.NChar));
            cmd.Parameters.Add(new SqlParameter("@ma_nguyenlieu", SqlDbType.NChar));
            cmd.Parameters.Add(new SqlParameter("@soluong", SqlDbType.Float));
            bool change = false;
            
            this.grdNguyenlieuSPCB.BindingContext[(DataTable)grdNguyenlieuSPCB.DataSource].EndCurrentEdit();
            var dataTable = ((DataTable)grdNguyenlieuSPCB.DataSource);                
            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    switch (row.RowState)
                    {
                        case DataRowState.Added:
                            // DO INSERT QUERY
                            change = true;
                            cmd.CommandText = "INSERT INTO T_Chebien (ma_thanhpham, ma_nguyenlieu, soluong) VALUES (@ma_thanhpham, @ma_nguyenlieu, @soluong)";
                            cmd.Parameters["@ma_thanhpham"].Value = row["ma_thanhpham"];
                            cmd.Parameters["@ma_nguyenlieu"].Value = row["ma_nguyenlieu"];
                            cmd.Parameters["@soluong"].Value = row["soluong"];
                            cmd.ExecuteNonQuery();
                            break;
                        case DataRowState.Deleted:
                            // DO DELETE QUERY
                            change = true;
                            cmd.CommandText = "DELETE FROM T_Chebien WHERE ma_thanhpham = @ma_thanhpham AND ma_nguyenlieu = @ma_nguyenlieu";
                            cmd.Parameters.Remove(cmd.Parameters["@soluong"]);
                            cmd.Parameters["@ma_nguyenlieu"].Value = clsNguyenlieu.Ma_Nguyenlieu;
                            cmd.Parameters["@ma_thanhpham"].Value = clsThanhpham.Ma_Thanhpham;
                            cmd.ExecuteNonQuery();
                            cmd.Parameters.Add(new SqlParameter("@soluong", SqlDbType.Float));
                            break;
                        case DataRowState.Modified:
                            change = true;
                            cmd.CommandText = "UPDATE T_Chebien SET soluong = @soluong WHERE ma_thanhpham = @ma_thanhpham AND ma_nguyenlieu = @ma_nguyenlieu";
                            cmd.Parameters["@soluong"].Value = row["soluong"];
                            cmd.Parameters["@ma_nguyenlieu"].Value = row["ma_nguyenlieu"];
                            cmd.Parameters["@ma_thanhpham"].Value = row["ma_thanhpham"];
                            cmd.ExecuteNonQuery();
                            break;
                    }
                }
                Load_DSNLSave(txtMaSPCB.Text);
            }
            
            if (change)
            {
                //Update don gia san pham
                cmd.CommandText = "UPDATE T_Thanhpham SET dongia = @dongia WHERE ma_thanhpham = @ma_thanhpham";

                cmd.Parameters.AddWithValue("@dongia", int.Parse(txtTongDongia.Text));
                cmd.Parameters["@ma_thanhpham"].Value = txtMaSPCB.Text;
                cmd.Parameters.Remove(cmd.Parameters["@soluong"]);
                cmd.Parameters.Remove(cmd.Parameters["@ma_nguyenlieu"]);
                cmd.ExecuteNonQuery();
            }

            sqlCon.Close();

            if (change)
            {
                cbTenSPCB.SelectedIndex = 0;
                fillAllTheRest(cbTenSPCB.SelectedValue.ToString());
                Load_DSNL(cbTenSPCB.SelectedValue.ToString());
            }
        }

        private int indexChebien = 0;

        private void btnDeleteSPCB_Click(object sender, EventArgs e)
        {
            if (grdNguyenlieuSPCB.CurrentRow != null)
            {
                clsThanhpham.Ma_Thanhpham = grdNguyenlieuSPCB.CurrentRow.Cells[0].Value.ToString();
                clsNguyenlieu.Ma_Nguyenlieu = grdNguyenlieuSPCB.CurrentRow.Cells[1].Value.ToString();
                grdNguyenlieuSPCB.Rows.RemoveAt(indexChebien);
            }
            LoadTongDongia();
        }

        private void cbMaSPCB_DropDownClosed(object sender, EventArgs e)
        {
            fillAllTheRest(cbTenSPCB.SelectedValue.ToString());
            Load_DSNL(cbTenSPCB.SelectedValue.ToString());
        }

        private void btnSaveSPCB_Click(object sender, EventArgs e)
        {
            bool found = false;
            this.grdNguyenlieuSPCB.SelectionChanged -= new System.EventHandler(this.grdNguyenlieuSPCB_SelectionChanged);
            if (txtSoluongSPCB.Text != "")
            {
                foreach (DataGridViewRow row in grdNguyenlieuSPCB.Rows)
                {
                    if (row.Cells[1].Value.ToString() == cbNguyenlieuSPCB.SelectedValue.ToString())
                    {
                        // row exists
                        found = true;
                        grdNguyenlieuSPCB.Rows[row.Index].Cells[3].Value = txtSoluongSPCB.Text;
                        grdNguyenlieuSPCB.Rows[row.Index].Cells[4].Value = Convert.ToInt32(grdNguyenlieuSPCB.Rows[row.Index].Cells[5].Value)*Convert.ToInt32(txtSoluongSPCB.Text);
                        break;
                    }
                }

                if (!found)
                {
                    DataRow newRow = dtNLCB.NewRow();
                    int dongia = Convert.ToInt32(((DataTable)cbNguyenlieuSPCB.DataSource).Rows[cbNguyenlieuSPCB.SelectedIndex][2]);
                    dtNLCB.Rows.Add(txtMaSPCB.Text, cbNguyenlieuSPCB.SelectedValue.ToString(), cbNguyenlieuSPCB.Text, Convert.ToInt32(txtSoluongSPCB.Text), dongia * Convert.ToInt32(txtSoluongSPCB.Text), dongia);
                }
                LoadTongDongia();
            }
            else
            {
                MessageBox.Show("Chưa nhập số lượng.");
            }
            txtSoluongSPCB.Text = "";
            this.grdNguyenlieuSPCB.SelectionChanged += new System.EventHandler(this.grdNguyenlieuSPCB_SelectionChanged);

        }

        private void grdNguyenlieuSPCB_SelectionChanged(object sender, EventArgs e)
        {
            if (grdNguyenlieuSPCB.CurrentRow != null)
            {
                indexChebien = grdNguyenlieuSPCB.CurrentRow.Index;

                cbNguyenlieuSPCB.SelectedValue = grdNguyenlieuSPCB.CurrentRow.Cells[1].Value;
                txtSoluongSPCB.Text = grdNguyenlieuSPCB.CurrentRow.Cells[3].Value.ToString();
            }
        }

        #endregion

        #region Hoa don

        private void btnHoadon_Click(object sender, EventArgs e)
        {
            Load_TabHoadon();
        }

        private void Load_TabHoadon()
        {
            tabPages.SelectedTab = tabHoadon;
            if (cbNhanvien.Items.Count == 0)
            {
                RefreshHD();
            }
            btnDelete.Visible = false;
            btnIn.Visible = true;
        }

        private void RefreshHD()
        {
            RemoveEventTabHD();
            Load_Mahoadon();
            cbMahoadon.Text = "AD01TT01" + GetLastIdHD();

            Load_Nhanvien();
            Load_KhuvucHD();
            Load_Soban();

            AddEventTabHD();

            Load_SanphamHD();

            Load_CTHoadon(cbMahoadon.Text);

            txtSoluong.Text = "";
            txtThanhtien.Text = "0";
            dtThoidiem.Value = DateTime.Now;
        }

        private void AddEventTabHD()
        {
            cbNhanvien.SelectedIndexChanged += new System.EventHandler(this.cbNhanvien_SelectedIndexChanged);
            cbKhuvuc.SelectedIndexChanged += new System.EventHandler(this.cbKhuvuc_SelectedIndexChanged);
            cbSoban.SelectedIndexChanged += new System.EventHandler(this.cbSoban_SelectedIndexChanged);
            cbMahoadon.SelectedIndexChanged += new System.EventHandler(this.cbMahoadon_SelectedIndexChanged);
        }

        private void RemoveEventTabHD()
        {
            cbNhanvien.SelectedIndexChanged -= new System.EventHandler(this.cbNhanvien_SelectedIndexChanged);
            cbKhuvuc.SelectedIndexChanged -= new System.EventHandler(this.cbKhuvuc_SelectedIndexChanged);
            cbSoban.SelectedIndexChanged -= new System.EventHandler(this.cbSoban_SelectedIndexChanged);
            cbMahoadon.SelectedIndexChanged -= new System.EventHandler(this.cbMahoadon_SelectedIndexChanged);
        }

        private void Load_Nhanvien()
        {
            string mk = "SELECT ma_nv, ten_nhanvien FROM T_Nhanvien";
            SqlDataAdapter ada = new SqlDataAdapter(mk, sqlCon);
            sqlCon.Open();
            DataTable dt = new DataTable();
            ada.Fill(dt);

            cbNhanvien.DataSource = dt;
            cbNhanvien.DisplayMember = "ten_nhanvien";
            cbNhanvien.ValueMember = "ma_nv";
            sqlCon.Close();

            cbMahoadon.Text = cbNhanvien.SelectedValue.ToString() + cbMahoadon.Text.Substring(4, 2) + cbMahoadon.Text.Substring(6, 2) + cbMahoadon.Text.Substring(8, 4);
        }

        private void Load_SanphamHD()
        {
            string mk = "SELECT ma_thanhpham, ten_thanhpham, giaban FROM T_Thanhpham";
            SqlDataAdapter ada = new SqlDataAdapter(mk, sqlCon);
            sqlCon.Open();
            DataTable dt = new DataTable();
            ada.Fill(dt);

            cbSanpham.DataSource = dt;
            cbSanpham.DisplayMember = "ten_thanhpham";
            cbSanpham.ValueMember = "ma_thanhpham";
            sqlCon.Close();
        }

        private void Load_KhuvucHD()
        {
            string mk = "SELECT ma_kv, ten_kv FROM T_Khuvuc";
            SqlDataAdapter ada = new SqlDataAdapter(mk, sqlCon);
            sqlCon.Open();
            DataTable dt = new DataTable();
            ada.Fill(dt);

            cbKhuvuc.DataSource = dt;
            cbKhuvuc.DisplayMember = "ten_kv";
            cbKhuvuc.ValueMember = "ma_kv";
            sqlCon.Close();

            cbMahoadon.Text = cbMahoadon.Text.Substring(0, 4) + cbKhuvuc.SelectedValue.ToString() + cbMahoadon.Text.Substring(6, 2) + cbMahoadon.Text.Substring(8, 4);
        }

        private void Load_Soban()
        {
            string mk = "SELECT maban, tenban FROM T_Ban WHERE ma_kv = '" + cbKhuvuc.SelectedValue.ToString() + "'";
            SqlDataAdapter ada = new SqlDataAdapter(mk, sqlCon);
            sqlCon.Open();
            DataTable dt = new DataTable();
            ada.Fill(dt);

            cbSoban.DataSource = dt;
            cbSoban.DisplayMember = "tenban";
            cbSoban.ValueMember = "maban";
            sqlCon.Close();

            cbMahoadon.Text = cbMahoadon.Text.Substring(0, 4) + cbMahoadon.Text.Substring(4, 2) + cbSoban.SelectedValue.ToString() + cbMahoadon.Text.Substring(8, 4);
        }

        public bool checkExistHoadon(string ma_hd)
        {
            string sql = "SELECT ma_hd FROM T_CTHoadon WHERE (ma_hd = @ma_hd)";
            bool isExist = false;
            SqlCommand cmd = new SqlCommand(sql, sqlCon);
            cmd.Parameters.AddWithValue("ma_hd", ma_hd);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                isExist = true;
            }
            dr.Close();
            return isExist;
        }

        private string GetLastIdHD() 
        {
            string sql = "SELECT TOP 1 id_hd FROM T_Hoadon ORDER BY id_hd DESC";            
            SqlCommand cmd = new SqlCommand(sql, sqlCon);
            sqlCon.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            string lastID = "0001";
            clsHoadon.Id_Hd = 1;
            if (dr.Read())
            {
                clsHoadon.Id_Hd = Convert.ToInt32(dr[0].ToString()) + 1;
                lastID = (clsHoadon.Id_Hd).ToString();
                
                while(lastID.Length < 4)
                {
                    lastID = "0" + lastID;
                }
            }
            sqlCon.Close();
            return lastID;
        }

        private void Save_CTHoadon()
        {
            SqlCommand cmd = sqlCon.CreateCommand();
            sqlCon.Open();
            cmd.Parameters.Add(new SqlParameter("@ma_hd", SqlDbType.NChar));
            cmd.Parameters.Add(new SqlParameter("@ma_thanhpham", SqlDbType.NChar));
            cmd.Parameters.Add(new SqlParameter("@soluong", SqlDbType.Float));
            if (!checkExistHoadon(cbMahoadon.Text))
            {                
                foreach (DataGridViewRow row in grdHoadon.Rows)
                {
                    //Add
                    cmd.CommandText = "INSERT INTO T_CTHoadon (ma_hd, ma_thanhpham, soluong) VALUES (@ma_hd, @ma_thanhpham, @soluong)";

                    cmd.Parameters["@ma_hd"].Value = cbMahoadon.Text;
                    cmd.Parameters["@ma_thanhpham"].Value = row.Cells[1].Value;
                    cmd.Parameters["@soluong"].Value = row.Cells[3].Value;

                    cmd.ExecuteNonQuery();
                }
            }
            else
            {
                this.grdHoadon.BindingContext[(DataTable)grdHoadon.DataSource].EndCurrentEdit();
                var dataTable = ((DataTable)grdHoadon.DataSource).GetChanges();
                if (dataTable != null && dataTable.Rows.Count > 0)
                {
                    foreach (DataRow row in dataTable.Rows)
                    {
                        switch (row.RowState)
                        {
                            case DataRowState.Added:
                                // DO INSERT QUERY
                                cmd.CommandText = "INSERT INTO T_CTHoadon (ma_hd, ma_thanhpham, soluong) VALUES (@ma_hd, @ma_thanhpham, @soluong)";
                                cmd.Parameters["@ma_hd"].Value = row["ma_hd"];
                                cmd.Parameters["@ma_thanhpham"].Value = row["ma_thanhpham"];
                                cmd.Parameters["@soluong"].Value = row["soluong"];
                                cmd.ExecuteNonQuery();                                
                                break;
                            case DataRowState.Deleted:
                                // DO DELETE QUERY
                                cmd.CommandText = "DELETE FROM T_CTHoadon WHERE ma_hd = @ma_hd AND ma_thanhpham = @ma_thanhpham";
                                cmd.Parameters.Remove(cmd.Parameters["@soluong"]);
                                cmd.Parameters["@ma_hd"].Value = clsCTHoadon.Ma_Hd;
                                cmd.Parameters["@ma_thanhpham"].Value = clsCTHoadon.Ma_Thanhpham;
                                cmd.ExecuteNonQuery();
                                cmd.Parameters.Add(new SqlParameter("@soluong", SqlDbType.Float));
                                break;
                            case DataRowState.Modified:
                                cmd.CommandText = "UPDATE T_CTHoadon SET soluong = @soluong WHERE ma_hd = @ma_hd AND ma_thanhpham = @ma_thanhpham";
                                cmd.Parameters["@soluong"].Value = row["soluong"];
                                cmd.Parameters["@ma_hd"].Value = row["ma_hd"];
                                cmd.Parameters["@ma_thanhpham"].Value = row["ma_thanhpham"];
                                cmd.ExecuteNonQuery();
                                break;
                        }
                    }
                    ////////Load_CTHoadon(cbMahoadon.SelectedValue.ToString());                    
                }
            }
            sqlCon.Close();
        }
        
        private void Save_Hoadon()
        {
            SqlCommand cmd = sqlCon.CreateCommand();
            sqlCon.Open();
            
            if (checkExistHoadon(cbMahoadon.Text))
            {
                //Edit
                cmd.CommandText = "UPDATE T_Hoadon SET ma_nv  = @ma_nv, ma_kv=@ma_kv, ma_ban = @ma_ban, thoidiem = @thoidiem WHERE ma_hd = @ma_hd";

                cmd.Parameters.AddWithValue("@ma_nv", cbNhanvien.SelectedValue);
                cmd.Parameters.AddWithValue("@ma_kv", cbKhuvuc.SelectedValue);
                cmd.Parameters.AddWithValue("@ma_ban", cbSoban.SelectedValue);
                cmd.Parameters.AddWithValue("@thoidiem", dtThoidiemHD.Value);
                cmd.Parameters.AddWithValue("@ma_hd", cbMahoadon.Text);

                cmd.ExecuteNonQuery();
            }
            else
            {
                //Add
                cmd.CommandText = "INSERT INTO T_Hoadon (ma_nv, ma_kv, ma_ban, thoidiem, ma_hd, id_hd) VALUES (@ma_nv, @ma_kv, @ma_ban, @thoidiem, @ma_hd, @id_hd)";

                cmd.Parameters.AddWithValue("@ma_nv", cbNhanvien.SelectedValue);
                cmd.Parameters.AddWithValue("@ma_kv", cbKhuvuc.SelectedValue);
                cmd.Parameters.AddWithValue("@ma_ban", cbSoban.SelectedValue);
                cmd.Parameters.AddWithValue("@thoidiem", dtThoidiemHD.Value);
                cmd.Parameters.AddWithValue("@ma_hd", cbMahoadon.Text);
                cmd.Parameters.AddWithValue("@id_hd", clsHoadon.Id_Hd);
                cmd.ExecuteNonQuery();
            }            
            sqlCon.Close();
        }

        private void cbNhanvien_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbMahoadon.Text = cbNhanvien.SelectedValue.ToString() + cbMahoadon.Text.Substring(4, 2) + cbMahoadon.Text.Substring(6, 2) + cbMahoadon.Text.Substring(8, 4);
        }

        private void cbKhuvuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbMahoadon.Text = cbMahoadon.Text.Substring(0, 4) + cbKhuvuc.SelectedValue.ToString() + cbMahoadon.Text.Substring(6, 2) + cbMahoadon.Text.Substring(8, 4);
        }

        private void cbSoban_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbMahoadon.Text = cbMahoadon.Text.Substring(0, 4) + cbMahoadon.Text.Substring(4, 2) + cbSoban.SelectedValue.ToString() + cbMahoadon.Text.Substring(8, 4);
        }

        private void btnCommitHD_Click(object sender, EventArgs e)
        {
            bool found = false;
            this.grdHoadon.SelectionChanged -= new System.EventHandler(this.grdHoadon_SelectionChanged);
            if (txtSoluong.Text != "")
            {                
                foreach (DataGridViewRow row in grdHoadon.Rows)
                {
                    if (row.Cells[1].Value.ToString() == cbSanpham.SelectedValue.ToString())
                    {
                        // row exists;
                        found = true;
                        grdHoadon.Rows[row.Index].Cells[3].Value = txtSoluong.Text;
                        grdHoadon.Rows[row.Index].Cells[5].Value = Convert.ToInt32(grdHoadon.Rows[row.Index].Cells[4].Value) * Convert.ToInt32(txtSoluong.Text);
                        break;
                    }
                }

                if (!found)
                {
                    DataTable dt = (DataTable)(grdHoadon.DataSource);
                    int giaban = Convert.ToInt32(((DataTable)cbSanpham.DataSource).Rows[cbSanpham.SelectedIndex][2]);
                    dt.Rows.Add(cbMahoadon.Text, cbSanpham.SelectedValue.ToString(), cbSanpham.Text, txtSoluong.Text, giaban, giaban*Convert.ToInt32(txtSoluong.Text));
                    grdHoadon.DataSource = dt;
                }
            }
            else 
            {
                MessageBox.Show("Chưa nhập số lượng.");            
            }
            txtSoluong.Text = "";
            cbSanpham.Focus();
            LoadTongThanhtien();
            this.grdHoadon.SelectionChanged += new System.EventHandler(this.grdHoadon_SelectionChanged);
        }

        private int indexHoadon = 0;

        private void btnDeleteHD_Click(object sender, EventArgs e)
        {
            if (grdHoadon.RowCount == 1)
            {
                txtSoluong.Text = "";
            }
            if (grdHoadon.CurrentRow != null)
            {
                clsCTHoadon.Ma_Hd = grdHoadon.CurrentRow.Cells[0].Value.ToString();
                clsCTHoadon.Ma_Thanhpham = grdHoadon.CurrentRow.Cells[1].Value.ToString();
                grdHoadon.Rows.RemoveAt(indexHoadon);                
            }
            LoadTongThanhtien();
        }
        
        private void grdHoadon_SelectionChanged(object sender, EventArgs e)
        {
            if (grdHoadon.CurrentRow != null)
            {
                indexHoadon = grdHoadon.CurrentRow.Index;

                cbSanpham.SelectedValue = grdHoadon.CurrentRow.Cells[1].Value;
                txtSoluong.Text = grdHoadon.CurrentRow.Cells[3].Value.ToString();
            }
        }

        private void Load_Mahoadon()
        {
            string mk = "SELECT TOP 5 ma_hd FROM T_Hoadon ORDER BY id_hd DESC";
            SqlDataAdapter ada = new SqlDataAdapter(mk, sqlCon);
            sqlCon.Open();
            DataTable dt = new DataTable();
            ada.Fill(dt);

            cbMahoadon.DataSource = dt;
            cbMahoadon.DisplayMember = "ma_hd";
            cbMahoadon.ValueMember = "ma_hd";
            sqlCon.Close();
        }
        
        private void cbMahoadon_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "SELECT ma_nv, ma_kv, ma_ban, thoidiem, ma_hd FROM T_Hoadon WHERE ma_hd = @ma_hd";
            sqlCon.Open();
            SqlCommand cmd = new SqlCommand(sql, sqlCon);
            cmd.Parameters.AddWithValue("ma_hd", cbMahoadon.SelectedValue.ToString());
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                cbNhanvien.SelectedValue = dr[0];
                cbKhuvuc.SelectedValue = dr[1];
                cbSoban.SelectedValue = dr[2];
                dtThoidiem.Value = Convert.ToDateTime(dr[3].ToString());
            }
            dr.Close();
            Load_CTHoadon(cbMahoadon.SelectedValue.ToString());
            LoadTongThanhtien();
            sqlCon.Close();    
        }

        private void Load_CTHoadon(string ma_hd)
        {
            string sql2 = "SELECT t1.ma_hd, t1.ma_thanhpham, t2.ten_thanhpham, t1.soluong, t2.giaban, t1.soluong * t2.giaban as thanhtien FROM T_CTHoadon t1 LEFT OUTER JOIN T_Thanhpham t2 ON t1.ma_thanhpham = t2.ma_thanhpham WHERE ma_hd = @ma_hd";
            SqlDataAdapter ada = new SqlDataAdapter(sql2, sqlCon);
            ada.SelectCommand.Parameters.Add("@ma_hd", SqlDbType.NChar).Value = ma_hd;
            DataTable dt = new DataTable();
            ada.Fill(dt);
            grdHoadon.DataSource = dt;
        }

        private void LoadTongThanhtien()
        {
            int tong = 0;
            foreach (DataGridViewRow row in grdHoadon.Rows)
            {
                tong = tong + Convert.ToInt32(row.Cells[5].Value);
            }
            txtThanhtien.Text = string.Format("{0:#,##0}", double.Parse(tong.ToString()));
        }

        private void dtThoidiemHD_ValueChanged(object sender, EventArgs e)
        {
            if (dtThoidiemHD.Value.Date > DateTime.Now.Date)
            {
                dtThoidiemHD.Value = DateTime.Now;
                MessageBox.Show("Thời điểm tạo hóa đơn không được lớn hơn ngày hiện tại."); 
            }
        }

        private void cbMahoadon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Home && e.KeyChar != (char)Keys.End && e.KeyChar != (char)Keys.Enter && e.KeyChar != (char)Keys.PageUp && e.KeyChar != (char)Keys.PageDown && e.KeyChar != (char)Keys.Up && e.KeyChar != (char)Keys.Down && e.KeyChar != (char)Keys.Left && e.KeyChar != (char)Keys.Right)
            {
                e.Handled = true;
            }
        }

        private void cbMahoadon_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                e.Handled = true;
            }
        }

        #endregion

        private void btnIn_Click(object sender, EventArgs e)
        {
            if (grdHoadon.Rows.Count > 0)
            {
                Save_Hoadon();
                Save_CTHoadon();
                ////////RefreshHD();
            }
            else
            {
                MessageBox.Show("Chưa chọn sản phẩm.");
                return;
            }

            rptBill rpt = new rptBill();
            rpt.so_hoadon = cbMahoadon.Text;
            rpt.soban = cbSoban.SelectedValue.ToString();
            rpt.ten_khuvuc = cbKhuvuc.Text;
            rpt.ten_nhanvien = cbNhanvien.Text;
            rpt.Show();

            RefreshHD();
        }

        private void txtDongia_Leave(object sender, EventArgs e)
        {
            txtDongia.Text = string.Format("{0:#,##0}", double.Parse(txtDongia.Text));
        }
        
        private void grdDsSanpham_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmDetailProduct frm = new frmDetailProduct();
            frm.ma_thanhpham = grdDsSanpham.CurrentRow.Cells[0].Value.ToString();
            frm.Show();
        }
    }
}