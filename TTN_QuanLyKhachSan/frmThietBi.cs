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
    public partial class frmThietBi : Form
    {
        private DAL_ThietBi dal_tb = new DAL_ThietBi();
        private EC_ThietBi ec = new EC_ThietBi();
        private DataTable tblThietBi = new DataTable();
        private bool themmoi;
        void SetNull()
        {
            cboMaPh.Text = "";
            txtThietBi.Text = "";
            txtSoLuong.Text = "";
            txtNhaSanXuat.Text = "";
        }
        private void KhoaDieuKhien()
        {
            cboMaPh.Enabled = false;
            txtThietBi.ReadOnly = true;
            txtSoLuong.ReadOnly = true;
            txtNhaSanXuat.ReadOnly = true;

            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;

        }
        private void MoDieuKhien()
        {
            cboMaPh.Enabled = true;
            txtThietBi.ReadOnly = false;
            txtSoLuong.ReadOnly = false;
            txtNhaSanXuat.ReadOnly = false;
        }
        private void HienThi(string where)
        {
            dgvDanhSach.DataSource = dal_tb.TaoBang(where);
        }
        private void DoDLMaLop()
        {
  
            cboMaPh.DataSource = dal_tb.TruyVanRaMaPh("");
            cboMaPh.DisplayMember = "MaPh";
        }
        public frmThietBi()
        {
            InitializeComponent();
        }

        private void frmThietBi_Load(object sender, EventArgs e)
        {
            HienThi("");
            KhoaDieuKhien();
            DoDLMaLop();
        }

        private void dgvDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                int dong = e.RowIndex;/*biến dòng :kich vào dòng thì chỉ số dòng đc lưu vào biến dòng */
                cboMaPh.Text = dgvDanhSach.Rows[dong].Cells[0].Value.ToString();
                txtThietBi.Text = dgvDanhSach.Rows[dong].Cells[1].Value.ToString();
                txtSoLuong.Text = dgvDanhSach.Rows[dong].Cells[2].Value.ToString();
                txtNhaSanXuat.Text = dgvDanhSach.Rows[dong].Cells[3].Value.ToString();
            }
            catch
            {

            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //kich hoat cac chuc năng
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            txtThietBi.Focus();
            MoDieuKhien();
            SetNull();
            themmoi = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            //kich hoat cac chuc năng
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            MoDieuKhien();
            txtThietBi.ReadOnly = true;
            cboMaPh.Enabled = false;
            themmoi = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult xacnhan;
            xacnhan = MessageBox.Show("Bạn có chắc chắn muốn xóa không??", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (xacnhan == DialogResult.OK)
            {
                ec.MaPh = cboMaPh.Text;
                ec.ThietBi = txtThietBi.Text;
                if (dal_tb.XoaTTThietBi(ec)==0 )
                {

                    MessageBox.Show("Không thể xoá!!!", "Thông báo???", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
                else
                {
                    dal_tb.XoaTTThietBi(ec);
                    MessageBox.Show("Đã xóa thành công!");
                    btnCapNhap_Click(sender, e);
                    SetNull();

                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtThietBi.Text == "" || txtSoLuong.Text == "" || txtNhaSanXuat.Text == ""||cboMaPh.Text=="" )
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
                        ec.ThietBi = txtThietBi.Text;
                        ec.MaPh= cboMaPh.Text;
                        ec.SoLuong = int.Parse(txtSoLuong.Text);
                        ec.NhaSanXuat = txtNhaSanXuat.Text;

                        dal_tb.ThemThongTin(ec);
                        MessageBox.Show("Đã thêm mới thành công");/*dòng thông báo*/
                        btnCapNhap_Click(sender, e);
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
                        ec.ThietBi = txtThietBi.Text;
                        ec.MaPh = cboMaPh.Text;
                        ec.SoLuong = int.Parse(txtSoLuong.Text);
                        ec.NhaSanXuat = txtNhaSanXuat.Text;
                        dal_tb.SuaThongTin(ec);
                        MessageBox.Show("Đã sửa thành công");
                        btnCapNhap_Click(sender, e);
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
                HienThi("");
            }
        }

        private void btnCapNhap_Click(object sender, EventArgs e)
        {
            DataTable tbl = dal_tb.TaoBang("");
            dgvDanhSach.DataSource = tbl;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
            Dispose();
        }

        private void cboMaPh_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
