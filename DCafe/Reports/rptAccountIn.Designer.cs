﻿namespace DCafe.Reports
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
            this.rptAccIn = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rptAccIn
            // 
            this.rptAccIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptAccIn.Location = new System.Drawing.Point(0, 0);
            this.rptAccIn.Name = "rptAccIn";
            this.rptAccIn.Size = new System.Drawing.Size(895, 503);
            this.rptAccIn.TabIndex = 0;
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
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptAccIn;
    }
}