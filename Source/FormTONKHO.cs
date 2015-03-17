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
    public partial class FormTONKHO : Form
    {
        public FormTONKHO()
        {
            InitializeComponent();
        }

        private void FormTONKHO_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSetTONKHO.HANGHOA' table. You can move, or remove it, as needed.
            this.HANGHOATableAdapter.Fill(this.DataSetTONKHO.HANGHOA);

            this.reportViewer1.RefreshReport();
        }
    }
}
