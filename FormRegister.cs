using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AppLuxury
{
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
        }

        private void FormRegister_Load(object sender, EventArgs e)
        {
         
        }

        private void btnDangKi_Click(object sender, EventArgs e)
        {
            SaveAccountInfo(); 
        }

        private void SaveAccountInfo()
        {
            string username = txtTenTaiKhoan.Text.Trim();
            string password = txtMatKhau.Text.Trim();
            string email = txtGmail.Text.Trim();

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Tên đăng nhập và mật khẩu không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (username.Length < 5)
            {
                MessageBox.Show("Tên tài khoản có ít nhất 5 ký tự!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            if (password.Length < 6)
            {
                MessageBox.Show("Mật khẩu cần có ít nhất 6 ký tự!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Email không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            if (email.Length < 5)
            {
                MessageBox.Show("Email cần có ít nhất 5 ký tự!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

           
            

            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}+@gmail\.com$"; 
            if (!Regex.IsMatch(email, emailPattern))
            {
                MessageBox.Show("Email không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection connection = new SqlConnection("Data Source=ABoy;Initial Catalog=LuxurySalesDB;Integrated Security=True"))
            {
                try
                {
                    connection.Open();

                    
                    string checkQuery = "SELECT COUNT(*) FROM tblAccount WHERE Username = @username";
                    SqlCommand checkCommand = new SqlCommand(checkQuery, connection);
                    checkCommand.Parameters.AddWithValue("@username", username);
                    int exists = (int)checkCommand.ExecuteScalar();

                    if (exists == 0)
                    {
                        
                        string insertQuery = "INSERT INTO tblAccount (Username, Password, Email, Role) VALUES (@username, @password, @email, 'User')";
                        SqlCommand insertCommand = new SqlCommand(insertQuery, connection);
                        insertCommand.Parameters.AddWithValue("@username", username);
                        insertCommand.Parameters.AddWithValue("@password", password);
                        insertCommand.Parameters.AddWithValue("@email", email);
                        insertCommand.ExecuteNonQuery();

                        MessageBox.Show("Tài khoản đã được tạo và lưu với quyền User.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Tài khoản đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi khi lưu tài khoản: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Sự kiện đăng nhập
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string username = txtTenTaiKhoan.Text.Trim();
            string password = txtMatKhau.Text.Trim();

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập và mật khẩu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection connection = new SqlConnection("Data Source=ABoy;Initial Catalog=LuxurySalesDB;Integrated Security=True"))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT Role FROM tblAccount WHERE Username = @username AND Password = @password";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);

                    var result = command.ExecuteScalar();

                    if (result != null)
                    {
                        string role = result.ToString();
                        MessageBox.Show($"Đăng nhập thành công với quyền {role}!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        
                        FormHome formHome = new FormHome(role);
                        this.Hide();
                        formHome.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi khi đăng nhập: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void lblThoat_Click(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
            this.Close();
        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void lblThoat_MouseEnter(object sender, EventArgs e)
        {
            lblThoat.ForeColor = Color.Red;
        }

        private void lblThoat_MouseLeave(object sender, EventArgs e)
        {
            lblThoat.ForeColor = Color.Black;
        }
    }
}
