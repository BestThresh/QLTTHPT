using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyTruongTHPT_Entity;
namespace QuanLyTruongTHPT_FORM
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

       

        private void trangChủToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void TSDangNhap_Click(object sender, EventArgs e)
        {
            frmDangNhap f = new frmDangNhap();
            f.Show();
            this.Dispose();
        }

        private void TSDangKi_Click(object sender, EventArgs e)
        {
            frmThemTaiKhoan f = new frmThemTaiKhoan();
            f.Show();
            this.Dispose();
        }

        private void TSHocSinh_Click(object sender, EventArgs e)
        {
            frmHocSinh f = new frmHocSinh();
            f.Show();
            this.Dispose();
        }

        private void TSGiaoVien_Click(object sender, EventArgs e)
        {
            frmGiaoVien f = new frmGiaoVien();
            f.Show();
            this.Dispose();
        }

        private void TSThemGIeoVien_Click(object sender, EventArgs e)
        {
            frmThemGV f = new frmThemGV();
            f.Show();
            this.Dispose();
        }

        private void TSTimGV_Click(object sender, EventArgs e)
        {
            frmTimGV f = new frmTimGV();
            f.Show();
            this.Dispose();

        }

        private void quảnLýGiáoDụcToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void TSTKB_Click(object sender, EventArgs e)
        {
            frmTKB frm = new frmTKB();
            frm.Show();
            this.Dispose();
        }

        private void hướngDẫnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
                    }
    }
}
