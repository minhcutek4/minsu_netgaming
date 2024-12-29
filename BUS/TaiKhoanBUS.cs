using System.Data.SqlClient;
using System;
using MinsuNet.DAL;



namespace MinsuNet.BUS
{
    public class TaiKhoanBUS
    {
        private string connectionString = @"Data Source=MINHVIP\SQLEXPRESS;Initial Catalog=QuanLyTiemNet;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

        private TaiKhoanDAL dal = new TaiKhoanDAL();

        public void Register(string tenDangNhap, string matKhau, string hoTen, string email)
        {
            // Gọi phương thức CreateAccount với đủ tham số
            dal.CreateAccount(tenDangNhap, matKhau, hoTen, email);
        }

        public bool Login(string tenDangNhap, string matKhau)
        {
            return dal.ValidateLogin(tenDangNhap, matKhau);
        }

        private bool AddUser(string tenDangNhap, string matKhau, string hoTen, string sdt, decimal soTien)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO Users (TenDangNhap, MatKhau, HoTen, SDT, SoTien) VALUES (@TenDangNhap, @MatKhau, @HoTen, @SDT, @SoTien)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@TenDangNhap", tenDangNhap);
                    command.Parameters.AddWithValue("@MatKhau", matKhau);
                    command.Parameters.AddWithValue("@HoTen", hoTen);
                    command.Parameters.AddWithValue("@SDT", sdt);
                    command.Parameters.AddWithValue("@SoTien", soTien);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

    }
}