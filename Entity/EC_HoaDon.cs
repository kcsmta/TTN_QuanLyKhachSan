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
        private DateTime _NgayVao;

        public DateTime NgayVao
        {
            get { return _NgayVao; }
            set { _NgayVao = value; }
        }
        private DateTime _NgayRa;

        public DateTime NgayRa
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

        private string _Gia;
        public string Gia
        {
            get { return _Gia; }
            set { _Gia = value; }
        }
    }
}
