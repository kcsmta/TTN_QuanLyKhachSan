using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.Data;

namespace DAL
{
    public class DAL_Phong
    {
        private KetNoiData connect = new KetNoiData();
        public DataTable ThongTinPhong(string dk)
        {
            DataTable tb = connect.GetDataTable("select * from tblPhong " + dk);
            return tb;
        }

        public int ThemThongTin(EC_Phong EC_Ph)
        {
            return connect.ThucHienLenh("insert into tblPhong(MaPh,SoPhong,TrangThai) values(N'" + EC_Ph.MaPh + "', N'" + EC_Ph.SoPhong + "', N'" + EC_Ph.TrangThai + "') ");
        }

        public int SuaThongTin(EC_Phong EC_Ph)
        {
            return connect.ThucHienLenh("update tblPhong set SoPhong = N'" + EC_Ph.SoPhong + "', TrangThai = N'" + EC_Ph.TrangThai + "'  where MaPh = '" + EC_Ph.MaPh + "'");
        }

        public int XoaTTPhong(EC_Phong EC_Ph)
        {
            return connect.ThucHienLenh("delete from tblPhong where MaPh = '" + EC_Ph.MaPh + "'");
        }
        public DataTable TaoBang(string DieuKien)
        {
            return connect.GetDataTable(@"SELECT * FROM tblPhong " + DieuKien);
        }

        public void TraPhong(EC_Phong EC_Ph)
        {
            connect.ThucHienLenh("update tblPhong set TrangThai = N'" + EC_Ph.TrangThai + "'  where MaPh = '" + EC_Ph.MaPh + "'");
        }
    }
}
