namespace QuanLyHieuThuoc
{
    partial class FormDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDangNhap));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textUsername = new System.Windows.Forms.TextBox();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nutquenmk = new System.Windows.Forms.LinkLabel();
            this.buttonDangNhap = new System.Windows.Forms.Button();
            this.buttonThoat = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(814, 273);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(461, 41);
            this.label1.TabIndex = 2;
            this.label1.Text = "Vui lòng đăng nhập để sử dụng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(873, 375);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Username";
            // 
            // textUsername
            // 
            this.textUsername.Location = new System.Drawing.Point(833, 408);
            this.textUsername.Name = "textUsername";
            this.textUsername.Size = new System.Drawing.Size(442, 22);
            this.textUsername.TabIndex = 1;
            // 
            // textPassword
            // 
            this.textPassword.Location = new System.Drawing.Point(833, 476);
            this.textPassword.Name = "textPassword";
            this.textPassword.PasswordChar = '*';
            this.textPassword.Size = new System.Drawing.Size(442, 22);
            this.textPassword.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(873, 443);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Password";
            // 
            // nutquenmk
            // 
            this.nutquenmk.AutoSize = true;
            this.nutquenmk.Cursor = System.Windows.Forms.Cursors.Help;
            this.nutquenmk.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.nutquenmk.Location = new System.Drawing.Point(1130, 517);
            this.nutquenmk.Name = "nutquenmk";
            this.nutquenmk.Size = new System.Drawing.Size(145, 23);
            this.nutquenmk.TabIndex = 10;
            this.nutquenmk.TabStop = true;
            this.nutquenmk.Text = "Quên mật khẩu ?";
            this.nutquenmk.MouseClick += new System.Windows.Forms.MouseEventHandler(this.clickquenmk);
            // 
            // buttonDangNhap
            // 
            this.buttonDangNhap.AutoSize = true;
            this.buttonDangNhap.BackColor = System.Drawing.Color.LightCyan;
            this.buttonDangNhap.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDangNhap.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDangNhap.ForeColor = System.Drawing.Color.Black;
            this.buttonDangNhap.Image = global::QuanLyHieuThuoc.Properties.Resources.icons8_login_48;
            this.buttonDangNhap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDangNhap.Location = new System.Drawing.Point(980, 556);
            this.buttonDangNhap.Name = "buttonDangNhap";
            this.buttonDangNhap.Size = new System.Drawing.Size(159, 54);
            this.buttonDangNhap.TabIndex = 3;
            this.buttonDangNhap.Text = "Đăng Nhập";
            this.buttonDangNhap.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonDangNhap.UseVisualStyleBackColor = false;
            this.buttonDangNhap.Click += new System.EventHandler(this.buttonDangNhap_Click);
            // 
            // buttonThoat
            // 
            this.buttonThoat.AutoSize = true;
            this.buttonThoat.BackgroundImage = global::QuanLyHieuThuoc.Properties.Resources.icons8_exit_60;
            this.buttonThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonThoat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonThoat.Location = new System.Drawing.Point(1289, 643);
            this.buttonThoat.Name = "buttonThoat";
            this.buttonThoat.Size = new System.Drawing.Size(61, 66);
            this.buttonThoat.TabIndex = 12;
            this.buttonThoat.UseVisualStyleBackColor = false;
            this.buttonThoat.Click += new System.EventHandler(this.buttonThoat_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::QuanLyHieuThuoc.Properties.Resources.password_22;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(833, 436);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(34, 34);
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::QuanLyHieuThuoc.Properties.Resources.user;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(833, 368);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(34, 34);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::QuanLyHieuThuoc.Properties.Resources.logothuoc;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(931, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(232, 230);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::QuanLyHieuThuoc.Properties.Resources.Xanh_dương_và_Xanh_ngọc_lam_Thông_thường_Doanh_nghiệp_Hiệu_thuốc_Kỹ_thuật_số_Bài_đăng_Facebook;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(691, 697);
            this.panel1.TabIndex = 0;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.checkBox1.Location = new System.Drawing.Point(833, 513);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(169, 27);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "Hiển thị mật khẩu";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // FormDangNhap
            // 
            this.AcceptButton = this.buttonDangNhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.CancelButton = this.buttonThoat;
            this.ClientSize = new System.Drawing.Size(1362, 721);
            this.ControlBox = false;
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.buttonThoat);
            this.Controls.Add(this.nutquenmk);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textUsername);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonDangNhap);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDangNhap";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormDangNhap_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonDangNhap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel nutquenmk;
        private System.Windows.Forms.Button buttonThoat;
        public System.Windows.Forms.TextBox textUsername;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}