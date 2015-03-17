using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TTTT
{
    public partial class Kinhdoanh : Form
    {
        public Kinhdoanh()
        {
            InitializeComponent();
        }
        string chuoi_ket_noi = "server=linhngu-pc;database=vd;uid=linh;pwd=linh";
       // load du lieu vao datagridview radi Tat ca
        int check;
        private void Kinhdoanh_Load(object sender, EventArgs e)
        {
            load_ten_hang1();
            load_loai_hang1();
            load_ten_ncc1();
            cmb_ten_hang.Enabled = false;
            cmb_loai_hang.Enabled = false;
            cmb_nha_cung_cap.Enabled = false;
            cmb_Thang1.Enabled = false;
            cmb_Quy1.Enabled = false;
            cmb_Nam1.Enabled = false;
            //radioButton_tatca1.Enabled = true;
            dateTimePicker1.Enabled = false;
            dateTimePicker2.Enabled = false;


            load_ten_hang2();
            load_loai_hang2();
            load_ten_ncc2();
            cmb_ten_hang2.Enabled = false;
            cmb_loai_hang2.Enabled = false;
            cmb_ncc2.Enabled = false;
            cmb_Thang2.Enabled = false;
            cmb_Quy2.Enabled = false;
            cmb_nam2.Enabled = false;
            //dateTimePicker_tu2.Enabled = false;
            //dateTimePicker_den2.Enabled = false;

            load_ten_hang3();
            load_loai_hang3();
            load_ten_ncc3();
            cmb_ten_hang3.Enabled = false;
            cmb_loai_hang3.Enabled = false;
            cmb_ncc3.Enabled = false;
            cmb_thang3.Enabled = false;
            cmb_quy3.Enabled = false;
            cmb_nam3.Enabled = false;
            //dateTimePicker_tu3.Enabled = false;
            //dateTimePicker_den3.Enabled = false;

            // 
            
        }
        // Load Vao datagridview Doanh Thu
        void load_data1()
        {
            // load Ten Hang Thang
            if (radioButton_Ten_hang2.Checked == true && radioButton_Thang2.Checked == true)
            {
                string chuoi1 = "select a.ma_hh, a.ten_hh,a.chung_loai,b.ten_ncc,a.dvt,f.ngay_xuat_hd, (e.sl_ban*e.dg_ban)as Thanhtien from hanghoa a, nha_cung_cap b, cung_cap_hh c, nhap d, ban e, HoaDon f where a.ma_hh=e.ma_hh and b.Ma_ncc=c.ma_ncc and c.stt_pn=d. stt_pn and d.ma_hh=a.ma_hh and f.STT_Hd=e.Stt_hd and MONTH(f.ngay_xuat_hd)=" + cmb_Thang2.Text + " and a.ten_hh='" + cmb_ten_hang2.Text + "' ";

                try
                {
                    SqlConnection conn = new SqlConnection(chuoi_ket_noi);
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter(chuoi1, conn);
                    DataTable dt = new DataTable();
                    //do du lieu vao datatable
                    da.Fill(dt);
                    dataGridView_doanh_thu.DataSource = dt;
                    dataGridView_doanh_thu.Columns[0].HeaderText = " Mã Hàng Hóa";
                    dataGridView_doanh_thu.Columns[1].HeaderText = " Tên Hàng Hóa";
                    dataGridView_doanh_thu.Columns[2].HeaderText = "Loại Hàng";
                    dataGridView_doanh_thu.Columns[3].HeaderText = "Tên Nhà Cung Cấp";
                    dataGridView_doanh_thu.Columns[4].HeaderText = "Đơn Vị Tính";
                    dataGridView_doanh_thu.Columns[5].HeaderText = " Ngày Xuất HD";
                    dataGridView_doanh_thu.Columns[6].HeaderText = "Thành Tiền";
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            // ten hang- Quy
            else if (radioButton_Ten_hang2.Checked == true && radioButton_quy2.Checked == true)
            {
                string chuoi1 = "select a.ma_hh, a.ten_hh,a.chung_loai,b.ten_ncc,a.dvt,f.ngay_xuat_hd, (e.sl_ban*e.dg_ban)as Thanhtien from hanghoa a, nha_cung_cap b, cung_cap_hh c, nhap d, ban e, HoaDon f where a.ma_hh=e.ma_hh and b.Ma_ncc=c.ma_ncc and c.stt_pn=d. stt_pn and d.ma_hh=a.ma_hh and f.STT_Hd=e.Stt_hd and MONTH(f.ngay_xuat_hd)=" + cmb_Quy2.Text + " and a.ten_hh='" + cmb_ten_hang2.Text + "' ";

                try
                {
                    SqlConnection conn = new SqlConnection(chuoi_ket_noi);
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter(chuoi1, conn);
                    DataTable dt = new DataTable();
                    //do du lieu vao datatable
                    da.Fill(dt);
                    dataGridView_doanh_thu.DataSource = dt;
                    dataGridView_doanh_thu.Columns[0].HeaderText = " Mã Hàng Hóa";
                    dataGridView_doanh_thu.Columns[1].HeaderText = " Tên Hàng Hóa";
                    dataGridView_doanh_thu.Columns[2].HeaderText = "Loại Hàng";
                    dataGridView_doanh_thu.Columns[3].HeaderText = "Tên Nhà Cung Cấp";
                    dataGridView_doanh_thu.Columns[4].HeaderText = "Đơn Vị Tính";
                    dataGridView_doanh_thu.Columns[5].HeaderText = " Ngày Xuất HD";
                    dataGridView_doanh_thu.Columns[6].HeaderText = "Thành Tiền";
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
                // ten Hnag- Nam
            else if (radioButton_Ten_hang2.Checked == true && radioButton_Nam2.Checked == true)
            {
                string chuoi1 = "select a.ma_hh, a.ten_hh,a.chung_loai,b.ten_ncc,a.dvt,f.ngay_xuat_hd, (e.sl_ban*e.dg_ban)as Thanhtien from hanghoa a, nha_cung_cap b, cung_cap_hh c, nhap d, ban e, HoaDon f where a.ma_hh=e.ma_hh and b.Ma_ncc=c.ma_ncc and c.stt_pn=d. stt_pn and d.ma_hh=a.ma_hh and f.STT_Hd=e.Stt_hd and year(f.ngay_xuat_hd)=" + cmb_nam2.Text + " and a.ten_hh='" + cmb_ten_hang2.Text + "' ";

                try
                {
                    SqlConnection conn = new SqlConnection(chuoi_ket_noi);
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter(chuoi1, conn);
                    DataTable dt = new DataTable();
                    //do du lieu vao datatable
                    da.Fill(dt);
                    dataGridView_doanh_thu.DataSource = dt;
                    dataGridView_doanh_thu.Columns[0].HeaderText = " Mã Hàng Hóa";
                    dataGridView_doanh_thu.Columns[1].HeaderText = " Tên Hàng Hóa";
                    dataGridView_doanh_thu.Columns[2].HeaderText = "Loại Hàng";
                    dataGridView_doanh_thu.Columns[3].HeaderText = "Tên Nhà Cung Cấp";
                    dataGridView_doanh_thu.Columns[4].HeaderText = "Đơn Vị Tính";
                    dataGridView_doanh_thu.Columns[5].HeaderText = " Ngày Xuất HD";
                    dataGridView_doanh_thu.Columns[6].HeaderText = "Thành Tiền";
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
           
            
        
            // Loai Hang- THang (Chung Loai)
            else if (radioButton_loai_Hang2.Checked == true && radioButton_Thang2.Checked == true)
            {
                string chuoi1 = "select a.ma_hh, a.ten_hh,a.chung_loai,b.ten_ncc,a.dvt,f.ngay_xuat_hd, (e.sl_ban*e.dg_ban)as Thanhtien from hanghoa a, nha_cung_cap b, cung_cap_hh c, nhap d, ban e, HoaDon f where a.ma_hh=e.ma_hh and b.Ma_ncc=c.ma_ncc and c.stt_pn=d. stt_pn and d.ma_hh=a.ma_hh and f.STT_Hd=e.Stt_hd and MONTH(f.ngay_xuat_hd)=" + cmb_Thang2.Text + " and a.Chung_Loai='" + cmb_loai_hang2.Text + "' ";

                try
                {
                    SqlConnection conn = new SqlConnection(chuoi_ket_noi);
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter(chuoi1, conn);
                    DataTable dt = new DataTable();
                    //do du lieu vao datatable
                    da.Fill(dt);
                    dataGridView_doanh_thu.DataSource = dt;
                    dataGridView_doanh_thu.Columns[0].HeaderText = " Mã Hàng Hóa";
                    dataGridView_doanh_thu.Columns[1].HeaderText = " Tên Hàng Hóa";
                    dataGridView_doanh_thu.Columns[2].HeaderText = "Loại Hàng";
                    dataGridView_doanh_thu.Columns[3].HeaderText = "Tên Nhà Cung Cấp";
                    dataGridView_doanh_thu.Columns[4].HeaderText = "Đơn Vị Tính";
                    dataGridView_doanh_thu.Columns[5].HeaderText = " Ngày Xuất HD";
                    dataGridView_doanh_thu.Columns[6].HeaderText = "Thành Tiền";
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            // Loai Hang - Quy
            else if (radioButton_loai_Hang2.Checked == true && radioButton_quy2.Checked == true)
            {
                string chuoi1 = "select a.ma_hh, a.ten_hh,a.chung_loai,b.ten_ncc,a.dvt,f.ngay_xuat_hd, (e.sl_ban*e.dg_ban)as Thanhtien from hanghoa a, nha_cung_cap b, cung_cap_hh c, nhap d, ban e, HoaDon f where a.ma_hh=e.ma_hh and b.Ma_ncc=c.ma_ncc and c.stt_pn=d. stt_pn and d.ma_hh=a.ma_hh and f.STT_Hd=e.Stt_hd and MONTH(f.ngay_xuat_hd)=" + cmb_Thang2.Text + " and a.Chung_Loai='" + cmb_loai_hang2.Text + "' ";

                try
                {
                    SqlConnection conn = new SqlConnection(chuoi_ket_noi);
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter(chuoi1, conn);
                    DataTable dt = new DataTable();
                    //do du lieu vao datatable
                    da.Fill(dt);
                    dataGridView_doanh_thu.DataSource = dt;
                    dataGridView_doanh_thu.Columns[0].HeaderText = " Mã Hàng Hóa";
                    dataGridView_doanh_thu.Columns[1].HeaderText = " Tên Hàng Hóa";
                    dataGridView_doanh_thu.Columns[2].HeaderText = "Loại Hàng";
                    dataGridView_doanh_thu.Columns[3].HeaderText = "Tên Nhà Cung Cấp";
                    dataGridView_doanh_thu.Columns[4].HeaderText = "Đơn Vị Tính";
                    dataGridView_doanh_thu.Columns[5].HeaderText = " Ngày Xuất HD";
                    dataGridView_doanh_thu.Columns[6].HeaderText = "Thành Tiền";
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        // Loai Hang - Nam
            else if (radioButton_loai_Hang2.Checked == true && radioButton_Nam2.Checked == true)
            {
                string chuoi1 = "select a.ma_hh, a.ten_hh,a.chung_loai,b.ten_ncc,a.dvt,f.ngay_xuat_hd, (e.sl_ban*e.dg_ban)as Thanhtien from hanghoa a, nha_cung_cap b, cung_cap_hh c, nhap d, ban e, HoaDon f where a.ma_hh=e.ma_hh and b.Ma_ncc=c.ma_ncc and c.stt_pn=d. stt_pn and d.ma_hh=a.ma_hh and f.STT_Hd=e.Stt_hd and Year(f.ngay_xuat_hd)=" + cmb_nam2.Text + " and a.Chung_Loai='" + cmb_loai_hang2.Text + "' ";

                try
                {
                    SqlConnection conn = new SqlConnection(chuoi_ket_noi);
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter(chuoi1, conn);
                    DataTable dt = new DataTable();
                    //do du lieu vao datatable
                    da.Fill(dt);
                    dataGridView_doanh_thu.DataSource = dt;
                    dataGridView_doanh_thu.Columns[0].HeaderText = " Mã Hàng Hóa";
                    dataGridView_doanh_thu.Columns[1].HeaderText = " Tên Hàng Hóa";
                    dataGridView_doanh_thu.Columns[2].HeaderText = "Loại Hàng";
                    dataGridView_doanh_thu.Columns[3].HeaderText = "Tên Nhà Cung Cấp";
                    dataGridView_doanh_thu.Columns[4].HeaderText = "Đơn Vị Tính";
                    dataGridView_doanh_thu.Columns[5].HeaderText = " Ngày Xuất HD";
                    dataGridView_doanh_thu.Columns[6].HeaderText = "Thành Tiền";
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        
            
        // Nha cung cap - Thang
            else if (radioButton_Nha_cung_cap2.Checked == true && radioButton_Thang2.Checked == true)
            {
                string chuoi1 = "select a.ma_hh, a.ten_hh,a.chung_loai,b.ten_ncc,a.dvt,f.ngay_xuat_hd, (e.sl_ban*e.dg_ban)as Thanhtien from hanghoa a, nha_cung_cap b, cung_cap_hh c, nhap d, ban e, HoaDon f where a.ma_hh=e.ma_hh and b.Ma_ncc=c.ma_ncc and c.stt_pn=d. stt_pn and d.ma_hh=a.ma_hh and f.STT_Hd=e.Stt_hd and MONTH(f.ngay_xuat_hd)=" + cmb_Thang2.Text + " and b.ten_ncc='" + cmb_ncc2.Text + "' ";

                try
                {
                    SqlConnection conn = new SqlConnection(chuoi_ket_noi);
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter(chuoi1, conn);
                    DataTable dt = new DataTable();
                    //do du lieu vao datatable
                    da.Fill(dt);
                    dataGridView_doanh_thu.DataSource = dt;
                    dataGridView_doanh_thu.Columns[0].HeaderText = " Mã Hàng Hóa";
                    dataGridView_doanh_thu.Columns[1].HeaderText = " Tên Hàng Hóa";
                    dataGridView_doanh_thu.Columns[2].HeaderText = "Loại Hàng";
                    dataGridView_doanh_thu.Columns[3].HeaderText = "Tên Nhà Cung Cấp";
                    dataGridView_doanh_thu.Columns[4].HeaderText = "Đơn Vị Tính";
                    dataGridView_doanh_thu.Columns[5].HeaderText = " Ngày Xuất HD";
                    dataGridView_doanh_thu.Columns[6].HeaderText = "Thành Tiền";
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            // Nha cung cap - Quy 
            else if (radioButton_loai_Hang2.Checked == true && radioButton_quy2.Checked == true)
            {
                string chuoi1 = "select a.ma_hh, a.ten_hh,a.chung_loai,b.ten_ncc,a.dvt,f.ngay_xuat_hd, (e.sl_ban*e.dg_ban)as Thanhtien from hanghoa a, nha_cung_cap b, cung_cap_hh c, nhap d, ban e, HoaDon f where a.ma_hh=e.ma_hh and b.Ma_ncc=c.ma_ncc and c.stt_pn=d. stt_pn and d.ma_hh=a.ma_hh and f.STT_Hd=e.Stt_hd and MONTH(f.ngay_xuat_hd)=" + cmb_Thang2.Text + " and b.Ten_ncc='" + cmb_ncc2.Text + "' ";

                try
                {
                    SqlConnection conn = new SqlConnection(chuoi_ket_noi);
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter(chuoi1, conn);
                    DataTable dt = new DataTable();
                    //do du lieu vao datatable
                    da.Fill(dt);
                    dataGridView_doanh_thu.DataSource = dt;
                    dataGridView_doanh_thu.Columns[0].HeaderText = " Mã Hàng Hóa";
                    dataGridView_doanh_thu.Columns[1].HeaderText = " Tên Hàng Hóa";
                    dataGridView_doanh_thu.Columns[2].HeaderText = "Loại Hàng";
                    dataGridView_doanh_thu.Columns[3].HeaderText = "Tên Nhà Cung Cấp";
                    dataGridView_doanh_thu.Columns[4].HeaderText = "Đơn Vị Tính";
                    dataGridView_doanh_thu.Columns[5].HeaderText = " Ngày Xuất HD";
                    dataGridView_doanh_thu.Columns[6].HeaderText = "Thành Tiền";
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            //NHa cung cap - Nam
            else if (radioButton_Nha_cung_cap2.Checked == true && radioButton_Thang2.Checked == true)
            {
                string chuoi1 = "select a.ma_hh, a.ten_hh,a.chung_loai,b.ten_ncc,a.dvt,f.ngay_xuat_hd, (e.sl_ban*e.dg_ban)as Thanhtien from hanghoa a, nha_cung_cap b, cung_cap_hh c, nhap d, ban e, HoaDon f where a.ma_hh=e.ma_hh and b.Ma_ncc=c.ma_ncc and c.stt_pn=d. stt_pn and d.ma_hh=a.ma_hh and f.STT_Hd=e.Stt_hd and year(f.ngay_xuat_hd)=" + cmb_nam2.Text + " and b.ten_ncc='" + cmb_ncc2.Text + "' ";

                try
                {
                    SqlConnection conn = new SqlConnection(chuoi_ket_noi);
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter(chuoi1, conn);
                    DataTable dt = new DataTable();
                    //do du lieu vao datatable
                    da.Fill(dt);
                    dataGridView_doanh_thu.DataSource = dt;
                    dataGridView_doanh_thu.Columns[0].HeaderText = " Mã Hàng Hóa";
                    dataGridView_doanh_thu.Columns[1].HeaderText = " Tên Hàng Hóa";
                    dataGridView_doanh_thu.Columns[2].HeaderText = "Loại Hàng";
                    dataGridView_doanh_thu.Columns[3].HeaderText = "Tên Nhà Cung Cấp";
                    dataGridView_doanh_thu.Columns[4].HeaderText = "Đơn Vị Tính";
                    dataGridView_doanh_thu.Columns[5].HeaderText = " Ngày Xuất HD";
                    dataGridView_doanh_thu.Columns[5].HeaderText = "Thành Tiền";
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
                
            
        }
        // void Load du tieu datagridview  Loi Nhuan
        void load_data_LoiNhuan(){
            string chuoi_loi_nhuan = "select a.ma_hh, a.ten_hh,a.chung_loai,b.ten_ncc,a.dvt,f.ngay_xuat_hd, (e.sl_ban*e.dg_ban-d.sl_nhap*dg_nhap)as Loinhuan from hanghoa a, nha_cung_cap b, cung_cap_hh c, nhap d, ban e, HoaDon f where a.ma_hh=e.ma_hh and b.Ma_ncc=c.ma_ncc and c.stt_pn=d. stt_pn and d.ma_hh=a.ma_hh and f.STT_Hd=e.Stt_hd";
            if (radioButtonTen_Hang3.Checked == true && radioButton_thang3.Checked == true)
            {
                string chuoi_loi_nhuan1 = chuoi_loi_nhuan + " and MONTH(f.ngay_xuat_hd)=" + cmb_thang3.Text + " and a.ten_hh='" + cmb_ten_hang3.Text + "'";

                try
                {
                    conn con = new conn();
                    SqlConnection conn = con.con();
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter(chuoi_loi_nhuan1, conn);
                    DataTable dt = new DataTable();
                    //do du lieu vao datatable
                    da.Fill(dt);
                    dataGridView_doanh_thu.DataSource = dt;
                    dataGridView_doanh_thu.Columns[0].HeaderText = " Mã Hàng Hóa";
                    dataGridView_doanh_thu.Columns[1].HeaderText = " Tên Hàng Hóa";
                    dataGridView_doanh_thu.Columns[2].HeaderText = "Loại Hàng";
                    dataGridView_doanh_thu.Columns[3].HeaderText = "Tên Nhà Cung Cấp";
                    dataGridView_doanh_thu.Columns[4].HeaderText = "Đơn Vị Tính";
                    dataGridView_doanh_thu.Columns[5].HeaderText = " Ngày Xuất HD";
                    dataGridView_doanh_thu.Columns[6].HeaderText = "Loi Nhuan";
                    Tong_loi_nhuan.Text = chuoi_loi_nhuan1;
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }
    
        #region "Tab_Tong Chi"

        // load combox Ten_hang tong chi
        void load_ten_hang1()
        {
            string ten_hang = "select distinct rtrim(ten_hh) from HANGHOA";
            cmb_ten_hang.Items.Clear();
            try
            {
                SqlConnection conn = new SqlConnection(chuoi_ket_noi);
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(ten_hang, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cmb_ten_hang.Items.Add(dt.Rows[i][0].ToString());
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        // load combox Loai Hang Tong chi
        void load_loai_hang1()
        {
            string loai_hang = "select distinct rtrim(chung_loai) from HANGHOA";
            cmb_loai_hang.Items.Clear();
            try
            {
                SqlConnection conn = new SqlConnection(chuoi_ket_noi);
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(loai_hang, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cmb_loai_hang.Items.Add(dt.Rows[i][0].ToString());
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        // load combox Ten_nha_cung_cap tong chi
        void load_ten_ncc1()
        {
            string ten_ncc = "select distinct rtrim(ten_ncc) from nha_cung_cap";
            cmb_nha_cung_cap.Items.Clear();
            try
            {
                SqlConnection conn = new SqlConnection(chuoi_ket_noi);
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(ten_ncc, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cmb_nha_cung_cap.Items.Add(dt.Rows[i][0].ToString());
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        

        private void rbtn_thang_CheckedChanged(object sender, EventArgs e)
        {
            cmb_ten_hang.Enabled = true;
            cmb_loai_hang.Enabled = false;
            cmb_nha_cung_cap.Enabled = false;
            cmb_loai_hang.Text = "";
            cmb_nha_cung_cap.Text = "";
            
        }

        private void rbtn_lhang_CheckedChanged(object sender, EventArgs e)
        {
            cmb_loai_hang.Enabled = true;
            cmb_nha_cung_cap.Enabled = false;
            cmb_ten_hang.Enabled = false;
            cmb_ten_hang.Text = "";
            cmb_nha_cung_cap.Text = "";
        }

        private void rbtn_ncc_CheckedChanged(object sender, EventArgs e)
        {
            cmb_nha_cung_cap.Enabled = true;
            cmb_ten_hang.Enabled = false;
            cmb_loai_hang.Enabled = false;
            cmb_ten_hang.Text = "";
            cmb_loai_hang.Text = "";
        }

        private void radioButton_tatca1_CheckedChanged(object sender, EventArgs e)
        {
            cmb_Thang1.Enabled = false;
            cmb_Quy1.Enabled = false;
            cmb_Nam1.Enabled = false;
            //radioButton_tatca1.Enabled = true;
            dateTimePicker1.Enabled = false;
            dateTimePicker2.Enabled = false;
        }

        private void radioButton_thang1_CheckedChanged(object sender, EventArgs e)
        {
            cmb_Thang1.Enabled = true;
            cmb_Quy1.Enabled = false;
            cmb_Nam1.Enabled = false;
            cmb_Quy1.Text = "";
            cmb_Nam1.Text = "";
            dateTimePicker1.Enabled = false;
            dateTimePicker2.Enabled = false;
        }

        private void radioButton_quy1_CheckedChanged(object sender, EventArgs e)
        {
            cmb_Thang1.Enabled = false;
            cmb_Quy1.Enabled = true;
            cmb_Nam1.Enabled = false;
            cmb_Thang1.Text = "";
            cmb_Nam1.Text = "";
            dateTimePicker1.Enabled = false;
            dateTimePicker2.Enabled = false;
        }

        private void radioButton_nam1_CheckedChanged(object sender, EventArgs e)
        {
            cmb_Thang1.Enabled = false;
            cmb_Quy1.Enabled = false;
            cmb_Nam1.Enabled = true;
            cmb_Thang1.Text = "";
            cmb_Quy1.Text="";
            dateTimePicker1.Enabled = false;
            dateTimePicker2.Enabled = false;
        }

        private void radioButton_tu_ngay1_CheckedChanged(object sender, EventArgs e)
        {
            cmb_Thang1.Enabled = false;
            cmb_Quy1.Enabled = false;
            cmb_Nam1.Enabled = false;
            //radioButton_tatca1.Enabled = false;
            dateTimePicker1.Enabled = true;
            dateTimePicker2.Enabled = true;
        }
        #endregion



        // Tab Doanh THu
        #region " Tab Doanh Thu"
        // load combox Ten_hang Doanh Thu
        void load_ten_hang2()
        {
            string ten_hang = "select distinct rtrim(ten_hh) from HANGHOA";
            cmb_ten_hang2.Items.Clear();
            try
            {
                SqlConnection conn = new SqlConnection(chuoi_ket_noi);
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(ten_hang, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cmb_ten_hang2.Items.Add(dt.Rows[i][0].ToString());
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        // load combox Loai Hang Daonh Thu
        void load_loai_hang2()
        {
            string loai_hang = "select distinct rtrim(chung_loai) from HANGHOA";
            cmb_loai_hang2.Items.Clear();
            try
            {
                SqlConnection conn = new SqlConnection(chuoi_ket_noi);
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(loai_hang, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cmb_loai_hang2.Items.Add(dt.Rows[i][0].ToString());
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        // load combox Ten_nha_cung_cap Doanh Thu
        void load_ten_ncc2()
        {
            string ten_ncc = "select distinct rtrim(ten_ncc) from nha_cung_cap";
            cmb_ncc2.Items.Clear();
            try
            {
                SqlConnection conn = new SqlConnection(chuoi_ket_noi);
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(ten_ncc, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cmb_ncc2.Items.Add(dt.Rows[i][0].ToString());
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }




        

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            cmb_ten_hang2.Enabled = true;
            cmb_loai_hang2.Enabled = false;
            cmb_ncc2.Enabled = false;
            cmb_loai_hang2.Text = "";
            cmb_ncc2.Text = "";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            cmb_ten_hang2.Enabled = false;
            cmb_loai_hang2.Enabled = true;
            cmb_ncc2.Enabled = false;
            cmb_ten_hang2.Text = "";
            cmb_ncc2.Text = "";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            cmb_ten_hang2.Enabled = false;
            cmb_loai_hang2.Enabled = false;
            cmb_ncc2.Enabled = true;
            cmb_ten_hang2.Text = "";
            cmb_ncc2.Text = "";
        }

        private void radioButton_tat_ca_CheckedChanged(object sender, EventArgs e)
        {
            cmb_Thang2.Enabled = false;
            cmb_Quy2.Enabled = false;
            cmb_nam2.Enabled = false;
            cmb_ten_hang2.Enabled = false;
            cmb_ten_hang2.Text = "";
           
            //dateTimePicker_tu2.Enabled = false;
            //dateTimePicker_den2.Enabled = false;
        }

        private void radioButton_Thang_CheckedChanged(object sender, EventArgs e)
        {
            cmb_Thang2.Enabled = true;
            cmb_Quy2.Enabled = false;
            cmb_nam2.Enabled = false;
            //dateTimePicker_tu2.Enabled = false;
            //dateTimePicker_den2.Enabled = false;
        }

        private void radioButton_quy_CheckedChanged(object sender, EventArgs e)
        {
            cmb_Thang2.Enabled = false;
            cmb_Quy2.Enabled = true;
            cmb_nam2.Enabled = false;
            //dateTimePicker_tu2.Enabled = false;
            //dateTimePicker_den2.Enabled = false;
        }

        private void radioButton_Nam_CheckedChanged(object sender, EventArgs e)
        {
            cmb_Thang2.Enabled = false;
            cmb_Quy2.Enabled = false;
            cmb_nam2.Enabled = true;
            //dateTimePicker_tu2.Enabled = false;
            //dateTimePicker_den2.Enabled = false;
        }

        private void radioButton_Tu_ngay_CheckedChanged(object sender, EventArgs e)
        {
            cmb_Thang2.Enabled = false;
            cmb_Quy2.Enabled = false;
            cmb_nam2.Enabled = false;
            //dateTimePicker_tu2.Enabled = true;
            //dateTimePicker_den2.Enabled = true;
        }
        #endregion




        // Tab loi nhuan
        // load combox Ten_hang Loi nhuan
        void load_ten_hang3()
        {
            string ten_hang = "select distinct ten_hh from HANGHOA";
            cmb_ten_hang3.Items.Clear();
            try
            {
                SqlConnection conn = new SqlConnection(chuoi_ket_noi);
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(ten_hang, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cmb_ten_hang3.Items.Add(dt.Rows[i][0].ToString());
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // load combox Loai Hang Loi Nhuan
        void load_loai_hang3()
        {
            string loai_hang = "select distinct chung_loai from HANGHOA";
            cmb_loai_hang3.Items.Clear();
            try
            {
                SqlConnection conn = new SqlConnection(chuoi_ket_noi);
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(loai_hang, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cmb_loai_hang3.Items.Add(dt.Rows[i][0].ToString());
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        // load combox Ten_nha_cung_cap Loi Nhuan
        void load_ten_ncc3()
        {
            string ten_ncc = "select distinct ten_ncc from nha_cung_cap";
            cmb_ncc3.Items.Clear();
            try
            {
                SqlConnection conn = new SqlConnection(chuoi_ket_noi);
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(ten_ncc, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cmb_ncc3.Items.Add(dt.Rows[i][0].ToString());
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            cmb_ten_hang3.Enabled =true;
            cmb_loai_hang3.Enabled = false;
            cmb_ncc3.Enabled = false;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            cmb_ten_hang3.Enabled = false;
            cmb_loai_hang3.Enabled = true;
            cmb_ncc3.Enabled = false;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            cmb_ten_hang3.Enabled = false;
            cmb_loai_hang3.Enabled = false;
            cmb_ncc3.Enabled = true;
        }

        private void radioButton19_CheckedChanged(object sender, EventArgs e)
        {
            cmb_thang3.Enabled = false;
            cmb_quy3.Enabled = false;
            cmb_nam3.Enabled = false;
            //dateTimePicker_tu3.Enabled = false;
            //dateTimePicker_den3.Enabled = false;

        }

        private void radioButton15_CheckedChanged(object sender, EventArgs e)
        {
            cmb_thang3.Enabled = true;
            cmb_quy3.Enabled = false;
            cmb_nam3.Enabled = false;
            //dateTimePicker_tu3.Enabled = false;
            //dateTimePicker_den3.Enabled = false;
        }

        private void radioButton18_CheckedChanged(object sender, EventArgs e)
        {
            cmb_thang3.Enabled = false;
            cmb_quy3.Enabled = true;
            cmb_nam3.Enabled = false;
            //dateTimePicker_tu3.Enabled = false;
            //dateTimePicker_den3.Enabled = false;
        }

        private void radioButton17_CheckedChanged(object sender, EventArgs e)
        {
            cmb_thang3.Enabled = false;
            cmb_quy3.Enabled = false;
            cmb_nam3.Enabled =true;
            //dateTimePicker_tu3.Enabled = false;
            //dateTimePicker_den3.Enabled = false;
        }

        private void radioButton16_CheckedChanged(object sender, EventArgs e)
        {
            cmb_thang3.Enabled = false;
            cmb_quy3.Enabled = false;
            cmb_nam3.Enabled = false;
            //dateTimePicker_tu3.Enabled =true;
            //dateTimePicker_den3.Enabled = true;
        }

        private void btn_TK_DThu_Click(object sender, EventArgs e)
        {
            KiemTra2();
            string str = "select BAN.STT_HD,sum(convert(int,DG_BAN*SL_BAN*(100+thue)/100))as thanhtien,rtrim(convert(char,NGAY_XUAT_HD,3)),NHANVIEN.MANV,HOTEN  from HANGHOA,NHANVIEN,HOADON,BAN where HANGHOA.MA_HH=ban.MA_HH and ban.STT_HD=HOADON.STT_HD and HOADON.MANV=NHANVIEN.MANV";
            if (radioButton_Ten_hang2.Checked) str = str + " and ten_hh='" + cmb_ten_hang2.Text + "'";
            if (radioButton_loai_Hang2.Checked) str = str + " and chung_loai='" + cmb_loai_hang2.Text + "'";
            if (radioButton_Nha_cung_cap2.Checked) str += " and ten_ncc='" + cmb_ncc2.Text + "'";
            if (radioButton_Thang2.Checked) str += " and month(ngay_xuat_hd)=" + cmb_Thang2.Text + " and year(ngay_xuat_hd)=year(getdate())";
            if (radioButton_quy2.Checked)
            {
                switch (cmb_Quy2.Text)
                {
                    case "I": str += " and month(ngay_xuat_hd)>=1  and month(ngay_xuat_hd)<=3 and year(ngay_xuat_hd)=year(getdate())"; break;
                    case "II": str += " and month(ngay_xuat_hd)>=4  and month(ngay_xuat_hd)<=6 and year(ngay_xuat_hd)=year(getdate())"; break;
                    case "III": str += " and month(ngay_xuat_hd)>=7  and month(ngay_xuat_hd)<=9 and year(ngay_xuat_hd)=year(getdate())"; break;
                    case "IV": str += " and month(ngay_xuat_hd)>=10  and month(ngay_xuat_hd)<=12 and year(ngay_xuat_hd)=year(getdate())"; break;
                }
            }
            if (radioButton_Nam2.Checked) str += " and year(ngay_xuat_hd)=" + cmb_nam2.Text;
            
            str += " group by ban.STT_HD ,NGAY_XUAT_HD,NHANVIEN.MANV,HOTEN";
            //vd0.Text=str;
            try
            {
                conn con = new conn();
                SqlConnection con1 = con.con();
                con1.Open();
                //string str1 = "drop table #a";


                SqlDataAdapter da = new SqlDataAdapter(str, con1);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView_doanh_thu.DataSource = dt;
                dataGridView_doanh_thu.Columns[0].HeaderText = "Mã hóa đơn";
                dataGridView_doanh_thu.Columns[1].HeaderText = "Thành tiền";
                dataGridView_doanh_thu.Columns[2].HeaderText = "Ngày xuất";
                dataGridView_doanh_thu.Columns[3].HeaderText = "Mã NV xuất";
                dataGridView_doanh_thu.Columns[4].HeaderText = "Tên NV xuất";
                dataGridView_doanh_thu.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                con1.Close();
                a = 0;
                for (b = 0; b < dt.Rows.Count; b++)
                {
                    a += Convert.ToInt32(dt.Rows[b][1].ToString());
                }
                tongthu.Text = Convert.ToString(a);
            }
            catch { }
        }

        

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case (Keys.Enter):
                    if(check==1) btn_Tke1_Click(null, null);
                    if (check == 2) btn_TK_DThu_Click(null, null);
                    break;

                case (Keys.Escape):
                    btn_Thoat_Click(null, null);
                    break;
            }
            //vd0.Text = Convert.ToString(tab_lnhuan.DrawMode.ToString());
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        
        

        private void tabPage2_Layout(object sender, LayoutEventArgs e)
        {
            conn con = new conn();
            SqlConnection con1 = con.con();
            con1.Open();
            //string str1 = "drop table #a";
            string str = "select distinct HANGHOA.MA_HH,TEN_HH,DVT,SL_TK,convert(date,HAN_SD,103),TEN_NCC  from HANGHOA,NHAP,CUNG_CAP_HH,NHA_CUNG_CAP where HANGHOA.MA_HH=NHAP.MA_HH and NHAP.STT_PN=CUNG_CAP_HH.STT_PN and CUNG_CAP_HH.MA_NCC=NHA_CUNG_CAP.MA_NCC";

            SqlDataAdapter da = new SqlDataAdapter(str, con1);
            DataTable dt = new DataTable();
            da.Fill(dt);
            data.DataSource = dt;
            data.Columns[0].HeaderText = "Mã hàng";
            data.Columns[1].HeaderText = "Tên hàng";
            data.Columns[2].HeaderText = "Đơn vị tính";
            data.Columns[3].HeaderText = "Số lượng";
            data.Columns[4].HeaderText = "Hạn SD";
            data.Columns[5].HeaderText = "Tên NCC";
            data.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            con1.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private int b; int a;
        private void btn_Tke1_Click(object sender, EventArgs e)
        {
            KiemTra1();
            string str = "select NHAP.STT_PN,HANGHOA.MA_HH,rtrim(TEN_HH),SL_NHAP,DG_NHAP,THUE,convert(int,DG_NHAP*SL_NHAP*(100+thue)/100)as thanhtien,rtrim(TEN_NCC),rtrim(convert(char,NGAY_NHAP,3)) from HANGHOA,NHAP,CUNG_CAP_HH,NHA_CUNG_CAP,PHIEUNHAP where HANGHOA.MA_HH=NHAP.MA_HH and NHAP.STT_PN=CUNG_CAP_HH.STT_PN and CUNG_CAP_HH.MA_NCC=NHA_CUNG_CAP.MA_NCC and NHAP.STT_PN=PHIEUNHAP.STT_PN";
            if (rbtn_ten_hang.Checked) str = str + " and ten_hh='" + cmb_ten_hang.Text + "'";
            if (rbtn_lhang.Checked) str = str + " and chung_loai='"+cmb_loai_hang.Text+"'";
            if (rbtn_ncc.Checked) str += " and ten_ncc='" + cmb_nha_cung_cap.Text + "'";
            if (radioButton_thang1.Checked) str += " and month(ngay_nhap)=" + cmb_Thang1.Text + " and year(ngay_nhap)=year(getdate())";
            if (radioButton_quy1.Checked) {
                switch (cmb_Quy1.Text) {
                    case "I": str += " and month(ngay_nhap)>=1  and month(ngay_nhap)<=3 and year(ngay_nhap)=year(getdate())"; break;
                    case "II": str += " and month(ngay_nhap)>=4  and month(ngay_nhap)<=6 and year(ngay_nhap)=year(getdate())"; break;
                    case "III": str += " and month(ngay_nhap)>=7  and month(ngay_nhap)<=9 and year(ngay_nhap)=year(getdate())"; break;
                    case "IV": str += " and month(ngay_nhap)>=10  and month(ngay_nhap)<=12 and year(ngay_nhap)=year(getdate())"; break;
                }
            }
            if (radioButton_nam1.Checked) str += " and year(ngay_nhap)="+cmb_Nam1.Text;
            if (radioButton_tu_ngay1.Checked) str += " and ngay_nhap>=" + dateTimePicker1.Text + " and ngay_nhap<=" + dateTimePicker2.Text;
            
            try
            {
                conn con = new conn();
                SqlConnection con1 = con.con();
                con1.Open();
                //string str1 = "drop table #a";
                

                SqlDataAdapter da = new SqlDataAdapter(str, con1);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.Columns[0].HeaderText = "Mã hóa đơn";
                dataGridView1.Columns[1].HeaderText = "Mã hàng";
                dataGridView1.Columns[2].HeaderText = "Tên hàng";
                dataGridView1.Columns[3].HeaderText = "Số lượng";
                dataGridView1.Columns[4].HeaderText = "Đơn giá";
                dataGridView1.Columns[5].HeaderText = "Thuế";
                dataGridView1.Columns[6].HeaderText = "Thành tiền";
                dataGridView1.Columns[7].HeaderText = "Nhà cung cấp";
                dataGridView1.Columns[8].HeaderText = "Ngày nhập";
                dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                con1.Close();
                
                for (b = 0; b < dt.Rows.Count; b++) {
                    a += Convert.ToInt32(dt.Rows[b][6].ToString());
                }
                tong.Text =Convert.ToString(a);
            }
            catch { }
        }

        private void btn_thoat1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tab_chiphi_Layout(object sender, LayoutEventArgs e)
        {
            check = 1;
        }

        private void tab_dthu_Layout(object sender, LayoutEventArgs e)
        {
            check = 2;
        }

        private void tabPage1_Layout(object sender, LayoutEventArgs e)
        {
            check = 3;
        }

        private void btn_Thong_Ke3_loi_nhuan_Click(object sender, EventArgs e)
        {
            KiemTra3();
            string str = "select BAN.STT_HD,sum(convert(int,DG_BAN*SL_BAN*(100+thue)/100)-(SL_NHAP*DG_NHAP))as LOINHUAN,rtrim(convert(char,NGAY_XUAT_HD,3)),NHANVIEN.MANV,HOTEN  from HANGHOA,NHANVIEN,HOADON,BAN,NHAP where HANGHOA.MA_HH=ban.MA_HH and ban.STT_HD=HOADON.STT_HD and HOADON.MANV=NHANVIEN.MANV and NHAP.MA_HH=HANGHOA.MA_HH";
            if (radioButtonTen_Hang3.Checked) str = str + " and ten_hh='" + cmb_ten_hang3.Text + "'";
            if (radioButtonLoai_hang3.Checked) str = str + " and chung_loai='" + cmb_loai_hang3.Text + "'";
            if (radioButtonNha_cung_cap3.Checked) str += " and ten_ncc='" + cmb_ncc3.Text + "'";
            if (radioButton_thang3.Checked) str += " and month(ngay_xuat_hd)=" + cmb_thang3.Text + " and year(ngay_xuat_hd)=year(getdate())";
            if (radioButtonQuy3.Checked)
            {
                switch (cmb_quy3.Text)
                {
                    case "I": str += " and month(ngay_xuat_hd)>=1  and month(ngay_xuat_hd)<=3 and year(ngay_xuat_hd)=year(getdate())"; break;
                    case "II": str += " and month(ngay_xuat_hd)>=4  and month(ngay_xuat_hd)<=6 and year(ngay_xuat_hd)=year(getdate())"; break;
                    case "III": str += " and month(ngay_xuat_hd)>=7  and month(ngay_xuat_hd)<=9 and year(ngay_xuat_hd)=year(getdate())"; break;
                    case "IV": str += " and month(ngay_xuat_hd)>=10  and month(ngay_xuat_hd)<=12 and year(ngay_xuat_hd)=year(getdate())"; break;
                }
            }
            if (radioButtonNam3.Checked) str += " and year(ngay_xuat_hd)=" + cmb_nam2.Text;

            str += " group by ban.STT_HD ,NGAY_XUAT_HD,NHANVIEN.MANV,HOTEN";
            //vd0.Text=str;
            try
            {
                conn con = new conn();
                SqlConnection con1 = con.con();
                con1.Open();
                //string str1 = "drop table #a";


                SqlDataAdapter da = new SqlDataAdapter(str, con1);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewLoi_Nhuan.DataSource = dt;
                dataGridViewLoi_Nhuan.Columns[0].HeaderText = "Mã hóa đơn";
                dataGridViewLoi_Nhuan.Columns[1].HeaderText = "Lợi nhuận";
                dataGridViewLoi_Nhuan.Columns[2].HeaderText = "Ngày xuất";
                dataGridViewLoi_Nhuan.Columns[3].HeaderText = "Mã NV xuất";
                dataGridViewLoi_Nhuan.Columns[4].HeaderText = "Tên NV xuất";
                dataGridViewLoi_Nhuan.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                con1.Close();
                a = 0;
                for (b = 0; b < dt.Rows.Count; b++)
                {
                    a += Convert.ToInt32(dt.Rows[b][1].ToString());
                }
                tongthu.Text = Convert.ToString(a);
            }
            catch { }
        }

        private void btnThoat3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void KiemTra1()
        {
            if ((rbtn_ten_hang.Checked) && (cmb_ten_hang.Text == ""))
                MessageBox.Show("Bạn chưa chọn TÊN HÀNG");
            else if ((rbtn_lhang.Checked) && (cmb_loai_hang.Text == "")) MessageBox.Show("Bạn chưa chọn TÊN LOẠI HÀNG");
            else if ((rbtn_ncc.Checked) && (cmb_nha_cung_cap.Text == "")) MessageBox.Show("Bạn chưa chọn TÊN NHÀ CUNG CẤP");
            else if ((radioButton_thang1.Checked) && (cmb_Thang1.Text == "")) MessageBox.Show("Bạn chưa chọn THÁNG");
            else if ((radioButton_quy1.Checked) && (cmb_Quy1.Text == "")) MessageBox.Show("Bạn chưa chọn TÊN QUÝ");
            else if ((radioButton_nam1.Checked) && (cmb_Nam1.Text == "")) MessageBox.Show("Bạn chưa chọn TÊN NĂM");
            else if ((radioButton_tu_ngay1.Checked) && (dateTimePicker1.Text == ""))
                MessageBox.Show("Ban chua chon ngay bat dau");
            else if ((radioButton_tu_ngay1.Checked) && (dateTimePicker2.Text == ""))
                MessageBox.Show("Ban chua chon ngay den");
        }
        void KiemTra2()
        {
            if((radioButton_Ten_hang2.Checked)&&(cmb_ten_hang2.Text=="")) MessageBox.Show("Bạn chưa chọn TÊN HÀNG");
            if((radioButton_loai_Hang2.Checked)&&(cmb_loai_hang2.Text=="") )MessageBox.Show("Bạn chưa chọn TÊN LOẠI HÀNG");
            if((radioButton_Nha_cung_cap2.Checked)&&(cmb_ncc2.Text=="")) MessageBox.Show("Bạn chưa chọn TÊN NHÀ CUNG CẤP");
            if((radioButton_Thang2.Checked)&&(cmb_Thang2.Text=="")) MessageBox.Show("Bạn chưa chọn THÁNG");
            if((radioButton_quy2.Checked)&&(cmb_Quy2.Text=="")) MessageBox.Show("Bạn chưa chọn TÊN QUÝ");
            if((radioButton_Nam2.Checked)&&(cmb_nam2.Text=="") )MessageBox.Show("Bạn chưa chọn TÊN NĂM");

        }
    void KiemTra3()
    {
        if((radioButtonTen_Hang3.Checked)&&(cmb_ten_hang3.Text=="") )MessageBox.Show("Bạn chưa chọn TÊN HÀNG");
        if((radioButtonLoai_hang3.Checked)&&(cmb_loai_hang3.Text=="") )MessageBox.Show("Bạn chưa chọn TÊN LOẠI HÀNG");
        if((radioButtonNha_cung_cap3.Checked)&&(cmb_ncc3.Text=="")) MessageBox.Show("Bạn chưa chọn TÊN NHÀ CUNG CẤP");
        if((radioButton_thang3.Checked)&&(cmb_thang3.Text=="")) MessageBox.Show("Bạn chưa chọn THÁNG");
        if((radioButtonQuy3.Checked)&&(cmb_quy3.Text=="")) MessageBox.Show("Bạn chưa chọn TÊN QUÝ");
        if((radioButtonNam3.Checked)&&(cmb_nam3.Text=="")) MessageBox.Show("Bạn chưa chọn TÊN NĂM");
    
    }

    private void button4_Click(object sender, EventArgs e)
    {

        FormTONKHO ftk = new FormTONKHO();
        ftk.ShowDialog();

    }


     

        
        

        

       

        

        






    }
}
