﻿namespace QuanLyTruongTHPT_FORM
{
    partial class frmHocSinh
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
            this.grbThongTinHocSinh = new System.Windows.Forms.GroupBox();
            this.cboTonGiao = new System.Windows.Forms.ComboBox();
            this.cboDanToc = new System.Windows.Forms.ComboBox();
            this.cboMaLop = new System.Windows.Forms.ComboBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.rdbNu = new System.Windows.Forms.RadioButton();
            this.rdbNam = new System.Windows.Forms.RadioButton();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtHo = new System.Windows.Forms.TextBox();
            this.txtMaHS = new System.Windows.Forms.TextBox();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.lblGT = new System.Windows.Forms.Label();
            this.lblTen = new System.Windows.Forms.Label();
            this.lblTonGiao = new System.Windows.Forms.Label();
            this.lblDanToc = new System.Windows.Forms.Label();
            this.lblMaLop = new System.Windows.Forms.Label();
            this.lblHo = new System.Windows.Forms.Label();
            this.lblMaHS = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.txtTimMaHS = new System.Windows.Forms.TextBox();
            this.txtTimTenHS = new System.Windows.Forms.TextBox();
            this.txtTimHoHS = new System.Windows.Forms.TextBox();
            this.cboTimMaLop = new System.Windows.Forms.ComboBox();
            this.cboTimTonGiao = new System.Windows.Forms.ComboBox();
            this.cboTimDanToc = new System.Windows.Forms.ComboBox();
            this.dgvHocSinh = new System.Windows.Forms.DataGridView();
            this.colMaHS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColHo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDanToc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTonGiao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.grbThongTinHocSinh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocSinh)).BeginInit();
            this.SuspendLayout();
            // 
            // grbThongTinHocSinh
            // 
            this.grbThongTinHocSinh.Controls.Add(this.cboTonGiao);
            this.grbThongTinHocSinh.Controls.Add(this.cboDanToc);
            this.grbThongTinHocSinh.Controls.Add(this.cboMaLop);
            this.grbThongTinHocSinh.Controls.Add(this.txtDiaChi);
            this.grbThongTinHocSinh.Controls.Add(this.dtpNgaySinh);
            this.grbThongTinHocSinh.Controls.Add(this.rdbNu);
            this.grbThongTinHocSinh.Controls.Add(this.rdbNam);
            this.grbThongTinHocSinh.Controls.Add(this.txtTen);
            this.grbThongTinHocSinh.Controls.Add(this.txtHo);
            this.grbThongTinHocSinh.Controls.Add(this.txtMaHS);
            this.grbThongTinHocSinh.Controls.Add(this.lblDiaChi);
            this.grbThongTinHocSinh.Controls.Add(this.lblNgaySinh);
            this.grbThongTinHocSinh.Controls.Add(this.lblGT);
            this.grbThongTinHocSinh.Controls.Add(this.lblTen);
            this.grbThongTinHocSinh.Controls.Add(this.lblTonGiao);
            this.grbThongTinHocSinh.Controls.Add(this.lblDanToc);
            this.grbThongTinHocSinh.Controls.Add(this.lblMaLop);
            this.grbThongTinHocSinh.Controls.Add(this.lblHo);
            this.grbThongTinHocSinh.Controls.Add(this.lblMaHS);
            this.grbThongTinHocSinh.Location = new System.Drawing.Point(12, 12);
            this.grbThongTinHocSinh.Name = "grbThongTinHocSinh";
            this.grbThongTinHocSinh.Size = new System.Drawing.Size(837, 213);
            this.grbThongTinHocSinh.TabIndex = 0;
            this.grbThongTinHocSinh.TabStop = false;
            this.grbThongTinHocSinh.Text = "Thông tin học sinh";
            // 
            // cboTonGiao
            // 
            this.cboTonGiao.FormattingEnabled = true;
            this.cboTonGiao.Location = new System.Drawing.Point(493, 95);
            this.cboTonGiao.Name = "cboTonGiao";
            this.cboTonGiao.Size = new System.Drawing.Size(243, 21);
            this.cboTonGiao.TabIndex = 41;
            this.cboTonGiao.Text = "- Chọn tôn giáo -";
            this.cboTonGiao.SelectedIndexChanged += new System.EventHandler(this.comboBox6_SelectedIndexChanged);
            // 
            // cboDanToc
            // 
            this.cboDanToc.FormattingEnabled = true;
            this.cboDanToc.Location = new System.Drawing.Point(493, 56);
            this.cboDanToc.Name = "cboDanToc";
            this.cboDanToc.Size = new System.Drawing.Size(243, 21);
            this.cboDanToc.TabIndex = 40;
            this.cboDanToc.Text = "- Chọn dân tộc - ";
            this.cboDanToc.SelectedIndexChanged += new System.EventHandler(this.comboBox5_SelectedIndexChanged);
            // 
            // cboMaLop
            // 
            this.cboMaLop.FormattingEnabled = true;
            this.cboMaLop.Location = new System.Drawing.Point(492, 23);
            this.cboMaLop.Name = "cboMaLop";
            this.cboMaLop.Size = new System.Drawing.Size(244, 21);
            this.cboMaLop.TabIndex = 39;
            this.cboMaLop.Text = "- Chọn mã lớp -";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(492, 130);
            this.txtDiaChi.Multiline = true;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(244, 55);
            this.txtDiaChi.TabIndex = 19;
            this.txtDiaChi.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Location = new System.Drawing.Point(128, 166);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(244, 20);
            this.dtpNgaySinh.TabIndex = 16;
            // 
            // rdbNu
            // 
            this.rdbNu.AutoSize = true;
            this.rdbNu.Location = new System.Drawing.Point(225, 131);
            this.rdbNu.Name = "rdbNu";
            this.rdbNu.Size = new System.Drawing.Size(39, 17);
            this.rdbNu.TabIndex = 13;
            this.rdbNu.TabStop = true;
            this.rdbNu.Text = "Nữ";
            this.rdbNu.UseVisualStyleBackColor = true;
            // 
            // rdbNam
            // 
            this.rdbNam.AutoSize = true;
            this.rdbNam.Location = new System.Drawing.Point(143, 131);
            this.rdbNam.Name = "rdbNam";
            this.rdbNam.Size = new System.Drawing.Size(47, 17);
            this.rdbNam.TabIndex = 12;
            this.rdbNam.TabStop = true;
            this.rdbNam.Text = "Nam";
            this.rdbNam.UseVisualStyleBackColor = true;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(128, 95);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(244, 20);
            this.txtTen.TabIndex = 11;
            this.txtTen.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtHo
            // 
            this.txtHo.Location = new System.Drawing.Point(128, 56);
            this.txtHo.Name = "txtHo";
            this.txtHo.Size = new System.Drawing.Size(244, 20);
            this.txtHo.TabIndex = 10;
            // 
            // txtMaHS
            // 
            this.txtMaHS.Location = new System.Drawing.Point(128, 23);
            this.txtMaHS.Name = "txtMaHS";
            this.txtMaHS.Size = new System.Drawing.Size(244, 20);
            this.txtMaHS.TabIndex = 9;
            this.txtMaHS.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Location = new System.Drawing.Point(420, 131);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(40, 13);
            this.lblDiaChi.TabIndex = 8;
            this.lblDiaChi.Text = "Địa chỉ";
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Location = new System.Drawing.Point(19, 172);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(54, 13);
            this.lblNgaySinh.TabIndex = 7;
            this.lblNgaySinh.Text = "Ngày sinh";
            // 
            // lblGT
            // 
            this.lblGT.AutoSize = true;
            this.lblGT.Location = new System.Drawing.Point(19, 133);
            this.lblGT.Name = "lblGT";
            this.lblGT.Size = new System.Drawing.Size(47, 13);
            this.lblGT.TabIndex = 6;
            this.lblGT.Text = "Giới tính";
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Location = new System.Drawing.Point(19, 98);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(26, 13);
            this.lblTen.TabIndex = 5;
            this.lblTen.Text = "Tên";
            // 
            // lblTonGiao
            // 
            this.lblTonGiao.AutoSize = true;
            this.lblTonGiao.Location = new System.Drawing.Point(420, 98);
            this.lblTonGiao.Name = "lblTonGiao";
            this.lblTonGiao.Size = new System.Drawing.Size(49, 13);
            this.lblTonGiao.TabIndex = 4;
            this.lblTonGiao.Text = "Tôn giáo";
            // 
            // lblDanToc
            // 
            this.lblDanToc.AutoSize = true;
            this.lblDanToc.Location = new System.Drawing.Point(420, 59);
            this.lblDanToc.Name = "lblDanToc";
            this.lblDanToc.Size = new System.Drawing.Size(45, 13);
            this.lblDanToc.TabIndex = 3;
            this.lblDanToc.Text = "Dân tộc";
            this.lblDanToc.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblMaLop
            // 
            this.lblMaLop.AutoSize = true;
            this.lblMaLop.Location = new System.Drawing.Point(420, 26);
            this.lblMaLop.Name = "lblMaLop";
            this.lblMaLop.Size = new System.Drawing.Size(39, 13);
            this.lblMaLop.TabIndex = 2;
            this.lblMaLop.Text = "Mã lớp";
            // 
            // lblHo
            // 
            this.lblHo.AutoSize = true;
            this.lblHo.Location = new System.Drawing.Point(19, 59);
            this.lblHo.Name = "lblHo";
            this.lblHo.Size = new System.Drawing.Size(21, 13);
            this.lblHo.TabIndex = 1;
            this.lblHo.Text = "Họ";
            this.lblHo.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblMaHS
            // 
            this.lblMaHS.AutoSize = true;
            this.lblMaHS.Location = new System.Drawing.Point(19, 26);
            this.lblMaHS.Name = "lblMaHS";
            this.lblMaHS.Size = new System.Drawing.Size(69, 13);
            this.lblMaHS.TabIndex = 0;
            this.lblMaHS.Text = "Mã Học Sinh";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(34, 246);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 20;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(435, 249);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 21;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(304, 249);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 22;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(165, 249);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 23;
            this.btnSua.Text = "Thay đổi";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(550, 249);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(75, 23);
            this.btnLamMoi.TabIndex = 24;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(673, 246);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 25;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.button6_Click);
            // 
            // txtTimMaHS
            // 
            this.txtTimMaHS.Location = new System.Drawing.Point(140, 313);
            this.txtTimMaHS.Name = "txtTimMaHS";
            this.txtTimMaHS.Size = new System.Drawing.Size(100, 20);
            this.txtTimMaHS.TabIndex = 26;
            this.txtTimMaHS.Text = "- Mã học sinh -";
            this.txtTimMaHS.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            this.txtTimMaHS.Enter += new System.EventHandler(this.txtTimMaHS_Enter);
            // 
            // txtTimTenHS
            // 
            this.txtTimTenHS.Location = new System.Drawing.Point(385, 313);
            this.txtTimTenHS.Name = "txtTimTenHS";
            this.txtTimTenHS.Size = new System.Drawing.Size(100, 20);
            this.txtTimTenHS.TabIndex = 32;
            this.txtTimTenHS.Text = "- Tên học sinh -";
            this.txtTimTenHS.TextChanged += new System.EventHandler(this.textBox11_TextChanged);
            this.txtTimTenHS.Enter += new System.EventHandler(this.txtTimTenHS_Enter);
            // 
            // txtTimHoHS
            // 
            this.txtTimHoHS.Location = new System.Drawing.Point(262, 312);
            this.txtTimHoHS.Name = "txtTimHoHS";
            this.txtTimHoHS.Size = new System.Drawing.Size(100, 20);
            this.txtTimHoHS.TabIndex = 34;
            this.txtTimHoHS.Text = "- Họ -";
            this.txtTimHoHS.TextChanged += new System.EventHandler(this.textBox12_TextChanged);
            this.txtTimHoHS.Enter += new System.EventHandler(this.txtTimHoHS_Enter);
            // 
            // cboTimMaLop
            // 
            this.cboTimMaLop.FormattingEnabled = true;
            this.cboTimMaLop.Location = new System.Drawing.Point(504, 313);
            this.cboTimMaLop.Name = "cboTimMaLop";
            this.cboTimMaLop.Size = new System.Drawing.Size(121, 21);
            this.cboTimMaLop.TabIndex = 36;
            this.cboTimMaLop.Text = "- Mã lớp -";
            this.cboTimMaLop.SelectedIndexChanged += new System.EventHandler(this.cboTimMaLop_SelectedIndexChanged);
            this.cboTimMaLop.Enter += new System.EventHandler(this.cboTimMaLop_Enter);
            // 
            // cboTimTonGiao
            // 
            this.cboTimTonGiao.FormattingEnabled = true;
            this.cboTimTonGiao.Location = new System.Drawing.Point(800, 313);
            this.cboTimTonGiao.Name = "cboTimTonGiao";
            this.cboTimTonGiao.Size = new System.Drawing.Size(121, 21);
            this.cboTimTonGiao.TabIndex = 37;
            this.cboTimTonGiao.Text = "- Tôn giáo -";
            this.cboTimTonGiao.SelectedIndexChanged += new System.EventHandler(this.cboTimTonGiao_SelectedIndexChanged);
            this.cboTimTonGiao.Enter += new System.EventHandler(this.cboTimTonGiao_Enter);
            // 
            // cboTimDanToc
            // 
            this.cboTimDanToc.FormattingEnabled = true;
            this.cboTimDanToc.Location = new System.Drawing.Point(652, 313);
            this.cboTimDanToc.Name = "cboTimDanToc";
            this.cboTimDanToc.Size = new System.Drawing.Size(121, 21);
            this.cboTimDanToc.TabIndex = 38;
            this.cboTimDanToc.Text = "- Dân tộc -";
            this.cboTimDanToc.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            this.cboTimDanToc.Enter += new System.EventHandler(this.cboTimDanToc_Enter);
            // 
            // dgvHocSinh
            // 
            this.dgvHocSinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHocSinh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaHS,
            this.ColHo,
            this.colTen,
            this.colMaLop,
            this.colDanToc,
            this.colTonGiao,
            this.colGT,
            this.colNgaySinh,
            this.colDiaChi});
            this.dgvHocSinh.Location = new System.Drawing.Point(12, 359);
            this.dgvHocSinh.Name = "dgvHocSinh";
            this.dgvHocSinh.Size = new System.Drawing.Size(909, 227);
            this.dgvHocSinh.TabIndex = 39;
            this.dgvHocSinh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHocSinh_CellClick);
            this.dgvHocSinh.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // colMaHS
            // 
            this.colMaHS.HeaderText = "Mã Học sinh";
            this.colMaHS.Name = "colMaHS";
            // 
            // ColHo
            // 
            this.ColHo.DataPropertyName = "Ho";
            this.ColHo.HeaderText = "Họ";
            this.ColHo.Name = "ColHo";
            // 
            // colTen
            // 
            this.colTen.DataPropertyName = "Ten";
            this.colTen.HeaderText = "Tên";
            this.colTen.Name = "colTen";
            // 
            // colMaLop
            // 
            this.colMaLop.DataPropertyName = "MaLop";
            this.colMaLop.HeaderText = "Mã lớp";
            this.colMaLop.Name = "colMaLop";
            // 
            // colDanToc
            // 
            this.colDanToc.DataPropertyName = "DanToc";
            this.colDanToc.HeaderText = "Dân tộc";
            this.colDanToc.Name = "colDanToc";
            // 
            // colTonGiao
            // 
            this.colTonGiao.DataPropertyName = "TonGiao";
            this.colTonGiao.HeaderText = "Tôn giáo";
            this.colTonGiao.Name = "colTonGiao";
            // 
            // colGT
            // 
            this.colGT.DataPropertyName = "GT";
            this.colGT.HeaderText = "Giới tính";
            this.colGT.Name = "colGT";
            // 
            // colNgaySinh
            // 
            this.colNgaySinh.DataPropertyName = "NgaySinh";
            this.colNgaySinh.HeaderText = "Ngày sinh";
            this.colNgaySinh.Name = "colNgaySinh";
            // 
            // colDiaChi
            // 
            this.colDiaChi.DataPropertyName = "DiaChi";
            this.colDiaChi.HeaderText = "Địa chỉ";
            this.colDiaChi.Name = "colDiaChi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 316);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Tìm kiếm";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmHocSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 603);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvHocSinh);
            this.Controls.Add(this.cboTimDanToc);
            this.Controls.Add(this.cboTimTonGiao);
            this.Controls.Add(this.cboTimMaLop);
            this.Controls.Add(this.txtTimHoHS);
            this.Controls.Add(this.txtTimTenHS);
            this.Controls.Add(this.txtTimMaHS);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.grbThongTinHocSinh);
            this.Name = "frmHocSinh";
            this.Text = "Học Sinh";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmHocSinh_FormClosed);
            this.Load += new System.EventHandler(this.frmHocSinh_Load);
            this.grbThongTinHocSinh.ResumeLayout(false);
            this.grbThongTinHocSinh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocSinh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbThongTinHocSinh;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblGT;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.Label lblTonGiao;
        private System.Windows.Forms.Label lblDanToc;
        private System.Windows.Forms.Label lblMaLop;
        private System.Windows.Forms.Label lblHo;
        private System.Windows.Forms.Label lblMaHS;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtHo;
        private System.Windows.Forms.TextBox txtMaHS;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.RadioButton rdbNu;
        private System.Windows.Forms.RadioButton rdbNam;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.TextBox txtTimMaHS;
        private System.Windows.Forms.TextBox txtTimTenHS;
        private System.Windows.Forms.TextBox txtTimHoHS;
        private System.Windows.Forms.ComboBox cboTimMaLop;
        private System.Windows.Forms.ComboBox cboTimTonGiao;
        private System.Windows.Forms.ComboBox cboTimDanToc;
        private System.Windows.Forms.DataGridView dgvHocSinh;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.ComboBox cboTonGiao;
        private System.Windows.Forms.ComboBox cboDanToc;
        private System.Windows.Forms.ComboBox cboMaLop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaHS;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColHo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDanToc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTonGiao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiaChi;
    }
}