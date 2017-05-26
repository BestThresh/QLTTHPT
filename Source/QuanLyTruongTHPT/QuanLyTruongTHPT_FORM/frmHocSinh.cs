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

        private void HienThi()
        {
            dgvHocSinh.DataSource = busHS.getAllHocsinh();
        }
        void TuDanhMaHS()//ham này dùng trong trường hợp thêm tb thì nếu chỉ nhập tên tb thì sẽ tự động đánh MaTB
        {
            DataTable MaHS;
            MaHS = busHS.LayMaHS();
            txtMaHS.DataBindings.Clear();
            txtMaHS.DataBindings.Add("Text", MaHS, "MaHS", true);
            string MP = txtMaHS.Text;
            int stt = int.Parse(MP.Substring(2, MP.Length - 2)) + 1;
            if (stt < 10) { txtMaHS.Text = MP.Substring(0, 2) + "0" + stt.ToString(); }
            else txtMaHS.Text = MP.Substring(0, 2) + stt.ToString();

        }

        public frmHocSinh()
        {
            InitializeComponent();
        }

        private void frmHocSinh_Load(object sender, EventArgs e)
        {
            DataTable tbl = busHS.getAllHocsinh();
            dgvHocSinh.DataSource = tbl;
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
            frmMain frm = new frmMain();
            frm.Show();
            this.Dispose();
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
            DataTable tbl = busHS.getAllHocsinh();
            dgvHocSinh.DataSource = tbl;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            txtMaHS.Focus();
            MoDieuKhien();
            SetNull();
            TuDanhMaHS();
            DoDLMaLop();
            themmoi = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvHocSinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                /*int dong = e.RowIndex;/*biến dòng :kich vào dòng thì chỉ số dòng đc lưu vào biến dòng */
                txtMaHS.Text = dgvHocSinh.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtHo.Text = dgvHocSinh.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtTen.Text = dgvHocSinh.Rows[e.RowIndex].Cells[2].Value.ToString();
                cboMaLop.Text = dgvHocSinh.Rows[e.RowIndex].Cells["colMaLop"].Value.ToString();
                cboDanToc.Text = dgvHocSinh.Rows[e.RowIndex].Cells["colDanToc"].Value.ToString();
                cboTonGiao.Text = dgvHocSinh.Rows[e.RowIndex].Cells["colTonGiao"].Value.ToString();
                if (dgvHocSinh.Rows[e.RowIndex].Cells["colGT"].Value.ToString() == "Nam") rdbNam.Checked = true;
                else rdbNu.Checked = true;
                dtpNgaySinh.Text = dgvHocSinh.Rows[e.RowIndex].Cells["colNgaySinh"].Value.ToString();

                txtDiaChi.Text = dgvHocSinh.Rows[e.RowIndex].Cells["colDiaChi"].Value.ToString();
            }
            catch
            {

            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            //kich hoat cac chuc năng
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            MoDieuKhien();
            txtMaHS.ReadOnly = true;
            themmoi = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaHS.Text == "" || txtTen.Text == "")
            {
                MessageBox.Show("Xin mời nhập thông tin đầy đủ");
                KhoaDieuKhien();
                return;
            }
            else
            {
                if (themmoi == true)/*đang ở trang thái thêm mới*/
                {
                    try
                    {
                        ectHS.MaHS = txtMaHS.Text;
                        ectHS.Ho = txtHo.Text;
                        ectHS.Ten = txtTen.Text;
                        if (rdbNam.Checked) ectHS.GT = "Nam";
                        else ectHS.GT = "Nu";
                        ectHS.NgaySinh = dtpNgaySinh.Value.Year.ToString() + "-" + dtpNgaySinh.Value.Month.ToString() + "-" + dtpNgaySinh.Value.Day.ToString();
                        ectHS.MaLop = cboMaLop.Text;
                        ectHS.DiaChi = txtDiaChi.Text;
                        ectHS.DanToc = cboDanToc.Text;
                        ectHS.TonGiao = cboTonGiao.Text;

                        busHS.addHocsinh(ectHS);
                        MessageBox.Show("Đã thêm mới thành công");/*dòng thông báo*/
                        SetNull();
                    }
                    catch
                    {
                        MessageBox.Show("Lỗi");
                        return;
                    }

                }
                else
                {
                    try
                    {
                        ectHS.MaHS = txtMaHS.Text;
                        ectHS.Ho = txtHo.Text;
                        ectHS.Ten = txtTen.Text;
                        if (rdbNam.Checked) ectHS.GT = "Nam";
                        else ectHS.GT = "Nu";
                        ectHS.NgaySinh = dtpNgaySinh.Value.Year.ToString() + "-" + dtpNgaySinh.Value.Month.ToString() + "-" + dtpNgaySinh.Value.Day.ToString();
                        ectHS.MaLop = cboMaLop.Text;
                        ectHS.DiaChi = txtDiaChi.Text;
                        ectHS.DanToc = cboDanToc.Text;
                        ectHS.TonGiao = cboTonGiao.Text;

                        busHS.updateHocsinh(ectHS);
                        MessageBox.Show("Đã sửa thành công");
                        SetNull();
                    }
                    catch
                    {
                        MessageBox.Show("Lỗi");
                        return;
                    }
                }
                SetNull();
                KhoaDieuKhien();/*không cho thao tác*/
                HienThi();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult xacnhan;
            xacnhan = MessageBox.Show("Bạn có chắc chắn muốn xóa không??", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (xacnhan == DialogResult.OK)
            {
                ectHS.MaHS = txtMaHS.Text;
                busHS.delHocsinh(ectHS);
                MessageBox.Show("Đã xóa thành công!");
                SetNull();
            }
        }

        private void frmHocSinh_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmMain frm = new frmMain();
            frm.Show();
            this.Dispose();
        }
    }
}
