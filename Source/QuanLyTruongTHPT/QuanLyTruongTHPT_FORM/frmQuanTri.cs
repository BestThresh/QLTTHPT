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
using QuanLyTruongTHPT_BUS;

namespace QuanLyTruongTHPT_FORM
{
    public partial class frmQuanTri : Form
    {
        EC_tblUser ecUser = new EC_tblUser();
        BUS_tblUser busUser = new BUS_tblUser();
        int dong = -1;
        public frmQuanTri()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmThemTaiKhoan frm = new frmThemTaiKhoan();
            this.Hide();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dong < 0)
            {
                MessageBox.Show("Chưa chọn tài khoản để xóa .");
                return;
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa ?", "Hỏi", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    ecUser.Username = dgvAcc.Rows[dong].Cells["Username"].Value.ToString();
                    ecUser.Password = dgvAcc.Rows[dong].Cells["Password"].Value.ToString();
                    busUser.delUser(ecUser);
                    frmQuanTri_Load(sender, e);
                }
                else if (dialogResult == DialogResult.No)
                {
                    return;
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dong = e.RowIndex;
            ecUser.Username = dgvAcc.Rows[dong].Cells["Username"].Value.ToString();
            ecUser.Password = dgvAcc.Rows[dong].Cells["Password"].Value.ToString();
            ecUser.MaGV = dgvAcc.Rows[dong].Cells["MaGV"].Value.ToString();
            ecUser.Quyen = dgvAcc.Rows[dong].Cells["TenQuyen"].Value.ToString();

        }

        private void frmQuanTri_Load(object sender, EventArgs e)
        {
            dgvAcc.DataSource = busUser.getUserinfo("");
            for (int i = 0; i < dgvAcc.RowCount; i++)
            {
                if (dgvAcc.Rows[i].Cells["TenQuyen"].Value.ToString() == "Administrator") dgvAcc.Rows[i].DefaultCellStyle.ForeColor = Color.Red;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dong < 0)
            {
                MessageBox.Show("Chưa chọn tài khoản!");
                return;
            }
            frmThemTaiKhoan frm = new frmThemTaiKhoan(ecUser);
            frm.Show();
            this.Hide();
        }

        private void frmQuanTri_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmMain frm = new frmMain();
            frm.Show();
            this.Dispose();
        }

        private void dgvAcc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dong = e.RowIndex;
            ecUser.Username = dgvAcc.Rows[dong].Cells["Username"].Value.ToString();
            ecUser.Password = dgvAcc.Rows[dong].Cells["Password"].Value.ToString();
            ecUser.MaGV = dgvAcc.Rows[dong].Cells["MaGV"].Value.ToString();
            ecUser.Quyen = dgvAcc.Rows[dong].Cells["TenQuyen"].Value.ToString();

        }
    }
}
