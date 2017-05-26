using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyTruongTHPT_BUS;
using QuanLyTruongTHPT_DAL;
using QuanLyTruongTHPT_FORM;
using QuanLyTruongTHPT_Entity;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace QuanLyTruongTHPT_FORM
{
    public partial class frmHocSinh : Form
    {
        private bool _dangTimMa = false;
        private bool _dangTimHo = false;
        private bool _dangTimTen = false;
        private bool _dangTimMaLop = false;
        private bool _dangTimDanToc = false;
        private bool _dangTimTonGiao = false;

        private BUS_tblHocSinh busHS = new BUS_tblHocSinh();
        private EC_tblHocsinh ectHS = new EC_tblHocsinh();
        private bool _koload = true;
        private bool _koclick = true;
        private bool _kotim = true;
        private bool _xacnhan = false;
        private bool themmoi;
        void SetNull()
        {
            txtMaHS.Text = "";
            txtHo.Text = "";
            txtTen.Text = "";
            cboMaLop.Text = "";
            txtDiaChi.Text = "";
            dtpNgaySinh.ResetText();
        }
        private void KhoaDieuKhien()
        {
            rdbNam.Enabled = false;
            rdbNu.Enabled = false;
            txtMaHS.ReadOnly = true;
            txtHo.ReadOnly = true;
            txtTen.ReadOnly = true;
            cboMaLop.Enabled = false;
            txtDiaChi.ReadOnly = true;
            dtpNgaySinh.Enabled = false;
            cboTonGiao.Enabled = false;
            cboDanToc.Enabled = false;

            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;

        }
        private void MoDieuKhien()
        {
            rdbNam.Enabled = true;
            rdbNu.Enabled = true;
            txtMaHS.ReadOnly = false;
            txtHo.ReadOnly = false;
            txtTen.ReadOnly = false;
            cboMaLop.Enabled = true;
            cboTonGiao.Enabled = true;
            cboDanToc.Enabled = true;
            txtDiaChi.ReadOnly = false;
            dtpNgaySinh.Enabled = true;
        }

        private void DoDLMaLop()
        {
            cboMaLop.DataSource = busHS.DoDLMaLop("");
            cboMaLop.DisplayMember = "MaLop";
        }

        public frmHocSinh(string action)
        {
            InitializeComponent();
            if (action == "TimKiem")
                grbThongTinHocSinh.Enabled = false;
            btnLamMoi.Enabled = false;
            btnLuu.Enabled = false;
            btnSua.Enabled = false;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
        }

        public frmHocSinh()
        {
            InitializeComponent();
        }

        private void frmHocSinh_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }
    }
}
