namespace QuanLyTruongTHPT_FORM
{
    partial class frmTKB
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
            this.lblClass = new System.Windows.Forms.Label();
            this.cmbClass = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvTKB = new System.Windows.Forms.DataGridView();
            this.Tiet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thu2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaGV2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenGV2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thu3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaGV3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenGV3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thu4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenGV4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaGV4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thu5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaGV5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenGV5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.THu6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaGV6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenGV6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thu7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaGV7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenGV7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTKB)).BeginInit();
            this.SuspendLayout();
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Location = new System.Drawing.Point(12, 15);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(25, 13);
            this.lblClass.TabIndex = 0;
            this.lblClass.Text = "Lớp";
            this.lblClass.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmbClass
            // 
            this.cmbClass.FormattingEnabled = true;
            this.cmbClass.Location = new System.Drawing.Point(79, 12);
            this.cmbClass.Name = "cmbClass";
            this.cmbClass.Size = new System.Drawing.Size(121, 21);
            this.cmbClass.TabIndex = 1;
            this.cmbClass.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(238, 10);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "button1";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // dgvTKB
            // 
            this.dgvTKB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTKB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tiet,
            this.Thu2,
            this.MaGV2,
            this.TenGV2,
            this.Thu3,
            this.MaGV3,
            this.TenGV3,
            this.Thu4,
            this.TenGV4,
            this.MaGV4,
            this.Thu5,
            this.MaGV5,
            this.TenGV5,
            this.THu6,
            this.MaGV6,
            this.TenGV6,
            this.Thu7,
            this.MaGV7,
            this.TenGV7});
            this.dgvTKB.Location = new System.Drawing.Point(15, 65);
            this.dgvTKB.Name = "dgvTKB";
            this.dgvTKB.Size = new System.Drawing.Size(1163, 298);
            this.dgvTKB.TabIndex = 3;
            // 
            // Tiet
            // 
            this.Tiet.HeaderText = "Tiết";
            this.Tiet.Name = "Tiet";
            this.Tiet.Width = 50;
            // 
            // Thu2
            // 
            this.Thu2.HeaderText = "Thứ 2";
            this.Thu2.Name = "Thu2";
            // 
            // MaGV2
            // 
            this.MaGV2.HeaderText = "MaGV2";
            this.MaGV2.Name = "MaGV2";
            // 
            // TenGV2
            // 
            this.TenGV2.HeaderText = "Tên GV";
            this.TenGV2.Name = "TenGV2";
            // 
            // Thu3
            // 
            this.Thu3.HeaderText = "Thứ 3";
            this.Thu3.Name = "Thu3";
            // 
            // MaGV3
            // 
            this.MaGV3.HeaderText = "MaGV3";
            this.MaGV3.Name = "MaGV3";
            // 
            // TenGV3
            // 
            this.TenGV3.HeaderText = "Tên GV";
            this.TenGV3.Name = "TenGV3";
            // 
            // Thu4
            // 
            this.Thu4.HeaderText = "Thứ 4";
            this.Thu4.Name = "Thu4";
            // 
            // TenGV4
            // 
            this.TenGV4.HeaderText = "Tên GV";
            this.TenGV4.Name = "TenGV4";
            // 
            // MaGV4
            // 
            this.MaGV4.HeaderText = "MaGV4";
            this.MaGV4.Name = "MaGV4";
            // 
            // Thu5
            // 
            this.Thu5.HeaderText = "Thứ 5";
            this.Thu5.Name = "Thu5";
            // 
            // MaGV5
            // 
            this.MaGV5.HeaderText = "MaGV5";
            this.MaGV5.Name = "MaGV5";
            // 
            // TenGV5
            // 
            this.TenGV5.HeaderText = "TenGV";
            this.TenGV5.Name = "TenGV5";
            // 
            // THu6
            // 
            this.THu6.HeaderText = "Thứ 6";
            this.THu6.Name = "THu6";
            // 
            // MaGV6
            // 
            this.MaGV6.HeaderText = "MaGV6";
            this.MaGV6.Name = "MaGV6";
            // 
            // TenGV6
            // 
            this.TenGV6.HeaderText = "Tên GV";
            this.TenGV6.Name = "TenGV6";
            // 
            // Thu7
            // 
            this.Thu7.HeaderText = "Thứ 7";
            this.Thu7.Name = "Thu7";
            // 
            // MaGV7
            // 
            this.MaGV7.HeaderText = "MaGV7";
            this.MaGV7.Name = "MaGV7";
            // 
            // TenGV7
            // 
            this.TenGV7.HeaderText = "Tên GV";
            this.TenGV7.Name = "TenGV7";
            // 
            // frmTKB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 375);
            this.Controls.Add(this.dgvTKB);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cmbClass);
            this.Controls.Add(this.lblClass);
            this.Name = "frmTKB";
            this.Text = "frmTKB";
            this.Load += new System.EventHandler(this.frmTKB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTKB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.ComboBox cmbClass;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvTKB;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tiet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thu2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaGV2;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenGV2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thu3;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaGV3;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenGV3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thu4;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenGV4;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaGV4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thu5;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaGV5;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenGV5;
        private System.Windows.Forms.DataGridViewTextBoxColumn THu6;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaGV6;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenGV6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thu7;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaGV7;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenGV7;
    }
}