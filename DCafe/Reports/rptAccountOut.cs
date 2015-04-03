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
    public partial class rptAccountOut : Form
    {
        private SqlConnection sqlCon;

        public rptAccountOut()
        {
            InitializeComponent();
        }
                
        public object dtStart = null;
        public object dtEnd = null;     

        private void LoadTongChi()
        {
            string sql = "SELECT t1.ma_hd, SUM(t1.soluong*t2.dongia) AS thanhtien, t3.thoidiem FROM T_CTHoadon t1, T_Thanhpham t2, T_Hoadon t3 WHERE t1.ma_thanhpham = t2.ma_thanhpham AND t1.ma_hd = t3.ma_hd AND t3.thoidiem >= @start AND t3.thoidiem <= @end GROUP BY t1.ma_hd, t3.thoidiem";

            SqlDataAdapter ada = new SqlDataAdapter(sql, sqlCon);
            ada.SelectCommand.Parameters.AddWithValue("@start", dtStart);
            ada.SelectCommand.Parameters.AddWithValue("@end", dtEnd);

            sqlCon.Open();
            DataSet ds = new DataSet();
            ada.Fill(ds, "DsQuanLy");

            ds.Tables[0].TableName = "T_TongThu";

            this.TongThubindingSource.DataSource = ds;
            this.rptAccOut.RefreshReport();

            sqlCon.Close();
        }

        private void rptAccountOut_Load(object sender, EventArgs e)
        {
            Conn conn = new Conn();
            sqlCon = conn.createConn();

            System.Drawing.Printing.PageSettings ps = new System.Drawing.Printing.PageSettings();
            ps.Landscape = true;
            ps.PaperSize = new System.Drawing.Printing.PaperSize("A4", 827, 1170);
            ps.PaperSize.RawKind = (int)System.Drawing.Printing.PaperKind.A4;
            rptAccOut.SetPageSettings(ps);

            LoadTongChi();
        }
    }
}
