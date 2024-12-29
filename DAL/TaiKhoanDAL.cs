using System;
using System.Data.SqlClient;


namespace MinsuNet.DAL
{
    public class TaiKhoanDAL
    {
        private string connectionString = @"Data Source=MINHVIP\SQLEXPRESS;Initial Catalog=QuanLyTiemNet;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

        public void CreateAccount(string tenDangNhap, string matKhau, string hoTen, string email)
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO TaiKhoanAdmin (TenDangNhap, MatKhau, HoTen, Email) VALUES (@TenDangNhap, @MatKhau, @HoTen, @Email)";
                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@TenDangNhap", tenDangNhap);
                        command.Parameters.AddWithValue("@MatKhau", matKhau); // Nên mã hóa mật khẩu
                        command.Parameters.AddWithValue("@HoTen", hoTen);
                        command.Parameters.AddWithValue("@Email", email);

                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Lỗi khi đăng ký: " + ex.Message);
            }
        }

        public bool ValidateLogin(string tenDangNhap, string matKhau)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM TaiKhoanAdmin WHERE TenDangNhap = @TenDangNhap AND MatKhau = @MatKhau";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TenDangNhap", tenDangNhap);
                    command.Parameters.AddWithValue("@MatKhau", matKhau);

                    connection.Open();
                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }
        }
    }
}