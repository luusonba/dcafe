namespace DCafe
{
    partial class frmImport
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmImport));
            this.label1 = new System.Windows.Forms.Label();
            this.grdNhaphang = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEditNV = new System.Windows.Forms.Button();
            this.btnAddNV = new System.Windows.Forms.Button();
            this.txtSoluong = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtThoidiem = new System.Windows.Forms.DateTimePicker();
            this.cbNguyenlieu = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cIdnhaphang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNguyenlieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSoluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cThoidiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cThanhtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cManguyenlieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDongia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdNhaphang)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(467, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập Hàng";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // grdNhaphang
            // 
            this.grdNhaphang.AllowUserToAddRows = false;
            this.grdNhaphang.AllowUserToDeleteRows = false;
            this.grdNhaphang.AllowUserToResizeColumns = false;
            this.grdNhaphang.AllowUserToResizeRows = false;
            this.grdNhaphang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grdNhaphang.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdNhaphang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdNhaphang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdNhaphang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cIdnhaphang,
            this.cNguyenlieu,
            this.cSoluong,
            this.cThoidiem,
            this.cThanhtien,
            this.cManguyenlieu,
            this.cDongia});
            this.grdNhaphang.Location = new System.Drawing.Point(292, 57);
            this.grdNhaphang.Name = "grdNhaphang";
            this.grdNhaphang.ReadOnly = true;
            this.grdNhaphang.RowHeadersVisible = false;
            this.grdNhaphang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdNhaphang.Size = new System.Drawing.Size(740, 426);
            this.grdNhaphang.TabIndex = 6;
            this.grdNhaphang.SelectionChanged += new System.EventHandler(this.grdNhaphang_SelectionChanged);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSave.Location = new System.Drawing.Point(957, 498);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 27);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDelete.Location = new System.Drawing.Point(211, 190);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 27);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEditNV
            // 
            this.btnEditNV.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnEditNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnEditNV.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEditNV.Location = new System.Drawing.Point(119, 190);
            this.btnEditNV.Name = "btnEditNV";
            this.btnEditNV.Size = new System.Drawing.Size(75, 27);
            this.btnEditNV.TabIndex = 33;
            this.btnEditNV.Text = "Sửa";
            this.btnEditNV.UseVisualStyleBackColor = false;
            this.btnEditNV.Click += new System.EventHandler(this.btnEditNV_Click);
            // 
            // btnAddNV
            // 
            this.btnAddNV.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAddNV.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAddNV.Location = new System.Drawing.Point(25, 190);
            this.btnAddNV.Name = "btnAddNV";
            this.btnAddNV.Size = new System.Drawing.Size(75, 27);
            this.btnAddNV.TabIndex = 32;
            this.btnAddNV.Text = "Thêm";
            this.btnAddNV.UseVisualStyleBackColor = false;
            this.btnAddNV.Click += new System.EventHandler(this.btnAddNV_Click);
            // 
            // txtSoluong
            // 
            this.txtSoluong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoluong.Location = new System.Drawing.Point(119, 149);
            this.txtSoluong.Name = "txtSoluong";
            this.txtSoluong.Size = new System.Drawing.Size(167, 26);
            this.txtSoluong.TabIndex = 31;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(36, 152);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 20);
            this.label8.TabIndex = 30;
            this.label8.Text = "Số lượng";
            // 
            // dtThoidiem
            // 
            this.dtThoidiem.CustomFormat = "dd/MM/yyyy";
            this.dtThoidiem.Enabled = false;
            this.dtThoidiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtThoidiem.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtThoidiem.Location = new System.Drawing.Point(119, 57);
            this.dtThoidiem.Name = "dtThoidiem";
            this.dtThoidiem.Size = new System.Drawing.Size(167, 26);
            this.dtThoidiem.TabIndex = 28;
            // 
            // cbNguyenlieu
            // 
            this.cbNguyenlieu.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbNguyenlieu.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbNguyenlieu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNguyenlieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNguyenlieu.FormattingEnabled = true;
            this.cbNguyenlieu.Location = new System.Drawing.Point(119, 102);
            this.cbNguyenlieu.Name = "cbNguyenlieu";
            this.cbNguyenlieu.Size = new System.Drawing.Size(167, 28);
            this.cbNguyenlieu.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "Nguyên liệu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Ngày nhập";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(90, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 16);
            this.label4.TabIndex = 25;
            // 
            // cIdnhaphang
            // 
            this.cIdnhaphang.DataPropertyName = "id_nhaphang";
            this.cIdnhaphang.HeaderText = "Mã nhập hàng";
            this.cIdnhaphang.Name = "cIdnhaphang";
            this.cIdnhaphang.ReadOnly = true;
            this.cIdnhaphang.Width = 140;
            // 
            // cNguyenlieu
            // 
            this.cNguyenlieu.DataPropertyName = "ten_nguyenlieu";
            this.cNguyenlieu.FillWeight = 243.6548F;
            this.cNguyenlieu.HeaderText = "Nguyên liệu";
            this.cNguyenlieu.Name = "cNguyenlieu";
            this.cNguyenlieu.ReadOnly = true;
            this.cNguyenlieu.Width = 190;
            // 
            // cSoluong
            // 
            this.cSoluong.DataPropertyName = "soluong";
            this.cSoluong.FillWeight = 52.11507F;
            this.cSoluong.HeaderText = "Số lượng";
            this.cSoluong.Name = "cSoluong";
            this.cSoluong.ReadOnly = true;
            this.cSoluong.Width = 120;
            // 
            // cThoidiem
            // 
            this.cThoidiem.DataPropertyName = "thoidiem";
            this.cThoidiem.FillWeight = 52.11507F;
            this.cThoidiem.HeaderText = "Ngày nhập";
            this.cThoidiem.Name = "cThoidiem";
            this.cThoidiem.ReadOnly = true;
            this.cThoidiem.Width = 160;
            // 
            // cThanhtien
            // 
            this.cThanhtien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cThanhtien.DataPropertyName = "thanhtien";
            this.cThanhtien.FillWeight = 52.11507F;
            this.cThanhtien.HeaderText = "Thành tiền";
            this.cThanhtien.Name = "cThanhtien";
            this.cThanhtien.ReadOnly = true;
            // 
            // cManguyenlieu
            // 
            this.cManguyenlieu.DataPropertyName = "ma_nguyenlieu";
            this.cManguyenlieu.HeaderText = "Mã nguyên liệu";
            this.cManguyenlieu.Name = "cManguyenlieu";
            this.cManguyenlieu.ReadOnly = true;
            this.cManguyenlieu.Visible = false;
            // 
            // cDongia
            // 
            this.cDongia.DataPropertyName = "dongia";
            this.cDongia.HeaderText = "Đơn giá";
            this.cDongia.Name = "cDongia";
            this.cDongia.ReadOnly = true;
            this.cDongia.Visible = false;
            // 
            // frmImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 534);
            this.Controls.Add(this.grdNhaphang);
            this.Controls.Add(this.btnEditNV);
            this.Controls.Add(this.btnAddNV);
            this.Controls.Add(this.txtSoluong);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtThoidiem);
            this.Controls.Add(this.cbNguyenlieu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmImport";
            this.Text = "Nhập hàng";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmImport_FormClosed);
            this.Load += new System.EventHandler(this.frmImport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdNhaphang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grdNhaphang;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEditNV;
        private System.Windows.Forms.Button btnAddNV;
        private System.Windows.Forms.TextBox txtSoluong;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtThoidiem;
        private System.Windows.Forms.ComboBox cbNguyenlieu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIdnhaphang;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNguyenlieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSoluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn cThoidiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn cThanhtien;
        private System.Windows.Forms.DataGridViewTextBoxColumn cManguyenlieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDongia;
    }
}