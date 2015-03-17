using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TTTT
{
    public partial class FormPN : Form
    {
        public FormPN()
        {
            InitializeComponent();
        }

        private void FormPN_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSetPN.HANGHOA' table. You can move, or remove it, as needed.
            this.HANGHOATableAdapter.Fill(this.DataSetPN.HANGHOA,class1.stt_pn);

            this.reportViewer1.RefreshReport();
        }
    }
}
