namespace DCafe
{
    partial class frmSupport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSupport));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grdDsKhuvuc = new System.Windows.Forms.DataGridView();
            this.MKV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TKV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPages = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTen_kv = new System.Windows.Forms.TextBox();
            this.txtMa_kv = new System.Windows.Forms.TextBox();
            this.lblTen_nv = new System.Windows.Forms.Label();
            this.lblManv = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.grdDsBan = new System.Windows.Forms.DataGridView();
            this.MB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cbKhuvuc = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnXoaban = new System.Windows.Forms.Button();
            this.btnThemban = new System.Windows.Forms.Button();
            this.txtTenban = new System.Windows.Forms.TextBox();
            this.txtMaban = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtLoaiDV = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTenDV = new System.Windows.Forms.TextBox();
            this.txtMaDV = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.grdDsDonvi = new System.Windows.Forms.DataGridView();
            this.MADV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDsKhuvuc)).BeginInit();
            this.tabPages.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDsBan)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDsDonvi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(308, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 24);
            this.label1.TabIndex = 71;
            this.label1.Text = "QUẢN LÝ KHU VỰC";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.grdDsKhuvuc);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox2.Location = new System.Drawing.Point(265, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(540, 315);
            this.groupBox2.TabIndex = 75;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách ";
            // 
            // grdDsKhuvuc
            // 
            this.grdDsKhuvuc.AllowUserToAddRows = false;
            this.grdDsKhuvuc.AllowUserToDeleteRows = false;
            this.grdDsKhuvuc.AllowUserToResizeColumns = false;
            this.grdDsKhuvuc.AllowUserToResizeRows = false;
            this.grdDsKhuvuc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grdDsKhuvuc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdDsKhuvuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDsKhuvuc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MKV,
            this.TKV});
            this.grdDsKhuvuc.Location = new System.Drawing.Point(6, 19);
            this.grdDsKhuvuc.Name = "grdDsKhuvuc";
            this.grdDsKhuvuc.ReadOnly = true;
            this.grdDsKhuvuc.RowHeadersVisible = false;
            this.grdDsKhuvuc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdDsKhuvuc.Size = new System.Drawing.Size(528, 290);
            this.grdDsKhuvuc.TabIndex = 5;
            this.grdDsKhuvuc.SelectionChanged += new System.EventHandler(this.grdDsKhuvuc_SelectionChanged);
            // 
            // MKV
            // 
            this.MKV.DataPropertyName = "ma_kv";
            this.MKV.HeaderText = "Mã khu vực";
            this.MKV.Name = "MKV";
            this.MKV.ReadOnly = true;
            // 
            // TKV
            // 
            this.TKV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TKV.DataPropertyName = "ten_kv";
            this.TKV.HeaderText = "Tên khu vực";
            this.TKV.Name = "TKV";
            this.TKV.ReadOnly = true;
            // 
            // tabPages
            // 
            this.tabPages.Controls.Add(this.tabPage2);
            this.tabPages.Controls.Add(this.tabPage1);
            this.tabPages.Controls.Add(this.tabPage3);
            this.tabPages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPages.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tabPages.Location = new System.Drawing.Point(0, 0);
            this.tabPages.Name = "tabPages";
            this.tabPages.SelectedIndex = 0;
            this.tabPages.Size = new System.Drawing.Size(821, 375);
            this.tabPages.TabIndex = 6;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(813, 342);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Khu vực";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.txtTen_kv);
            this.groupBox1.Controls.Add(this.txtMa_kv);
            this.groupBox1.Controls.Add(this.lblTen_nv);
            this.groupBox1.Controls.Add(this.lblManv);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btn_them);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox1.Location = new System.Drawing.Point(0, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(263, 311);
            this.groupBox1.TabIndex = 74;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi tiết ";
            // 
            // txtTen_kv
            // 
            this.txtTen_kv.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTen_kv.Location = new System.Drawing.Point(101, 53);
            this.txtTen_kv.Name = "txtTen_kv";
            this.txtTen_kv.Size = new System.Drawing.Size(156, 26);
            this.txtTen_kv.TabIndex = 80;
            // 
            // txtMa_kv
            // 
            this.txtMa_kv.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtMa_kv.Location = new System.Drawing.Point(101, 19);
            this.txtMa_kv.Name = "txtMa_kv";
            this.txtMa_kv.Size = new System.Drawing.Size(156, 26);
            this.txtMa_kv.TabIndex = 79;
            // 
            // lblTen_nv
            // 
            this.lblTen_nv.AutoSize = true;
            this.lblTen_nv.BackColor = System.Drawing.Color.Transparent;
            this.lblTen_nv.Location = new System.Drawing.Point(5, 56);
            this.lblTen_nv.Name = "lblTen_nv";
            this.lblTen_nv.Size = new System.Drawing.Size(94, 20);
            this.lblTen_nv.TabIndex = 78;
            this.lblTen_nv.Text = "Tên khu vực";
            // 
            // lblManv
            // 
            this.lblManv.AutoSize = true;
            this.lblManv.BackColor = System.Drawing.Color.Transparent;
            this.lblManv.Location = new System.Drawing.Point(10, 22);
            this.lblManv.Name = "lblManv";
            this.lblManv.Size = new System.Drawing.Size(89, 20);
            this.lblManv.TabIndex = 77;
            this.lblManv.Text = "Mã khu vực";
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnXoa.BackColor = System.Drawing.Color.Transparent;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(168, 277);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 28);
            this.btnXoa.TabIndex = 76;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btn_them
            // 
            this.btn_them.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_them.BackColor = System.Drawing.Color.Transparent;
            this.btn_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.Location = new System.Drawing.Point(73, 277);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(75, 28);
            this.btn_them.TabIndex = 73;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(813, 342);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Bàn";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox3.Controls.Add(this.grdDsBan);
            this.groupBox3.Location = new System.Drawing.Point(265, 25);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(541, 315);
            this.groupBox3.TabIndex = 78;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách ";
            // 
            // grdDsBan
            // 
            this.grdDsBan.AllowUserToAddRows = false;
            this.grdDsBan.AllowUserToDeleteRows = false;
            this.grdDsBan.AllowUserToResizeColumns = false;
            this.grdDsBan.AllowUserToResizeRows = false;
            this.grdDsBan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grdDsBan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdDsBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDsBan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MB,
            this.Column1,
            this.Column2,
            this.Column3});
            this.grdDsBan.Location = new System.Drawing.Point(6, 19);
            this.grdDsBan.Name = "grdDsBan";
            this.grdDsBan.ReadOnly = true;
            this.grdDsBan.RowHeadersVisible = false;
            this.grdDsBan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdDsBan.Size = new System.Drawing.Size(529, 290);
            this.grdDsBan.TabIndex = 5;
            this.grdDsBan.SelectionChanged += new System.EventHandler(this.grdDsBan_SelectionChanged);
            // 
            // MB
            // 
            this.MB.DataPropertyName = "maban";
            this.MB.HeaderText = "Mã bàn";
            this.MB.Name = "MB";
            this.MB.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "tenban";
            this.Column1.HeaderText = "Tên bàn";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "ma_kv";
            this.Column2.HeaderText = "Mã khu vực";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Visible = false;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "ten_kv";
            this.Column3.HeaderText = "Tên khu vực";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox4.Controls.Add(this.cbKhuvuc);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.btnXoaban);
            this.groupBox4.Controls.Add(this.btnThemban);
            this.groupBox4.Controls.Add(this.txtTenban);
            this.groupBox4.Controls.Add(this.txtMaban);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Location = new System.Drawing.Point(7, 25);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(252, 311);
            this.groupBox4.TabIndex = 77;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Chi tiết ";
            // 
            // cbKhuvuc
            // 
            this.cbKhuvuc.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cbKhuvuc.FormattingEnabled = true;
            this.cbKhuvuc.Location = new System.Drawing.Point(87, 90);
            this.cbKhuvuc.Name = "cbKhuvuc";
            this.cbKhuvuc.Size = new System.Drawing.Size(156, 28);
            this.cbKhuvuc.TabIndex = 88;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(19, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 87;
            this.label5.Text = "Khu vực";
            // 
            // btnXoaban
            // 
            this.btnXoaban.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnXoaban.BackColor = System.Drawing.Color.Transparent;
            this.btnXoaban.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaban.Location = new System.Drawing.Point(168, 277);
            this.btnXoaban.Name = "btnXoaban";
            this.btnXoaban.Size = new System.Drawing.Size(75, 28);
            this.btnXoaban.TabIndex = 86;
            this.btnXoaban.Text = "Xóa";
            this.btnXoaban.UseVisualStyleBackColor = false;
            // 
            // btnThemban
            // 
            this.btnThemban.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnThemban.BackColor = System.Drawing.Color.Transparent;
            this.btnThemban.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemban.Location = new System.Drawing.Point(73, 277);
            this.btnThemban.Name = "btnThemban";
            this.btnThemban.Size = new System.Drawing.Size(75, 28);
            this.btnThemban.TabIndex = 85;
            this.btnThemban.Text = "Thêm";
            this.btnThemban.UseVisualStyleBackColor = false;
            // 
            // txtTenban
            // 
            this.txtTenban.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTenban.Location = new System.Drawing.Point(87, 53);
            this.txtTenban.Name = "txtTenban";
            this.txtTenban.Size = new System.Drawing.Size(156, 26);
            this.txtTenban.TabIndex = 84;
            // 
            // txtMaban
            // 
            this.txtMaban.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtMaban.Location = new System.Drawing.Point(87, 19);
            this.txtMaban.Name = "txtMaban";
            this.txtMaban.Size = new System.Drawing.Size(156, 26);
            this.txtMaban.TabIndex = 83;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(19, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 82;
            this.label2.Text = "Tên bàn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(23, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 81;
            this.label3.Text = "Mã bàn";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label12.Location = new System.Drawing.Point(308, 3);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(136, 24);
            this.label12.TabIndex = 76;
            this.label12.Text = "QUẢN LÝ BÀN";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox6);
            this.tabPage3.Controls.Add(this.groupBox5);
            this.tabPage3.Controls.Add(this.label18);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(813, 342);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "Đơn vị";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox6.Controls.Add(this.txtLoaiDV);
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Controls.Add(this.txtTenDV);
            this.groupBox6.Controls.Add(this.txtMaDV);
            this.groupBox6.Controls.Add(this.label4);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Controls.Add(this.button1);
            this.groupBox6.Controls.Add(this.button2);
            this.groupBox6.Location = new System.Drawing.Point(7, 28);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(252, 308);
            this.groupBox6.TabIndex = 79;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Chi tiết ";
            // 
            // txtLoaiDV
            // 
            this.txtLoaiDV.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtLoaiDV.Location = new System.Drawing.Point(87, 90);
            this.txtLoaiDV.Name = "txtLoaiDV";
            this.txtLoaiDV.Size = new System.Drawing.Size(156, 26);
            this.txtLoaiDV.TabIndex = 82;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(2, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 20);
            this.label7.TabIndex = 81;
            this.label7.Text = "Loại đơn vị";
            // 
            // txtTenDV
            // 
            this.txtTenDV.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTenDV.Location = new System.Drawing.Point(87, 53);
            this.txtTenDV.Name = "txtTenDV";
            this.txtTenDV.Size = new System.Drawing.Size(156, 26);
            this.txtTenDV.TabIndex = 80;
            // 
            // txtMaDV
            // 
            this.txtMaDV.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtMaDV.Location = new System.Drawing.Point(87, 19);
            this.txtMaDV.Name = "txtMaDV";
            this.txtMaDV.Size = new System.Drawing.Size(156, 26);
            this.txtMaDV.TabIndex = 79;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(3, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 78;
            this.label4.Text = "Tên đơn vị";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(7, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 20);
            this.label6.TabIndex = 77;
            this.label6.Text = "Mã đơn vị";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(168, 274);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 28);
            this.button1.TabIndex = 76;
            this.button1.Text = "Xóa";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(73, 274);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 28);
            this.button2.TabIndex = 73;
            this.button2.Text = "Thêm";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox5.Controls.Add(this.grdDsDonvi);
            this.groupBox5.Location = new System.Drawing.Point(265, 25);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(540, 315);
            this.groupBox5.TabIndex = 78;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Danh sách ";
            // 
            // grdDsDonvi
            // 
            this.grdDsDonvi.AllowUserToAddRows = false;
            this.grdDsDonvi.AllowUserToDeleteRows = false;
            this.grdDsDonvi.AllowUserToResizeColumns = false;
            this.grdDsDonvi.AllowUserToResizeRows = false;
            this.grdDsDonvi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grdDsDonvi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdDsDonvi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDsDonvi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MADV,
            this.Column4,
            this.Column5});
            this.grdDsDonvi.Location = new System.Drawing.Point(6, 19);
            this.grdDsDonvi.Name = "grdDsDonvi";
            this.grdDsDonvi.ReadOnly = true;
            this.grdDsDonvi.RowHeadersVisible = false;
            this.grdDsDonvi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdDsDonvi.Size = new System.Drawing.Size(528, 290);
            this.grdDsDonvi.TabIndex = 5;
            this.grdDsDonvi.SelectionChanged += new System.EventHandler(this.grdDsDonvi_SelectionChanged);
            // 
            // MADV
            // 
            this.MADV.DataPropertyName = "ma_donvi";
            this.MADV.HeaderText = "Mã đơn vị";
            this.MADV.Name = "MADV";
            this.MADV.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "ten_donvi";
            this.Column4.HeaderText = "Tên đơn vị";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "loai_donvi";
            this.Column5.HeaderText = "Loại đơn vị";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label18.Location = new System.Drawing.Point(308, 3);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(161, 24);
            this.label18.TabIndex = 76;
            this.label18.Text = "QUẢN LÝ ĐƠN VỊ";
            // 
            // frmSupport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 375);
            this.Controls.Add(this.tabPages);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSupport";
            this.Text = "Hỗ trợ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmSupport_FormClosed);
            this.Load += new System.EventHandler(this.frmSupport_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdDsKhuvuc)).EndInit();
            this.tabPages.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdDsBan)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdDsDonvi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView grdDsKhuvuc;
        private System.Windows.Forms.TabControl tabPages;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView grdDsBan;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView grdDsDonvi;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTen_kv;
        private System.Windows.Forms.TextBox txtMa_kv;
        private System.Windows.Forms.Label lblTen_nv;
        private System.Windows.Forms.Label lblManv;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btnXoaban;
        private System.Windows.Forms.Button btnThemban;
        private System.Windows.Forms.TextBox txtTenban;
        private System.Windows.Forms.TextBox txtMaban;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbKhuvuc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox txtLoaiDV;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTenDV;
        private System.Windows.Forms.TextBox txtMaDV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MADV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn MKV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TKV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MB;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}