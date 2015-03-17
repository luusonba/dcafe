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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnNhanvien_Click(object sender, EventArgs e)
        {
            tabPages.SelectedTab = tabNhanvien;
        }

        private void btnNguyenlieu_Click(object sender, EventArgs e)
        {
            tabPages.SelectedTab = tabNguyenlieu;
        }

        private void btnThanhpham_Click(object sender, EventArgs e)
        {
            tabPages.SelectedTab = tabSanpham;
        }

        private void btnChebien_Click(object sender, EventArgs e)
        {
            tabPages.SelectedTab = tabChebien;
        }

        private void btnHoadon_Click(object sender, EventArgs e)
        {
            tabPages.SelectedTab = tabHoadon;
        }      
    }
}
