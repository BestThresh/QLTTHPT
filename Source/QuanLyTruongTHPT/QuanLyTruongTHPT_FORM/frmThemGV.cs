using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyTruongTHPT_DAL;
using QuanLyTruongTHPT_Entity;

namespace QuanLyTruongTHPT_FORM
{
    public partial class frmThemGV : Form
    {
        SQL_tblGiaovien giaovien = new SQL_tblGiaovien();
        EC_tblGiaovien gv = new EC_tblGiaovien();
        DataTable dt = new DataTable();
        public void SetNull()
        {
            txtHo.Text = "";
            txtTen.Text = "";
            txtDiaChi.Text = "";
            txtMaGV.Text = "";
            txtSDT.Text = "";
            txtLuong.Text = "";
        }
        public frmThemGV()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtMaGV.Text == "GV")
            {
                MessageBox.Show("Bạn chwua điền đủ thông tin!!!", "Thông Báo", MessageBoxButtons.OK);
                return;
            }
            else
            {
                gv.MaGV = txtMaGV.Text;
                gv.MaMon = cbMaMon.Text;
                gv.Ho = txtHo.Text;
                gv.Ten = txtTen.Text;
                gv.NgaySinh = dtpNS.Value.ToShortDateString();
                gv.SDT = txtSDT.Text;
                gv.Luong = txtLuong.Text;
                gv.DiaChi = txtDiaChi.Text;
                if (chkNam.Checked == true)
                {
                    gv.GT = "Nam";
                }
                else
                {
                    gv.GT = "Nữ";
                }
                giaovien.addGiaovien(gv);
                MessageBox.Show("Bạn đã lưu thành công!!!", "Thông Báo", MessageBoxButtons.OK);
                SetNull();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn muốn thoát???", "Questions", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNu.Checked == true)
            {
                chkNam.Checked = false;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmThemGV_Load(object sender, EventArgs e)
        {
            SQL_tblMonhoc monhoc = new SQL_tblMonhoc();
            dt = monhoc.getAllMonhoc();
            cbMaMon.DataSource = dt;
            cbMaMon.DisplayMember = "MaMon";
            cbTenMon.DataSource = dt;
            cbTenMon.DisplayMember = "TenMon";
        }

        private void chkNam_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNam.Checked == true)
            {
                chkNu.Checked = false;
            }
        }

        private void frmThemGV_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn muốn thoát???", "Questions", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
