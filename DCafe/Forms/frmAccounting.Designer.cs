namespace DCafe
{
    partial class frmAccounting
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAccounting));
            this.tabTongthu = new System.Windows.Forms.TabPage();
            this.btnInThu = new System.Windows.Forms.Button();
            this.btnTimThu = new System.Windows.Forms.Button();
            this.grdTongThu = new System.Windows.Forms.DataGridView();
            this.cMahoadon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cThoidiemThu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cThanhtienThu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTongThu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtEndThu = new System.Windows.Forms.DateTimePicker();
            this.dtStartThu = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabTongchi = new System.Windows.Forms.TabPage();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.grdTongchi = new System.Windows.Forms.DataGridView();
            this.cManguyenlieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTennguyenlieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSoluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDongia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cThanhtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rbnBanra = new System.Windows.Forms.RadioButton();
            this.txtTongchi = new System.Windows.Forms.TextBox();
            this.rbnNhapvao = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.chkTenhang = new System.Windows.Forms.CheckBox();
            this.dtEnd = new System.Windows.Forms.DateTimePicker();
            this.cbNguyenlieu = new System.Windows.Forms.ComboBox();
            this.dtStart = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabKinhdoanh = new System.Windows.Forms.TabControl();
            this.tabTongthu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTongThu)).BeginInit();
            this.tabTongchi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTongchi)).BeginInit();
            this.tabKinhdoanh.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabTongthu
            // 
            this.tabTongthu.Controls.Add(this.btnInThu);
            this.tabTongthu.Controls.Add(this.btnTimThu);
            this.tabTongthu.Controls.Add(this.grdTongThu);
            this.tabTongthu.Controls.Add(this.txtTongThu);
            this.tabTongthu.Controls.Add(this.label4);
            this.tabTongthu.Controls.Add(this.dtEndThu);
            this.tabTongthu.Controls.Add(this.dtStartThu);
            this.tabTongthu.Controls.Add(this.label5);
            this.tabTongthu.Controls.Add(this.label7);
            this.tabTongthu.Controls.Add(this.label8);
            this.tabTongthu.Location = new System.Drawing.Point(4, 25);
            this.tabTongthu.Name = "tabTongthu";
            this.tabTongthu.Padding = new System.Windows.Forms.Padding(3);
            this.tabTongthu.Size = new System.Drawing.Size(915, 509);
            this.tabTongthu.TabIndex = 1;
            this.tabTongthu.Text = "Doanh thu";
            this.tabTongthu.UseVisualStyleBackColor = true;
            // 
            // btnInThu
            // 
            this.btnInThu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInThu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnInThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnInThu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnInThu.Location = new System.Drawing.Point(834, 475);
            this.btnInThu.Name = "btnInThu";
            this.btnInThu.Size = new System.Drawing.Size(75, 27);
            this.btnInThu.TabIndex = 115;
            this.btnInThu.Text = "In";
            this.btnInThu.UseVisualStyleBackColor = false;
            this.btnInThu.Click += new System.EventHandler(this.btnInThu_Click);
            // 
            // btnTimThu
            // 
            this.btnTimThu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnTimThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnTimThu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnTimThu.Location = new System.Drawing.Point(14, 161);
            this.btnTimThu.Name = "btnTimThu";
            this.btnTimThu.Size = new System.Drawing.Size(75, 27);
            this.btnTimThu.TabIndex = 114;
            this.btnTimThu.Text = "Tìm";
            this.btnTimThu.UseVisualStyleBackColor = false;
            this.btnTimThu.Click += new System.EventHandler(this.btnTimThu_Click);
            // 
            // grdTongThu
            // 
            this.grdTongThu.AllowUserToAddRows = false;
            this.grdTongThu.AllowUserToDeleteRows = false;
            this.grdTongThu.AllowUserToResizeColumns = false;
            this.grdTongThu.AllowUserToResizeRows = false;
            this.grdTongThu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grdTongThu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdTongThu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grdTongThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTongThu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cMahoadon,
            this.cThoidiemThu,
            this.cThanhtienThu});
            this.grdTongThu.Location = new System.Drawing.Point(262, 41);
            this.grdTongThu.Name = "grdTongThu";
            this.grdTongThu.RowHeadersVisible = false;
            this.grdTongThu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdTongThu.Size = new System.Drawing.Size(647, 385);
            this.grdTongThu.TabIndex = 102;
            this.grdTongThu.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdTongThu_CellDoubleClick);
            // 
            // cMahoadon
            // 
            this.cMahoadon.DataPropertyName = "ma_hd";
            this.cMahoadon.HeaderText = "Mã hóa đơn";
            this.cMahoadon.Name = "cMahoadon";
            // 
            // cThoidiemThu
            // 
            this.cThoidiemThu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cThoidiemThu.DataPropertyName = "thoidiem";
            this.cThoidiemThu.HeaderText = "Thời điểm";
            this.cThoidiemThu.Name = "cThoidiemThu";
            // 
            // cThanhtienThu
            // 
            this.cThanhtienThu.DataPropertyName = "thanhtien";
            dataGridViewCellStyle1.Format = "N0";
            this.cThanhtienThu.DefaultCellStyle = dataGridViewCellStyle1;
            this.cThanhtienThu.HeaderText = "Thành tiền";
            this.cThanhtienThu.Name = "cThanhtienThu";
            // 
            // txtTongThu
            // 
            this.txtTongThu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTongThu.Enabled = false;
            this.txtTongThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTongThu.Location = new System.Drawing.Point(704, 441);
            this.txtTongThu.Name = "txtTongThu";
            this.txtTongThu.Size = new System.Drawing.Size(205, 27);
            this.txtTongThu.TabIndex = 105;
            this.txtTongThu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(629, 444);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 104;
            this.label4.Text = "Tổng thu";
            // 
            // dtEndThu
            // 
            this.dtEndThu.CustomFormat = "dd/MM/yyyy";
            this.dtEndThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dtEndThu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtEndThu.Location = new System.Drawing.Point(14, 115);
            this.dtEndThu.Name = "dtEndThu";
            this.dtEndThu.Size = new System.Drawing.Size(167, 26);
            this.dtEndThu.TabIndex = 109;
            // 
            // dtStartThu
            // 
            this.dtStartThu.CustomFormat = "dd/MM/yyyy";
            this.dtStartThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dtStartThu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtStartThu.Location = new System.Drawing.Point(15, 61);
            this.dtStartThu.Name = "dtStartThu";
            this.dtStartThu.Size = new System.Drawing.Size(166, 26);
            this.dtStartThu.TabIndex = 108;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(11, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 20);
            this.label5.TabIndex = 107;
            this.label5.Text = "Từ ngày...";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(11, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 20);
            this.label7.TabIndex = 106;
            this.label7.Text = "Đến...";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label8.Location = new System.Drawing.Point(349, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(306, 31);
            this.label8.TabIndex = 103;
            this.label8.Text = "THỐNG KÊ TỔNG THU";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tabTongchi
            // 
            this.tabTongchi.Controls.Add(this.btnIn);
            this.tabTongchi.Controls.Add(this.btnTim);
            this.tabTongchi.Controls.Add(this.grdTongchi);
            this.tabTongchi.Controls.Add(this.rbnBanra);
            this.tabTongchi.Controls.Add(this.txtTongchi);
            this.tabTongchi.Controls.Add(this.rbnNhapvao);
            this.tabTongchi.Controls.Add(this.label3);
            this.tabTongchi.Controls.Add(this.chkTenhang);
            this.tabTongchi.Controls.Add(this.dtEnd);
            this.tabTongchi.Controls.Add(this.cbNguyenlieu);
            this.tabTongchi.Controls.Add(this.dtStart);
            this.tabTongchi.Controls.Add(this.label6);
            this.tabTongchi.Controls.Add(this.label2);
            this.tabTongchi.Controls.Add(this.label1);
            this.tabTongchi.Location = new System.Drawing.Point(4, 25);
            this.tabTongchi.Name = "tabTongchi";
            this.tabTongchi.Padding = new System.Windows.Forms.Padding(3);
            this.tabTongchi.Size = new System.Drawing.Size(915, 509);
            this.tabTongchi.TabIndex = 0;
            this.tabTongchi.Text = "Tổng chi";
            this.tabTongchi.UseVisualStyleBackColor = true;
            // 
            // btnIn
            // 
            this.btnIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnIn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnIn.Location = new System.Drawing.Point(834, 475);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(75, 27);
            this.btnIn.TabIndex = 101;
            this.btnIn.Text = "In";
            this.btnIn.UseVisualStyleBackColor = false;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnTim
            // 
            this.btnTim.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnTim.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnTim.Location = new System.Drawing.Point(14, 259);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 27);
            this.btnTim.TabIndex = 100;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = false;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // grdTongchi
            // 
            this.grdTongchi.AllowUserToAddRows = false;
            this.grdTongchi.AllowUserToDeleteRows = false;
            this.grdTongchi.AllowUserToResizeColumns = false;
            this.grdTongchi.AllowUserToResizeRows = false;
            this.grdTongchi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grdTongchi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdTongchi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grdTongchi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTongchi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cManguyenlieu,
            this.cTennguyenlieu,
            this.cSoluong,
            this.cDongia,
            this.cThanhtien});
            this.grdTongchi.Location = new System.Drawing.Point(262, 41);
            this.grdTongchi.Name = "grdTongchi";
            this.grdTongchi.RowHeadersVisible = false;
            this.grdTongchi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdTongchi.Size = new System.Drawing.Size(647, 385);
            this.grdTongchi.TabIndex = 0;
            // 
            // cManguyenlieu
            // 
            this.cManguyenlieu.DataPropertyName = "ma_nguyenlieu";
            this.cManguyenlieu.HeaderText = "Mã nguyên liệu";
            this.cManguyenlieu.Name = "cManguyenlieu";
            this.cManguyenlieu.Visible = false;
            // 
            // cTennguyenlieu
            // 
            this.cTennguyenlieu.DataPropertyName = "ten_nguyenlieu";
            this.cTennguyenlieu.HeaderText = "Nguyên liệu";
            this.cTennguyenlieu.Name = "cTennguyenlieu";
            // 
            // cSoluong
            // 
            this.cSoluong.DataPropertyName = "soluong";
            this.cSoluong.HeaderText = "Số lượng";
            this.cSoluong.Name = "cSoluong";
            // 
            // cDongia
            // 
            this.cDongia.DataPropertyName = "dongia";
            this.cDongia.HeaderText = "Đơn giá";
            this.cDongia.Name = "cDongia";
            this.cDongia.Visible = false;
            // 
            // cThanhtien
            // 
            this.cThanhtien.DataPropertyName = "thanhtien";
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            this.cThanhtien.DefaultCellStyle = dataGridViewCellStyle2;
            this.cThanhtien.HeaderText = "Thành tiền";
            this.cThanhtien.Name = "cThanhtien";
            // 
            // rbnBanra
            // 
            this.rbnBanra.AutoSize = true;
            this.rbnBanra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rbnBanra.Location = new System.Drawing.Point(14, 220);
            this.rbnBanra.Name = "rbnBanra";
            this.rbnBanra.Size = new System.Drawing.Size(108, 24);
            this.rbnBanra.TabIndex = 99;
            this.rbnBanra.TabStop = true;
            this.rbnBanra.Text = "Trên bán ra";
            this.rbnBanra.UseVisualStyleBackColor = true;
            // 
            // txtTongchi
            // 
            this.txtTongchi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTongchi.Enabled = false;
            this.txtTongchi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTongchi.Location = new System.Drawing.Point(704, 441);
            this.txtTongchi.Name = "txtTongchi";
            this.txtTongchi.Size = new System.Drawing.Size(205, 27);
            this.txtTongchi.TabIndex = 76;
            this.txtTongchi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // rbnNhapvao
            // 
            this.rbnNhapvao.AutoSize = true;
            this.rbnNhapvao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rbnNhapvao.Location = new System.Drawing.Point(128, 220);
            this.rbnNhapvao.Name = "rbnNhapvao";
            this.rbnNhapvao.Size = new System.Drawing.Size(128, 24);
            this.rbnNhapvao.TabIndex = 99;
            this.rbnNhapvao.TabStop = true;
            this.rbnNhapvao.Text = "Trên nhập vào";
            this.rbnNhapvao.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(629, 444);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 75;
            this.label3.Text = "Tổng chi";
            // 
            // chkTenhang
            // 
            this.chkTenhang.AutoSize = true;
            this.chkTenhang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.chkTenhang.Location = new System.Drawing.Point(14, 155);
            this.chkTenhang.Name = "chkTenhang";
            this.chkTenhang.Size = new System.Drawing.Size(120, 24);
            this.chkTenhang.TabIndex = 98;
            this.chkTenhang.Text = "Tìm tên hàng";
            this.chkTenhang.UseVisualStyleBackColor = true;
            this.chkTenhang.CheckedChanged += new System.EventHandler(this.chkTenhang_CheckedChanged);
            // 
            // dtEnd
            // 
            this.dtEnd.CustomFormat = "dd/MM/yyyy";
            this.dtEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dtEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtEnd.Location = new System.Drawing.Point(14, 115);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.Size = new System.Drawing.Size(167, 26);
            this.dtEnd.TabIndex = 92;
            // 
            // cbNguyenlieu
            // 
            this.cbNguyenlieu.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbNguyenlieu.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbNguyenlieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbNguyenlieu.FormattingEnabled = true;
            this.cbNguyenlieu.Location = new System.Drawing.Point(14, 181);
            this.cbNguyenlieu.Name = "cbNguyenlieu";
            this.cbNguyenlieu.Size = new System.Drawing.Size(167, 28);
            this.cbNguyenlieu.TabIndex = 97;
            // 
            // dtStart
            // 
            this.dtStart.CustomFormat = "dd/MM/yyyy";
            this.dtStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dtStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtStart.Location = new System.Drawing.Point(15, 61);
            this.dtStart.Name = "dtStart";
            this.dtStart.Size = new System.Drawing.Size(166, 26);
            this.dtStart.TabIndex = 91;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(11, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 20);
            this.label6.TabIndex = 90;
            this.label6.Text = "Từ ngày...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(11, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 90;
            this.label2.Text = "Đến...";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(349, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 31);
            this.label1.TabIndex = 65;
            this.label1.Text = "THỐNG KÊ TỔNG CHI";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tabKinhdoanh
            // 
            this.tabKinhdoanh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabKinhdoanh.Controls.Add(this.tabTongchi);
            this.tabKinhdoanh.Controls.Add(this.tabTongthu);
            this.tabKinhdoanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabKinhdoanh.Location = new System.Drawing.Point(1, 1);
            this.tabKinhdoanh.Name = "tabKinhdoanh";
            this.tabKinhdoanh.SelectedIndex = 0;
            this.tabKinhdoanh.Size = new System.Drawing.Size(923, 538);
            this.tabKinhdoanh.TabIndex = 1;
            // 
            // frmAccounting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 540);
            this.Controls.Add(this.tabKinhdoanh);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAccounting";
            this.Text = "Kinh doanh";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAccounting_FormClosed);
            this.Load += new System.EventHandler(this.frmAccounting_Load);
            this.tabTongthu.ResumeLayout(false);
            this.tabTongthu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTongThu)).EndInit();
            this.tabTongchi.ResumeLayout(false);
            this.tabTongchi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTongchi)).EndInit();
            this.tabKinhdoanh.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabTongthu;
        private System.Windows.Forms.TabPage tabTongchi;
        private System.Windows.Forms.TextBox txtTongchi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView grdTongchi;
        private System.Windows.Forms.DateTimePicker dtEnd;
        private System.Windows.Forms.ComboBox cbNguyenlieu;
        private System.Windows.Forms.DateTimePicker dtStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabKinhdoanh;
        private System.Windows.Forms.RadioButton rbnBanra;
        private System.Windows.Forms.RadioButton rbnNhapvao;
        private System.Windows.Forms.CheckBox chkTenhang;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnInThu;
        private System.Windows.Forms.Button btnTimThu;
        private System.Windows.Forms.DataGridView grdTongThu;
        private System.Windows.Forms.TextBox txtTongThu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtEndThu;
        private System.Windows.Forms.DateTimePicker dtStartThu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMahoadon;
        private System.Windows.Forms.DataGridViewTextBoxColumn cThoidiemThu;
        private System.Windows.Forms.DataGridViewTextBoxColumn cThanhtienThu;
        private System.Windows.Forms.DataGridViewTextBoxColumn cManguyenlieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTennguyenlieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSoluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDongia;
        private System.Windows.Forms.DataGridViewTextBoxColumn cThanhtien;

    }
}