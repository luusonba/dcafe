namespace TTTT
{
    partial class FormTONKHO
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataSetTONKHO = new TTTT.DataSetTONKHO();
            this.HANGHOABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.HANGHOATableAdapter = new TTTT.DataSetTONKHOTableAdapters.HANGHOATableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetTONKHO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HANGHOABindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSetTONKHO";
            reportDataSource1.Value = this.HANGHOABindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TTTT.ReportTONKHO.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(780, 391);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataSetTONKHO
            // 
            this.DataSetTONKHO.DataSetName = "DataSetTONKHO";
            this.DataSetTONKHO.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // HANGHOABindingSource
            // 
            this.HANGHOABindingSource.DataMember = "HANGHOA";
            this.HANGHOABindingSource.DataSource = this.DataSetTONKHO;
            // 
            // HANGHOATableAdapter
            // 
            this.HANGHOATableAdapter.ClearBeforeFill = true;
            // 
            // FormTONKHO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 395);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormTONKHO";
            this.Text = "FormTONKHO";
            this.Load += new System.EventHandler(this.FormTONKHO_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSetTONKHO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HANGHOABindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource HANGHOABindingSource;
        private DataSetTONKHO DataSetTONKHO;
        private DataSetTONKHOTableAdapters.HANGHOATableAdapter HANGHOATableAdapter;
    }
}