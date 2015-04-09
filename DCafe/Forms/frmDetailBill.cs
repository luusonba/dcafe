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
    public partial class frmDetailBill : Form
    {
        public string ma_hd = "";
        private SqlConnection sqlCon;

        public frmDetailBill()
        {
            InitializeComponent();
            Conn conn = new Conn();
            sqlCon = conn.createConn();
        }

        private void Load_CTHoadon()
        {
            string sql2 = "SELECT t1.ma_hd, t1.ma_thanhpham, t2.ten_thanhpham, t1.soluong, t2.giaban, t1.soluong * t2.giaban as thanhtien FROM T_CTHoadon t1 LEFT OUTER JOIN T_Thanhpham t2 ON t1.ma_thanhpham = t2.ma_thanhpham WHERE ma_hd = @ma_hd";
            SqlDataAdapter ada = new SqlDataAdapter(sql2, sqlCon);
            ada.SelectCommand.Parameters.Add("@ma_hd", SqlDbType.NChar).Value = ma_hd;
            DataTable dt = new DataTable();
            ada.Fill(dt);
            grdHoadon.DataSource = dt;
        }

        private void Load_Hoadon()
        {
            string sql = "SELECT ma_hd, ma_nv, ma_kv, ma_ban, thoidiem FROM T_Hoadon WHERE ma_hd = @ma_hd";

            SqlCommand cmd = new SqlCommand(sql, sqlCon);
            sqlCon.Open();
            cmd.Parameters.AddWithValue("ma_hd", ma_hd);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                cbMahoadon.Text = dr[0].ToString();
                cbNhanvien.SelectedValue = dr[1];
                cbKhuvuc.SelectedValue = dr[2];
                cbSoban.SelectedValue = dr[3];
                dtThoidiemHD.Value = Convert.ToDateTime(dr[4]);
            }
            dr.Close();
            sqlCon.Close();
        }

        private void LoadTextTongThu()
        {
            int tong = 0;
            foreach (DataGridViewRow row in grdHoadon.Rows)
            {
                tong = tong + Convert.ToInt32(row.Cells["cThanhtien"].Value);
            }
            txtTongThu.Text = string.Format("{0:#,##0}", double.Parse(tong.ToString()));
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
        }

        private void frmDetailBill_Load(object sender, EventArgs e)
        {
            Load_KhuvucHD();
            Load_Soban();
            Load_Nhanvien();
            
            Load_CTHoadon();
            Load_Hoadon();
            LoadTextTongThu();
        }
    }
}
