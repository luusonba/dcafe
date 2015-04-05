namespace DCafe.Reports
{
    partial class rptAccountIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rptAccountIn));
            this.T_TongNhapbindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DsQuanLy = new DCafe.Dataset.DsQuanLy();
            this.rptAccIn = new Microsoft.Reporting.WinForms.ReportViewer();
            this.t_TongNhapTableAdapter = new DCafe.Dataset.DsQuanLyTableAdapters.T_TongNhapTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.T_TongNhapbindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DsQuanLy)).BeginInit();
            this.SuspendLayout();
            // 
            // T_TongNhapbindingSource
            // 
            this.T_TongNhapbindingSource.DataMember = "T_TongNhap";
            this.T_TongNhapbindingSource.DataSource = this.DsQuanLy;
            // 
            // DsQuanLy
            // 
            this.DsQuanLy.DataSetName = "DsQuanLy";
            this.DsQuanLy.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rptAccIn
            // 
            this.rptAccIn.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DsQuanLy";
            reportDataSource1.Value = this.T_TongNhapbindingSource;
            this.rptAccIn.LocalReport.DataSources.Add(reportDataSource1);
            this.rptAccIn.LocalReport.ReportEmbeddedResource = "DCafe.Reports.TongChi.rdlc";
            this.rptAccIn.Location = new System.Drawing.Point(0, 0);
            this.rptAccIn.Name = "rptAccIn";
            this.rptAccIn.Size = new System.Drawing.Size(895, 503);
            this.rptAccIn.TabIndex = 0;
            // 
            // t_TongNhapTableAdapter
            // 
            this.t_TongNhapTableAdapter.ClearBeforeFill = true;
            // 
            // rptAccountIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 503);
            this.Controls.Add(this.rptAccIn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "rptAccountIn";
            this.Text = "In Tổng chi";
            this.Load += new System.EventHandler(this.rptAccountIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.T_TongNhapbindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DsQuanLy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptAccIn;
        private Dataset.DsQuanLy DsQuanLy;
        private System.Windows.Forms.BindingSource T_TongNhapbindingSource;
        private Dataset.DsQuanLyTableAdapters.T_TongNhapTableAdapter t_TongNhapTableAdapter;
    }
}