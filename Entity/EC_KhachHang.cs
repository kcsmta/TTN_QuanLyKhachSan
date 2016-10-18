using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class EC_KhachHang
    {
        private string _MaKH;
        public string MaKH
        {
            get { return _MaKH; }
            set { _MaKH = value; }
        }
        private string _TenKH;
        public string TenKH
        {
            get { return _TenKH; }
            set { _TenKH = value; }
        }
        private DateTime _NgaySinh;
        public DateTime NgaySinh
        {
            get { return _NgaySinh; }
            set { _NgaySinh = value; }
        }
        private string _GT;
        public string GT
        {
            get { return _GT; }
            set { _GT = value; }
        }
        private string _SoDT;
        public string SoDT
        {
            get { return _SoDT; }
            set { _SoDT = value; }
        }
        private string _CMND;
        public string CMND
        {
            get { return _CMND; }
            set { _CMND = value; }
        }
        private string _DiaChi;
        public string DiaChi
        {
            get { return _DiaChi; }
            set { _DiaChi = value; }
        }
    }
}
