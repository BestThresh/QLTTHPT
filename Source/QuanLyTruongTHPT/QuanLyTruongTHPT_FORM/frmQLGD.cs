﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyTruongTHPT_Entity;
using QuanLyTruongTHPT_DAL;

namespace QuanLyTruongTHPT_FORM
{
    public partial class frmQLGD : Form
    {
        public frmQLGD()
        {
            InitializeComponent();
        }

        private SQL_tblGiangday DAL_Giang = new SQL_tblGiangday();
        private SQL_tblGiaovien DAL_GV = new SQL_tblGiaovien();
        private SQL_tblLop DAL_Lop = new SQL_tblLop();
        private EC_tblGiangday EC_Giang = new EC_tblGiangday();
        private bool _them = false;
        private string dk = "";

        private void Reset()
        {
            dgvDanhSach.DataSource = DAL_Giang.getThongTinGD();
        }

        private void MoBtn()
        {
            txtTiet.Enabled = true;
            cboLop.Enabled = true;
            cboGiaoVien.Enabled = true;
            cmbThu.Enabled = true;
            btnLuu.Enabled = true;
            dgvDanhSach.Enabled = false;
        }

        private void KhoaBtn()
        {
            txtTiet.Enabled = false;
            cboLop.Enabled = false;
            cboGiaoVien.Enabled = false;
            cmbThu.Enabled = false;
            btnLuu.Enabled = false;
            dgvDanhSach.Enabled = true;
        }

        private void ResetData()
        {
            cboGiaoVien.ResetText();
            cboLop.ResetText();
            txtTiet.ResetText();
            cmbThu.ResetText();
        }
        private void frmQLGD_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MoBtn();
            btnSua.Enabled = false;
            btnXoa.Enabled = false;

            ResetData();

            _them = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (cboGiaoVien.Text != "" && cboGiaoVien.SelectedValue != null) EC_Giang.MaGV = cboGiaoVien.SelectedValue.ToString();
            else
            {
                MessageBox.Show("Giáo viên không xác định");
                cboGiaoVien.Focus();
                return;
            }
            if (cboLop.Text != "" && cboLop.SelectedValue != null) EC_Giang.MaLop = cboLop.SelectedValue.ToString();
            else
            {
                MessageBox.Show("Lớp không xác định");
                cboLop.Focus();
                return;
            }
            EC_Giang.Thu = cmbThu.Text;
            EC_Giang.Tietday = txtTiet.Text;

            if (_them)
            {
                //them tt
                DAL_Giang.addGiangday(EC_Giang);

                KhoaBtn();
                Reset();
            }
            else
            {
                //sua tt
                DAL_Giang.updateGiangday(EC_Giang);
                KhoaBtn();
                Reset();
            }
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            txtTiet.Enabled = true;
            btnLuu.Enabled = true;
            dgvDanhSach.Enabled = false;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            EC_Giang.Tietday = txtTiet.Text;
            EC_Giang.Thu = cmbThu.Text;
            EC_Giang.MaLop = cboLop.SelectedValue.ToString();
            EC_Giang.MaGV = cboGiaoVien.SelectedValue.ToString();
            DAL_Giang.delGiangday(EC_Giang);
            Reset();
        }
    }
}
