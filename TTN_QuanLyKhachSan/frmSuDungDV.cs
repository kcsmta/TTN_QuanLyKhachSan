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
    public partial class frmSuDungDV : Form
    {
        public frmSuDungDV()
        {
            InitializeComponent();
        }

        private DAL_SuDungDichVu DAL_SuDung = new DAL_SuDungDichVu();
        private EC_SuDungDichVu EC_SuDung = new EC_SuDungDichVu();
        private int _dong;
        private bool _chon = false;
        private bool _them = false;
        private bool _xoa = false;
        private bool _koload = true;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!_chon)
            {
                labNgay.Text = DateTime.Today.ToShortDateString();
                labGio.Text = DateTime.Now.ToLongTimeString();
            }          
        }

        private void frmSuDungDV_Load(object sender, EventArgs e)
        {
            _koload = false;
            var source = new AutoCompleteStringCollection();
            DataTable tb = DAL_SuDung.getPhong();
            cboPhong.DataSource = tb;
            cboPhong.DisplayMember = "SoPhong";
            cboPhong.ValueMember = "MaPh";
            for (int _i = 0; _i < tb.Rows.Count; _i++) source.Add(tb.Rows[_i]["SoPhong"].ToString());
            cboPhong.AutoCompleteCustomSource = source;

            tb = DAL_SuDung.getDV();
            cboDichVu.DataSource = tb;
            cboDichVu.DisplayMember = "TenDV";
            cboDichVu.ValueMember = "MaDV";
            for (int _i = 0; _i < tb.Rows.Count; _i++) source.Add(tb.Rows[_i]["TenDV"].ToString());
            cboDichVu.AutoCompleteCustomSource = source;

            dgvDanhSach.DataSource = DAL_SuDung.getDanhSach();
            if (dgvDanhSach.RowCount != 0) btnXoa.Enabled = true;
            _koload = true;
        }

        private void dgvDanhSach_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (_koload) timer1.Enabled = false;
            cboDichVu.SelectedIndex = -1;
            cboDichVu.Text = dgvDanhSach.Rows[e.RowIndex].Cells["TenDV"].Value.ToString();
            cboPhong.SelectedIndex = -1;
            cboPhong.Text = dgvDanhSach.Rows[e.RowIndex].Cells["TenPhong"].Value.ToString();
            txtHoaDon.Text = dgvDanhSach.Rows[e.RowIndex].Cells["MaHD"].Value.ToString();
            string s = dgvDanhSach.Rows[e.RowIndex].Cells["ThoiGian"].Value.ToString();
            labNgay.Text = s.Substring(0,11);
            labGio.Text = s.Substring(11,s.Length - 11);
            _dong = e.RowIndex;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            timer1_Tick(null,null);
            timer1.Enabled = false;
            cboPhong.Enabled = true;
            cboDichVu.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            cboPhong.ResetText();
            cboDichVu.ResetText();
            txtHoaDon.ResetText();
            _them = true;
            btnXoa.Enabled = true;
        }

        private void cboPhong_TextChanged(object sender, EventArgs e)
        {
            if (_them)
            {
                txtHoaDon.Text = DAL_SuDung.getMaHD(cboPhong.Text);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            EC_SuDung.MaDV = cboDichVu.SelectedValue.ToString();
            EC_SuDung.MaHD = txtHoaDon.Text;

            dtpThoiGian.Value = Convert.ToDateTime(labNgay.Text);
            EC_SuDung.ThoiGian = dtpThoiGian.Value;         

            DAL_SuDung.addSuDung(EC_SuDung);//ok
            dgvDanhSach.DataSource = DAL_SuDung.getDanhSach();
            _them = false;
            btnLuu.Enabled = false;
            btnThem.Enabled = true;
            timer1.Enabled = true;
            cboPhong.Enabled = false;
            cboDichVu.Enabled = false;
        }

        private void cboPhong_Validated(object sender, EventArgs e)
        {
            if (cboPhong.SelectedValue == null)
            {
                MessageBox.Show("Không có Phòng");
                cboPhong.Focus();
            }
            if (txtHoaDon.Text == "")
            {
                MessageBox.Show("Phòng chưa được thuê");
                cboPhong.Focus();
            }
        }

        private void cboDichVu_Validated(object sender, EventArgs e)
        {
            if (cboDichVu.SelectedValue == null)
            {
                MessageBox.Show("Không có Dich vụ");
                cboDichVu.Focus();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            _xoa = true;
            string temp = dgvDanhSach.Rows[_dong].Cells["ThoiGian"].Value.ToString();
            dtpThoiGian.Text = temp;
            EC_SuDung.ThoiGian = Convert.ToDateTime(dtpThoiGian.Text + temp.Substring(10, temp.Length - 10));
            EC_SuDung.MaDV = cboDichVu.SelectedValue.ToString();
            EC_SuDung.MaHD = txtHoaDon.Text;
            DAL_SuDung.delSuDung(EC_SuDung);
            dgvDanhSach.DataSource = DAL_SuDung.getDanhSach();
            timer1.Enabled = true;
            dtpThoiGian.ResetText();
            if (dgvDanhSach.RowCount == 0) btnXoa.Enabled = false;
            _xoa = false;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            timer1_Tick(null,null);
            dgvDanhSach.DataSource = DAL_SuDung.getDanhSach();
            btnThem.Enabled = true;
            btnLuu.Enabled = false;
            cboDichVu.Enabled = false;
            cboPhong.Enabled = false;
            dtpThoiGian.ResetText();
            txtTimPhong.Clear();
            txtTimDV.Clear();
            timer1.Enabled = true;
        }

        private void txtTimPhong_TextChanged(object sender, EventArgs e)
        {
            string dk;
            dk = "and SoPhong like '%" + txtTimPhong.Text + "%'";
            if (txtTimDV.Text != "") dk += " and TenDV like N'%" + txtTimDV.Text + "%'";
            dgvDanhSach.DataSource = DAL_SuDung.getDanhSach(dk);
        }

        private void txtTimDV_TextChanged(object sender, EventArgs e)
        {
            string dk;
            dk = "and TenDV like N'%" + txtTimDV.Text + "%'";
            if (txtTimPhong.Text != "") dk += " and SoPhong like '%" + txtTimPhong.Text + "%'";
            dgvDanhSach.DataSource = DAL_SuDung.getDanhSach(dk);
        }
    }
}
