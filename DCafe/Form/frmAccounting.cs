using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DCafe
{
    public partial class frmAccounting : Form
    {
        public frmAccounting()
        {
            InitializeComponent();
        }

        private void frmAccounting_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form frm = (Form)Application.OpenForms["frmMain"];
            frm.Visible = true;
        }
    }
}
