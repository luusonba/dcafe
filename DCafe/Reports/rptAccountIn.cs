using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;

namespace DCafe.Reports
{
    public partial class rptAccountIn : Form
    {
        private SqlConnection sqlCon;
        
        public rptAccountIn()
        {
            InitializeComponent();
        }

        public bool chkTenhang = false;
        public bool rbnNhapvao = false;
        public object dtStart = null;
        public object dtEnd = null;
        public object cbNguyenlieu = null;       

        private void LoadTongChi()
        {
            string and = "";
            if (chkTenhang)
            {
                and = "and t1.ma_nguyenlieu = @ma_nguyenlieu";
            }
            string sql = "";

            if (rbnNhapvao)
            {
                sql = "SELECT t1.ma_nguyenlieu, RTRIM(t2.ten_nguyenlieu) AS ten_nguyenlieu, SUM(soluong) AS soluong, SUM(soluong) * t2.dongia AS thanhtien, t2.dongia  AS dongia FROM T_Nhaphang t1 LEFT OUTER JOIN T_Nguyenlieu t2 ON t1.ma_nguyenlieu = t2.ma_nguyenlieu WHERE t1.thoidiem >= @start AND t1.thoidiem <= @end " + and + " GROUP BY t1.ma_nguyenlieu, ten_nguyenlieu, dongia";
            }
            else
            {
                sql = "SELECT t1.ma_nguyenlieu, t3.ten_nguyenlieu, t3.dongia, SUM(t1.soluong) AS soluong, SUM(t1.soluong) * t3.dongia AS thanhtien FROM t_chebien t1, t_cthoadon t2, t_nguyenlieu t3, t_hoadon t4 WHERE t1.ma_thanhpham = t2.ma_thanhpham AND t1.ma_nguyenlieu = t3.ma_nguyenlieu AND t2.ma_hd = t4.ma_hd AND t4.thoidiem >= @start AND t4.thoidiem <= @end " + and + " GROUP BY t1.ma_nguyenlieu, t3.dongia, t3.ten_nguyenlieu";
            }

            SqlDataAdapter ada = new SqlDataAdapter(sql, sqlCon);
            ada.SelectCommand.Parameters.AddWithValue("@start", dtStart);
            ada.SelectCommand.Parameters.AddWithValue("@end", dtEnd);
            if (chkTenhang)
            {
                ada.SelectCommand.Parameters.AddWithValue("@ma_nguyenlieu", cbNguyenlieu);
            }
            sqlCon.Open();
            DataSet ds = new DataSet();
            ada.Fill(ds,"DsQuanLy");

            ds.Tables[0].TableName = "T_TongNhap";

            this.T_TongNhapbindingSource.DataSource = ds;
            this.rptAccIn.RefreshReport();

            sqlCon.Close();
        }

        private void rptAccountIn_Load(object sender, EventArgs e)
        {
            Conn conn = new Conn();
            sqlCon = conn.createConn();

            System.Drawing.Printing.PageSettings ps = new System.Drawing.Printing.PageSettings();
            ps.Landscape = true;
            ps.PaperSize = new System.Drawing.Printing.PaperSize("A4", 827, 1170);
            ps.PaperSize.RawKind = (int)System.Drawing.Printing.PaperKind.A4;
            rptAccIn.SetPageSettings(ps);

            LoadTongChi();
        }
    }
}
