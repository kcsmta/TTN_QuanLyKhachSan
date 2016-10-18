using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class EC_NhanVien
    {
        private string _MaNV;
        public string MaNV
        {
            get { return _MaNV; }
            set { _MaNV = value; }
        }

        private string _TenNV;
        public string TenNV
        {
            get { return _TenNV; }
            set { _TenNV = value; }
        }

        private string _GioiTinh;
        public string GioiTinh
        {
            get { return _GioiTinh; }
            set { _GioiTinh = value; }
        }

        private string _NgaySinh;
        public string NgaySinh
        {
            get { return _NgaySinh; }
            set { _NgaySinh = value; }
        }

        private string _CMND;
        public string CMND
        {
            get { return _CMND; }
            set { _CMND = value; }
        }

        private string _SoDT;
        public string SoDT
        {
            get { return _SoDT; }
            set { _SoDT = value; }
        }

        private string _DiaChi;
        public string DiaChi
        {
            get { return _DiaChi; }
            set { _DiaChi = value; }
        }
    }
}
