
using System.Data;
using System.Data.SQLite;

namespace Bai05
{

    public class SinhVienDAL
    {
        private string connectionString = "Data Source=./SinhVien.db;Version=3;";

        public SinhVienDAL()
        {
            EnsureDatabase();
        }

        private void EnsureDatabase()
        {
            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string create = @"
                    CREATE TABLE IF NOT EXISTS SinhVien (
                        MaSV   TEXT PRIMARY KEY,
                        HoTen  TEXT NOT NULL,
                        Khoa   TEXT,
                        DiemTB REAL
                    );";
                using (var cmd = new SQLiteCommand(create, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void AddSinhVien(string maSV, string hoTen, string khoa, double diemTB)
        {
            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO SinhVien (MaSV, HoTen, Khoa, DiemTB) VALUES (@masv, @hoten, @khoa, @diemtb)";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@masv", maSV);
                    cmd.Parameters.AddWithValue("@hoten", hoTen);
                    cmd.Parameters.AddWithValue("@khoa", khoa);
                    cmd.Parameters.AddWithValue("@diemtb", diemTB);
             
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public DataTable GetListOfSinhVien()
        {
            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT MaSV, HoTen, Khoa, DiemTB FROM SinhVien ORDER BY MaSV";
                using (var da = new SQLiteDataAdapter(query, conn))
                {
                    var dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }
    }
}
