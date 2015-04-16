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
using DCafe.Class;

namespace DCafe.Reports
{
    public partial class rptBill : Form
    {
        public string so_hoadon = "";
        public string soban = "";
        public string ten_khuvuc = "";
        public string ten_nhanvien = "";

        private SqlConnection sqlCon;

        public rptBill()
        {
            InitializeComponent();
        }

        private void rptBill_Load(object sender, EventArgs e)
        {
            Conn conn = new Conn();
            sqlCon = conn.createConn();

            LoadHoadon();

            ReportPrintDocument RP = new ReportPrintDocument(rptHoadon.LocalReport);
            System.Drawing.Printing.PageSettings ps = new System.Drawing.Printing.PageSettings();
            ps.Landscape = true;
            ps.PaperSize = new System.Drawing.Printing.PaperSize("BILL", 100, 300);
            ps.PaperSize.RawKind = (int)System.Drawing.Printing.PaperKind.A6;
            rptHoadon.SetPageSettings(ps);
            RP.Print();

            this.Close();
        }

        private void LoadHoadon()
        {
            string sql = "SELECT t1.ma_hd, t2.ten_thanhpham, t1.soluong, t1.soluong * t2.giaban as thanhtien FROM T_CTHoadon t1 LEFT OUTER JOIN T_Thanhpham t2 ON t1.ma_thanhpham = t2.ma_thanhpham WHERE ma_hd = @ma_hd";

            SqlDataAdapter ada = new SqlDataAdapter(sql, sqlCon);
            ada.SelectCommand.Parameters.AddWithValue("@ma_hd", so_hoadon);

            sqlCon.Open();
            DataSet ds = new DataSet();
            ada.Fill(ds, "DsQuanLy");

            ds.Tables[0].TableName = "T_Hoadon";

            this.HoadonbindingSource.DataSource = ds;

            ReportParameter[] parameters = new ReportParameter[4];
            parameters[0] = new ReportParameter("so_hoadon", so_hoadon);
            parameters[1] = new ReportParameter("soban", soban);
            parameters[2] = new ReportParameter("ten_khuvuc", ten_khuvuc);
            parameters[3] = new ReportParameter("ten_nhanvien", ten_nhanvien);
            this.rptHoadon.LocalReport.SetParameters(parameters);

            this.rptHoadon.RefreshReport();

            sqlCon.Close();
        }
    }
}