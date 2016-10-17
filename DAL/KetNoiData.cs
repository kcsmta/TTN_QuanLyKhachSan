using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class KetNoiData
    {
        private static SqlConnection connect;

        private void MoKetNoi()
        {
            if (KetNoiData.connect == null)
                KetNoiData.connect = new SqlConnection(@"Data Source=DESKTOP-T173AL2\TUNGKHANH;Initial Catalog=TTN_QuanLyKhachSan;Integrated Security=True");
            if (KetNoiData.connect.State != ConnectionState.Open)
                KetNoiData.connect.Open();
        }

        private void DongKetNoi()
        {
            if (KetNoiData.connect != null)
            {
                if (KetNoiData.connect.State == ConnectionState.Open)
                {
                    KetNoiData.connect.Close();
                }
            }
        }

        public int ThucHienLenh(string st)
        {
            try
            {
                MoKetNoi();
                SqlCommand sqlcmd = new SqlCommand(st, connect);
                sqlcmd.ExecuteNonQuery();
                DongKetNoi();
                return 1;
            }
            catch
            {
                return 0;
            }
        }

        public DataTable GetDataTable(string st)
        {
            try
            {
                MoKetNoi();
                DataTable dt = new DataTable();
                SqlDataAdapter sqlda = new SqlDataAdapter(st, connect);
                sqlda.Fill(dt);
                DongKetNoi();
                return dt;
            }
            catch
            {
                return null;
            }
        }

        public string GetValue(string st)
        {
            try
            {
                MoKetNoi();
                string gt = "";
                SqlCommand cmd = new SqlCommand(st,connect);
                SqlDataReader reader;
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    gt = (reader.GetValue(0).ToString());
                }
                reader.Close();
                DongKetNoi();
                return gt;
            }
            catch
            {
                return "";
            }
        }
    }
}
