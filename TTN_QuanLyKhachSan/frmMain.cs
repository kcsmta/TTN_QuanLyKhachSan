using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Helpers;

namespace TTN_QuanLyKhachSan
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        Add clsAddTab = new Add();

        public static string _taikhoan = "";
        public frmMain()
        {
            InitializeComponent();
        }

        public frmMain(string s)
        {
            InitializeComponent();
            _taikhoan = s;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            
        }

        private void ribbon_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            
        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            
        }

        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
            
        }

        private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
        {
           
        }

        private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e)
        {
            
        }
    }
}