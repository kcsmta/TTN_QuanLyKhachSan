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
    public class DAL_SuDungDV
    {
        private KetNoiData connect = new KetNoiData();
        public DataTable ThongTinSuDungDV(string MaHD)
        {
            DataTable tb = connect.GetDataTable("select * from tblSuDungDV where MaHD = '" + MaHD + "'");
            return tb;
        }

        public void ThemThongTin(EC_SuDungDV EC_SD)
        {
            connect.ThucHienLenh("insert into tblSuDungDV(MaHD,MaDV,ThoiGian) values(N'" + EC_SD.MaHD + "', N'" + EC_SD.MaDV + "', N'" + EC_SD.ThoiGian + "'");
        }

        public void SuaThongTin(EC_SuDungDV EC_SD)
        {
            connect.ThucHienLenh("update tblSuDungDV set ThoiGian = N'" + EC_SD.ThoiGian + "'  where MaHD = '" + EC_SD.MaHD + "' and MaDV = N'"+EC_SD.MaDV+"' and ThoiGian='"+EC_SD.ThoiGian+"'");
        }

        public void XoaTTSuDungDV(EC_SuDungDV EC_SD)
        {
            connect.ThucHienLenh("delete from tblSuDungDV where MaHD = '" + EC_SD.MaHD + "'");
        }
    }
}
