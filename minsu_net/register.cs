using System;
using System.Windows.Forms;
using MinsuNet;
using MinsuNet.BUS; // Import namespace BUS

namespace minsu_net
{
    public partial class register : Form
    {
        private TaiKhoanBUS bus = new TaiKhoanBUS();

        public register()
        {
            InitializeComponent();
        }

        private void login_registerbtn_Click(object sender, EventArgs e)
        {
            string tenDangNhap = Login_username.Text.Trim();
            string matKhau = login_password.Text.Trim();
            string xacNhanMatKhau = login_password_again.Text.Trim();

            // Kiểm tra dữ liệu
            if (string.IsNullOrEmpty(tenDangNhap) || string.IsNullOrEmpty(matKhau) || string.IsNullOrEmpty(xacNhanMatKhau))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
                return;
            }

            if (matKhau != xacNhanMatKhau)
            {
                MessageBox.Show("Mật khẩu và xác nhận mật khẩu không khớp!");
                return;
            }

            // Gọi phương thức đăng ký
            try
            {
                bus.Register(tenDangNhap, matKhau, "", ""); // Có thể thêm họ tên và email nếu cần
                MessageBox.Show("Tài khoản đã được tạo thành công!");

                this.Close();
                Login login = new Login(); // Tạo đối tượng form đăng nhập
                login.Show(); // Hiển thị form đăng nhập
                                 }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tạo tài khoản: " + ex.Message);
            }
        }

        private void login_close_Click(object sender, EventArgs e)
        {
            this.Close(); // Đóng form
        }

        private void login_showpassword_CheckedChanged(object sender, EventArgs e)
        {
            if (login_showpassword.Checked)
            {
                login_password.PasswordChar = '\0'; // Hiện mật khẩu chính
                login_password_again.PasswordChar = '\0'; // Hiện mật khẩu xác nhận
            }
            else
            {
                login_password.PasswordChar = '*'; // Ẩn mật khẩu chính
                login_password_again.PasswordChar = '*'; // Ẩn mật khẩu xác nhận
            }
        }
    }
}