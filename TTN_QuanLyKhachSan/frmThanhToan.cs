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
    public partial class frmThanhToan : Form
    {
        DAL_Phong dalPh = new DAL_Phong();
        KetNoiData cn = new KetNoiData();
        EC_PhieuThue ecPT = new EC_PhieuThue();
        EC_HoaDon ecHD = new EC_HoaDon();
        DAL_HoaDon dalHD = new DAL_HoaDon();
        public frmThanhToan()
        {
            InitializeComponent();
        }
        public static string findCode(string name, string columnSrc, string columnDes, DataTable tb)
        {
            for (int i = 0; i < tb.Rows.Count; i++)
            {
                if (tb.Rows[i][columnSrc].ToString() == name) return tb.Rows[i][columnDes].ToString();
            }
            return null;
        }

        public static int getCost(DateTime dateIn, DateTime dateOut, int cost)
        {
            TimeSpan Time = dateOut - dateIn;
            int sum = Time.Days;
            return sum * cost;
        }

        private void frmThanhToan_Load(object sender, EventArgs e)
        {
            DateTime date = DateTime.Today.AddDays(0);
            dtpNgayra.Value = date;
            //load combobox
            DataTable tb = cn.GetDataTable("Select distinct MaKH, tenKH from tblKhachHang");
            cmbKhachhang.DataSource = tb;
            cmbKhachhang.DisplayMember = "tenKH";
            txtMaKH.Text = findCode(cmbKhachhang.Text, "TenKH", "MaKH", tb);
            
            //load Hoadon
            tb = cn.GetDataTable("Select distinct h.MaHD from tblKhachHang k, tblHoaDon h, tblPhieuThue p where k.MaKH = p.MaKH and p.MaPhieu = h.MaPhieuThue and h.ThanhTien = 0 and k.MaKH='" + txtMaKH.Text + "'");
            cmbMahd.DataSource = tb;
            cmbMahd.DisplayMember = "MaHD";

            //load dgvThongTin
           tb = dalHD.ThongTinThanhToan(cmbMahd.Text);
           dgvThongtin.DataSource = tb;
           for (int i = 0; i < dgvThongtin.RowCount; i++)
           {
               dgvThongtin.Rows[i].Cells["STT"].Value = i + 1;
               if (dgvThongtin.Rows[i].Cells["TenPT"].Value.ToString() == "Qua đêm") dgvThongtin.Rows[i].DefaultCellStyle.BackColor = Color.GreenYellow;
               else
                   if (dgvThongtin.Rows[i].Cells["TenPT"].Value.ToString() == "Dài hạn") dgvThongtin.Rows[i].DefaultCellStyle.BackColor = Color.LightSkyBlue;
                   else
                       if (dgvThongtin.Rows[i].Cells["TenPT"].Value.ToString() == "VIP") dgvThongtin.Rows[i].DefaultCellStyle.BackColor = Color.YellowGreen;
           }

           //lay dl vao ec

           ecHD.NgayVao = date.ToShortDateString();
            

        }

        private void ckcAll_CheckedChanged(object sender, EventArgs e)
        {
            DataTable tb = new DataTable();
            if (ckcAll.Checked == false) tb = dalHD.ThongTinThanhToan(cmbMahd.Text);
            else tb = dalHD.ThongTinThanhToanKH(txtMaKH.Text);

            dgvThongtin.DataSource = tb;
            for (int i = 0; i < dgvThongtin.RowCount; i++)
            {
                dgvThongtin.Rows[i].Cells["STT"].Value = i + 1;
                if (dgvThongtin.Rows[i].Cells["TenPT"].Value.ToString() == "Qua đêm") dgvThongtin.Rows[i].DefaultCellStyle.BackColor = Color.GreenYellow;
                else
                    if (dgvThongtin.Rows[i].Cells["TenPT"].Value.ToString() == "Dài hạn") dgvThongtin.Rows[i].DefaultCellStyle.BackColor = Color.LightSkyBlue;
                    else
                        if (dgvThongtin.Rows[i].Cells["TenPT"].Value.ToString() == "VIP") dgvThongtin.Rows[i].DefaultCellStyle.BackColor = Color.YellowGreen;
            }
        }

        private void cmbKhachhang_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable tb = cn.GetDataTable("Select distinct MaKH, tenKH from tblKhachHang");
            txtMaKH.Text = findCode(cmbKhachhang.Text, "TenKH", "MaKH", tb);

            cmbMahd.Text = "";
            tb = cn.GetDataTable("Select distinct h.MaHD from tblKhachHang k, tblHoaDon h, tblPhieuThue p where k.MaKH = p.MaKH and p.MaPhieu = h.MaPhieuThue and h.ThanhTien = 0 and k.MaKH='" + txtMaKH.Text + "'");
            cmbMahd.DataSource = tb;
            cmbMahd.DisplayMember = "MaHD";
        }



        private void cmbMahd_TextChanged(object sender, EventArgs e)
        {
            DataTable tb = new DataTable();
            if (ckcAll.Checked == false) tb = dalHD.ThongTinThanhToan(cmbMahd.Text);
            else tb = dalHD.ThongTinThanhToanKH(txtMaKH.Text);

            dgvThongtin.DataSource = tb;
            for (int i = 0; i < dgvThongtin.RowCount; i++)
            {
                dgvThongtin.Rows[i].Cells["STT"].Value = i + 1;
                if (dgvThongtin.Rows[i].Cells["TenPT"].Value.ToString() == "Qua đêm") dgvThongtin.Rows[i].DefaultCellStyle.BackColor = Color.GreenYellow;
                else
                    if (dgvThongtin.Rows[i].Cells["TenPT"].Value.ToString() == "Dài hạn") dgvThongtin.Rows[i].DefaultCellStyle.BackColor = Color.LightSkyBlue;
                    else
                        if (dgvThongtin.Rows[i].Cells["TenPT"].Value.ToString() == "VIP") dgvThongtin.Rows[i].DefaultCellStyle.BackColor = Color.YellowGreen;
            }
        }

        private void btnThanhtoan_Click(object sender, EventArgs e)
        {
            int sum = 0;
            for (int i = 0; i < dgvThongtin.RowCount; i++)
            {
                ecHD.MaPhieuThue = dgvThongtin.Rows[i].Cells["MaPh"].Value.ToString();
                ecHD.MaHD = dgvThongtin.Rows[i].Cells["MaHD"].Value.ToString();
                ecHD.NgayVao = (Convert.ToDateTime(dgvThongtin.Rows[i].Cells["NgayVao"].Value.ToString())).ToShortDateString();
                if (dgvThongtin.Rows[i].Cells["NgayRa"].Value.ToString() == "") ecHD.NgayRa = DateTime.Now.ToShortDateString();
                else ecHD.NgayRa = dgvThongtin.Rows[i].Cells["NgayRa"].Value.ToString();
                //tinh tien
                sum = getCost(Convert.ToDateTime(ecHD.NgayVao), Convert.ToDateTime(ecHD.NgayRa), int.Parse(dgvThongtin.Rows[i].Cells["DonGia"].Value.ToString()));
                if (dgvThongtin.Rows[i].Cells["ThoiGian"].Value.ToString() != "") 
                    sum += getCost(Convert.ToDateTime(dgvThongtin.Rows[i].Cells["ThoiGian"].Value.ToString()), Convert.ToDateTime(ecHD.NgayRa), int.Parse(dgvThongtin.Rows[i].Cells["Gia"].Value.ToString()));
                ecHD.ThanhTien = sum.ToString();
                dalHD.SuaThongTin(ecHD);

                //thay doi thong tin phong
                EC_Phong ecPh = new EC_Phong();
                ecPh.MaPh = dgvThongtin.Rows[i].Cells["MaPh"].Value.ToString();
                ecPh.SoPhong = dgvThongtin.Rows[i].Cells["SoPhong"].Value.ToString();
                ecPh.TrangThai = "Tốt";
                dalPh.SuaThongTin(ecPh);
            }
            sum *= -1;// dieu ve lo luon y
            MessageBox.Show(sum.ToString());
            ckcAll_CheckedChanged(sender, e);
        }
    }
}
