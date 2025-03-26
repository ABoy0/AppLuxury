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

namespace AppLuxury
{
    public partial class FormAdmin : Form
    {
        private string role;
        private string connectionString = "Data Source=ABoy;Initial Catalog=LuxurySalesDB;Integrated Security=True";
        private List<(string productName, decimal price, int quantity, Image image)> cart = new List<(string productName, decimal price, int quantity, Image image)>();

        public FormAdmin()
        {
            InitializeComponent();
            LoadSanPham();
        }


        private void btnThemSP_Click(object sender, EventArgs e)
        {
            string productName = txtTenHang.Text; // Lấy tên sản phẩm từ TextBox
            int quantity;

            // Kiểm tra xem số lượng có phải là số nguyên hợp lệ không
            if (!int.TryParse(txtSL.Text, out quantity) || quantity < 0) // Chỉnh sửa tên TextBox
            {
                MessageBox.Show("Vui lòng nhập số lượng hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int materialID = int.Parse(txtMaCL.Text); // Lấy giá trị từ TextBox

            decimal priceIn = decimal.Parse(txtĐGN.Text); // Giá nhập từ TextBox
            decimal priceOut = decimal.Parse(txtĐGB.Text); // Giá bán từ TextBox
            string imagePath = pictureBoxSP.Text; // Đường dẫn hình ảnh từ TextBox
            string notes = txtGhiChu.Text; // Ghi chú từ TextBox

            // Kiểm tra dữ liệu đầu vào
            if (string.IsNullOrEmpty(productName) || priceIn <= 0 || priceOut <= 0 || string.IsNullOrEmpty(imagePath))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin sản phẩm hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kết nối đến cơ sở dữ liệu
            using (SqlConnection conn = new SqlConnection("Data Source=ABoy;Initial Catalog=LuxurySalesDB;Integrated Security=True;"))
            {
                conn.Open();
                string query = "INSERT INTO tblHang (Tenhang, Machatlieu, Soluong, Dongianhap, Dongiaban, Anh, Ghichu) VALUES (@TenHang, @Machatlieu, @SoLuong, @Dongianhap, @Dongiaban, @Anh, @Ghichu)"; // Cập nhật truy vấn

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@TenHang", productName);
                    cmd.Parameters.AddWithValue("@Machatlieu", materialID); // Thay yourMaterialID bằng giá trị thực tế
                    cmd.Parameters.AddWithValue("@SoLuong", quantity);
                    cmd.Parameters.AddWithValue("@Dongianhap", priceIn);
                    cmd.Parameters.AddWithValue("@Dongiaban", priceOut);
                    cmd.Parameters.AddWithValue("@Anh", imagePath);
                    cmd.Parameters.AddWithValue("@Ghichu", notes);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Sản phẩm đã được thêm thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Cập nhật lại danh sách sản phẩm (nếu cần)
                        
                    }
                    else
                    {
                        MessageBox.Show("Thêm sản phẩm thất bại. Vui lòng thử lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void LoadSanPham()
        {
            string connectionString = "Data Source=ABoy;Initial Catalog=LuxurySalesDB;Integrated Security=True";
            string query = "SELECT * FROM tblHang";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();

                try
                {
                    connection.Open();
                    adapter.Fill(dataTable);

                    // Hiển thị sản phẩm lên FlowLayoutPanel
                    ShowProductsOnFlowLayout(dataTable);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tải danh sách sản phẩm: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void ShowProductsOnFlowLayout(DataTable dataTable)
        {
            

            foreach (DataRow row in dataTable.Rows)
            {
                // Tạo một Panel để chứa thông tin sản phẩm
                Panel productPanel = new Panel
                {
                    Width = 300,
                    Height = 400,
                    BorderStyle = BorderStyle.FixedSingle,
                    Margin = new Padding(10)
                };

                // Thêm ảnh sản phẩm (PictureBox)
                PictureBox pictureBox = new PictureBox
                {
                    Width = 180,
                    Height = 180,
                    SizeMode = PictureBoxSizeMode.Zoom,
                    ImageLocation = row["Anh"].ToString(),
                    Dock = DockStyle.Top
                };

                // Thêm tên sản phẩm (Label)
                Label lblTenHang = new Label
                {
                    Text = row["TenHang"].ToString(),
                    AutoSize = false,
                    Width = 180,
                    Height = 30,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Dock = DockStyle.Top,
                    Font = new Font("Arial", 10, FontStyle.Bold)
                };

                // Thêm giá bán sản phẩm (Label)
                Label lblGiaBan = new Label
                {
                    Text = $"Giá: {row["Dongiaban"]} VNĐ",
                    AutoSize = false,
                    Width = 180,
                    Height = 30,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Dock = DockStyle.Top,
                    ForeColor = Color.Green,
                    Font = new Font("Arial", 10, FontStyle.Regular)
                };

                // Thêm các thành phần vào panel
                productPanel.Controls.Add(lblGiaBan);
                productPanel.Controls.Add(lblTenHang);
                productPanel.Controls.Add(pictureBox);

                
            }
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT DISTINCT ThuongHieu FROM tblHang";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();
            }
            LoadSanPham();
        }

        private void flPannelDanhSachTK_Paint(object sender, PaintEventArgs e)
        {

        }   

        private void btnThemTK_Click(object sender, EventArgs e)
        {

        }

        private void btnSuaTK_Click(object sender, EventArgs e)
        {

        }

        private void btnXoaTK_Click(object sender, EventArgs e)
        {

        }

        private void btnSuaSP_Click(object sender, EventArgs e)
        {
            int productId = int.Parse(txtMaHang.Text); // Lấy mã sản phẩm từ TextBox
            string productName = txtTenHang.Text; // Tên sản phẩm
            int quantity;

            // Kiểm tra xem số lượng có phải là số nguyên hợp lệ không
            if (!int.TryParse(txtSL.Text, out quantity) || quantity < 0)
            {
                MessageBox.Show("Vui lòng nhập số lượng hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int materialID = int.Parse(txtMaCL.Text); // Lấy giá trị từ TextBox
            decimal priceIn = decimal.Parse(txtĐGN.Text); // Giá nhập từ TextBox
            decimal priceOut = decimal.Parse(txtĐGB.Text); // Giá bán từ TextBox
            string imagePath = pictureBoxSP.Text; // Đường dẫn hình ảnh
            string notes = txtGhiChu.Text; // Ghi chú

            // Kiểm tra dữ liệu đầu vào
            if (string.IsNullOrEmpty(productName) || priceIn <= 0 || priceOut <= 0 || string.IsNullOrEmpty(imagePath))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin sản phẩm hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kết nối đến cơ sở dữ liệu
            using (SqlConnection conn = new SqlConnection("Data Source=ABoy;Initial Catalog=LuxurySalesDB;Integrated Security=True;"))
            {
                conn.Open();

                // Kiểm tra xem sản phẩm có tồn tại hay không
                string checkQuery = "SELECT COUNT(*) FROM tblHang WHERE Mahang = @Mahang";
                using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                {
                    checkCmd.Parameters.AddWithValue("@Mahang", productId);
                    int count = (int)checkCmd.ExecuteScalar();

                    if (count == 0)
                    {
                        MessageBox.Show("Sản phẩm không tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                // Cập nhật sản phẩm
                string updateQuery = "UPDATE tblHang SET Tenhang = @TenHang, Machatlieu = @Machatlieu, Soluong = @SoLuong, Dongianhap = @Dongianhap, Dongiaban = @Dongiaban, Anh = @Anh, Ghichu = @Ghichu WHERE Mahang = @Mahang";

                using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@TenHang", productName);
                    cmd.Parameters.AddWithValue("@Machatlieu", materialID);
                    cmd.Parameters.AddWithValue("@SoLuong", quantity);
                    cmd.Parameters.AddWithValue("@Dongianhap", priceIn);
                    cmd.Parameters.AddWithValue("@Dongiaban", priceOut);
                    cmd.Parameters.AddWithValue("@Anh", imagePath);
                    cmd.Parameters.AddWithValue("@Ghichu", notes);
                    cmd.Parameters.AddWithValue("@Mahang", productId); // Mã sản phẩm cần sửa

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Sản phẩm đã được sửa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Sửa sản phẩm thất bại. Vui lòng thử lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void btnXoaSP_Click(object sender, EventArgs e)
        {
            int productId = int.Parse(txtMaHang.Text); // Lấy mã sản phẩm từ TextBox

            // Kiểm tra xem mã sản phẩm có hợp lệ không
            if (productId <= 0)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm hợp lệ để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kết nối đến cơ sở dữ liệu
            using (SqlConnection conn = new SqlConnection("Data Source=ABoy;Initial Catalog=LuxurySalesDB;Integrated Security=True;"))
            {
                conn.Open();

                // Kiểm tra xem sản phẩm có tồn tại hay không
                string checkQuery = "SELECT COUNT(*) FROM tblHang WHERE Mahang = @Mahang";
                using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                {
                    checkCmd.Parameters.AddWithValue("@Mahang", productId);
                    int count = (int)checkCmd.ExecuteScalar();

                    if (count == 0)
                    {
                        MessageBox.Show("Sản phẩm không tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                // Xóa sản phẩm
                string deleteQuery = "DELETE FROM tblHang WHERE Mahang = @Mahang";

                using (SqlCommand cmd = new SqlCommand(deleteQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@Mahang", productId); // Mã sản phẩm cần xóa

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Sản phẩm đã được xóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Xóa sản phẩm thất bại. Vui lòng thử lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void xtraUserControl2_Load(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnThemAnh_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = @"C:\Users\trand\Downloads\DoAnLuxury\images"; // Set initial directory
                openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png, *.gif)|*.jpg;*.jpeg;*.png;*.gif|All files (*.*)|*.*"; // Filter for image files
                openFileDialog.Title = "Chọn ảnh"; // Title for the dialog

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Get the path of the selected image
                    string imagePath = openFileDialog.FileName;

                    // Assuming you have a PictureBox named pictureBox to display the image
                    pictureBoxSP.Image = Image.FromFile(imagePath); // Load the image into the PictureBox
                    pictureBoxSP.SizeMode = PictureBoxSizeMode.StretchImage; // Optional: Set the size mode

                    // Optionally, save the image path or perform any other operation you need
                    // For example, you can set a variable or display the path
                    // txtImagePath.Text = imagePath; // If you have a TextBox to show the path
                }
            }
        }

        private void flPannelSP_Paint(object sender, PaintEventArgs e)
        {
    

            // Kết nối đến cơ sở dữ liệu
            using (SqlConnection conn = new SqlConnection("Data Source=ABoy;Initial Catalog=LuxurySalesDB;Integrated Security=True;"))
            {
                conn.Open();
                string query = "SELECT Mahang, Tenhang, Dongiaban, Anh FROM tblHang"; // Lấy mã hàng, tên hàng, giá bán, và hình ảnh

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Tạo panel cho mỗi sản phẩm
                            Panel productPanel = new Panel
                            {
                                Size = new Size(200, 250),
                                Margin = new Padding(10),
                                BorderStyle = BorderStyle.FixedSingle
                            };

                            // Tạo PictureBox cho hình ảnh
                            PictureBox pictureBox = new PictureBox
                            {
                                Size = new Size(180, 120),
                                SizeMode = PictureBoxSizeMode.StretchImage,
                                ImageLocation = reader["Anh"].ToString() // Đường dẫn hình ảnh
                            };

                            // Tạo Label cho tên sản phẩm
                            Label nameLabel = new Label
                            {
                                Text = reader["Tenhang"].ToString(),
                                AutoSize = true,
                                Location = new Point(10, 130)
                            };

                            // Tạo Label cho giá bán
                            Label priceLabel = new Label
                            {
                                Text = "Giá bán: " + reader["Dongiaban"].ToString(),
                                AutoSize = true,
                                Location = new Point(10, 150)
                            };

                            // Tạo Button để chỉnh sửa sản phẩm
                            Button editButton = new Button
                            {
                                Text = "Sửa",
                                Location = new Point(10, 200),
                                Tag = reader["Mahang"] // Lưu mã sản phẩm vào thuộc tính Tag
                            };
                            editButton.Click += EditButton_Click; // Gán sự kiện Click

                            // Thêm các điều khiển vào panel sản phẩm
                            productPanel.Controls.Add(pictureBox);
                            productPanel.Controls.Add(nameLabel);
                            productPanel.Controls.Add(priceLabel);
                            productPanel.Controls.Add(editButton);

                        }
                    }
                }
            }
        }
        





        private void EditButton_Click(object sender, EventArgs e)
        {
            // Lấy mã sản phẩm từ thuộc tính Tag của button
            int productId = (int)((Button)sender).Tag;

            // Hiển thị thông tin sản phẩm để chỉnh sửa (có thể gọi một phương thức khác)
        }

        private void btnTimTK_Click(object sender, EventArgs e)
        {

        }
    }

    }
