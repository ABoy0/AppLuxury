using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace AppLuxury
{
    public partial class FormCart : Form
    {
        private List<(string productName, decimal price, int quantity, Image image)> cart;

        public FormCart(List<(string productName, decimal price, int quantity, Image image)> cartItems)
        {
            InitializeComponent();
            cart = cartItems;
            LoadCart();
        }

        private void LoadCart()
        {
            
            dgvCart.Columns.Clear();
            var imageColumn = new DataGridViewImageColumn
            {
                Name = "Image",
                HeaderText = "Hình ảnh",
                Width = 200,
                ImageLayout = DataGridViewImageCellLayout.Zoom 
            };
            dgvCart.Columns.Add(imageColumn); 
            dgvCart.Columns.Add("ProductName", "Tên sản phẩm");
            dgvCart.Columns.Add("Price", "Giá");
            dgvCart.Columns.Add("Quantity", "Số lượng");

          
            foreach (var item in cart)
            {
                var index = dgvCart.Rows.Add();
                dgvCart.Rows[index].Cells["Image"].Value = item.image; 
                dgvCart.Rows[index].Cells["ProductName"].Value = item.productName;
                dgvCart.Rows[index].Cells["Price"].Value = item.price.ToString("C");
                dgvCart.Rows[index].Cells["Quantity"].Value = item.quantity;


                dgvCart.Rows[index].Height = 200;
            }

            decimal total = 0;
            foreach (var item in cart)
            {
                total += item.price * item.quantity;
            }

            
            lblTotal.Text = $" {total:C}";
        }

        private void FormCart_Load(object sender, EventArgs e)
        {
            
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}
