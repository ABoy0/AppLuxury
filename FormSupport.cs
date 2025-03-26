using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppLuxury
{
    public partial class FormSupport : Form
    {
        public FormSupport()
        {
            InitializeComponent();
        }

        private void btnTroLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lklfb_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            string fbLink = "https://www.facebook.com/tranduongkhanh19012004/"; 

            
            System.Diagnostics.Process.Start(fbLink);
        }

        private void btnGuiTinNhan_Click(object sender, EventArgs e)
        {
          
            string emailAddress = "tranduongkhanh191@gmail.com";

           
            string body = txbHoTro.Text.Trim(); 

           
            string subject = "Tin nhắn từ khách hàng";

           
            string mailtoLink = $"mailto:{emailAddress}?subject={Uri.EscapeDataString(subject)}&body={Uri.EscapeDataString(body)}";

            
            System.Diagnostics.Process.Start(mailtoLink);

            
            txbHoTro.Clear();
        }

        private void FormSupport_Load(object sender, EventArgs e)
        {

        }
    }
}
