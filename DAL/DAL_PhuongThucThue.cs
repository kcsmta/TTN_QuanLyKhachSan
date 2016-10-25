using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DAL;
using System.Data;

namespace DAL
{
    public class DAL_PhuongThucThue
    {
        private KetNoiData connect = new KetNoiData();
        public DataTable ThongTinPhuongThucThue(string MaPT)
        {
            DataTable tb = connect.GetDataTable("select * from tbPhuongThucThue where MaPT = '" + MaPT + "'");
            return tb;
        }

        public void ThemThongTin(EC_PhuongThucThue EC_PT)
        {
            connect.ThucHienLenh("insert into tbPhuongThucThue(MaPT,TenPT,DonGia) values(N'" + EC_PT.MaPT + "', N'" + EC_PT.TenPT + "', '" + EC_PT.DonGia + "')");
        }

        public void SuaThongTin(EC_PhuongThucThue EC_PT)
        {
            connect.ThucHienLenh("update tbPhuongThucThue set TenPT = N'" + EC_PT.TenPT + "', DonGia = '" + EC_PT.DonGia + "'  where MaPT = N'" + EC_PT.MaPT + "'");
        }

        public void XoaTTPhuongThucThue(EC_PhuongThucThue EC_PT)
        {
            connect.ThucHienLenh("delete from tbPhuongThucThue where MaPT = N'" + EC_PT.MaPT + "'");
        }
    }
}
