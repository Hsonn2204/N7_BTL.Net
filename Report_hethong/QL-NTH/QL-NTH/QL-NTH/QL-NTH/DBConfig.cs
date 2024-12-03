using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Collections;

namespace QL_NTH
{
    class DBConfig
    {
        private static string DuongDan = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=QLNTH;Integrated Security=True";
        // tạo kết nối
        private static SqlConnection Taoketnoi()
        {
            return new SqlConnection(DuongDan);
        }
        public static DataTable LayBang(string sql)
        {
            SqlConnection KetNoi = Taoketnoi();
            KetNoi.Open();
            DataTable kq = new DataTable();
            SqlDataAdapter MayLayDuLieu = new SqlDataAdapter(sql, KetNoi);
            MayLayDuLieu.Fill(kq);
            KetNoi.Close();
            MayLayDuLieu.Dispose();
            return kq;
        }
        // thêm sửa xóa
        public static void ThemSuaXoa(string sql)
        {
            SqlConnection KetNoi = Taoketnoi();
            KetNoi.Open();
            SqlCommand lenh = new SqlCommand(sql, KetNoi);
            lenh.ExecuteNonQuery();
            KetNoi.Close();
            lenh.Dispose();
        }
        // lấy một giá trị
        public static string LayMotGiaTri(string sql)
        {
            SqlConnection KetNoi = Taoketnoi();
            KetNoi.Open();
            SqlCommand lenh = new SqlCommand(sql, KetNoi);
            object kq = lenh.ExecuteScalar();
            KetNoi.Close();
            lenh.Dispose();
            if (kq != null)
                return kq.ToString();
            else
                return "";
        }
    }
}
