using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class EC_PhuongThucThue
    {
        private string _MaPT;

        public string MaPT
        {
            get { return _MaPT; }
            set { _MaPT = value; }
        }
        private string _TenPT;

        public string TenPT
        {
            get { return _TenPT; }
            set { _TenPT = value; }
        }
        private string _DonGia;

        public string DonGia
        {
            get { return _DonGia; }
            set { _DonGia = value; }
        }
    }
}
