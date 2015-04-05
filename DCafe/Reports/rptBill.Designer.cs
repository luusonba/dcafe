namespace DCafe.Reports
{
    partial class rptBill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rptBill));
            this.HoadonbindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DsQuanLy1 = new DCafe.Dataset.DsQuanLy1();
            this.rptHoadon = new Microsoft.Reporting.WinForms.ReportViewer();
            this.t_HoadonTableAdapter = new DCafe.Dataset.DsQuanLy1TableAdapters.T_HoadonTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.HoadonbindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DsQuanLy1)).BeginInit();
            this.SuspendLayout();
            // 
            // HoadonbindingSource
            // 
            this.HoadonbindingSource.DataMember = "T_Hoadon";
            this.HoadonbindingSource.DataSource = this.DsQuanLy1;
            // 
            // DsQuanLy1
            // 
            this.DsQuanLy1.DataSetName = "DsQuanLy1";
            this.DsQuanLy1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rptHoadon
            // 
            this.rptHoadon.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DsQuanLy1";
            reportDataSource1.Value = this.HoadonbindingSource;
            this.rptHoadon.LocalReport.DataSources.Add(reportDataSource1);
            this.rptHoadon.LocalReport.ReportEmbeddedResource = "DCafe.Reports.HoaDon.rdlc";
            this.rptHoadon.Location = new System.Drawing.Point(0, 0);
            this.rptHoadon.Name = "rptHoadon";
            this.rptHoadon.Size = new System.Drawing.Size(895, 503);
            this.rptHoadon.TabIndex = 0;
            // 
            // t_HoadonTableAdapter
            // 
            this.t_HoadonTableAdapter.ClearBeforeFill = true;
            // 
            // rptBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 503);
            this.Controls.Add(this.rptHoadon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "rptBill";
            this.Text = "Hóa đơn";
            this.Load += new System.EventHandler(this.rptBill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HoadonbindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DsQuanLy1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptHoadon;
        private System.Windows.Forms.BindingSource HoadonbindingSource;
        private Dataset.DsQuanLy1 DsQuanLy1;
        private Dataset.DsQuanLy1TableAdapters.T_HoadonTableAdapter t_HoadonTableAdapter;
    }
}