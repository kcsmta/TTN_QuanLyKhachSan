using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Entity;

namespace DAL
{
    public class DAL_NhanVien
    {
        private KetNoiData connect = new KetNoiData();
        public DataTable ThongTinNV(string us)
        {
            DataTable tb = connect.GetDataTable(@"select * from tblNhanVien where MaNV = '" + us +"'");
            return tb;
        }

        public void ThemThongTin(EC_NhanVien EC_NV)
        {
            connect.ThucHienLenh(@"insert into tblNhanVien(MaNV, TenNV, NgaySinh, GioiTinh, CMND, DiaChi, SoDT) values(N'" + EC_NV.MaNV + "', N'" + EC_NV.TenNV + "', '" + EC_NV.NgaySinh + "', N'" + EC_NV.GioiTinh + "', '" + EC_NV.CMND + "', N'" + EC_NV.DiaChi + "', '" + EC_NV.SoDT + "') ");
        }

        public void SuaThongTin(EC_NhanVien EC_NV)
        {
            connect.ThucHienLenh(@"update tblNhanVien set TenNV = N'" + EC_NV.TenNV + "', NgaySinh = '" + EC_NV.NgaySinh + "', GioiTinh = N'" + EC_NV.GioiTinh + "', CMND = '" + EC_NV.CMND + "', SoDT = '" + EC_NV.SoDT + "', DiaChi = N'" + EC_NV.DiaChi + "'  where MaNV = '" + EC_NV.MaNV + "'");
        }

        public void XoaTTNhanVien(EC_NhanVien EC_NV)
        {
            connect.ThucHienLenh(@"delete from tblNhanVien where MaNV = '" + EC_NV.MaNV + "'");
            connect.ThucHienLenh(@"insert into tblNhanVien(MaNV) values('" + EC_NV.MaNV + "')");
        }
    }
}
