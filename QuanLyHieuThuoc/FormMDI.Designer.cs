namespace QuanLyHieuThuoc
{
    partial class FormMDI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMDI));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.labelTenTK = new System.Windows.Forms.ToolStripLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.trangChủToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhSáchNhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.điểmDanhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhMụcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.khoThuốcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhSáchHóaĐơnNhậpHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhSáchHóaĐơnBánHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.bảngCôngNhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vốnLãiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelTenTK});
            this.toolStrip1.Location = new System.Drawing.Point(0, 649);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1396, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // labelTenTK
            // 
            this.labelTenTK.Name = "labelTenTK";
            this.labelTenTK.Size = new System.Drawing.Size(150, 22);
            this.labelTenTK.Text = "Trạng thái đăng nhập";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trangChủToolStripMenuItem,
            this.hệThốngToolStripMenuItem,
            this.danhMụcToolStripMenuItem,
            this.thốngKêToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1396, 48);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // trangChủToolStripMenuItem
            // 
            this.trangChủToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("trangChủToolStripMenuItem.Image")));
            this.trangChủToolStripMenuItem.Name = "trangChủToolStripMenuItem";
            this.trangChủToolStripMenuItem.Size = new System.Drawing.Size(132, 44);
            this.trangChủToolStripMenuItem.Text = "Trang chủ";
            this.trangChủToolStripMenuItem.Click += new System.EventHandler(this.trangChủToolStripMenuItem_Click);
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.danhSáchNhânViênToolStripMenuItem,
            this.điểmDanhToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.hệThốngToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hệThốngToolStripMenuItem.Image = global::QuanLyHieuThuoc.Properties.Resources.icons8_management_system_50;
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(131, 44);
            this.hệThốngToolStripMenuItem.Text = "Hệ Thống";
            // 
            // danhSáchNhânViênToolStripMenuItem
            // 
            this.danhSáchNhânViênToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.danhSáchNhânViênToolStripMenuItem.Image = global::QuanLyHieuThuoc.Properties.Resources.icons8_management_50;
            this.danhSáchNhânViênToolStripMenuItem.Name = "danhSáchNhânViênToolStripMenuItem";
            this.danhSáchNhânViênToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.danhSáchNhânViênToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.danhSáchNhânViênToolStripMenuItem.Text = "Quản lý";
            this.danhSáchNhânViênToolStripMenuItem.Click += new System.EventHandler(this.danhSáchNhânViênToolStripMenuItem_Click);
            // 
            // điểmDanhToolStripMenuItem
            // 
            this.điểmDanhToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.điểmDanhToolStripMenuItem.Image = global::QuanLyHieuThuoc.Properties.Resources.icons8_attendance_50;
            this.điểmDanhToolStripMenuItem.Name = "điểmDanhToolStripMenuItem";
            this.điểmDanhToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.điểmDanhToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.điểmDanhToolStripMenuItem.Text = "Điểm danh";
            this.điểmDanhToolStripMenuItem.Click += new System.EventHandler(this.điểmDanhToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.đăngXuấtToolStripMenuItem.Image = global::QuanLyHieuThuoc.Properties.Resources.icons8_exit_30__1_;
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng Xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // danhMụcToolStripMenuItem
            // 
            this.danhMụcToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.khoThuốcToolStripMenuItem,
            this.danhSáchHóaĐơnNhậpHàngToolStripMenuItem,
            this.danhSáchHóaĐơnBánHàngToolStripMenuItem});
            this.danhMụcToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.danhMụcToolStripMenuItem.Image = global::QuanLyHieuThuoc.Properties.Resources.icons8_home_50;
            this.danhMụcToolStripMenuItem.Name = "danhMụcToolStripMenuItem";
            this.danhMụcToolStripMenuItem.Size = new System.Drawing.Size(129, 44);
            this.danhMụcToolStripMenuItem.Text = "Cửa hàng";
            // 
            // khoThuốcToolStripMenuItem
            // 
            this.khoThuốcToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.khoThuốcToolStripMenuItem.Image = global::QuanLyHieuThuoc.Properties.Resources.icons8_medicine_50;
            this.khoThuốcToolStripMenuItem.Name = "khoThuốcToolStripMenuItem";
            this.khoThuốcToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D1)));
            this.khoThuốcToolStripMenuItem.Size = new System.Drawing.Size(343, 26);
            this.khoThuốcToolStripMenuItem.Text = "Kho thuốc";
            this.khoThuốcToolStripMenuItem.Click += new System.EventHandler(this.khoThuốcToolStripMenuItem_Click);
            // 
            // danhSáchHóaĐơnNhậpHàngToolStripMenuItem
            // 
            this.danhSáchHóaĐơnNhậpHàngToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.danhSáchHóaĐơnNhậpHàngToolStripMenuItem.Image = global::QuanLyHieuThuoc.Properties.Resources.icons8_order_40;
            this.danhSáchHóaĐơnNhậpHàngToolStripMenuItem.Name = "danhSáchHóaĐơnNhậpHàngToolStripMenuItem";
            this.danhSáchHóaĐơnNhậpHàngToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D2)));
            this.danhSáchHóaĐơnNhậpHàngToolStripMenuItem.Size = new System.Drawing.Size(343, 26);
            this.danhSáchHóaĐơnNhậpHàngToolStripMenuItem.Text = "Danh sách hóa đơn nhập hàng";
            this.danhSáchHóaĐơnNhậpHàngToolStripMenuItem.Click += new System.EventHandler(this.danhSáchHóaĐơnNhậpHàngToolStripMenuItem_Click);
            // 
            // danhSáchHóaĐơnBánHàngToolStripMenuItem
            // 
            this.danhSáchHóaĐơnBánHàngToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.danhSáchHóaĐơnBánHàngToolStripMenuItem.Image = global::QuanLyHieuThuoc.Properties.Resources.icons8_order_40;
            this.danhSáchHóaĐơnBánHàngToolStripMenuItem.Name = "danhSáchHóaĐơnBánHàngToolStripMenuItem";
            this.danhSáchHóaĐơnBánHàngToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D3)));
            this.danhSáchHóaĐơnBánHàngToolStripMenuItem.Size = new System.Drawing.Size(343, 26);
            this.danhSáchHóaĐơnBánHàngToolStripMenuItem.Text = "Danh sách hóa đơn bán hàng";
            this.danhSáchHóaĐơnBánHàngToolStripMenuItem.Click += new System.EventHandler(this.danhSáchHóaĐơnBánHàngToolStripMenuItem_Click);
            // 
            // thốngKêToolStripMenuItem1
            // 
            this.thốngKêToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bảngCôngNhânViênToolStripMenuItem,
            this.vốnLãiToolStripMenuItem});
            this.thốngKêToolStripMenuItem1.Image = global::QuanLyHieuThuoc.Properties.Resources.icons8_report_35;
            this.thốngKêToolStripMenuItem1.Name = "thốngKêToolStripMenuItem1";
            this.thốngKêToolStripMenuItem1.Size = new System.Drawing.Size(128, 44);
            this.thốngKêToolStripMenuItem1.Text = "Thống kê";
            // 
            // bảngCôngNhânViênToolStripMenuItem
            // 
            this.bảngCôngNhânViênToolStripMenuItem.Image = global::QuanLyHieuThuoc.Properties.Resources.icons8_bribery_35;
            this.bảngCôngNhânViênToolStripMenuItem.Name = "bảngCôngNhânViênToolStripMenuItem";
            this.bảngCôngNhânViênToolStripMenuItem.Size = new System.Drawing.Size(265, 46);
            this.bảngCôngNhânViênToolStripMenuItem.Text = "Bảng lương nhân viên";
            this.bảngCôngNhânViênToolStripMenuItem.Click += new System.EventHandler(this.bảngCôngNhânViênToolStripMenuItem_Click);
            // 
            // vốnLãiToolStripMenuItem
            // 
            this.vốnLãiToolStripMenuItem.Image = global::QuanLyHieuThuoc.Properties.Resources.icons8_wage_38;
            this.vốnLãiToolStripMenuItem.Name = "vốnLãiToolStripMenuItem";
            this.vốnLãiToolStripMenuItem.Size = new System.Drawing.Size(265, 46);
            this.vốnLãiToolStripMenuItem.Text = "Doanh thu";
            this.vốnLãiToolStripMenuItem.Click += new System.EventHandler(this.vốnLãiToolStripMenuItem_Click);
            // 
            // FormMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::QuanLyHieuThuoc.Properties.Resources.nenMDI;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1396, 674);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMDI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "";
            this.Text = "Nhà thuốc Vinh Lưu Lộc";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhMụcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhSáchNhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem điểmDanhToolStripMenuItem;
        public System.Windows.Forms.ToolStripLabel labelTenTK;
        private System.Windows.Forms.ToolStripMenuItem thốngKêToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem khoThuốcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhSáchHóaĐơnNhậpHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhSáchHóaĐơnBánHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trangChủToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bảngCôngNhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vốnLãiToolStripMenuItem;
    }
}

