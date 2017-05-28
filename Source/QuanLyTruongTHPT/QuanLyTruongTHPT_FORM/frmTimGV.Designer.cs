namespace QuanLyTruongTHPT_FORM
{
    partial class frmTimGV
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
            this.cboTimMaMon = new System.Windows.Forms.ComboBox();
            this.txtTimMaGV = new System.Windows.Forms.TextBox();
            this.txtTimTenGV = new System.Windows.Forms.TextBox();
            this.txtTimHoGV = new System.Windows.Forms.TextBox();
            this.cboTimDiaChi = new System.Windows.Forms.ComboBox();
            this.dgvGiaoVien = new System.Windows.Forms.DataGridView();
            this.colMaGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiaoVien)).BeginInit();
            this.SuspendLayout();
            // 
            // cboTimMaMon
            // 
            this.cboTimMaMon.FormattingEnabled = true;
            this.cboTimMaMon.Location = new System.Drawing.Point(365, 37);
            this.cboTimMaMon.Name = "cboTimMaMon";
            this.cboTimMaMon.Size = new System.Drawing.Size(121, 21);
            this.cboTimMaMon.TabIndex = 0;
            this.cboTimMaMon.Text = "-- Mã môn";
            this.cboTimMaMon.SelectedIndexChanged += new System.EventHandler(this.cboTimMaMon_SelectedIndexChanged);
            this.cboTimMaMon.TextChanged += new System.EventHandler(this.cboTimMaMon_TextChanged);
            this.cboTimMaMon.Click += new System.EventHandler(this.cboTimMaMon_Click);
            this.cboTimMaMon.Enter += new System.EventHandler(this.cboTimMaMon_Enter);
            // 
            // txtTimMaGV
            // 
            this.txtTimMaGV.Location = new System.Drawing.Point(47, 37);
            this.txtTimMaGV.Name = "txtTimMaGV";
            this.txtTimMaGV.Size = new System.Drawing.Size(100, 20);
            this.txtTimMaGV.TabIndex = 1;
            this.txtTimMaGV.Text = "-- Mã giáo viên";
            this.txtTimMaGV.Click += new System.EventHandler(this.txtTimMaGV_Click);
            this.txtTimMaGV.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtTimMaGV.Enter += new System.EventHandler(this.txtTimMaGV_Enter);
            // 
            // txtTimTenGV
            // 
            this.txtTimTenGV.Location = new System.Drawing.Point(259, 37);
            this.txtTimTenGV.Name = "txtTimTenGV";
            this.txtTimTenGV.Size = new System.Drawing.Size(100, 20);
            this.txtTimTenGV.TabIndex = 3;
            this.txtTimTenGV.Text = "-- Tên giáo viên";
            this.txtTimTenGV.Click += new System.EventHandler(this.txtTimTenGV_Click);
            this.txtTimTenGV.TextChanged += new System.EventHandler(this.txtTimTenGV_TextChanged);
            this.txtTimTenGV.Enter += new System.EventHandler(this.txtTimTenGV_Enter);
            // 
            // txtTimHoGV
            // 
            this.txtTimHoGV.Location = new System.Drawing.Point(153, 37);
            this.txtTimHoGV.Name = "txtTimHoGV";
            this.txtTimHoGV.Size = new System.Drawing.Size(100, 20);
            this.txtTimHoGV.TabIndex = 4;
            this.txtTimHoGV.Text = "-- Họ giáo viên";
            this.txtTimHoGV.Click += new System.EventHandler(this.txtTimHoGV_Click);
            this.txtTimHoGV.TextChanged += new System.EventHandler(this.txtTimHoGV_TextChanged);
            this.txtTimHoGV.Enter += new System.EventHandler(this.txtTimHoGV_Enter);
            // 
            // cboTimDiaChi
            // 
            this.cboTimDiaChi.FormattingEnabled = true;
            this.cboTimDiaChi.Location = new System.Drawing.Point(492, 37);
            this.cboTimDiaChi.Name = "cboTimDiaChi";
            this.cboTimDiaChi.Size = new System.Drawing.Size(121, 21);
            this.cboTimDiaChi.TabIndex = 5;
            this.cboTimDiaChi.Text = "-- Địa chỉ";
            this.cboTimDiaChi.SelectedIndexChanged += new System.EventHandler(this.cboTimDiaChi_SelectedIndexChanged);
            this.cboTimDiaChi.TextChanged += new System.EventHandler(this.cboTimDiaChi_TextChanged);
            this.cboTimDiaChi.Click += new System.EventHandler(this.cboTimDiaChi_Click);
            this.cboTimDiaChi.Enter += new System.EventHandler(this.cboTimDiaChi_Enter);
            // 
            // dgvGiaoVien
            // 
            this.dgvGiaoVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGiaoVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaGV,
            this.colHo,
            this.colTen,
            this.colMaMon,
            this.colDiaChi,
            this.colGT,
            this.colNgaySinh,
            this.colLuong,
            this.colSDT});
            this.dgvGiaoVien.Location = new System.Drawing.Point(12, 88);
            this.dgvGiaoVien.Name = "dgvGiaoVien";
            this.dgvGiaoVien.Size = new System.Drawing.Size(944, 301);
            this.dgvGiaoVien.TabIndex = 6;
            // 
            // colMaGV
            // 
            this.colMaGV.DataPropertyName = "MaGV";
            this.colMaGV.HeaderText = "Mã giáo viên";
            this.colMaGV.Name = "colMaGV";
            // 
            // colHo
            // 
            this.colHo.DataPropertyName = "Ho";
            this.colHo.HeaderText = "Họ";
            this.colHo.Name = "colHo";
            // 
            // colTen
            // 
            this.colTen.DataPropertyName = "Ten";
            this.colTen.HeaderText = "Tên";
            this.colTen.Name = "colTen";
            // 
            // colMaMon
            // 
            this.colMaMon.DataPropertyName = "MaMon";
            this.colMaMon.HeaderText = "Mã môn";
            this.colMaMon.Name = "colMaMon";
            // 
            // colDiaChi
            // 
            this.colDiaChi.DataPropertyName = "DiaChi";
            this.colDiaChi.HeaderText = "Địa chỉ";
            this.colDiaChi.Name = "colDiaChi";
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
            // colLuong
            // 
            this.colLuong.DataPropertyName = "Luong";
            this.colLuong.HeaderText = "Lương";
            this.colLuong.Name = "colLuong";
            // 
            // colSDT
            // 
            this.colSDT.DataPropertyName = "SDT";
            this.colSDT.HeaderText = "SĐT";
            this.colSDT.Name = "colSDT";
            // 
            // frmTimGV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 401);
            this.Controls.Add(this.dgvGiaoVien);
            this.Controls.Add(this.cboTimDiaChi);
            this.Controls.Add(this.txtTimHoGV);
            this.Controls.Add(this.txtTimTenGV);
            this.Controls.Add(this.txtTimMaGV);
            this.Controls.Add(this.cboTimMaMon);
            this.Name = "frmTimGV";
            this.Text = "Tìm giáo viên";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmTimGV_FormClosed);
            this.Load += new System.EventHandler(this.frmTimGV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiaoVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboTimMaMon;
        private System.Windows.Forms.TextBox txtTimMaGV;
        private System.Windows.Forms.TextBox txtTimTenGV;
        private System.Windows.Forms.TextBox txtTimHoGV;
        private System.Windows.Forms.ComboBox cboTimDiaChi;
        private System.Windows.Forms.DataGridView dgvGiaoVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSDT;
    }
}