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
            Microsoft.Reporting.WinForms.ReportDataSource rptDsQuanLy = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.rptAccIn = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DsQuanLy = new DCafe.Dataset.DsQuanLy();
            this.T_TongNhapbindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t_TongNhapTableAdapter = new DCafe.Dataset.DsQuanLyTableAdapters.T_TongNhapTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DsQuanLy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.T_TongNhapbindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rptAccIn
            // 
            this.rptAccIn.Dock = System.Windows.Forms.DockStyle.Fill;
            rptDsQuanLy.Name = "DsQuanLy";
            rptDsQuanLy.Value = this.T_TongNhapbindingSource;
            this.rptAccIn.LocalReport.DataSources.Add(rptDsQuanLy);
            this.rptAccIn.LocalReport.ReportEmbeddedResource = "DCafe.Reports.TongChi.rdlc";
            this.rptAccIn.Location = new System.Drawing.Point(0, 0);
            this.rptAccIn.Name = "rptAccIn";
            this.rptAccIn.Size = new System.Drawing.Size(895, 503);
            this.rptAccIn.TabIndex = 0;
            // 
            // DsQuanLy
            // 
            this.DsQuanLy.DataSetName = "DsQuanLy";
            this.DsQuanLy.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // T_TongNhapbindingSource
            // 
            this.T_TongNhapbindingSource.DataMember = "T_TongNhap";
            this.T_TongNhapbindingSource.DataSource = this.DsQuanLy;
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
            this.Name = "rptAccountIn";
            this.Text = "In Tổng chi";
            this.Load += new System.EventHandler(this.rptAccountIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DsQuanLy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.T_TongNhapbindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptAccIn;
        private Dataset.DsQuanLy DsQuanLy;
        private System.Windows.Forms.BindingSource T_TongNhapbindingSource;
        private Dataset.DsQuanLyTableAdapters.T_TongNhapTableAdapter t_TongNhapTableAdapter;
    }
}