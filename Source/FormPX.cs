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
    public partial class FormPX : Form
    {
        public FormPX()
        {
            InitializeComponent();
        }

        private void FormPX_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSetPX.HANGHOA' table. You can move, or remove it, as needed.
            this.HANGHOATableAdapter.Fill(this.DataSetPX.HANGHOA,class1.stt_px);

            this.reportViewer1.RefreshReport();
        }
    }
}
