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
            connect.ThucHienLenh("insert into tblHoaDon(MaHD, MaPhieuThue, NgayVao, NgayRa, ThanhTien) values(N'" + EC_HD.MaHD + "', N'" + EC_HD.MaPhieuThue + "', '" + EC_HD.NgayVao + "', '" + EC_HD.NgayRa + "', '" + EC_HD.ThanhTien +"') ");
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
            DataTable tb = connect.GetDataTable(@"select t.TenKH, t.MaPh, t.SoPhong, t.MaKH, t.MaPhieu, t.TenPT, t.DonGia, t.MaHD, t.NgayVao, t.NgayRa, t.ThanhTien , v.MaDV, v.ThoiGian, v.TenDV, v.Gia
from (select p.MaPh, p.SoPhong, k.MaKH, k.TenKH, pt.MaPhieu,ptt.TenPT, ptt.DonGia, h.MaHD, h.NgayVao, h.NgayRa, h.ThanhTien 
	  from tblPhong p,tblPhieuThue pt,tblKhachHang k,tblPhuongThucThue ptt,tblHoaDon h
	  where p.MaPh = pt.MaPh and pt.MaPhieu = h.MaPhieuThue and k.MaKH = pt.MaKH
	  and ptt.MaPT = pt.MaPT and h.MaPhieuThue = pt.MaPhieu and h.ThanhTien = 0 and h.MaHD  = '" + maHd + @"')  t 
left join (select s.MaHD,s.MaDV, s.ThoiGian, d.TenDV, d.Gia 
		   from tblSuDungDV s, tblDichVu d 
		   where s.MaDV=d.MaDV ) v
on	t.MaHD = v.MaHD ");
            return tb;
        }
        public DataTable ThongTinThanhToanKH(string maKh)
        {
            DataTable tb = connect.GetDataTable(@"select t.TenKH, t.MaPh, t.SoPhong, t.MaKH, t.MaPhieu, t.TenPT, t.DonGia, t.MaHD, t.NgayVao, t.NgayRa, t.ThanhTien , v.MaDV, v.ThoiGian, v.TenDV, v.Gia
from (select p.MaPh, p.SoPhong, k.MaKH, k.TenKH, pt.MaPhieu, ptt.TenPT, ptt.DonGia, h.MaHD, h.NgayVao, h.NgayRa, h.ThanhTien 
	  from tblPhong p,tblPhieuThue pt,tblKhachHang k,tblPhuongThucThue ptt,tblHoaDon h
	  where p.MaPh = pt.MaPh and pt.MaPhieu = h.MaPhieuThue and k.MaKH = pt.MaKH
	  and ptt.MaPT = pt.MaPT and h.MaPhieuThue = pt.MaPhieu and h.ThanhTien = 0 and k.MaKH = '" + maKh + @"' )  t 
left join (select s.MaHD,s.MaDV, s.ThoiGian, d.TenDV, d.Gia 
		   from tblSuDungDV s, tblDichVu d 
		   where s.MaDV=d.MaDV) v
on	t.MaHD = v.MaHD ");
            return tb;
        }
    }
}
