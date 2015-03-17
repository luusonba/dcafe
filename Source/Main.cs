using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TTTT
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void quảnLýGiáToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Quan_ly_gia f = new Quan_ly_gia();
            f.MdiParent = this;
            f.Show();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tồnKhoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void lợiNhuậnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kinhdoanh f = new Kinhdoanh();
            f.MdiParent = this;
            f.Show();
        }
        public string _txttk
        {
            set { txtUser.Text = value; }
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void bánHàngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.MdiParent = this;
            f1.Show();
        }

        private void nhậpHàngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.MdiParent = this;
            f2.Show();

        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void quảnLýHàngHóaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            them_hang th = new them_hang();
            th.MdiParent = this;
            th.Show();
        }

    }
}
