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
    public partial class FormQLHH : Form
    {
        public FormQLHH()
        {
            InitializeComponent();
        }

        private void FormQLHH_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSetQLHH.HANGHOA' table. You can move, or remove it, as needed.
            this.HANGHOATableAdapter.Fill(this.DataSetQLHH.HANGHOA);

            this.reportViewer1.RefreshReport();
        }
    }
}
