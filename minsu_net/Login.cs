using System;
using System.Windows.Forms;
using minsu_net;
using MinsuNet.BUS; // Import namespace BUS

namespace MinsuNet
{
    public partial class Login : Form
    {
        private TaiKhoanBUS bus = new TaiKhoanBUS();

        public Login()
        {
            InitializeComponent();
        }

        private void login_registerbtn_Click(object sender, EventArgs e)
        {
            register register = new register();
            register.Show(); // Hiển thị MainForm
            this.Hide(); // Ẩn Form1
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            string tenDangNhap = Login_username.Text.Trim();
            string matKhau = login_password.Text.Trim();

            if (string.IsNullOrEmpty(tenDangNhap) || string.IsNullOrEmpty(matKhau))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập và mật khẩu.");
                return;
            }

            if (bus.Login(tenDangNhap, matKhau))
            {
                MessageBox.Show("Đăng nhập thành công!");

                // Mở MainForm
                MainForm mainForm = new MainForm();
                mainForm.Show(); // Hiển thị MainForm
                this.Hide(); // Ẩn Form1
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!");
            }
        }

        private void login_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_showpassword_CheckedChanged(object sender, EventArgs e)
        {
            // Hiển thị hoặc ẩn mật khẩu
            if (login_showpassword.Checked)
            {
                login_password.PasswordChar = '\0'; // Hiện mật khẩu
            }
            else
            {
                login_password.PasswordChar = '*'; // Ẩn mật khẩu
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}