namespace QuanLyHieuThuoc
{
    partial class FormQuanLy
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
            System.Windows.Forms.Button buttonTaiKhoan;
            System.Windows.Forms.Button buttonXemNv;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQuanLy));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.UC_NhanVien = new QuanLyHieuThuoc.QuanLyNhanVien.UC_NhanVien();
            this.UC_TaiKhoan = new QuanLyHieuThuoc.QuanLyNhanVien.UC_TaiKhoan();
            buttonTaiKhoan = new System.Windows.Forms.Button();
            buttonXemNv = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonTaiKhoan
            // 
            buttonTaiKhoan.BackColor = System.Drawing.Color.LightBlue;
            buttonTaiKhoan.FlatAppearance.BorderSize = 0;
            buttonTaiKhoan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            buttonTaiKhoan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            buttonTaiKhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            buttonTaiKhoan.ForeColor = System.Drawing.Color.Black;
            buttonTaiKhoan.Image = global::QuanLyHieuThuoc.Properties.Resources.icons8_add_user_48;
            buttonTaiKhoan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonTaiKhoan.Location = new System.Drawing.Point(12, 408);
            buttonTaiKhoan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            buttonTaiKhoan.Name = "buttonTaiKhoan";
            buttonTaiKhoan.Size = new System.Drawing.Size(253, 68);
            buttonTaiKhoan.TabIndex = 5;
            buttonTaiKhoan.Text = "Tài khoản";
            buttonTaiKhoan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            buttonTaiKhoan.UseVisualStyleBackColor = false;
            buttonTaiKhoan.Click += new System.EventHandler(this.buttonTaiKhoan_Click);
            // 
            // buttonXemNv
            // 
            buttonXemNv.BackColor = System.Drawing.Color.LightBlue;
            buttonXemNv.FlatAppearance.BorderSize = 0;
            buttonXemNv.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            buttonXemNv.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            buttonXemNv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonXemNv.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            buttonXemNv.ForeColor = System.Drawing.Color.Black;
            buttonXemNv.Image = global::QuanLyHieuThuoc.Properties.Resources.icons8_user_48;
            buttonXemNv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonXemNv.Location = new System.Drawing.Point(12, 315);
            buttonXemNv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            buttonXemNv.Name = "buttonXemNv";
            buttonXemNv.Size = new System.Drawing.Size(253, 68);
            buttonXemNv.TabIndex = 4;
            buttonXemNv.Text = "Nhân Viên";
            buttonXemNv.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            buttonXemNv.UseVisualStyleBackColor = false;
            buttonXemNv.Click += new System.EventHandler(this.buttonXemNv_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.LightBlue;
            this.panel1.Controls.Add(buttonTaiKhoan);
            this.panel1.Controls.Add(buttonXemNv);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 674);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(72, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 38);
            this.label2.TabIndex = 3;
            this.label2.Text = "Admin";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::QuanLyHieuThuoc.Properties.Resources.icons8_admin_100;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(48, 80);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(149, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // UC_NhanVien
            // 
            this.UC_NhanVien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UC_NhanVien.AutoScroll = true;
            this.UC_NhanVien.AutoSize = true;
            this.UC_NhanVien.Location = new System.Drawing.Point(273, -2);
            this.UC_NhanVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UC_NhanVien.Name = "UC_NhanVien";
            this.UC_NhanVien.Size = new System.Drawing.Size(62955, 674);
            this.UC_NhanVien.TabIndex = 1;
            // 
            // UC_TaiKhoan
            // 
            this.UC_TaiKhoan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UC_TaiKhoan.AutoSize = true;
            this.UC_TaiKhoan.Location = new System.Drawing.Point(273, -2);
            this.UC_TaiKhoan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UC_TaiKhoan.Name = "UC_TaiKhoan";
            this.UC_TaiKhoan.Size = new System.Drawing.Size(1112, 674);
            this.UC_TaiKhoan.TabIndex = 2;
            // 
            // FormQuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1396, 674);
            this.ControlBox = false;
            this.Controls.Add(this.UC_NhanVien);
            this.Controls.Add(this.UC_TaiKhoan);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormQuanLy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản lý nhân sự";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private QuanLyNhanVien.UC_NhanVien UC_NhanVien;
        private QuanLyNhanVien.UC_TaiKhoan UC_TaiKhoan;
    }
}