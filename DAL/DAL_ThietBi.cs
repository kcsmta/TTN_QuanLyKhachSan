using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Entity;

namespace DAL
{
    public class DAL_ThietBi
    {
        private KetNoiData connect = new KetNoiData();

        public int ThemThongTin(EC_ThietBi EC_ThietBi)
        {
            return connect.ThucHienLenh("insert into tblThietBi(MaPh, ThietBi, SoLuong, NhaSanXuat) values(N'" + EC_ThietBi.MaPh + "', N'" + EC_ThietBi.ThietBi + "', '" + EC_ThietBi.SoLuong + "', N'" + EC_ThietBi.NhaSanXuat + "') ");
        }

        public int SuaThongTin(EC_ThietBi EC_ThietBi)
        {
           return connect.ThucHienLenh("update tblThietBi set SoLuong='"+EC_ThietBi.SoLuong+"',NhaSanXuat=N'"+EC_ThietBi.NhaSanXuat+"' where MaPh=N'"+EC_ThietBi.MaPh+"' and ThietBi=N'"+EC_ThietBi.ThietBi+"'");
        }

        public int  XoaTTThietBi(EC_ThietBi EC_ThietBi)
        {
            return connect.ThucHienLenh("delete from tblThietBi where MaPh=N'" + EC_ThietBi.MaPh + "' and ThietBi=N'" + EC_ThietBi.ThietBi + "'");
            
        }
        public DataTable TaoBang(string DieuKien)
        {
            return connect.GetDataTable(@"SELECT * FROM tblThietBi " +DieuKien);
        }
        public DataTable TruyVanRaMaPh(string DieuKien)
        {
            return connect.GetDataTable(@"SELECT MaPh from tblPhong " + DieuKien);
        }
    }
}
