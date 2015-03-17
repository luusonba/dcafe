namespace TTTT
{
    partial class FormPN
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
            this.DataSetPN = new TTTT.DataSetPN();
            this.HANGHOABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.HANGHOATableAdapter = new TTTT.DataSetPNTableAdapters.HANGHOATableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetPN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HANGHOABindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSetPN";
            reportDataSource1.Value = this.HANGHOABindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TTTT.ReportPN.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(827, 498);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataSetPN
            // 
            this.DataSetPN.DataSetName = "DataSetPN";
            this.DataSetPN.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // HANGHOABindingSource
            // 
            this.HANGHOABindingSource.DataMember = "HANGHOA";
            this.HANGHOABindingSource.DataSource = this.DataSetPN;
            // 
            // HANGHOATableAdapter
            // 
            this.HANGHOATableAdapter.ClearBeforeFill = true;
            // 
            // FormPN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 510);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormPN";
            this.Text = "FormPN";
            this.Load += new System.EventHandler(this.FormPN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSetPN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HANGHOABindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource HANGHOABindingSource;
        private DataSetPN DataSetPN;
        private DataSetPNTableAdapters.HANGHOATableAdapter HANGHOATableAdapter;
    }
}