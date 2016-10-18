using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class EC_HoaDon
    {
        private string _MaHD;

        public string MaHD
        {
            get { return _MaHD; }
            set { _MaHD = value; }
        }
        private string _MaPhieuThue;

        public string MaPhieuThue
        {
            get { return _MaPhieuThue; }
            set { _MaPhieuThue = value; }
        }
        private string _NgayVao;

        public string NgayVao
        {
            get { return _NgayVao; }
            set { _NgayVao = value; }
        }
        private string _NgayRa;

        public string NgayRa
        {
            get { return _NgayRa; }
            set { _NgayRa = value; }
        }
        private string _ThanhTien;

        public string ThanhTien
        {
            get { return _ThanhTien; }
            set { _ThanhTien = value; }
        }
    }
}
