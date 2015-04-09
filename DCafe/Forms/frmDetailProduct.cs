using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DCafe.Forms
{
    public partial class frmDetailProduct : Form
    {
        public string ma_thanhpham = "";
        private SqlConnection sqlCon;

        public frmDetailProduct()
        {
            InitializeComponent();
            Conn conn = new Conn();
            sqlCon = conn.createConn();
        }

        private void Load_Sanpham()
        {
            string sql = "SELECT ma_thanhpham, giaban, donvi, thoidiem FROM T_Thanhpham WHERE ma_thanhpham = @ma_thanhpham";
            
            SqlCommand cmd = new SqlCommand(sql, sqlCon);
            sqlCon.Open();
            cmd.Parameters.AddWithValue("ma_thanhpham", ma_thanhpham);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txtMaSPCB.Text = dr[0].ToString();
                cbTenSPCB.SelectedValue = dr[0];
                txtGiabanSPCB.Text = dr[1].ToString();
                cbDonviSPCB.SelectedValue = dr[2];
                dtThoidiemSPCB.Value = Convert.ToDateTime(dr[3]);
            }
            dr.Close();
            sqlCon.Close();
        }

        private void LoadTextTong()
        {
            int tong = 0;
            foreach (DataGridViewRow row in grdNguyenlieuSPCB.Rows)
            {
                tong = tong + Convert.ToInt32(row.Cells["cDongiaCB"].Value);
            }
            txtTongDongia.Text = string.Format("{0:#,##0}", double.Parse(tong.ToString()));
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

        private void Load_DSNL()
        {
            string mk = "SELECT ma_thanhpham, T_Nguyenlieu.ma_nguyenlieu, RTRIM(ten_nguyenlieu) AS ten_nguyenlieu, soluong, soluong * T_Nguyenlieu.dongia as dongia, T_Nguyenlieu.dongia  as dongia_nl FROM T_Chebien, T_Nguyenlieu  WHERE T_Chebien.ma_nguyenlieu = T_Nguyenlieu.ma_nguyenlieu AND T_Chebien.ma_thanhpham = '" + ma_thanhpham + "'";
            SqlDataAdapter ada = new SqlDataAdapter(mk, sqlCon);
            sqlCon.Open();
            DataTable dt = new DataTable();
            ada.Fill(dt);
            grdNguyenlieuSPCB.DataSource = dt;
            sqlCon.Close();
        }

        private void frmDetailProduct_Load(object sender, EventArgs e)
        {
            Load_SanphamCB();
            Load_DonviSPCB();
            Load_Sanpham();
            Load_DSNL();
            LoadTextTong();
        }
    }
}
