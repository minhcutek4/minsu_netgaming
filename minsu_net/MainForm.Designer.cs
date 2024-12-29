using System;
using System.Windows.Forms;

namespace minsu_net
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lbCashierClose = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button5 = new System.Windows.Forms.Button();
            this.btn_user = new System.Windows.Forms.Button();
            this.btbn_dichvu = new System.Windows.Forms.Button();
            this.btn_order = new System.Windows.Forms.Button();
            this.btn_doanhthu = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangthai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phonee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.money = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.phone = new System.Windows.Forms.Label();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.delete_user = new System.Windows.Forms.Button();
            this.change_user = new System.Windows.Forms.Button();
            this.add_user = new System.Windows.Forms.Button();
            this.txt_money = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.txt_user = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_pay = new System.Windows.Forms.Button();
            this.txt_pay = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lbCashierClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1500, 46);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(627, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(289, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "HỆ THỐNG QUẢN LÝ TIỆM NET";
            // 
            // lbCashierClose
            // 
            this.lbCashierClose.AutoSize = true;
            this.lbCashierClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCashierClose.ForeColor = System.Drawing.Color.White;
            this.lbCashierClose.Location = new System.Drawing.Point(1471, 9);
            this.lbCashierClose.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCashierClose.Name = "lbCashierClose";
            this.lbCashierClose.Size = new System.Drawing.Size(18, 17);
            this.lbCashierClose.TabIndex = 0;
            this.lbCashierClose.Text = "X";
            this.lbCashierClose.Click += new System.EventHandler(this.lbCashierClose_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.btn_user);
            this.panel2.Controls.Add(this.btbn_dichvu);
            this.panel2.Controls.Add(this.btn_order);
            this.panel2.Controls.Add(this.btn_doanhthu);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 46);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(213, 706);
            this.panel2.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::minsu_net.Properties.Resources.minsu_logo__3_;
            this.pictureBox1.Location = new System.Drawing.Point(-35, -15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(277, 244);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.DimGray;
            this.button5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Transparent;
            this.button5.Location = new System.Drawing.Point(19, 653);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(156, 37);
            this.button5.TabIndex = 9;
            this.button5.Text = "Đăng Xuất";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btn_user
            // 
            this.btn_user.BackColor = System.Drawing.Color.DimGray;
            this.btn_user.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_user.ForeColor = System.Drawing.Color.Transparent;
            this.btn_user.Location = new System.Drawing.Point(19, 286);
            this.btn_user.Margin = new System.Windows.Forms.Padding(2);
            this.btn_user.Name = "btn_user";
            this.btn_user.Size = new System.Drawing.Size(156, 37);
            this.btn_user.TabIndex = 8;
            this.btn_user.Text = "Khách Hàng";
            this.btn_user.UseVisualStyleBackColor = false;
            // 
            // btbn_dichvu
            // 
            this.btbn_dichvu.BackColor = System.Drawing.Color.DimGray;
            this.btbn_dichvu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbn_dichvu.ForeColor = System.Drawing.Color.Transparent;
            this.btbn_dichvu.Location = new System.Drawing.Point(19, 344);
            this.btbn_dichvu.Margin = new System.Windows.Forms.Padding(2);
            this.btbn_dichvu.Name = "btbn_dichvu";
            this.btbn_dichvu.Size = new System.Drawing.Size(156, 37);
            this.btbn_dichvu.TabIndex = 7;
            this.btbn_dichvu.Text = "Thêm Dịch vụ";
            this.btbn_dichvu.UseVisualStyleBackColor = false;
            // 
            // btn_order
            // 
            this.btn_order.BackColor = System.Drawing.Color.DimGray;
            this.btn_order.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_order.ForeColor = System.Drawing.Color.Transparent;
            this.btn_order.Location = new System.Drawing.Point(19, 406);
            this.btn_order.Margin = new System.Windows.Forms.Padding(2);
            this.btn_order.Name = "btn_order";
            this.btn_order.Size = new System.Drawing.Size(156, 37);
            this.btn_order.TabIndex = 6;
            this.btn_order.Text = "Gọi món";
            this.btn_order.UseVisualStyleBackColor = false;
            // 
            // btn_doanhthu
            // 
            this.btn_doanhthu.BackColor = System.Drawing.Color.DimGray;
            this.btn_doanhthu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_doanhthu.ForeColor = System.Drawing.Color.Transparent;
            this.btn_doanhthu.Location = new System.Drawing.Point(19, 467);
            this.btn_doanhthu.Margin = new System.Windows.Forms.Padding(2);
            this.btn_doanhthu.Name = "btn_doanhthu";
            this.btn_doanhthu.Size = new System.Drawing.Size(156, 37);
            this.btn_doanhthu.TabIndex = 5;
            this.btn_doanhthu.Text = "Thống Kê Doanh Thu";
            this.btn_doanhthu.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(218, 65);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(717, 424);
            this.panel3.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stt,
            this.trangthai,
            this.user,
            this.pass,
            this.username,
            this.phonee,
            this.money});
            this.dataGridView1.Location = new System.Drawing.Point(-28, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(755, 313);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // stt
            // 
            this.stt.HeaderText = "Số máy";
            this.stt.Name = "stt";
            this.stt.ReadOnly = true;
            // 
            // trangthai
            // 
            this.trangthai.HeaderText = "Trạng thái";
            this.trangthai.Name = "trangthai";
            // 
            // user
            // 
            this.user.HeaderText = "Tên tài khoản";
            this.user.Name = "user";
            this.user.ReadOnly = true;
            // 
            // pass
            // 
            this.pass.HeaderText = "Mật khẩu";
            this.pass.Name = "pass";
            this.pass.ReadOnly = true;
            // 
            // username
            // 
            this.username.HeaderText = "Họ tên";
            this.username.Name = "username";
            this.username.ReadOnly = true;
            // 
            // phonee
            // 
            this.phonee.HeaderText = "SĐT";
            this.phonee.Name = "phonee";
            // 
            // money
            // 
            this.money.HeaderText = "Số tiền còn lại";
            this.money.Name = "money";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(236, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dữ liệu người chơi";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.phone);
            this.panel5.Controls.Add(this.txt_phone);
            this.panel5.Controls.Add(this.delete_user);
            this.panel5.Controls.Add(this.change_user);
            this.panel5.Controls.Add(this.add_user);
            this.panel5.Controls.Add(this.txt_money);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.txt_name);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.txt_pass);
            this.panel5.Controls.Add(this.txt_user);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Location = new System.Drawing.Point(941, 65);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(548, 671);
            this.panel5.TabIndex = 5;
            // 
            // phone
            // 
            this.phone.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone.Location = new System.Drawing.Point(136, 173);
            this.phone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(138, 24);
            this.phone.TabIndex = 25;
            this.phone.Text = "SĐT : ";
            // 
            // txt_phone
            // 
            this.txt_phone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_phone.Location = new System.Drawing.Point(139, 223);
            this.txt_phone.Margin = new System.Windows.Forms.Padding(2);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(285, 29);
            this.txt_phone.TabIndex = 24;
            // 
            // delete_user
            // 
            this.delete_user.BackColor = System.Drawing.Color.DimGray;
            this.delete_user.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_user.ForeColor = System.Drawing.Color.Transparent;
            this.delete_user.Location = new System.Drawing.Point(392, 599);
            this.delete_user.Margin = new System.Windows.Forms.Padding(2);
            this.delete_user.Name = "delete_user";
            this.delete_user.Size = new System.Drawing.Size(134, 37);
            this.delete_user.TabIndex = 23;
            this.delete_user.Text = "Xóa";
            this.delete_user.UseVisualStyleBackColor = false;
            this.delete_user.Click += new System.EventHandler(this.delete_user_Click);
            // 
            // change_user
            // 
            this.change_user.BackColor = System.Drawing.Color.DimGray;
            this.change_user.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.change_user.ForeColor = System.Drawing.Color.Transparent;
            this.change_user.Location = new System.Drawing.Point(216, 599);
            this.change_user.Margin = new System.Windows.Forms.Padding(2);
            this.change_user.Name = "change_user";
            this.change_user.Size = new System.Drawing.Size(134, 37);
            this.change_user.TabIndex = 22;
            this.change_user.Text = "Sửa";
            this.change_user.UseVisualStyleBackColor = false;
            this.change_user.Click += new System.EventHandler(this.change_user_Click);
            // 
            // add_user
            // 
            this.add_user.BackColor = System.Drawing.Color.DimGray;
            this.add_user.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_user.ForeColor = System.Drawing.Color.Transparent;
            this.add_user.Location = new System.Drawing.Point(37, 599);
            this.add_user.Margin = new System.Windows.Forms.Padding(2);
            this.add_user.Name = "add_user";
            this.add_user.Size = new System.Drawing.Size(134, 37);
            this.add_user.TabIndex = 10;
            this.add_user.Text = "Thêm";
            this.add_user.UseVisualStyleBackColor = false;
            this.add_user.Click += new System.EventHandler(this.add_user_Click);
            // 
            // txt_money
            // 
            this.txt_money.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_money.Location = new System.Drawing.Point(139, 527);
            this.txt_money.Margin = new System.Windows.Forms.Padding(2);
            this.txt_money.Name = "txt_money";
            this.txt_money.Size = new System.Drawing.Size(284, 29);
            this.txt_money.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(136, 485);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 24);
            this.label5.TabIndex = 20;
            this.label5.Text = "Số tiền nạp : ";
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(135, 115);
            this.txt_name.Margin = new System.Windows.Forms.Padding(2);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(285, 29);
            this.txt_name.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(136, 280);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 24);
            this.label7.TabIndex = 18;
            this.label7.Text = "Tên tài khoản :";
            // 
            // txt_pass
            // 
            this.txt_pass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pass.Location = new System.Drawing.Point(136, 423);
            this.txt_pass.Margin = new System.Windows.Forms.Padding(2);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.PasswordChar = '*';
            this.txt_pass.Size = new System.Drawing.Size(284, 29);
            this.txt_pass.TabIndex = 15;
            // 
            // txt_user
            // 
            this.txt_user.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_user.Location = new System.Drawing.Point(139, 330);
            this.txt_user.Margin = new System.Windows.Forms.Padding(2);
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(285, 29);
            this.txt_user.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(133, 381);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 24);
            this.label4.TabIndex = 12;
            this.label4.Text = "Mật khẩu :";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(136, 68);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 24);
            this.label6.TabIndex = 13;
            this.label6.Text = "Họ và tên :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(185, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tài khoản người chơi";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.btn_pay);
            this.panel4.Controls.Add(this.txt_pay);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Location = new System.Drawing.Point(218, 525);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(717, 211);
            this.panel4.TabIndex = 6;
            // 
            // btn_pay
            // 
            this.btn_pay.BackColor = System.Drawing.Color.DimGray;
            this.btn_pay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pay.ForeColor = System.Drawing.Color.Transparent;
            this.btn_pay.Location = new System.Drawing.Point(279, 153);
            this.btn_pay.Margin = new System.Windows.Forms.Padding(2);
            this.btn_pay.Name = "btn_pay";
            this.btn_pay.Size = new System.Drawing.Size(156, 37);
            this.btn_pay.TabIndex = 25;
            this.btn_pay.Text = "Nạp tiền ";
            this.btn_pay.UseVisualStyleBackColor = false;
            this.btn_pay.Click += new System.EventHandler(this.btn_pay_Click);
            // 
            // txt_pay
            // 
            this.txt_pay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pay.Location = new System.Drawing.Point(314, 78);
            this.txt_pay.Margin = new System.Windows.Forms.Padding(2);
            this.txt_pay.Name = "txt_pay";
            this.txt_pay.Size = new System.Drawing.Size(121, 29);
            this.txt_pay.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(191, 83);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 24);
            this.label10.TabIndex = 23;
            this.label10.Text = "Số tiền nạp : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(236, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(219, 24);
            this.label8.TabIndex = 1;
            this.label8.Text = "Nạp tiền cho tài khoản";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1500, 752);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "GiaoDienThuNgan";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbCashierClose;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btn_user;
        private System.Windows.Forms.Button btbn_dichvu;
        private System.Windows.Forms.Button btn_order;
        private System.Windows.Forms.Button btn_doanhthu;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button delete_user;
        private System.Windows.Forms.Button change_user;
        private System.Windows.Forms.Button add_user;
        private System.Windows.Forms.TextBox txt_money;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label phone;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_pay;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_pay;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangthai;
        private System.Windows.Forms.DataGridViewTextBoxColumn user;
        private System.Windows.Forms.DataGridViewTextBoxColumn pass;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn phonee;
        private System.Windows.Forms.DataGridViewTextBoxColumn money;
    }
}