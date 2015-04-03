using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using DCafe.Reports;

namespace DCafe
{
    public partial class frmAccounting : Form
    {
        private SqlConnection sqlCon;

        public frmAccounting()
        {
            InitializeComponent();
        }

        private void frmAccounting_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form frm = (Form)Application.OpenForms["frmMain"];
            frm.Visible = true;
        }

        private void frmAccounting_Load(object sender, EventArgs e)
        {
            Conn conn = new Conn();
            sqlCon = conn.createConn();
            rbnBanra.Checked = true;
            cbNguyenlieu.Enabled = false;
            DateTime day = DateTime.Now;
            DateTime start = new DateTime(day.Year, day.Month, 1);
            DateTime end = new DateTime(day.Year, day.Month, DateTime.DaysInMonth(day.Year, day.Month));

            dtStart.Value = start;
            dtEnd.Value = end;

            dtStartThu.Value = start;
            dtEndThu.Value = end;

            Load_Nguyenlieu();
        }

        private void LoadTongChi()
        {
            string and = "";
            if (chkTenhang.Checked)
            {
                and = "and t1.ma_nguyenlieu = @ma_nguyenlieu";
            }
            string sql = "";

            if (rbnNhapvao.Checked)
            {
                sql = "SELECT t1.ma_nguyenlieu, RTRIM(t2.ten_nguyenlieu) AS ten_nguyenlieu, SUM(soluong) AS soluong, SUM(soluong) * t2.dongia AS thanhtien, t2.dongia  AS dongia FROM T_Nhaphang t1 LEFT OUTER JOIN T_Nguyenlieu t2 ON t1.ma_nguyenlieu = t2.ma_nguyenlieu WHERE t1.thoidiem >= @start AND t1.thoidiem <= @end " + and + " GROUP BY t1.ma_nguyenlieu, ten_nguyenlieu, dongia";
            }
            else
            {
                sql = "SELECT t1.ma_nguyenlieu, t3.ten_nguyenlieu, t3.dongia, SUM(t1.soluong) AS soluong, SUM(t1.soluong) * t3.dongia AS thanhtien FROM t_chebien t1, t_cthoadon t2, t_nguyenlieu t3, t_hoadon t4 WHERE t1.ma_thanhpham = t2.ma_thanhpham AND t1.ma_nguyenlieu = t3.ma_nguyenlieu AND t2.ma_hd = t4.ma_hd AND t4.thoidiem >= @start AND t4.thoidiem <= @end " + and + " GROUP BY t1.ma_nguyenlieu, t3.dongia, t3.ten_nguyenlieu";
            }

            SqlDataAdapter ada = new SqlDataAdapter(sql, sqlCon);
            ada.SelectCommand.Parameters.AddWithValue("@start", dtStart.Value);
            ada.SelectCommand.Parameters.AddWithValue("@end", dtEnd.Value);
            if (chkTenhang.Checked)
            {
                ada.SelectCommand.Parameters.AddWithValue("@ma_nguyenlieu", cbNguyenlieu.SelectedValue);
            }
            sqlCon.Open();
            DataTable dt = new DataTable();
            ada.Fill(dt);
            grdTongchi.DataSource = dt;
            sqlCon.Close();
            LoadTextTongChi();
        }

        private void LoadTextTongChi()
        {
            int tong = 0;
            foreach (DataGridViewRow row in grdTongchi.Rows)
            {
                tong = tong + Convert.ToInt32(row.Cells["cThanhtien"].Value);
            }            
            txtTongchi.Text = string.Format("{0:#,##0}", double.Parse(tong.ToString()));
        }

        private void LoadTongThu()
        {

            string sql = "SELECT t1.ma_hd, SUM(t1.soluong*t2.dongia) AS thanhtien, t3.thoidiem FROM T_CTHoadon t1, T_Thanhpham t2, T_Hoadon t3 WHERE t1.ma_thanhpham = t2.ma_thanhpham AND t1.ma_hd = t3.ma_hd AND t3.thoidiem >= @start AND t3.thoidiem <= @end GROUP BY t1.ma_hd, t3.thoidiem";
            
            SqlDataAdapter ada = new SqlDataAdapter(sql, sqlCon);
            ada.SelectCommand.Parameters.AddWithValue("@start", dtStartThu.Value);
            ada.SelectCommand.Parameters.AddWithValue("@end", dtEndThu.Value);
            
            sqlCon.Open();
            DataTable dt = new DataTable();
            ada.Fill(dt);
            grdTongThu.DataSource = dt;
            sqlCon.Close();
            LoadTextTongThu();
        }

        private void LoadTextTongThu()
        {
            int tong = 0;
            foreach (DataGridViewRow row in grdTongThu.Rows)
            {
                tong = tong + Convert.ToInt32(row.Cells["cThanhtienThu"].Value);
            }
            txtTongThu.Text = string.Format("{0:#,##0}", double.Parse(tong.ToString()));
        }

        private void Load_Nguyenlieu()
        {
            string mk = "SELECT ma_nguyenlieu, RTRIM(ten_nguyenlieu) AS ten_nguyenlieu FROM T_Nguyenlieu";
            SqlDataAdapter ada = new SqlDataAdapter(mk, sqlCon);
            sqlCon.Open();
            DataTable dt = new DataTable();
            ada.Fill(dt);

            cbNguyenlieu.DataSource = dt;
            cbNguyenlieu.DisplayMember = "ten_nguyenlieu";
            cbNguyenlieu.ValueMember = "ma_nguyenlieu";
            sqlCon.Close();
        }

        private void chkTenhang_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTenhang.Checked)
            {
                cbNguyenlieu.Enabled = true;
            }
            else
            {
                cbNguyenlieu.Enabled = false;
            }
        }

        private bool _chkTenhang = false;
        private bool _rbnNhapvao = false;
        private object _dtStart = null;
        private object _dtEnd = null;
        private object _cbNguyenlieu = null;  

        private void btnTim_Click(object sender, EventArgs e)
        {
            _chkTenhang = chkTenhang.Checked;
            _rbnNhapvao = rbnNhapvao.Checked;
            _dtStart = dtStart.Value;
            _dtEnd = dtEnd.Value;
            _cbNguyenlieu = cbNguyenlieu.SelectedValue;
            LoadTongChi();
        }

        private void btnTimThu_Click(object sender, EventArgs e)
        {
            _dtStart = dtStartThu.Value;
            _dtEnd = dtEndThu.Value;
            LoadTongThu();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            rptAccountIn rpt = new rptAccountIn();
            rpt.chkTenhang = _chkTenhang;
            rpt.rbnNhapvao = _rbnNhapvao;
            rpt.dtStart = _dtStart;
            rpt.dtEnd = _dtEnd;
            rpt.cbNguyenlieu = _cbNguyenlieu;
            rpt.Show();
        }

        private void btnInThu_Click(object sender, EventArgs e)
        {
            rptAccountOut rpt = new rptAccountOut();
            rpt.dtStart = _dtStart;
            rpt.dtEnd = _dtEnd;
            rpt.Show();
        }
    }
}
