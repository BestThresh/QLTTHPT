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

        private void button1_Click(object sender, EventArgs e)
        {
            frmHocSinh frm = new frmHocSinh();
            frm.Show();
            this.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmGiaoVien frm = new frmGiaoVien();
            frm.Show();
            this.Dispose();
        }

        private void buttonTKB_Click(object sender, EventArgs e)
        {
            frmTKB frm = new frmTKB();
            frm.Show();
            this.Dispose();
        }
    }
}
