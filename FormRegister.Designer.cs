namespace AppLuxury
{
    partial class FormRegister
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
            this.lblThoat = new System.Windows.Forms.Label();
            this.btnDangKi = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.txtTenTaiKhoan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGmail = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblThoat
            // 
            this.lblThoat.AutoSize = true;
            this.lblThoat.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThoat.Location = new System.Drawing.Point(900, 556);
            this.lblThoat.Name = "lblThoat";
            this.lblThoat.Size = new System.Drawing.Size(81, 35);
            this.lblThoat.TabIndex = 15;
            this.lblThoat.Text = "Thoát";
            this.lblThoat.Click += new System.EventHandler(this.lblThoat_Click);
            this.lblThoat.MouseEnter += new System.EventHandler(this.lblThoat_MouseEnter);
            this.lblThoat.MouseLeave += new System.EventHandler(this.lblThoat_MouseLeave);
            // 
            // btnDangKi
            // 
            this.btnDangKi.Font = new System.Drawing.Font("Calibri", 14F);
            this.btnDangKi.Location = new System.Drawing.Point(855, 493);
            this.btnDangKi.Name = "btnDangKi";
            this.btnDangKi.Size = new System.Drawing.Size(126, 48);
            this.btnDangKi.TabIndex = 12;
            this.btnDangKi.Text = "Đăng kí";
            this.btnDangKi.UseVisualStyleBackColor = true;
            this.btnDangKi.Click += new System.EventHandler(this.btnDangKi_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(466, 377);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 41);
            this.label2.TabIndex = 11;
            this.label2.Text = "Mật khẩu";
            //this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 17F);
            this.label1.Location = new System.Drawing.Point(466, 435);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 41);
            this.label1.TabIndex = 10;
            this.label1.Text = "Gmail";
            //this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Font = new System.Drawing.Font("Tahoma", 14F);
            this.txtMatKhau.Location = new System.Drawing.Point(686, 370);
            this.txtMatKhau.Multiline = true;
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '*';
            this.txtMatKhau.Size = new System.Drawing.Size(358, 47);
            this.txtMatKhau.TabIndex = 9;
            this.txtMatKhau.TextChanged += new System.EventHandler(this.txtMatKhau_TextChanged);
            // 
            // txtTenTaiKhoan
            // 
            this.txtTenTaiKhoan.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenTaiKhoan.ForeColor = System.Drawing.Color.Black;
            this.txtTenTaiKhoan.Location = new System.Drawing.Point(686, 311);
            this.txtTenTaiKhoan.Multiline = true;
            this.txtTenTaiKhoan.Name = "txtTenTaiKhoan";
            this.txtTenTaiKhoan.Size = new System.Drawing.Size(358, 52);
            this.txtTenTaiKhoan.TabIndex = 8;
            //this.txtTenTaiKhoan.TextChanged += new System.EventHandler(this.txtTenTaiKhoan_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 17F);
            this.label3.Location = new System.Drawing.Point(466, 323);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 41);
            this.label3.TabIndex = 17;
            this.label3.Text = "Tên tài khoản";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtGmail
            // 
            this.txtGmail.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGmail.ForeColor = System.Drawing.Color.Black;
            this.txtGmail.Location = new System.Drawing.Point(686, 423);
            this.txtGmail.Multiline = true;
            this.txtGmail.Name = "txtGmail";
            this.txtGmail.Size = new System.Drawing.Size(469, 52);
            this.txtGmail.TabIndex = 16;
            //this.txtGmail.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // FormRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AppLuxury.Properties.Resources.ABShop;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1478, 800);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtGmail);
            this.Controls.Add(this.lblThoat);
            this.Controls.Add(this.btnDangKi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txtTenTaiKhoan);
            this.DoubleBuffered = true;
            this.Name = "FormRegister";
            this.Text = "FormRegister";
            this.Load += new System.EventHandler(this.FormRegister_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblThoat;
        private System.Windows.Forms.Button btnDangKi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.TextBox txtTenTaiKhoan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGmail;
    }
}