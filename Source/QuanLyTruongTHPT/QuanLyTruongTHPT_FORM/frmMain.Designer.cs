namespace QuanLyTruongTHPT_FORM
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.trangChủToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSDangNhap = new System.Windows.Forms.ToolStripMenuItem();
            this.TSDangKi = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSHocSinh = new System.Windows.Forms.ToolStripMenuItem();
            this.TSGiaoVien = new System.Windows.Forms.ToolStripMenuItem();
            this.TSThemGIeoVien = new System.Windows.Forms.ToolStripMenuItem();
            this.TSTimGV = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýGiáoDụcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSTKB = new System.Windows.Forms.ToolStripMenuItem();
            this.hướngDẫnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hướngDẫnCàiĐặtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phiênBảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trangChủToolStripMenuItem,
            this.quảnLýToolStripMenuItem,
            this.quảnLýGiáoDụcToolStripMenuItem,
            this.hướngDẫnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(551, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // trangChủToolStripMenuItem
            // 
            this.trangChủToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSDangNhap,
            this.TSDangKi,
            this.thoátToolStripMenuItem});
            this.trangChủToolStripMenuItem.Name = "trangChủToolStripMenuItem";
            this.trangChủToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.trangChủToolStripMenuItem.Text = "Trang Chủ";
            this.trangChủToolStripMenuItem.Click += new System.EventHandler(this.trangChủToolStripMenuItem_Click);
            // 
            // TSDangNhap
            // 
            this.TSDangNhap.Name = "TSDangNhap";
            this.TSDangNhap.Size = new System.Drawing.Size(134, 22);
            this.TSDangNhap.Text = "Đăng Nhập";
            this.TSDangNhap.Click += new System.EventHandler(this.TSDangNhap_Click);
            // 
            // TSDangKi
            // 
            this.TSDangKi.Name = "TSDangKi";
            this.TSDangKi.Size = new System.Drawing.Size(134, 22);
            this.TSDangKi.Text = "Đăng Kí";
            this.TSDangKi.Click += new System.EventHandler(this.TSDangKi_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.thoátToolStripMenuItem.Text = "Thoát";
            // 
            // quảnLýToolStripMenuItem
            // 
            this.quảnLýToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSHocSinh,
            this.TSGiaoVien});
            this.quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            this.quảnLýToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
            this.quảnLýToolStripMenuItem.Text = "Quản Lý Danh Sách";
            // 
            // TSHocSinh
            // 
            this.TSHocSinh.Name = "TSHocSinh";
            this.TSHocSinh.Size = new System.Drawing.Size(124, 22);
            this.TSHocSinh.Text = "Học Sinh";
            this.TSHocSinh.Click += new System.EventHandler(this.TSHocSinh_Click);
            // 
            // TSGiaoVien
            // 
            this.TSGiaoVien.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSThemGIeoVien,
            this.TSTimGV});
            this.TSGiaoVien.Name = "TSGiaoVien";
            this.TSGiaoVien.Size = new System.Drawing.Size(124, 22);
            this.TSGiaoVien.Text = "Giáo Viên";
            this.TSGiaoVien.Click += new System.EventHandler(this.TSGiaoVien_Click);
            // 
            // TSThemGIeoVien
            // 
            this.TSThemGIeoVien.Name = "TSThemGIeoVien";
            this.TSThemGIeoVien.Size = new System.Drawing.Size(158, 22);
            this.TSThemGIeoVien.Text = "Thêm Giáo Viên";
            this.TSThemGIeoVien.Click += new System.EventHandler(this.TSThemGIeoVien_Click);
            // 
            // TSTimGV
            // 
            this.TSTimGV.Name = "TSTimGV";
            this.TSTimGV.Size = new System.Drawing.Size(158, 22);
            this.TSTimGV.Text = "Tìm Giáo Viên";
            this.TSTimGV.Click += new System.EventHandler(this.TSTimGV_Click);
            // 
            // quảnLýGiáoDụcToolStripMenuItem
            // 
            this.quảnLýGiáoDụcToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSTKB});
            this.quảnLýGiáoDụcToolStripMenuItem.Name = "quảnLýGiáoDụcToolStripMenuItem";
            this.quảnLýGiáoDụcToolStripMenuItem.Size = new System.Drawing.Size(114, 20);
            this.quảnLýGiáoDụcToolStripMenuItem.Text = "Quản Lý Giáo Dục";
            this.quảnLýGiáoDụcToolStripMenuItem.Click += new System.EventHandler(this.quảnLýGiáoDụcToolStripMenuItem_Click);
            // 
            // TSTKB
            // 
            this.TSTKB.Name = "TSTKB";
            this.TSTKB.Size = new System.Drawing.Size(154, 22);
            this.TSTKB.Text = "Thời Khóa Biểu";
            this.TSTKB.Click += new System.EventHandler(this.TSTKB_Click);
            // 
            // hướngDẫnToolStripMenuItem
            // 
            this.hướngDẫnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hướngDẫnCàiĐặtToolStripMenuItem,
            this.phiênBảnToolStripMenuItem});
            this.hướngDẫnToolStripMenuItem.Name = "hướngDẫnToolStripMenuItem";
            this.hướngDẫnToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.hướngDẫnToolStripMenuItem.Text = "Hướng Dẫn";
            this.hướngDẫnToolStripMenuItem.Click += new System.EventHandler(this.hướngDẫnToolStripMenuItem_Click);
            // 
            // hướngDẫnCàiĐặtToolStripMenuItem
            // 
            this.hướngDẫnCàiĐặtToolStripMenuItem.Name = "hướngDẫnCàiĐặtToolStripMenuItem";
            this.hướngDẫnCàiĐặtToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.hướngDẫnCàiĐặtToolStripMenuItem.Text = "Hướng Dẫn Cài Đặt";
            // 
            // phiênBảnToolStripMenuItem
            // 
            this.phiênBảnToolStripMenuItem.Name = "phiênBảnToolStripMenuItem";
            this.phiênBảnToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.phiênBảnToolStripMenuItem.Text = "Phiên Bản";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 324);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Quản lý trường THPT";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem trangChủToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TSHocSinh;
        private System.Windows.Forms.ToolStripMenuItem TSGiaoVien;
        private System.Windows.Forms.ToolStripMenuItem TSThemGIeoVien;
        private System.Windows.Forms.ToolStripMenuItem TSTimGV;
        private System.Windows.Forms.ToolStripMenuItem quảnLýGiáoDụcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TSTKB;
        private System.Windows.Forms.ToolStripMenuItem hướngDẫnToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TSDangNhap;
        private System.Windows.Forms.ToolStripMenuItem TSDangKi;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hướngDẫnCàiĐặtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phiênBảnToolStripMenuItem;
    }
}