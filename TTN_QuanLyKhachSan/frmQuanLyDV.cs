using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using Entity;

namespace TTN_QuanLyKhachSan
{
    public partial class frmQuanLyDV : Form
    {
        public frmQuanLyDV()
        {
            InitializeComponent();
        }
        private DAL_DichVu DAL_DV = new DAL_DichVu();
        private EC_DichVu EC_DV = new EC_DichVu();
        private bool _them = false;
        private void frmQuanLyDV_Load(object sender, EventArgs e)
        {
            dgvDanhSach.DataSource = DAL_DV.GetAll();
        }

        private void dgvDanhSach_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtGia.Text = dgvDanhSach.Rows[e.RowIndex].Cells["Gia"].Value.ToString();
            txtMa.Text = dgvDanhSach.Rows[e.RowIndex].Cells["MaDV"].Value.ToString();
            txtTen.Text = dgvDanhSach.Rows[e.RowIndex].Cells["TenDV"].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            _them = true;
            btnLuu.Enabled = true;
            txtTen.ResetText();
            txtMa.ResetText();
            txtGia.ResetText();
            dgvDanhSach.Enabled = false;
            txtGia.Enabled = true;
            txtMa.Enabled = true;
            txtTen.Enabled = true;
            txtMa.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
            txtTen.Enabled = true;
            txtGia.Enabled = true;
            dgvDanhSach.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (_them)
            {
                EC_DV.MaDV = txtMa.Text;
                EC_DV.TenDV = txtTen.Text;
                EC_DV.Gia = txtGia.Text;
                _them = false;
                DAL_DV.ThemThongTin(EC_DV);
                dgvDanhSach.DataSource = DAL_DV.GetAll();
            }
            else
            {
                EC_DV.MaDV = txtMa.Text;
                EC_DV.TenDV = txtTen.Text;
                EC_DV.Gia = txtGia.Text;
                DAL_DV.SuaThongTin(EC_DV);
                dgvDanhSach.DataSource = DAL_DV.GetAll();
            }
            btnLuu.Enabled = false;
            txtGia.Enabled = false;
            txtMa.Enabled = false;
            txtTen.Enabled = false;
            dgvDanhSach.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            EC_DV.MaDV = txtMa.Text;
            if (DAL_DV.XoaTTDichVu(EC_DV) == 1)
            {
                MessageBox.Show("Xóa thành công");
                dgvDanhSach.DataSource = DAL_DV.GetAll();
            }
            else
            {
                MessageBox.Show("Xóa thất bại. Có đối tượng đang sử dụng dịch vụ");
            }
        }

        private void txtTimMa_TextChanged(object sender, EventArgs e)
        {
            string dk = "";
            dk = "MaDV like N'%" + txtTimMa.Text + "%'";
            if (txtTimTen.Text != null)
            {
                dk += " and TenDV like N'%" + txtTimTen.Text + "%'";
            }
            dgvDanhSach.DataSource = DAL_DV.GetAll(dk);
        }

        private void txtTimTen_TextChanged(object sender, EventArgs e)
        {
            string dk = "";
            dk = "TenDV like N'%" + txtTimTen.Text + "%'";
            if (txtTimMa.Text != null)
            {
                dk += " and MaDV like N'%" + txtTimMa.Text + "%'";
            }
            dgvDanhSach.DataSource = DAL_DV.GetAll(dk);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtTimTen.Clear();
            txtTimMa.Clear();
        }
    }
}
