namespace AppLuxury
{
    partial class FormAdmin
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
            this.grbAdmin = new System.Windows.Forms.GroupBox();
            this.btnTimTK = new System.Windows.Forms.Button();
            this.txtTimTK = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnXoaTK = new System.Windows.Forms.Button();
            this.grbDanhSachTK = new System.Windows.Forms.GroupBox();
            this.flPannelDanhSachTK = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSuaTK = new System.Windows.Forms.Button();
            this.btnTimSP = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnXoaSP = new System.Windows.Forms.Button();
            this.btnThemSP = new System.Windows.Forms.Button();
            this.txtMaHang = new System.Windows.Forms.TextBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.txtĐGB = new System.Windows.Forms.TextBox();
            this.txtĐGN = new System.Windows.Forms.TextBox();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.txtMaCL = new System.Windows.Forms.TextBox();
            this.txtTenHang = new System.Windows.Forms.TextBox();
            this.pictureBoxSP = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnThemAnh = new System.Windows.Forms.Button();
            this.grbAdmin.SuspendLayout();
            this.grbDanhSachTK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSP)).BeginInit();
            this.SuspendLayout();
            // 
            // grbAdmin
            // 
            this.grbAdmin.Controls.Add(this.btnTimTK);
            this.grbAdmin.Controls.Add(this.txtTimTK);
            this.grbAdmin.Controls.Add(this.label1);
            this.grbAdmin.Controls.Add(this.btnXoaTK);
            this.grbAdmin.Controls.Add(this.grbDanhSachTK);
            this.grbAdmin.Controls.Add(this.btnSuaTK);
            this.grbAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.grbAdmin.Location = new System.Drawing.Point(8, 3);
            this.grbAdmin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbAdmin.Name = "grbAdmin";
            this.grbAdmin.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbAdmin.Size = new System.Drawing.Size(1069, 686);
            this.grbAdmin.TabIndex = 0;
            this.grbAdmin.TabStop = false;
            this.grbAdmin.Text = "Admin";
            // 
            // btnTimTK
            // 
            this.btnTimTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimTK.Location = new System.Drawing.Point(651, 112);
            this.btnTimTK.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTimTK.Name = "btnTimTK";
            this.btnTimTK.Size = new System.Drawing.Size(54, 24);
            this.btnTimTK.TabIndex = 11;
            this.btnTimTK.Text = "Tìm";
            this.btnTimTK.UseVisualStyleBackColor = true;
            this.btnTimTK.Click += new System.EventHandler(this.btnTimTK_Click);
            // 
            // txtTimTK
            // 
            this.txtTimTK.Location = new System.Drawing.Point(651, 86);
            this.txtTimTK.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTimTK.Multiline = true;
            this.txtTimTK.Name = "txtTimTK";
            this.txtTimTK.Size = new System.Drawing.Size(166, 24);
            this.txtTimTK.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(648, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tài khoản";
            // 
            // btnXoaTK
            // 
            this.btnXoaTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaTK.Location = new System.Drawing.Point(767, 112);
            this.btnXoaTK.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnXoaTK.Name = "btnXoaTK";
            this.btnXoaTK.Size = new System.Drawing.Size(49, 23);
            this.btnXoaTK.TabIndex = 3;
            this.btnXoaTK.Text = "Xóa";
            this.btnXoaTK.UseVisualStyleBackColor = true;
            this.btnXoaTK.Click += new System.EventHandler(this.btnXoaTK_Click);
            // 
            // grbDanhSachTK
            // 
            this.grbDanhSachTK.Controls.Add(this.flPannelDanhSachTK);
            this.grbDanhSachTK.Location = new System.Drawing.Point(820, 33);
            this.grbDanhSachTK.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbDanhSachTK.Name = "grbDanhSachTK";
            this.grbDanhSachTK.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbDanhSachTK.Size = new System.Drawing.Size(237, 208);
            this.grbDanhSachTK.TabIndex = 0;
            this.grbDanhSachTK.TabStop = false;
            this.grbDanhSachTK.Text = "Danh sách tài khoản";
            // 
            // flPannelDanhSachTK
            // 
            this.flPannelDanhSachTK.Location = new System.Drawing.Point(4, 22);
            this.flPannelDanhSachTK.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flPannelDanhSachTK.Name = "flPannelDanhSachTK";
            this.flPannelDanhSachTK.Size = new System.Drawing.Size(229, 176);
            this.flPannelDanhSachTK.TabIndex = 0;
            this.flPannelDanhSachTK.Paint += new System.Windows.Forms.PaintEventHandler(this.flPannelDanhSachTK_Paint);
            // 
            // btnSuaTK
            // 
            this.btnSuaTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaTK.Location = new System.Drawing.Point(709, 113);
            this.btnSuaTK.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSuaTK.Name = "btnSuaTK";
            this.btnSuaTK.Size = new System.Drawing.Size(53, 23);
            this.btnSuaTK.TabIndex = 2;
            this.btnSuaTK.Text = "Sửa";
            this.btnSuaTK.UseVisualStyleBackColor = true;
            this.btnSuaTK.Click += new System.EventHandler(this.btnSuaTK_Click);
            // 
            // btnTimSP
            // 
            this.btnTimSP.Location = new System.Drawing.Point(812, 332);
            this.btnTimSP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTimSP.Name = "btnTimSP";
            this.btnTimSP.Size = new System.Drawing.Size(58, 25);
            this.btnTimSP.TabIndex = 12;
            this.btnTimSP.Text = "Tìm";
            this.btnTimSP.UseVisualStyleBackColor = true;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(891, 302);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTimKiem.Multiline = true;
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(174, 27);
            this.txtTimKiem.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(806, 309);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "Sản phẩm";
            // 
            // btnXoaSP
            // 
            this.btnXoaSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaSP.Location = new System.Drawing.Point(971, 332);
            this.btnXoaSP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnXoaSP.Name = "btnXoaSP";
            this.btnXoaSP.Size = new System.Drawing.Size(93, 30);
            this.btnXoaSP.TabIndex = 6;
            this.btnXoaSP.Text = "Xóa";
            this.btnXoaSP.UseVisualStyleBackColor = true;
            this.btnXoaSP.Click += new System.EventHandler(this.btnXoaSP_Click);
            // 
            // btnThemSP
            // 
            this.btnThemSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemSP.Location = new System.Drawing.Point(874, 332);
            this.btnThemSP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThemSP.Name = "btnThemSP";
            this.btnThemSP.Size = new System.Drawing.Size(93, 30);
            this.btnThemSP.TabIndex = 4;
            this.btnThemSP.Text = "Thêm";
            this.btnThemSP.UseVisualStyleBackColor = true;
            this.btnThemSP.Click += new System.EventHandler(this.btnThemSP_Click);
            // 
            // txtMaHang
            // 
            this.txtMaHang.Location = new System.Drawing.Point(893, 366);
            this.txtMaHang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMaHang.Multiline = true;
            this.txtMaHang.Name = "txtMaHang";
            this.txtMaHang.Size = new System.Drawing.Size(171, 26);
            this.txtMaHang.TabIndex = 7;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(893, 540);
            this.txtGhiChu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(171, 26);
            this.txtGhiChu.TabIndex = 9;
            // 
            // txtĐGB
            // 
            this.txtĐGB.Location = new System.Drawing.Point(893, 511);
            this.txtĐGB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtĐGB.Multiline = true;
            this.txtĐGB.Name = "txtĐGB";
            this.txtĐGB.Size = new System.Drawing.Size(171, 26);
            this.txtĐGB.TabIndex = 10;
            // 
            // txtĐGN
            // 
            this.txtĐGN.Location = new System.Drawing.Point(893, 482);
            this.txtĐGN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtĐGN.Multiline = true;
            this.txtĐGN.Name = "txtĐGN";
            this.txtĐGN.Size = new System.Drawing.Size(171, 26);
            this.txtĐGN.TabIndex = 11;
            // 
            // txtSL
            // 
            this.txtSL.Location = new System.Drawing.Point(893, 454);
            this.txtSL.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSL.Multiline = true;
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(171, 26);
            this.txtSL.TabIndex = 12;
            // 
            // txtMaCL
            // 
            this.txtMaCL.Location = new System.Drawing.Point(893, 425);
            this.txtMaCL.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMaCL.Multiline = true;
            this.txtMaCL.Name = "txtMaCL";
            this.txtMaCL.Size = new System.Drawing.Size(171, 26);
            this.txtMaCL.TabIndex = 13;
            this.txtMaCL.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // txtTenHang
            // 
            this.txtTenHang.Location = new System.Drawing.Point(893, 396);
            this.txtTenHang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTenHang.Multiline = true;
            this.txtTenHang.Name = "txtTenHang";
            this.txtTenHang.Size = new System.Drawing.Size(171, 26);
            this.txtTenHang.TabIndex = 14;
            // 
            // pictureBoxSP
            // 
            this.pictureBoxSP.Location = new System.Drawing.Point(674, 332);
            this.pictureBoxSP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBoxSP.Name = "pictureBoxSP";
            this.pictureBoxSP.Size = new System.Drawing.Size(131, 110);
            this.pictureBoxSP.TabIndex = 15;
            this.pictureBoxSP.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(809, 366);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 29);
            this.label3.TabIndex = 13;
            this.label3.Text = "Mã hàng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(808, 545);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 29);
            this.label5.TabIndex = 17;
            this.label5.Text = "Ghi chú";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(809, 517);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 29);
            this.label6.TabIndex = 18;
            this.label6.Text = "ĐGB";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(809, 488);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 29);
            this.label7.TabIndex = 19;
            this.label7.Text = "ĐGN";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(809, 454);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 29);
            this.label8.TabIndex = 20;
            this.label8.Text = "SL";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(809, 422);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 29);
            this.label9.TabIndex = 21;
            this.label9.Text = "Mã CL";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(808, 396);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 29);
            this.label10.TabIndex = 22;
            this.label10.Text = "Tên hàng";
            // 
            // btnThemAnh
            // 
            this.btnThemAnh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemAnh.Location = new System.Drawing.Point(674, 304);
            this.btnThemAnh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThemAnh.Name = "btnThemAnh";
            this.btnThemAnh.Size = new System.Drawing.Size(93, 24);
            this.btnThemAnh.TabIndex = 23;
            this.btnThemAnh.Text = "Ảnh";
            this.btnThemAnh.UseVisualStyleBackColor = true;
            this.btnThemAnh.Click += new System.EventHandler(this.btnThemAnh_Click);
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 696);
            this.Controls.Add(this.btnThemAnh);
            this.Controls.Add(this.btnTimSP);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnThemSP);
            this.Controls.Add(this.pictureBoxSP);
            this.Controls.Add(this.txtTenHang);
            this.Controls.Add(this.txtMaCL);
            this.Controls.Add(this.txtSL);
            this.Controls.Add(this.txtĐGN);
            this.Controls.Add(this.txtĐGB);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.txtMaHang);
            this.Controls.Add(this.btnXoaSP);
            this.Controls.Add(this.grbAdmin);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormAdmin";
            this.Text = "FormAdmin";
            this.Load += new System.EventHandler(this.FormAdmin_Load);
            this.grbAdmin.ResumeLayout(false);
            this.grbAdmin.PerformLayout();
            this.grbDanhSachTK.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbAdmin;
        private System.Windows.Forms.GroupBox grbDanhSachTK;
        private System.Windows.Forms.Button btnSuaTK;
        private System.Windows.Forms.Button btnXoaTK;
        private System.Windows.Forms.Button btnXoaSP;
        private System.Windows.Forms.Button btnThemSP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.TextBox txtTimTK;
        private System.Windows.Forms.Button btnTimTK;
        private System.Windows.Forms.Button btnTimSP;
        private System.Windows.Forms.FlowLayoutPanel flPannelDanhSachTK;
        private System.Windows.Forms.TextBox txtMaHang;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.TextBox txtĐGB;
        private System.Windows.Forms.TextBox txtĐGN;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.TextBox txtMaCL;
        private System.Windows.Forms.TextBox txtTenHang;
        private System.Windows.Forms.PictureBox pictureBoxSP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnThemAnh;
    }
}