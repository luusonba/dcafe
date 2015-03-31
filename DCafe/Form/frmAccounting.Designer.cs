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
            this.tab_dthu = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.tongthu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.cmb_ncc2 = new System.Windows.Forms.ComboBox();
            this.cmb_loai_hang2 = new System.Windows.Forms.ComboBox();
            this.cmb_ten_hang2 = new System.Windows.Forms.ComboBox();
            this.radioButton_Nha_cung_cap2 = new System.Windows.Forms.RadioButton();
            this.radioButton_loai_Hang2 = new System.Windows.Forms.RadioButton();
            this.radioButton_Ten_hang2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.btn_TK_DThu = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView_doanh_thu = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cmb_nam2 = new System.Windows.Forms.ComboBox();
            this.cmb_Quy2 = new System.Windows.Forms.ComboBox();
            this.cmb_Thang2 = new System.Windows.Forms.ComboBox();
            this.radioButton_Thang2 = new System.Windows.Forms.RadioButton();
            this.radioButton_Nam2 = new System.Windows.Forms.RadioButton();
            this.radioButton_quy2 = new System.Windows.Forms.RadioButton();
            this.radioButton_tat_ca = new System.Windows.Forms.RadioButton();
            this.tab_chiphi = new System.Windows.Forms.TabPage();
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
            this.tab_lnhuan = new System.Windows.Forms.TabControl();
            this.tab_dthu.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_doanh_thu)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.tab_chiphi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTongchi)).BeginInit();
            this.tab_lnhuan.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab_dthu
            // 
            this.tab_dthu.Controls.Add(this.label5);
            this.tab_dthu.Controls.Add(this.tongthu);
            this.tab_dthu.Controls.Add(this.label4);
            this.tab_dthu.Controls.Add(this.groupBox6);
            this.tab_dthu.Controls.Add(this.btn_Thoat);
            this.tab_dthu.Controls.Add(this.btn_TK_DThu);
            this.tab_dthu.Controls.Add(this.groupBox4);
            this.tab_dthu.Controls.Add(this.groupBox5);
            this.tab_dthu.Location = new System.Drawing.Point(4, 25);
            this.tab_dthu.Name = "tab_dthu";
            this.tab_dthu.Padding = new System.Windows.Forms.Padding(3);
            this.tab_dthu.Size = new System.Drawing.Size(915, 509);
            this.tab_dthu.TabIndex = 1;
            this.tab_dthu.Text = "Doanh thu";
            this.tab_dthu.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(343, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(251, 25);
            this.label5.TabIndex = 84;
            this.label5.Text = "THỐNG KÊ DOANH THU\r\n";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tongthu
            // 
            this.tongthu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tongthu.Enabled = false;
            this.tongthu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tongthu.Location = new System.Drawing.Point(706, 435);
            this.tongthu.Name = "tongthu";
            this.tongthu.Size = new System.Drawing.Size(203, 27);
            this.tongthu.TabIndex = 83;
            this.tongthu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(617, 439);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 82;
            this.label4.Text = "Tổng thu";
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox6.Controls.Add(this.cmb_ncc2);
            this.groupBox6.Controls.Add(this.cmb_loai_hang2);
            this.groupBox6.Controls.Add(this.cmb_ten_hang2);
            this.groupBox6.Controls.Add(this.radioButton_Nha_cung_cap2);
            this.groupBox6.Controls.Add(this.radioButton_loai_Hang2);
            this.groupBox6.Controls.Add(this.radioButton_Ten_hang2);
            this.groupBox6.Controls.Add(this.radioButton1);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(14, 48);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(180, 203);
            this.groupBox6.TabIndex = 81;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Tiêu chí";
            // 
            // cmb_ncc2
            // 
            this.cmb_ncc2.FormattingEnabled = true;
            this.cmb_ncc2.Location = new System.Drawing.Point(39, 175);
            this.cmb_ncc2.Name = "cmb_ncc2";
            this.cmb_ncc2.Size = new System.Drawing.Size(97, 21);
            this.cmb_ncc2.TabIndex = 99;
            // 
            // cmb_loai_hang2
            // 
            this.cmb_loai_hang2.FormattingEnabled = true;
            this.cmb_loai_hang2.Location = new System.Drawing.Point(39, 126);
            this.cmb_loai_hang2.Name = "cmb_loai_hang2";
            this.cmb_loai_hang2.Size = new System.Drawing.Size(97, 21);
            this.cmb_loai_hang2.TabIndex = 98;
            // 
            // cmb_ten_hang2
            // 
            this.cmb_ten_hang2.FormattingEnabled = true;
            this.cmb_ten_hang2.Location = new System.Drawing.Point(39, 76);
            this.cmb_ten_hang2.Name = "cmb_ten_hang2";
            this.cmb_ten_hang2.Size = new System.Drawing.Size(97, 21);
            this.cmb_ten_hang2.TabIndex = 97;
            // 
            // radioButton_Nha_cung_cap2
            // 
            this.radioButton_Nha_cung_cap2.AutoSize = true;
            this.radioButton_Nha_cung_cap2.Location = new System.Drawing.Point(17, 155);
            this.radioButton_Nha_cung_cap2.Name = "radioButton_Nha_cung_cap2";
            this.radioButton_Nha_cung_cap2.Size = new System.Drawing.Size(105, 17);
            this.radioButton_Nha_cung_cap2.TabIndex = 81;
            this.radioButton_Nha_cung_cap2.Text = "Nhà cung cấp";
            this.radioButton_Nha_cung_cap2.UseVisualStyleBackColor = true;
            // 
            // radioButton_loai_Hang2
            // 
            this.radioButton_loai_Hang2.AutoSize = true;
            this.radioButton_loai_Hang2.Location = new System.Drawing.Point(18, 103);
            this.radioButton_loai_Hang2.Name = "radioButton_loai_Hang2";
            this.radioButton_loai_Hang2.Size = new System.Drawing.Size(81, 17);
            this.radioButton_loai_Hang2.TabIndex = 80;
            this.radioButton_loai_Hang2.Text = "Loại hàng";
            this.radioButton_loai_Hang2.UseVisualStyleBackColor = true;
            // 
            // radioButton_Ten_hang2
            // 
            this.radioButton_Ten_hang2.AutoSize = true;
            this.radioButton_Ten_hang2.Location = new System.Drawing.Point(19, 56);
            this.radioButton_Ten_hang2.Name = "radioButton_Ten_hang2";
            this.radioButton_Ten_hang2.Size = new System.Drawing.Size(79, 17);
            this.radioButton_Ten_hang2.TabIndex = 79;
            this.radioButton_Ten_hang2.Text = "Tên hàng";
            this.radioButton_Ten_hang2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(17, 29);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(62, 17);
            this.radioButton1.TabIndex = 82;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Tất cả";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Thoat.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_Thoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Thoat.Location = new System.Drawing.Point(285, 437);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(75, 46);
            this.btn_Thoat.TabIndex = 80;
            this.btn_Thoat.Text = "Thoát\r\nEsc";
            this.btn_Thoat.UseVisualStyleBackColor = false;
            // 
            // btn_TK_DThu
            // 
            this.btn_TK_DThu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_TK_DThu.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_TK_DThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TK_DThu.Location = new System.Drawing.Point(204, 438);
            this.btn_TK_DThu.Name = "btn_TK_DThu";
            this.btn_TK_DThu.Size = new System.Drawing.Size(75, 45);
            this.btn_TK_DThu.TabIndex = 79;
            this.btn_TK_DThu.Text = "Thống kê\r\nEnter";
            this.btn_TK_DThu.UseVisualStyleBackColor = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.dataGridView_doanh_thu);
            this.groupBox4.Location = new System.Drawing.Point(200, 46);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(712, 382);
            this.groupBox4.TabIndex = 78;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Danh sách";
            // 
            // dataGridView_doanh_thu
            // 
            this.dataGridView_doanh_thu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_doanh_thu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_doanh_thu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_doanh_thu.Location = new System.Drawing.Point(6, 13);
            this.dataGridView_doanh_thu.Name = "dataGridView_doanh_thu";
            this.dataGridView_doanh_thu.Size = new System.Drawing.Size(706, 363);
            this.dataGridView_doanh_thu.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox5.Controls.Add(this.cmb_nam2);
            this.groupBox5.Controls.Add(this.cmb_Quy2);
            this.groupBox5.Controls.Add(this.cmb_Thang2);
            this.groupBox5.Controls.Add(this.radioButton_Thang2);
            this.groupBox5.Controls.Add(this.radioButton_Nam2);
            this.groupBox5.Controls.Add(this.radioButton_quy2);
            this.groupBox5.Controls.Add(this.radioButton_tat_ca);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(14, 266);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(180, 217);
            this.groupBox5.TabIndex = 77;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Thời gian";
            // 
            // cmb_nam2
            // 
            this.cmb_nam2.FormattingEnabled = true;
            this.cmb_nam2.Items.AddRange(new object[] {
            "2008",
            "2009",
            "2010",
            "2011",
            "2012"});
            this.cmb_nam2.Location = new System.Drawing.Point(39, 153);
            this.cmb_nam2.Name = "cmb_nam2";
            this.cmb_nam2.Size = new System.Drawing.Size(97, 21);
            this.cmb_nam2.TabIndex = 95;
            // 
            // cmb_Quy2
            // 
            this.cmb_Quy2.FormattingEnabled = true;
            this.cmb_Quy2.Items.AddRange(new object[] {
            "I",
            "II",
            "III",
            "IV"});
            this.cmb_Quy2.Location = new System.Drawing.Point(39, 115);
            this.cmb_Quy2.Name = "cmb_Quy2";
            this.cmb_Quy2.Size = new System.Drawing.Size(97, 21);
            this.cmb_Quy2.TabIndex = 94;
            // 
            // cmb_Thang2
            // 
            this.cmb_Thang2.FormattingEnabled = true;
            this.cmb_Thang2.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cmb_Thang2.Location = new System.Drawing.Point(39, 65);
            this.cmb_Thang2.Name = "cmb_Thang2";
            this.cmb_Thang2.Size = new System.Drawing.Size(97, 21);
            this.cmb_Thang2.TabIndex = 93;
            // 
            // radioButton_Thang2
            // 
            this.radioButton_Thang2.AutoSize = true;
            this.radioButton_Thang2.Location = new System.Drawing.Point(17, 42);
            this.radioButton_Thang2.Name = "radioButton_Thang2";
            this.radioButton_Thang2.Size = new System.Drawing.Size(90, 17);
            this.radioButton_Thang2.TabIndex = 86;
            this.radioButton_Thang2.Text = "Theo tháng";
            this.radioButton_Thang2.UseVisualStyleBackColor = true;
            // 
            // radioButton_Nam2
            // 
            this.radioButton_Nam2.AutoSize = true;
            this.radioButton_Nam2.Location = new System.Drawing.Point(15, 134);
            this.radioButton_Nam2.Name = "radioButton_Nam2";
            this.radioButton_Nam2.Size = new System.Drawing.Size(81, 17);
            this.radioButton_Nam2.TabIndex = 84;
            this.radioButton_Nam2.Text = "Theo năm";
            this.radioButton_Nam2.UseVisualStyleBackColor = true;
            // 
            // radioButton_quy2
            // 
            this.radioButton_quy2.AutoSize = true;
            this.radioButton_quy2.Location = new System.Drawing.Point(18, 92);
            this.radioButton_quy2.Name = "radioButton_quy2";
            this.radioButton_quy2.Size = new System.Drawing.Size(78, 17);
            this.radioButton_quy2.TabIndex = 83;
            this.radioButton_quy2.Text = "Theo quý";
            this.radioButton_quy2.UseVisualStyleBackColor = true;
            // 
            // radioButton_tat_ca
            // 
            this.radioButton_tat_ca.AutoSize = true;
            this.radioButton_tat_ca.Checked = true;
            this.radioButton_tat_ca.Location = new System.Drawing.Point(17, 19);
            this.radioButton_tat_ca.Name = "radioButton_tat_ca";
            this.radioButton_tat_ca.Size = new System.Drawing.Size(62, 17);
            this.radioButton_tat_ca.TabIndex = 82;
            this.radioButton_tat_ca.TabStop = true;
            this.radioButton_tat_ca.Text = "Tất cả";
            this.radioButton_tat_ca.UseVisualStyleBackColor = true;
            // 
            // tab_chiphi
            // 
            this.tab_chiphi.Controls.Add(this.btnIn);
            this.tab_chiphi.Controls.Add(this.btnTim);
            this.tab_chiphi.Controls.Add(this.grdTongchi);
            this.tab_chiphi.Controls.Add(this.rbnBanra);
            this.tab_chiphi.Controls.Add(this.txtTongchi);
            this.tab_chiphi.Controls.Add(this.rbnNhapvao);
            this.tab_chiphi.Controls.Add(this.label3);
            this.tab_chiphi.Controls.Add(this.chkTenhang);
            this.tab_chiphi.Controls.Add(this.dtEnd);
            this.tab_chiphi.Controls.Add(this.cbNguyenlieu);
            this.tab_chiphi.Controls.Add(this.dtStart);
            this.tab_chiphi.Controls.Add(this.label6);
            this.tab_chiphi.Controls.Add(this.label2);
            this.tab_chiphi.Controls.Add(this.label1);
            this.tab_chiphi.Location = new System.Drawing.Point(4, 25);
            this.tab_chiphi.Name = "tab_chiphi";
            this.tab_chiphi.Padding = new System.Windows.Forms.Padding(3);
            this.tab_chiphi.Size = new System.Drawing.Size(915, 509);
            this.tab_chiphi.TabIndex = 0;
            this.tab_chiphi.Text = "Tổng chi";
            this.tab_chiphi.UseVisualStyleBackColor = true;
            // 
            // btnIn
            // 
            this.btnIn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnIn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnIn.Location = new System.Drawing.Point(834, 475);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(75, 27);
            this.btnIn.TabIndex = 101;
            this.btnIn.Text = "In";
            this.btnIn.UseVisualStyleBackColor = false;
            // 
            // btnTim
            // 
            this.btnTim.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnTim.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnTim.Location = new System.Drawing.Point(15, 260);
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
            // tab_lnhuan
            // 
            this.tab_lnhuan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tab_lnhuan.Controls.Add(this.tab_chiphi);
            this.tab_lnhuan.Controls.Add(this.tab_dthu);
            this.tab_lnhuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab_lnhuan.Location = new System.Drawing.Point(1, 1);
            this.tab_lnhuan.Name = "tab_lnhuan";
            this.tab_lnhuan.SelectedIndex = 0;
            this.tab_lnhuan.Size = new System.Drawing.Size(923, 538);
            this.tab_lnhuan.TabIndex = 1;
            // 
            // frmAccounting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 540);
            this.Controls.Add(this.tab_lnhuan);
            this.Name = "frmAccounting";
            this.Text = "frmAccounting";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAccounting_FormClosed);
            this.Load += new System.EventHandler(this.frmAccounting_Load);
            this.tab_dthu.ResumeLayout(false);
            this.tab_dthu.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_doanh_thu)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.tab_chiphi.ResumeLayout(false);
            this.tab_chiphi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTongchi)).EndInit();
            this.tab_lnhuan.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tab_dthu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tongthu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ComboBox cmb_ncc2;
        private System.Windows.Forms.ComboBox cmb_loai_hang2;
        private System.Windows.Forms.ComboBox cmb_ten_hang2;
        private System.Windows.Forms.RadioButton radioButton_Nha_cung_cap2;
        private System.Windows.Forms.RadioButton radioButton_loai_Hang2;
        private System.Windows.Forms.RadioButton radioButton_Ten_hang2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button btn_TK_DThu;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView_doanh_thu;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox cmb_nam2;
        private System.Windows.Forms.ComboBox cmb_Quy2;
        private System.Windows.Forms.ComboBox cmb_Thang2;
        private System.Windows.Forms.RadioButton radioButton_Thang2;
        private System.Windows.Forms.RadioButton radioButton_Nam2;
        private System.Windows.Forms.RadioButton radioButton_quy2;
        private System.Windows.Forms.RadioButton radioButton_tat_ca;
        private System.Windows.Forms.TabPage tab_chiphi;
        private System.Windows.Forms.TextBox txtTongchi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView grdTongchi;
        private System.Windows.Forms.DateTimePicker dtEnd;
        private System.Windows.Forms.ComboBox cbNguyenlieu;
        private System.Windows.Forms.DateTimePicker dtStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tab_lnhuan;
        private System.Windows.Forms.RadioButton rbnBanra;
        private System.Windows.Forms.RadioButton rbnNhapvao;
        private System.Windows.Forms.CheckBox chkTenhang;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.DataGridViewTextBoxColumn cManguyenlieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTennguyenlieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSoluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDongia;
        private System.Windows.Forms.DataGridViewTextBoxColumn cThanhtien;

    }
}