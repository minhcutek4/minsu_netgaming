using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MinsuNet;


namespace minsu_net
{
    public partial class MainForm : Form
    {
        private string connectionString = @"Data Source=MINHVIP\SQLEXPRESS;Initial Catalog=QuanLyTiemNet;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
        public MainForm()
        {
            InitializeComponent();
            LoadUsers();
            dataGridView1.CellClick += DataGridView1_CellClick;

        }

        private void lbCashierClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            Login login = new Login();
            login.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void add_user_Click(object sender, EventArgs e)
        {
            // Lấy thông tin từ các TextBox
            string tenDangNhap = txt_user.Text;
            string matKhau = txt_pass.Text;
            string hoTen = txt_name.Text;
            string sdt = txt_phone.Text;
            decimal soTien;

            // Kiểm tra xem số tiền có hợp lệ
            if (!decimal.TryParse(txt_money.Text, out soTien))
            {
                MessageBox.Show("Số tiền không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Thêm người dùng vào cơ sở dữ liệu
            if (AddUser(tenDangNhap, matKhau, hoTen, sdt, soTien))
            {
                // Cập nhật DataGridView
                LoadUsers();
                MessageBox.Show("Thêm người dùng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra khi thêm người dùng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadUsers()
        {
            dataGridView1.Rows.Clear();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Users";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    // Thêm dòng mới vào DataGridView
                    dataGridView1.Rows.Add(reader["STT"], reader["Trangthai"], reader["TenDangNhap"], reader["MatKhau"], reader["HoTen"], reader["SDT"] ,reader["SoTien"]);
                }
            }
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
                return true; // Thêm thành công
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false; // Thêm thất bại
            }
        }

        private void change_user_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0) // Kiểm tra xem có hàng nào được chọn không
            {
                // Lấy hàng được chọn
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Lấy dữ liệu từ hàng được chọn
                string tenDangNhap = selectedRow.Cells[2].Value?.ToString();
                string matKhau = txt_pass.Text; // Lấy giá trị mới từ TextBox
                string hoTen = txt_name.Text; // Lấy giá trị mới từ TextBox
                string sdt = txt_phone.Text; // Lấy giá trị mới từ TextBox
                decimal soTien;
                if (!decimal.TryParse(txt_money.Text, out soTien))
                {
                    MessageBox.Show("Số tiền không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!string.IsNullOrEmpty(tenDangNhap))
                {
                    UpdateUser(tenDangNhap, matKhau, hoTen, sdt, soTien);

                    LoadUsers();

                    MessageBox.Show("Cập nhật người dùng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Hàm cập nhật người dùng trong cơ sở dữ liệu
        private void UpdateUser(string tenDangNhap, string matKhau, string hoTen, string sdt, decimal soTien)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "UPDATE Users SET MatKhau = @MatKhau, HoTen = @HoTen, SDT = @SDT, SoTien = @SoTien WHERE TenDangNhap = @TenDangNhap";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@TenDangNhap", tenDangNhap);
                    command.Parameters.AddWithValue("@MatKhau", matKhau);
                    command.Parameters.AddWithValue("@HoTen", hoTen);
                    command.Parameters.AddWithValue("@SDT", sdt);
                    command.Parameters.AddWithValue("@SoTien", soTien);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi cập nhật: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void UpdateUser(string tenDangNhap, string matKhau, string hoTen, decimal soTien)
        {
            string query = "UPDATE Users SET MatKhau = @MatKhau, HoTen = @HoTen, SoTien = @SoTien WHERE TenDangNhap = @TenDangNhap";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@TenDangNhap", tenDangNhap);
                command.Parameters.AddWithValue("@MatKhau", matKhau);
                command.Parameters.AddWithValue("@HoTen", hoTen);
                command.Parameters.AddWithValue("@SoTien", soTien);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu từ các trường nhập liệu
            string tenDangNhap = txt_user.Text;
            string matKhau = txt_pass.Text;
            string hoTen = txt_name.Text;
            decimal soTien = decimal.Parse(txt_money.Text);

            // Cập nhật người dùng
            UpdateUser(tenDangNhap, matKhau, hoTen, soTien);

            // Cập nhật lại DataGridView
            LoadData(); // Giả sử bạn có phương thức LoadData để tải lại dữ liệu
        }


        private void LoadData()
        {
            string query = "SELECT STT, Status, TenDangNhap, MatKhau, HoTen, SoTien FROM Users"; // Câu lệnh SQL

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    // Xóa dữ liệu cũ trong DataGridView trước khi tải dữ liệu mới
                    dataGridView1.Rows.Clear();

                    while (reader.Read())
                    {
                        // Thêm dữ liệu vào DataGridView
                        dataGridView1.Rows.Add(
                            reader.GetInt32(reader.GetOrdinal("STT")),
                            reader["Status"] != DBNull.Value ? reader["Status"].ToString() : string.Empty,
                            reader.GetString(reader.GetOrdinal("TenDangNhap")),
                            reader.GetString(reader.GetOrdinal("MatKhau")),
                            reader.GetString(reader.GetOrdinal("HoTen")),
                            reader.GetBoolean(reader.GetOrdinal("SDT")),
                            reader.GetDecimal(reader.GetOrdinal("SoTien"))
                        );
                    }
                }
            }
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Đảm bảo rằng người dùng không nhấp vào tiêu đề cột
            {
                // Chọn toàn bộ dòng chứa ô được nhấp
                dataGridView1.ClearSelection(); // Bỏ chọn các dòng trước đó (nếu có)
                dataGridView1.Rows[e.RowIndex].Selected = true;

                // Điền dữ liệu vào các TextBox
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                txt_user.Text = selectedRow.Cells[2].Value?.ToString() ?? string.Empty;
                txt_pass.Text = selectedRow.Cells[3].Value?.ToString() ?? string.Empty;
                txt_name.Text = selectedRow.Cells[4].Value?.ToString() ?? string.Empty;
                txt_phone.Text = selectedRow.Cells[5].Value?.ToString() ?? string.Empty;
                txt_money.Text = selectedRow.Cells[6].Value?.ToString() ?? string.Empty;
            }
        }

        private void delete_user_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0) // Kiểm tra xem có dòng nào được chọn
            {
                // Lấy tên đăng nhập từ dòng được chọn
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                string tenDangNhap = selectedRow.Cells[2].Value?.ToString();

                if (!string.IsNullOrEmpty(tenDangNhap))
                {
                    // Hiển thị thông báo xác nhận
                    DialogResult result = MessageBox.Show(
                        $"Bạn có chắc chắn muốn xóa người dùng {tenDangNhap} không?",
                        "Xác nhận xóa",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning
                    );

                    if (result == DialogResult.Yes)
                    {
                        // Gọi hàm xóa người dùng
                        if (DeleteUser(tenDangNhap))
                        {
                            // Cập nhật lại DataGridView
                            LoadUsers();
                            MessageBox.Show("Xóa người dùng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Có lỗi xảy ra khi xóa người dùng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Hàm xóa người dùng khỏi cơ sở dữ liệu
        private bool DeleteUser(string tenDangNhap)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM Users WHERE TenDangNhap = @TenDangNhap";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@TenDangNhap", tenDangNhap);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
                return true; // Xóa thành công
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xóa: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false; // Xóa thất bại
            }
        }

        private void btn_pay_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0) // Kiểm tra xem có dòng nào được chọn
            {
                // Lấy thông tin tài khoản từ dòng được chọn
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                string tenDangNhap = selectedRow.Cells[2].Value?.ToString(); // Cột "TenDangNhap"
                decimal soTienNap;

                // Kiểm tra số tiền nhập vào từ TextBox (giả sử TextBox chứa số tiền cần nạp tên là txt_add_money)
                if (!decimal.TryParse(txt_pay.Text, out soTienNap) || soTienNap <= 0)
                {
                    MessageBox.Show("Số tiền nạp không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!string.IsNullOrEmpty(tenDangNhap))
                {
                    // Gọi hàm cập nhật số dư
                    if (AddMoney(tenDangNhap, soTienNap))
                    {
                        // Cập nhật lại DataGridView
                        LoadUsers();
                        MessageBox.Show("Nạp tiền thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi xảy ra khi nạp tiền.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một tài khoản để nạp tiền.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Hàm cộng thêm tiền vào số dư hiện tại
        private bool AddMoney(string tenDangNhap, decimal soTienNap)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "UPDATE Users SET SoTien = SoTien + @SoTienNap WHERE TenDangNhap = @TenDangNhap";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@SoTienNap", soTienNap);
                    command.Parameters.AddWithValue("@TenDangNhap", tenDangNhap);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
                return true; // Nạp tiền thành công
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi nạp tiền: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false; // Nạp tiền thất bại
            }
        }

        private void SetAllStatusToOff()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "UPDATE Users SET Status = 'off'";
                    SqlCommand command = new SqlCommand(query, connection);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    MessageBox.Show($"Đã cập nhật trạng thái thành 'off' cho {rowsAffected} tài khoản.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi cập nhật trạng thái: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }


}
