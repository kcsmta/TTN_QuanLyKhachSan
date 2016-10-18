using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using DAL;

namespace TTN_QuanLyKhachSan
{
    public partial class frmDangNhap : Form
    {
        private DAL_TaiKhoan tk = new DAL_TaiKhoan();
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void frmThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            string pass = tk.LayPass(txtMa.Text);
            if (pass != "")
            {
                if (txtPass.Text == pass)
                {
                    this.Hide();
                    Form frm = new frmMain(txtMa.Text);
                    frm.Show();
                    //frmMain._taikhoan = txtMa.Text;
                    //Properties.Settings.Default.user = txtMa.Text;
                    //Properties.Settings.Default.Save();
                    //DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Sai Mã nhân viên hoặc mật khẩu.");
                }
            }
            else
            {
                MessageBox.Show("Sai Mã nhân viên hoặc mật khẩu.");
            }
        }

        private void frmDangNhap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btn_DangNhap_Click(null,null);
        }

        private void chkLuuTK_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHienMK.Checked) txtPass.PasswordChar = '\0';
            else txtPass.PasswordChar = '*';
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            txtMa.Text = Properties.Settings.Default.user;
        }
    }
}
