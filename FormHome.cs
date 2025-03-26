using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AppLuxury
{
    public partial class FormHome : Form
    {
        private string role;
        private string connectionString = "Data Source=ABoy;Initial Catalog=LuxurySalesDB;Integrated Security=True";
        private List<(string productName, decimal price, int quantity, Image image)> cart = new List<(string productName, decimal price, int quantity, Image image)>();

        public FormHome()
        {
            InitializeComponent();
            LoadProducts(); 
        }

        public FormHome(string role) : this() 
        {
            this.role = role;
        }

            private void LoadProducts()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT Tenhang, Dongiaban, Anh FROM tblHang"; 
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string productName = reader["Tenhang"].ToString();
                    decimal price = (decimal)reader["Dongiaban"];
                    string imagePath = reader["Anh"].ToString(); 
                    Image image = Image.FromFile(imagePath); 

                    
                    Panel productPanel = new Panel
                    {
                        Size = new Size(200, 300),
                        Margin = new Padding(10),
                        BorderStyle = BorderStyle.FixedSingle
                    };

                    
                    PictureBox pictureBox = new PictureBox
                    {
                        Size = new Size(180, 180),
                        Image = image, 
                        SizeMode = PictureBoxSizeMode.StretchImage,
                        Location = new Point(10, 10)
                    };

                    
                    Label nameLabel = new Label
                    {
                        Text = productName,
                        Font = new Font("Arial", 12, FontStyle.Bold),
                        Location = new Point(10, 200),
                        AutoSize = true
                    };

                    
                    Label priceLabel = new Label
                    {
                        Text = $"{price:C}",
                        Font = new Font("Arial", 10, FontStyle.Regular),
                        Location = new Point(10, 230),
                        AutoSize = true
                    };

                    
                    Button buyButton = new Button
                    {
                        Text = "Mua",
                        Location = new Point(10, 260),
                        Size = new Size(180, 30)
                    };

                    
                    buyButton.Click += (s, e) =>
                    {
                        AddToCart(productName, price, image);
                    };

                    
                    productPanel.Controls.Add(pictureBox);
                    productPanel.Controls.Add(nameLabel);
                    productPanel.Controls.Add(priceLabel);
                    productPanel.Controls.Add(buyButton);

                    
                    flowLayoutPanel2.Controls.Add(productPanel);
                }
                reader.Close();
            }
        }

        private void AddToCart(string productName, decimal price, Image image)
        {
            
            var existingItem = cart.Find(item => item.productName == productName);
            if (existingItem.Equals(default((string, decimal, int, Image)))) 
            {
                cart.Add((productName, price, 1, image)); 
                MessageBox.Show($"{productName} đã được thêm vào giỏ hàng!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                
                int newQuantity = existingItem.quantity + 1;
                cart.Remove(existingItem);
                cart.Add((productName, price, newQuantity, image));
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            
            FormCart formCart = new FormCart(cart);
            formCart.ShowDialog();
        }

        
        private Image ByteArrayToImage(byte[] byteArray)
        {
            using (MemoryStream ms = new MemoryStream(byteArray))
            {
                return Image.FromStream(ms);
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void FormHome_Load(object sender, EventArgs e)
        {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT DISTINCT ThuongHieu FROM tblHang";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        string brand = reader["ThuongHieu"].ToString();
                        btnChonBrand.Items.Add(brand);
                    }
                    reader.Close();
                }
            LoadSanPham();
        }
        private void LoadSanPham()
        {
            string connectionString = "Data Source=ABoy;Initial Catalog=LuxurySalesDB;Integrated Security=True";
            string query = "SELECT * FROM tblHang";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query,connection);
                DataTable dataTable = new DataTable();

                try
                {
                    connection.Open();
                    adapter.Fill(dataTable);
                    ShowProductsOnFlowLayout(dataTable);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tải danh sách sản phẩm: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnNoiBat_Click(object sender, EventArgs e)
        {
            
            flowLayoutPanel2.Controls.Clear();

            
            decimal minPrice = 500000; 
            decimal maxPrice = 1500000; 

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT Tenhang, Dongiaban, Anh FROM tblHang WHERE Dongiaban BETWEEN @MinPrice AND @MaxPrice"; // Lấy sản phẩm có giá trong khoảng tầm trung
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MinPrice", minPrice);
                command.Parameters.AddWithValue("@MaxPrice", maxPrice);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string productName = reader["Tenhang"].ToString();
                    decimal price = (decimal)reader["Dongiaban"];
                    string imagePath = reader["Anh"].ToString(); 

                    
                    Image image = Image.FromFile(imagePath);

                    
                    Panel productPanel = new Panel
                    {
                        Size = new Size(200, 300),
                        Margin = new Padding(10),
                        BorderStyle = BorderStyle.FixedSingle
                    };

                    
                    PictureBox pictureBox = new PictureBox
                    {
                        Size = new Size(180, 180),
                        Image = image,
                        SizeMode = PictureBoxSizeMode.StretchImage,
                        Location = new Point(10, 10)
                    };

                    
                    Label nameLabel = new Label
                    {
                        Text = productName,
                        Font = new Font("Arial", 12, FontStyle.Bold),
                        Location = new Point(10, 200),
                        AutoSize = true
                    };

                    
                    Label priceLabel = new Label
                    {
                        Text = $"{price:C}",
                        Font = new Font("Arial", 10, FontStyle.Regular),
                        Location = new Point(10, 230),
                        AutoSize = true
                    };

                    
                    Button buyButton = new Button
                    {
                        Text = "Mua",
                        Location = new Point(10, 260),
                        Size = new Size(180, 30)
                    };

                    
                    buyButton.Click += (s, eventArgs) =>
                    {
                        AddToCart(productName, price, image);
                        MessageBox.Show($"{productName} đã được thêm vào giỏ hàng!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    };

                    
                    productPanel.Controls.Add(pictureBox);
                    productPanel.Controls.Add(nameLabel);
                    productPanel.Controls.Add(priceLabel);
                    productPanel.Controls.Add(buyButton);

                    
                    flowLayoutPanel2.Controls.Add(productPanel);
                }
                reader.Close();
            }
        }

        private void btnHoTro_Click(object sender, EventArgs e)
        {
            FormSupport formSupport = new FormSupport(); 
            formSupport.ShowDialog(); 
        }

        private void btnChonBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedBrand = btnChonBrand.SelectedItem.ToString();
            flowLayoutPanel2.Controls.Clear();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT Tenhang, Dongiaban, Anh FROM tblHang WHERE ThuongHieu = @Brand";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Brand", selectedBrand);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string productName = reader["Tenhang"].ToString();
                    decimal price = (decimal)reader["Dongiaban"];
                    string imagePath = reader["Anh"].ToString();
                    Image image = Image.FromFile(imagePath);

                    Panel productPanel = new Panel
                    {
                        Size = new Size(200, 300),
                        Margin = new Padding(10),
                        BorderStyle = BorderStyle.FixedSingle
                    };

                    PictureBox pictureBox = new PictureBox
                    {
                        Size = new Size(180, 180),
                        Image = image,
                        SizeMode = PictureBoxSizeMode.StretchImage,
                        Location = new Point(10, 10)
                    };

                    Label nameLabel = new Label
                    {
                        Text = productName,
                        Font = new Font("Arial", 12, FontStyle.Bold),
                        Location = new Point(10, 200),
                        AutoSize = true
                    };

                    Label priceLabel = new Label
                    {
                        Text = $"{price:C}",
                        Font = new Font("Arial", 10, FontStyle.Regular),
                        Location = new Point(10, 230),
                        AutoSize = true
                    };

                    Button buyButton = new Button
                    {
                        Text = "Mua",
                        Location = new Point(10, 260),
                        Size = new Size(180, 30)
                    };

                    buyButton.Click += (s, eventArgs) =>
                    {
                        AddToCart(productName, price, image);
                        MessageBox.Show($"{productName} đã được thêm vào giỏ hàng!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    };

                    productPanel.Controls.Add(pictureBox);
                    productPanel.Controls.Add(nameLabel);
                    productPanel.Controls.Add(priceLabel);
                    productPanel.Controls.Add(buyButton);

                    flowLayoutPanel2.Controls.Add(productPanel);
                }
                reader.Close();
            }
        }

        private void txbTimKiem_TextChanged(object sender, EventArgs e)
        {
            SearchSanPham(txbTimKiem.Text.Trim());
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            SearchSanPham(txbTimKiem.Text.Trim());
        }
        private void SearchSanPham(string keyword)
        {
            string query = "SELECT * FROM tblHang WHERE TenHang LIKE @Keyword";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection); 
                command.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();

                try
                {
                    connection.Open();
                    adapter.Fill(dataTable);
                    ShowProductsOnFlowLayout(dataTable);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ShowProductsOnFlowLayout(DataTable dataTable)
        {
           
            flowLayoutPanel2.Controls.Clear();

            foreach (DataRow row in dataTable.Rows)
            {
                
                Panel productPanel = new Panel
                {
                    Width = 200,
                    Height = 300,
                    BorderStyle = BorderStyle.FixedSingle,
                    Margin = new Padding(10)
                };

                
                PictureBox pictureBox = new PictureBox
                {
                    Width = 180,
                    Height = 180,
                    SizeMode = PictureBoxSizeMode.Zoom,
                    ImageLocation = row["Anh"].ToString(),
                    Dock = DockStyle.Top
                };

                
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

                
                productPanel.Controls.Add(lblGiaBan);
                productPanel.Controls.Add(lblTenHang);
                productPanel.Controls.Add(pictureBox);

                
                flowLayoutPanel2.Controls.Add(productPanel);
            }
        }

        private void btnHangMoi_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

