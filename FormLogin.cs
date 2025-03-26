using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace AppLuxury
{
    public partial class FormLogin : DevExpress.XtraEditors.XtraForm
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void txtTenTaiKhoan_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblQuenMatKhau_Click(object sender, EventArgs e)
        {

        }

        private void lblQuenMatKhau_MouseEnter(object sender, EventArgs e)
        {
            lblQuenMatKhau.ForeColor = System.Drawing.Color.Red;
        }

        private void lblQuenMatKhau_MouseLeave(object sender, EventArgs e)
        {
            lblQuenMatKhau.ForeColor = System.Drawing.Color.Black;
        }

        private void lblThoat_MouseEnter(object sender, EventArgs e)
        {
            lblThoat.ForeColor = System.Drawing.Color.Red;

        }

        private void lblThoat_MouseLeave(object sender, EventArgs e)
        {
            lblThoat.ForeColor = System.Drawing.Color.Black;

        }

        private void lblThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDangKi_Click(object sender, EventArgs e)
        {
            FormRegister formRegister = new FormRegister();

            formRegister.Show();

            this.Hide();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnDangKi_Click_1(object sender, EventArgs e)
        {
            FormRegister formRegister = new FormRegister();

            formRegister.Show();

            this.Hide();
        }

        private void lblThoat_Click_1(object sender, EventArgs e)
        {
            this.Close();

        }

        private void lblQuenMatKhau_Click_1(object sender, EventArgs e)
        {
            FormPasswordRecovery recoveryForm = new FormPasswordRecovery();
            recoveryForm.Show();
        }

        private void lblQuenMatKhau_MouseEnter_1(object sender, EventArgs e)
        {
            lblQuenMatKhau.ForeColor = Color.Red;
        }

        private void lblQuenMatKhau_MouseLeave_1(object sender, EventArgs e)
        {
            lblQuenMatKhau.ForeColor = Color.Black;
        }

        private void lblThoat_MouseEnter_1(object sender, EventArgs e)
        {
            lblThoat.ForeColor = Color.Red;

        }

        private void lblThoat_MouseLeave_1(object sender, EventArgs e)
        {
            lblThoat.ForeColor = Color.Black;

        }

        private void txtTenTaiKhoan_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtMatKhau_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_Click_1(object sender, EventArgs e)
        {
            string username = txtTenTaiKhoan.Text.Trim();
            string password = txtMatKhau.Text.Trim();

          
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập và mật khẩu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

     
            if (username.Length < 4 || password.Length < 4)
            {
                MessageBox.Show("Tên đăng nhập phải có ít nhất 5 ký tự và mật khẩu phải có ít nhất 6 ký tự.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            string usernamePattern = @"^[a-zA-Z0-9_]+$";
            if (!Regex.IsMatch(username, usernamePattern))
            {
                MessageBox.Show("Tên đăng nhập không được chứa ký tự đặc biệt (chỉ cho phép chữ cái, số và dấu gạch dưới).", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

           
            using (SqlConnection connection = new SqlConnection("Data Source=ABoy;Initial Catalog=LuxurySalesDB;Integrated Security=True"))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT Role FROM tblAccount WHERE Username = @username COLLATE SQL_Latin1_General_CP1_CS_AS AND Password = @password COLLATE SQL_Latin1_General_CP1_CS_AS";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password); 

                    var result = command.ExecuteScalar();

                    if (result != null)
                    {
                        
                        string role = result.ToString();
                        MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        
                        if (role.Equals("Admin", StringComparison.OrdinalIgnoreCase))
                        {
                            FormAdmin formAdmin = new FormAdmin();
                            this.Hide(); 
                            formAdmin.ShowDialog(); 
                        }
                        else
                        {
                            FormHome formHome = new FormHome(role);
                            this.Hide(); 
                            formHome.ShowDialog();
                        }

                        this.Close(); 
                    }
                    else
                    {
                        MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi khi kết nối cơ sở dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
