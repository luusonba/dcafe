namespace DCafe.Forms
{
    partial class frmDetailBill
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cbMahoadon = new System.Windows.Forms.ComboBox();
            this.cbNhanvien = new System.Windows.Forms.ComboBox();
            this.cbKhuvuc = new System.Windows.Forms.ComboBox();
            this.cbSoban = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.grdHoadon = new System.Windows.Forms.DataGridView();
            this.cMaHoadon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cMasanphamHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSanpham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSoluongHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDongiaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cThanhtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.dtThoidiemHD = new System.Windows.Forms.DateTimePicker();
            this.label20 = new System.Windows.Forms.Label();
            this.txtTongThu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdHoadon)).BeginInit();
            this.SuspendLayout();
            // 
            // cbMahoadon
            // 
            this.cbMahoadon.Enabled = false;
            this.cbMahoadon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMahoadon.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cbMahoadon.FormattingEnabled = true;
            this.cbMahoadon.Location = new System.Drawing.Point(123, 57);
            this.cbMahoadon.Name = "cbMahoadon";
            this.cbMahoadon.Size = new System.Drawing.Size(166, 28);
            this.cbMahoadon.TabIndex = 28;
            // 
            // cbNhanvien
            // 
            this.cbNhanvien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNhanvien.Enabled = false;
            this.cbNhanvien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNhanvien.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cbNhanvien.FormattingEnabled = true;
            this.cbNhanvien.Location = new System.Drawing.Point(123, 102);
            this.cbNhanvien.Name = "cbNhanvien";
            this.cbNhanvien.Size = new System.Drawing.Size(166, 28);
            this.cbNhanvien.TabIndex = 29;
            // 
            // cbKhuvuc
            // 
            this.cbKhuvuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKhuvuc.Enabled = false;
            this.cbKhuvuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbKhuvuc.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cbKhuvuc.FormattingEnabled = true;
            this.cbKhuvuc.Location = new System.Drawing.Point(123, 147);
            this.cbKhuvuc.Name = "cbKhuvuc";
            this.cbKhuvuc.Size = new System.Drawing.Size(166, 28);
            this.cbKhuvuc.TabIndex = 30;
            // 
            // cbSoban
            // 
            this.cbSoban.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSoban.Enabled = false;
            this.cbSoban.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSoban.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cbSoban.FormattingEnabled = true;
            this.cbSoban.Location = new System.Drawing.Point(123, 192);
            this.cbSoban.Name = "cbSoban";
            this.cbSoban.Size = new System.Drawing.Size(166, 28);
            this.cbSoban.TabIndex = 31;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label19.Location = new System.Drawing.Point(66, 9);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(222, 31);
            this.label19.TabIndex = 37;
            this.label19.Text = "Chi Tiết Hóa Đơn";
            // 
            // grdHoadon
            // 
            this.grdHoadon.AllowUserToAddRows = false;
            this.grdHoadon.AllowUserToDeleteRows = false;
            this.grdHoadon.AllowUserToResizeColumns = false;
            this.grdHoadon.AllowUserToResizeRows = false;
            this.grdHoadon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grdHoadon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdHoadon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.grdHoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdHoadon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cMaHoadon,
            this.cMasanphamHD,
            this.cSanpham,
            this.cSoluongHD,
            this.cDongiaHD,
            this.cThanhtien});
            this.grdHoadon.Location = new System.Drawing.Point(297, 12);
            this.grdHoadon.Name = "grdHoadon";
            this.grdHoadon.RowHeadersVisible = false;
            this.grdHoadon.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.grdHoadon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdHoadon.Size = new System.Drawing.Size(696, 431);
            this.grdHoadon.TabIndex = 36;
            // 
            // cMaHoadon
            // 
            this.cMaHoadon.DataPropertyName = "ma_hd";
            this.cMaHoadon.HeaderText = "Mã hóa đơn";
            this.cMaHoadon.Name = "cMaHoadon";
            this.cMaHoadon.Visible = false;
            // 
            // cMasanphamHD
            // 
            this.cMasanphamHD.DataPropertyName = "ma_thanhpham";
            this.cMasanphamHD.HeaderText = "Mã sản phẩm";
            this.cMasanphamHD.Name = "cMasanphamHD";
            this.cMasanphamHD.Visible = false;
            // 
            // cSanpham
            // 
            this.cSanpham.DataPropertyName = "ten_thanhpham";
            this.cSanpham.HeaderText = "Sản phẩm";
            this.cSanpham.Name = "cSanpham";
            this.cSanpham.Width = 336;
            // 
            // cSoluongHD
            // 
            this.cSoluongHD.DataPropertyName = "soluong";
            this.cSoluongHD.HeaderText = "Số lượng";
            this.cSoluongHD.Name = "cSoluongHD";
            // 
            // cDongiaHD
            // 
            this.cDongiaHD.DataPropertyName = "giaban";
            this.cDongiaHD.HeaderText = "Đơn giá";
            this.cDongiaHD.Name = "cDongiaHD";
            this.cDongiaHD.Visible = false;
            // 
            // cThanhtien
            // 
            this.cThanhtien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cThanhtien.DataPropertyName = "thanhtien";
            dataGridViewCellStyle6.Format = "N0";
            this.cThanhtien.DefaultCellStyle = dataGridViewCellStyle6;
            this.cThanhtien.HeaderText = "Thành tiền";
            this.cThanhtien.Name = "cThanhtien";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(52, 150);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(65, 20);
            this.label21.TabIndex = 34;
            this.label21.Text = "Khu vực";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(57, 195);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(60, 20);
            this.label22.TabIndex = 35;
            this.label22.Text = "Số bàn";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(38, 105);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(79, 20);
            this.label23.TabIndex = 33;
            this.label23.Text = "Nhân viên";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(24, 60);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(93, 20);
            this.label24.TabIndex = 32;
            this.label24.Text = "Mã hóa đơn";
            // 
            // dtThoidiemHD
            // 
            this.dtThoidiemHD.CustomFormat = "dd/MM/yyyy";
            this.dtThoidiemHD.Enabled = false;
            this.dtThoidiemHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtThoidiemHD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtThoidiemHD.Location = new System.Drawing.Point(123, 235);
            this.dtThoidiemHD.Name = "dtThoidiemHD";
            this.dtThoidiemHD.Size = new System.Drawing.Size(166, 26);
            this.dtThoidiemHD.TabIndex = 38;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(40, 238);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(77, 20);
            this.label20.TabIndex = 39;
            this.label20.Text = "Thời điểm";
            // 
            // txtTongThu
            // 
            this.txtTongThu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTongThu.Enabled = false;
            this.txtTongThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTongThu.Location = new System.Drawing.Point(788, 449);
            this.txtTongThu.Name = "txtTongThu";
            this.txtTongThu.Size = new System.Drawing.Size(205, 27);
            this.txtTongThu.TabIndex = 107;
            this.txtTongThu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(702, 452);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 106;
            this.label4.Text = "Thành tiền";
            // 
            // frmDetailBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 486);
            this.Controls.Add(this.txtTongThu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtThoidiemHD);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.cbMahoadon);
            this.Controls.Add(this.cbNhanvien);
            this.Controls.Add(this.cbKhuvuc);
            this.Controls.Add(this.cbSoban);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.grdHoadon);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label24);
            this.Name = "frmDetailBill";
            this.Text = "Chi Tiết Hóa Đơn";
            this.Load += new System.EventHandler(this.frmDetailBill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdHoadon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbMahoadon;
        private System.Windows.Forms.ComboBox cbNhanvien;
        private System.Windows.Forms.ComboBox cbKhuvuc;
        private System.Windows.Forms.ComboBox cbSoban;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DataGridView grdHoadon;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMaHoadon;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMasanphamHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSanpham;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSoluongHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDongiaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn cThanhtien;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.DateTimePicker dtThoidiemHD;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtTongThu;
        private System.Windows.Forms.Label label4;

    }
}