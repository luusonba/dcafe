namespace DCafe.Reports
{
    partial class rptAccountOut
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
            this.TongThubindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DsQuanLy = new DCafe.Dataset.DsQuanLy();
            this.rptAccOut = new Microsoft.Reporting.WinForms.ReportViewer();
            this.t_TongThuTableAdapter = new DCafe.Dataset.DsQuanLyTableAdapters.T_TongThuTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.TongThubindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DsQuanLy)).BeginInit();
            this.SuspendLayout();
            // 
            // TongThubindingSource
            // 
            this.TongThubindingSource.DataMember = "T_TongThu";
            this.TongThubindingSource.DataSource = this.DsQuanLy;
            // 
            // DsQuanLy
            // 
            this.DsQuanLy.DataSetName = "DsQuanLy";
            this.DsQuanLy.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rptAccOut
            // 
            this.rptAccOut.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DsQuanLy";
            reportDataSource1.Value = this.TongThubindingSource;
            this.rptAccOut.LocalReport.DataSources.Add(reportDataSource1);
            this.rptAccOut.LocalReport.ReportEmbeddedResource = "DCafe.Reports.TongThu.rdlc";
            this.rptAccOut.Location = new System.Drawing.Point(0, 0);
            this.rptAccOut.Name = "rptAccOut";
            this.rptAccOut.Size = new System.Drawing.Size(895, 503);
            this.rptAccOut.TabIndex = 0;
            // 
            // t_TongThuTableAdapter
            // 
            this.t_TongThuTableAdapter.ClearBeforeFill = true;
            // 
            // rptAccountOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 503);
            this.Controls.Add(this.rptAccOut);
            this.Name = "rptAccountOut";
            this.Text = "In Tổng thu";
            this.Load += new System.EventHandler(this.rptAccountOut_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TongThubindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DsQuanLy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptAccOut;
        private Dataset.DsQuanLy DsQuanLy;
        private System.Windows.Forms.BindingSource TongThubindingSource;
        private Dataset.DsQuanLyTableAdapters.T_TongThuTableAdapter t_TongThuTableAdapter;
    }
}