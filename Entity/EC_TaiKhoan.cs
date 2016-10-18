using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class EC_TaiKhoan
    {
        private string _MaNV;
        public string MaNV
        {
            get { return _MaNV; }
            set { _MaNV = value; }
        }

        private string _MatKhau;
        public string MatKhau
        {
            get { return _MatKhau; }
            set { _MatKhau = value; }
        }

        private string _LoaiTK;
        public string LoaiTK
        {
            get { return _LoaiTK; }
            set { _LoaiTK = value; }
        }
    }
}
