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
    public class DAL_HoaDon
    {
        private KetNoiData connect = new KetNoiData();
        public DataTable ThongTinHD(string MaHD)
        {
            DataTable tb = connect.GetDataTable("select * from tblHoaDon where MaHD = '" + MaHD + "'");
            return tb;
        }

        public void ThemThongTin(EC_HoaDon EC_HD)
        {
            connect.ThucHienLenh("insert into tblHoaDon(MaHD, MaPhieuThue, NgayVao, NgayRa, ThanhTien, DonGiaHT) values(N'" + EC_HD.MaHD + "', N'" + EC_HD.MaPhieuThue + "', '" + EC_HD.NgayVao + "', '" + EC_HD.NgayRa + "', '" + EC_HD.ThanhTien +"', " + EC_HD.Gia.ToString() + ") ");
        }

        public void SuaThongTin(EC_HoaDon EC_HD)
        {
            connect.ThucHienLenh("update tblHoaDon set NgayVao = '" + EC_HD.NgayVao + "', NgayRa = '" + EC_HD.NgayRa + "', ThanhTien = " + EC_HD.ThanhTien + " where MaHD = '" + EC_HD.MaHD + "'");
        }

        public void XoaTTHoaDon(EC_HoaDon EC_HD)
        {
            connect.ThucHienLenh("delete from tblHoaDon where MaHD = '" + EC_HD.MaHD + "'");
        }

        public DataTable ThongTinThanhToan(string maHd)
        {
            return connect.GetDataTable(@"select SoPhong, TenDV,ThoiGian, tblSuDungDV.Gia from tblPhong,tblPhieuThue,tblHoaDon,tblSuDungDV,tblDichVu where tblPhong.MaPh = tblPhieuThue.MaPh and tblPhieuThue.MaPhieu = tblHoaDon.MaPhieuThue and tblHoaDon.MaHD = tblSuDungDV.MaHD and tblSuDungDV.MaDV = tblDichVu.MaDV and tblHoaDon.MaHD = '" + maHd + "' order by SoPhong,ThoiGian");
        }

        public void ThanhToan(EC_HoaDon EC_HD)
        {
            connect.ThucHienLenh("update tblHoaDon set ThanhTien = " + EC_HD.ThanhTien + " where MaHD = '" + EC_HD.MaHD + "'");
        }
    }
}
