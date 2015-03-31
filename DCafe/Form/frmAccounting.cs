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
            dtStart.Value = new DateTime(day.Year, day.Month,1);
            dtEnd.Value = new DateTime(day.Year, day.Month, DateTime.DaysInMonth(day.Year,day.Month));
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

            //SELECT t1.ma_nguyenlieu, RTRIM(t2.ten_nguyenlieu) AS ten_nguyenlieu, SUM(soluong) AS soluong, SUM(soluong) * t2.dongia AS thanhtien, t2.dongia  AS dongia FROM T_Nhaphang t1 LEFT OUTER JOIN T_Nguyenlieu t2 ON t1.ma_nguyenlieu = t2.ma_nguyenlieu WHERE DATEADD(dd,0, t1.thoidiem) >= DATEADD(dd,0, '3/1/2015 12:00:00 AM') AND t1.thoidiem <= '3/31/2015 11:00:00 PM' GROUP BY t1.ma_nguyenlieu, ten_nguyenlieu, dongia

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

        private void btnTim_Click(object sender, EventArgs e)
        {
            LoadTongChi();
        }
    }
}
