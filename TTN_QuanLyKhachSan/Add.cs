using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Windows.Forms.Layout;
using DevExpress.XtraEditors;
using System.Drawing;

namespace TTN_QuanLyKhachSan
{
    class Add
    {
          // Xây dựng hàm dùng để add XtratabPage và XtraTabcontrol 
        //(Hàm này đặt trong Project có dạng Library để Build thành file .dll .
        // Mục đích : viết 1 lần nhưng sử dụng cho nhiều Project khác nhau)
        // Sử dụng 4 đối số truyền vào cho hàm này gồm có:
        //1> DevExpress.XtraTab.XtraTabControl XtraTabCha : Tạm gọi là Tab Cha vì XtraTabControl này để mình quăng tabcon vào
        //2> string icon : Khi add Tab con vào Tab cha thì đối số này để quy định icon hình cho tabCon(XtraTabpage)
        //3> string TabNameAdd : Khi add tab con vào thì đối số này quy định tên của Tabcon vừa Add vào đó.
        //4> System.Windows.Forms.UserControl UserControl: Cái này dùng để Add cái UserControl do ta tạo vào Tabcon
        // Đướng đi: Khi gọi hàm này phải truyền vào 4 đối số để biết:
        //Anh muốn add 1 cái Tab con vào cái tab Cha nào?
        // Anh muốn đặt tên Tab con đó tên là gì?
        // anh muốn cái Tab con khi add vào thì Icon của nó là gì?
        // Anh muốn đặt cái gì vào trong cái Tab Con đó trước khi quăng nó lên TAb Cha?
        // Note : Các bạn có thể tùy biến nhiều đối số khác nữa nhé.
        public void AddTab(DevExpress.XtraTab.XtraTabControl XtraTabCha, string icon, string TabNameAdd, Form UserControl)
        {
            // Khởi tạo 1 Tab Con (XtraTabPage)
            DevExpress.XtraTab.XtraTabPage TAbAdd = new DevExpress.XtraTab.XtraTabPage();
            // Đặt đại cái tên cho nó là TestTab (Đây là tên nhé)
            TAbAdd.Name = "TestTab";
            // Tên của nó là đối số như đã nói ở trên
            TAbAdd.Text = TabNameAdd;
            // Add đối số UserControl vào Tab con vừa khởi tạo ở trên
            // TAbAdd.Controls.Add(UserControl);
            UserControl.TopLevel = false;
            UserControl.Parent = TAbAdd;
            // Dock cho nó tràn hết TAb con đó
            UserControl.Dock = DockStyle.Fill;
            try
            {
                // Icon của Tab con khi add vào Tab cha sẽ được quy định ở đây(cái này các bác tự chọn đường dẫn đến file Icon đó nhé)
                TAbAdd.Image = System.Drawing.Bitmap.FromFile(System.Windows.Forms.Application.StartupPath.ToString() + @"\Icons\" + icon);

            }
            catch (Exception e)
            {
            }
            // Quăng nó lên TAb Cha (XtraTabCha là đối số thứ nhất như đã nói ở trên)
            XtraTabCha.TabPages.Add(TAbAdd);
            UserControl.Show();
        }   
    }
}
