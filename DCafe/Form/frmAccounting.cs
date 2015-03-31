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
            Load_Nguyenlieu();
        }

        private void LoadTongChi()
        {
            string and = "";
            if (chkTenhang.Checked)
            {
                and = "and t1.ma_nguyenlieu = @ma_nguyenlieu";
            }
            string sqlNhap = "SELECT t1.ma_nguyenlieu, RTRIM(t2.ten_nguyenlieu) AS ten_nguyenlieu, sum(soluong) as soluong, sum(soluong * t2.dongia) as thanhtien, t2.dongia  as dongia FROM T_Nhaphang t1, T_Nguyenlieu t2 WHERE t1.thoidiem >= @start and t1.thoidiem <= @end " + and;

            //string sqlBan = "SELECT t1.ma_nguyenlieu, RTRIM(t2.ten_nguyenlieu) AS ten_nguyenlieu, soluong, soluong * t2.dongia as thanhtien, t2.dongia  as dongia FROM T_Nhaphang t1 LEFT OUTER JOIN T_Nguyenlieu t2 ON t1.ma_nguyenlieu = t2.ma_nguyenlieu WHERE t1.thoidiem >= @start and t1.thoidiem <= @end " + and;
            SqlDataAdapter ada = new SqlDataAdapter(sqlNhap, sqlCon);
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
