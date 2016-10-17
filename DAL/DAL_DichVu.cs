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
    public class DAL_DichVu
    {
        private KetNoiData connect = new KetNoiData();
        public DataTable ThongTinDichVu(string MaDV)
        {
            DataTable tb = connect.GetDataTable("select * from tblDichVu where MaDV = '" + MaDV + "'");
            return tb;
        }

        public void ThemThongTin(EC_DichVu EC_DV)
        {
            connect.ThucHienLenh("insert into tblDichVu(MaDV,TenDV,Gia) values(N'" + EC_DV.MaDV + "', N'" + EC_DV.TenDV + "', '" + EC_DV.Gia + "')");
        }

        public void SuaThongTin(EC_DichVu EC_DV)
        {
            connect.ThucHienLenh("update tblDichVu set TenDV = N'" + EC_DV.TenDV + "', Gia = N'" + EC_DV.Gia + "'  where MaDV = '" + EC_DV.MaDV + "'");
        }

        public int XoaTTDichVu(EC_DichVu EC_DV)
        {
            return connect.ThucHienLenh("delete from tblDichVu where MaDV = '" + EC_DV.MaDV + "'");
        }
    
        public DataTable GetAll()
        {
            return connect.GetDataTable(@"select * from tblDichVu");
        }

        public DataTable GetAll(string dk)
        {
            return connect.GetDataTable(@"select * from tblDichVu where " + dk);
        }

        public string GetGia(string MaDV)
        {
            return connect.GetValue("Select Gia from tblDichVu where MaDV = '" + MaDV +"'");
        }
    }
}
