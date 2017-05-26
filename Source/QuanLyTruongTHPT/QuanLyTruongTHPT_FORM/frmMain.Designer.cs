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
            this.btnHocsinh = new System.Windows.Forms.Button();
            this.buttonTKB = new System.Windows.Forms.Button();
            this.btnGiaoVien = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHocsinh
            // 
            this.btnHocsinh.Location = new System.Drawing.Point(151, 99);
            this.btnHocsinh.Name = "btnHocsinh";
            this.btnHocsinh.Size = new System.Drawing.Size(65, 36);
            this.btnHocsinh.TabIndex = 0;
            this.btnHocsinh.Text = "Quản lý học sinh\r\n";
            this.btnHocsinh.UseVisualStyleBackColor = true;
            this.btnHocsinh.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonTKB
            // 
            this.buttonTKB.Location = new System.Drawing.Point(327, 99);
            this.buttonTKB.Name = "buttonTKB";
            this.buttonTKB.Size = new System.Drawing.Size(75, 36);
            this.buttonTKB.TabIndex = 1;
            this.buttonTKB.Text = "Thời khóa biểu";
            this.buttonTKB.UseVisualStyleBackColor = true;
            this.buttonTKB.Click += new System.EventHandler(this.buttonTKB_Click);
            // 
            // btnGiaoVien
            // 
            this.btnGiaoVien.Location = new System.Drawing.Point(151, 215);
            this.btnGiaoVien.Name = "btnGiaoVien";
            this.btnGiaoVien.Size = new System.Drawing.Size(65, 41);
            this.btnGiaoVien.TabIndex = 2;
            this.btnGiaoVien.Text = "Quản lý giáo viên";
            this.btnGiaoVien.UseVisualStyleBackColor = true;
            this.btnGiaoVien.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(327, 215);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 41);
            this.button4.TabIndex = 3;
            this.button4.Text = "Hướng dẫn";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 324);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnGiaoVien);
            this.Controls.Add(this.buttonTKB);
            this.Controls.Add(this.btnHocsinh);
            this.Name = "frmMain";
            this.Text = "Quản lý trường THPT";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHocsinh;
        private System.Windows.Forms.Button buttonTKB;
        private System.Windows.Forms.Button btnGiaoVien;
        private System.Windows.Forms.Button button4;
    }
}