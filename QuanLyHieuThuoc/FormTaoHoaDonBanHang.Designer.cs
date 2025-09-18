namespace QuanLyHieuThuoc
{
    partial class FormTaoHoaDonBanHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTaoHoaDonBanHang));
            this.label8 = new System.Windows.Forms.Label();
            this.numericGiaBan = new System.Windows.Forms.NumericUpDown();
            this.buttonXoaSP = new System.Windows.Forms.Button();
            this.buttonThemSP = new System.Windows.Forms.Button();
            this.buttonXoaHoaDon = new System.Windows.Forms.Button();
            this.buttonSuaHoaDon = new System.Windows.Forms.Button();
            this.richTextBoxGhiChu2 = new System.Windows.Forms.RichTextBox();
            this.buttonTaoHoaDon = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBoxGhiChu1 = new System.Windows.Forms.RichTextBox();
            this.comboBoxPhuongThucThanhToan = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxTenThuoc = new System.Windows.Forms.ComboBox();
            this.buttonLuuHoaDon = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewChiTietHD = new System.Windows.Forms.DataGridView();
            this.numericUpDownSoLuong = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.GroupBoxThongTinHoaDon = new System.Windows.Forms.GroupBox();
            this.dataGridViewHoaDon = new System.Windows.Forms.DataGridView();
            this.maskedTextBoxSDT = new System.Windows.Forms.MaskedTextBox();
            this.labelSDTKH = new System.Windows.Forms.Label();
            this.textBoxMaHoaDonBanHang = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonXuatHoaDon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericGiaBan)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChiTietHD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSoLuong)).BeginInit();
            this.GroupBoxThongTinHoaDon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(6, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 23);
            this.label8.TabIndex = 56;
            this.label8.Text = "Giá bán:";
            // 
            // numericGiaBan
            // 
            this.numericGiaBan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericGiaBan.Location = new System.Drawing.Point(224, 143);
            this.numericGiaBan.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.numericGiaBan.Name = "numericGiaBan";
            this.numericGiaBan.ReadOnly = true;
            this.numericGiaBan.Size = new System.Drawing.Size(190, 27);
            this.numericGiaBan.TabIndex = 55;
            this.numericGiaBan.ThousandsSeparator = true;
            // 
            // buttonXoaSP
            // 
            this.buttonXoaSP.AutoSize = true;
            this.buttonXoaSP.BackColor = System.Drawing.Color.LightCyan;
            this.buttonXoaSP.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonXoaSP.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonXoaSP.ForeColor = System.Drawing.Color.Black;
            this.buttonXoaSP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonXoaSP.Location = new System.Drawing.Point(447, 121);
            this.buttonXoaSP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonXoaSP.Name = "buttonXoaSP";
            this.buttonXoaSP.Size = new System.Drawing.Size(132, 33);
            this.buttonXoaSP.TabIndex = 54;
            this.buttonXoaSP.Text = "Xóa sản phẩm";
            this.buttonXoaSP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonXoaSP.UseVisualStyleBackColor = false;
            this.buttonXoaSP.Click += new System.EventHandler(this.buttonXoaSP_Click);
            // 
            // buttonThemSP
            // 
            this.buttonThemSP.AutoSize = true;
            this.buttonThemSP.BackColor = System.Drawing.Color.LightCyan;
            this.buttonThemSP.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonThemSP.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThemSP.ForeColor = System.Drawing.Color.Black;
            this.buttonThemSP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonThemSP.Location = new System.Drawing.Point(442, 56);
            this.buttonThemSP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonThemSP.Name = "buttonThemSP";
            this.buttonThemSP.Size = new System.Drawing.Size(147, 33);
            this.buttonThemSP.TabIndex = 45;
            this.buttonThemSP.Text = "Thêm sản phẩm";
            this.buttonThemSP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonThemSP.UseVisualStyleBackColor = false;
            this.buttonThemSP.Click += new System.EventHandler(this.buttonThemSP_Click);
            // 
            // buttonXoaHoaDon
            // 
            this.buttonXoaHoaDon.AutoSize = true;
            this.buttonXoaHoaDon.BackColor = System.Drawing.Color.LightCyan;
            this.buttonXoaHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonXoaHoaDon.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonXoaHoaDon.ForeColor = System.Drawing.Color.Black;
            this.buttonXoaHoaDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonXoaHoaDon.Location = new System.Drawing.Point(442, 184);
            this.buttonXoaHoaDon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonXoaHoaDon.Name = "buttonXoaHoaDon";
            this.buttonXoaHoaDon.Size = new System.Drawing.Size(121, 33);
            this.buttonXoaHoaDon.TabIndex = 54;
            this.buttonXoaHoaDon.Text = "Xóa hóa đơn";
            this.buttonXoaHoaDon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonXoaHoaDon.UseVisualStyleBackColor = false;
            this.buttonXoaHoaDon.Click += new System.EventHandler(this.buttonXoaHoaDon_Click);
            // 
            // buttonSuaHoaDon
            // 
            this.buttonSuaHoaDon.AutoSize = true;
            this.buttonSuaHoaDon.BackColor = System.Drawing.Color.LightCyan;
            this.buttonSuaHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSuaHoaDon.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSuaHoaDon.ForeColor = System.Drawing.Color.Black;
            this.buttonSuaHoaDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSuaHoaDon.Location = new System.Drawing.Point(442, 116);
            this.buttonSuaHoaDon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSuaHoaDon.Name = "buttonSuaHoaDon";
            this.buttonSuaHoaDon.Size = new System.Drawing.Size(121, 33);
            this.buttonSuaHoaDon.TabIndex = 53;
            this.buttonSuaHoaDon.Text = "Sửa hóa đơn";
            this.buttonSuaHoaDon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSuaHoaDon.UseVisualStyleBackColor = false;
            this.buttonSuaHoaDon.Click += new System.EventHandler(this.buttonSuaHoaDon_Click);
            // 
            // richTextBoxGhiChu2
            // 
            this.richTextBoxGhiChu2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.richTextBoxGhiChu2.Location = new System.Drawing.Point(224, 184);
            this.richTextBoxGhiChu2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBoxGhiChu2.Name = "richTextBoxGhiChu2";
            this.richTextBoxGhiChu2.Size = new System.Drawing.Size(149, 96);
            this.richTextBoxGhiChu2.TabIndex = 50;
            this.richTextBoxGhiChu2.Text = "";
            // 
            // buttonTaoHoaDon
            // 
            this.buttonTaoHoaDon.AutoSize = true;
            this.buttonTaoHoaDon.BackColor = System.Drawing.Color.LightCyan;
            this.buttonTaoHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonTaoHoaDon.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTaoHoaDon.ForeColor = System.Drawing.Color.Black;
            this.buttonTaoHoaDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTaoHoaDon.Location = new System.Drawing.Point(442, 55);
            this.buttonTaoHoaDon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonTaoHoaDon.Name = "buttonTaoHoaDon";
            this.buttonTaoHoaDon.Size = new System.Drawing.Size(120, 33);
            this.buttonTaoHoaDon.TabIndex = 45;
            this.buttonTaoHoaDon.Text = "Tạo hóa đơn";
            this.buttonTaoHoaDon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonTaoHoaDon.UseVisualStyleBackColor = false;
            this.buttonTaoHoaDon.Click += new System.EventHandler(this.buttonTaoHoaDon_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(6, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 23);
            this.label3.TabIndex = 51;
            this.label3.Text = "Ghi chú:";
            // 
            // richTextBoxGhiChu1
            // 
            this.richTextBoxGhiChu1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.richTextBoxGhiChu1.Location = new System.Drawing.Point(226, 184);
            this.richTextBoxGhiChu1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBoxGhiChu1.Name = "richTextBoxGhiChu1";
            this.richTextBoxGhiChu1.Size = new System.Drawing.Size(149, 96);
            this.richTextBoxGhiChu1.TabIndex = 50;
            this.richTextBoxGhiChu1.Text = "";
            // 
            // comboBoxPhuongThucThanhToan
            // 
            this.comboBoxPhuongThucThanhToan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPhuongThucThanhToan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.comboBoxPhuongThucThanhToan.FormattingEnabled = true;
            this.comboBoxPhuongThucThanhToan.Items.AddRange(new object[] {
            "Chuyển khoản ngân hàng",
            "Tiền mặt"});
            this.comboBoxPhuongThucThanhToan.Location = new System.Drawing.Point(226, 139);
            this.comboBoxPhuongThucThanhToan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxPhuongThucThanhToan.Name = "comboBoxPhuongThucThanhToan";
            this.comboBoxPhuongThucThanhToan.Size = new System.Drawing.Size(190, 28);
            this.comboBoxPhuongThucThanhToan.TabIndex = 49;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(6, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 23);
            this.label4.TabIndex = 51;
            this.label4.Text = "Ghi chú:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(6, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 23);
            this.label5.TabIndex = 48;
            this.label5.Text = "Số lượng:";
            // 
            // comboBoxTenThuoc
            // 
            this.comboBoxTenThuoc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxTenThuoc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxTenThuoc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.comboBoxTenThuoc.FormattingEnabled = true;
            this.comboBoxTenThuoc.Location = new System.Drawing.Point(224, 56);
            this.comboBoxTenThuoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxTenThuoc.Name = "comboBoxTenThuoc";
            this.comboBoxTenThuoc.Size = new System.Drawing.Size(190, 28);
            this.comboBoxTenThuoc.TabIndex = 47;
            this.comboBoxTenThuoc.SelectedIndexChanged += new System.EventHandler(this.comboBoxTenThuoc_SelectedIndexChanged);
            // 
            // buttonLuuHoaDon
            // 
            this.buttonLuuHoaDon.AutoSize = true;
            this.buttonLuuHoaDon.BackColor = System.Drawing.Color.Salmon;
            this.buttonLuuHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonLuuHoaDon.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLuuHoaDon.ForeColor = System.Drawing.Color.Black;
            this.buttonLuuHoaDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLuuHoaDon.Location = new System.Drawing.Point(1323, 306);
            this.buttonLuuHoaDon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonLuuHoaDon.Name = "buttonLuuHoaDon";
            this.buttonLuuHoaDon.Size = new System.Drawing.Size(50, 101);
            this.buttonLuuHoaDon.TabIndex = 59;
            this.buttonLuuHoaDon.Text = "Lưu";
            this.buttonLuuHoaDon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonLuuHoaDon.UseVisualStyleBackColor = false;
            this.buttonLuuHoaDon.Click += new System.EventHandler(this.buttonLuuHoaDon_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(6, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 23);
            this.label2.TabIndex = 48;
            this.label2.Text = "Phương thức thanh toán:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.dataGridViewChiTietHD);
            this.groupBox1.Controls.Add(this.numericUpDownSoLuong);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.numericGiaBan);
            this.groupBox1.Controls.Add(this.buttonXoaSP);
            this.groupBox1.Controls.Add(this.buttonThemSP);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.richTextBoxGhiChu2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.comboBoxTenThuoc);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(21, 350);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1287, 305);
            this.groupBox1.TabIndex = 58;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi tiết hóa đơn";
            // 
            // dataGridViewChiTietHD
            // 
            this.dataGridViewChiTietHD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewChiTietHD.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewChiTietHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewChiTietHD.Location = new System.Drawing.Point(609, 24);
            this.dataGridViewChiTietHD.Name = "dataGridViewChiTietHD";
            this.dataGridViewChiTietHD.RowHeadersWidth = 51;
            this.dataGridViewChiTietHD.RowTemplate.Height = 24;
            this.dataGridViewChiTietHD.Size = new System.Drawing.Size(660, 275);
            this.dataGridViewChiTietHD.TabIndex = 59;
            // 
            // numericUpDownSoLuong
            // 
            this.numericUpDownSoLuong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownSoLuong.Location = new System.Drawing.Point(224, 98);
            this.numericUpDownSoLuong.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.numericUpDownSoLuong.Name = "numericUpDownSoLuong";
            this.numericUpDownSoLuong.Size = new System.Drawing.Size(190, 27);
            this.numericUpDownSoLuong.TabIndex = 57;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(6, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 23);
            this.label6.TabIndex = 46;
            this.label6.Text = "Tên thuốc:";
            // 
            // GroupBoxThongTinHoaDon
            // 
            this.GroupBoxThongTinHoaDon.BackColor = System.Drawing.Color.Transparent;
            this.GroupBoxThongTinHoaDon.Controls.Add(this.dataGridViewHoaDon);
            this.GroupBoxThongTinHoaDon.Controls.Add(this.maskedTextBoxSDT);
            this.GroupBoxThongTinHoaDon.Controls.Add(this.buttonXoaHoaDon);
            this.GroupBoxThongTinHoaDon.Controls.Add(this.buttonSuaHoaDon);
            this.GroupBoxThongTinHoaDon.Controls.Add(this.buttonTaoHoaDon);
            this.GroupBoxThongTinHoaDon.Controls.Add(this.label3);
            this.GroupBoxThongTinHoaDon.Controls.Add(this.richTextBoxGhiChu1);
            this.GroupBoxThongTinHoaDon.Controls.Add(this.comboBoxPhuongThucThanhToan);
            this.GroupBoxThongTinHoaDon.Controls.Add(this.label2);
            this.GroupBoxThongTinHoaDon.Controls.Add(this.labelSDTKH);
            this.GroupBoxThongTinHoaDon.Controls.Add(this.textBoxMaHoaDonBanHang);
            this.GroupBoxThongTinHoaDon.Controls.Add(this.label7);
            this.GroupBoxThongTinHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GroupBoxThongTinHoaDon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBoxThongTinHoaDon.Location = new System.Drawing.Point(21, 52);
            this.GroupBoxThongTinHoaDon.Name = "GroupBoxThongTinHoaDon";
            this.GroupBoxThongTinHoaDon.Size = new System.Drawing.Size(1287, 281);
            this.GroupBoxThongTinHoaDon.TabIndex = 57;
            this.GroupBoxThongTinHoaDon.TabStop = false;
            this.GroupBoxThongTinHoaDon.Text = "Thông tin hóa đơn:";
            // 
            // dataGridViewHoaDon
            // 
            this.dataGridViewHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewHoaDon.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHoaDon.Location = new System.Drawing.Point(609, 33);
            this.dataGridViewHoaDon.Name = "dataGridViewHoaDon";
            this.dataGridViewHoaDon.RowHeadersWidth = 51;
            this.dataGridViewHoaDon.RowTemplate.Height = 24;
            this.dataGridViewHoaDon.Size = new System.Drawing.Size(660, 230);
            this.dataGridViewHoaDon.TabIndex = 58;
            // 
            // maskedTextBoxSDT
            // 
            this.maskedTextBoxSDT.AllowPromptAsInput = false;
            this.maskedTextBoxSDT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.maskedTextBoxSDT.Location = new System.Drawing.Point(224, 97);
            this.maskedTextBoxSDT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maskedTextBoxSDT.Mask = "0000000000";
            this.maskedTextBoxSDT.Name = "maskedTextBoxSDT";
            this.maskedTextBoxSDT.PromptChar = ' ';
            this.maskedTextBoxSDT.Size = new System.Drawing.Size(192, 27);
            this.maskedTextBoxSDT.TabIndex = 57;
            this.maskedTextBoxSDT.ValidatingType = typeof(int);
            this.maskedTextBoxSDT.Click += new System.EventHandler(this.maskedTextBoxSDT_Click);
            // 
            // labelSDTKH
            // 
            this.labelSDTKH.AutoSize = true;
            this.labelSDTKH.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSDTKH.ForeColor = System.Drawing.Color.Black;
            this.labelSDTKH.Location = new System.Drawing.Point(6, 97);
            this.labelSDTKH.Name = "labelSDTKH";
            this.labelSDTKH.Size = new System.Drawing.Size(209, 23);
            this.labelSDTKH.TabIndex = 46;
            this.labelSDTKH.Text = "Số điện thoại khách hàng:";
            // 
            // textBoxMaHoaDonBanHang
            // 
            this.textBoxMaHoaDonBanHang.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxMaHoaDonBanHang.Location = new System.Drawing.Point(226, 55);
            this.textBoxMaHoaDonBanHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxMaHoaDonBanHang.Name = "textBoxMaHoaDonBanHang";
            this.textBoxMaHoaDonBanHang.ReadOnly = true;
            this.textBoxMaHoaDonBanHang.Size = new System.Drawing.Size(89, 27);
            this.textBoxMaHoaDonBanHang.TabIndex = 45;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(6, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(185, 23);
            this.label7.TabIndex = 26;
            this.label7.Text = "Mã hóa đơn bán hàng:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(468, -5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(467, 67);
            this.label9.TabIndex = 60;
            this.label9.Text = "Hóa đơn bán hàng";
            // 
            // buttonXuatHoaDon
            // 
            this.buttonXuatHoaDon.AutoSize = true;
            this.buttonXuatHoaDon.BackColor = System.Drawing.Color.LightCyan;
            this.buttonXuatHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonXuatHoaDon.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonXuatHoaDon.ForeColor = System.Drawing.Color.Black;
            this.buttonXuatHoaDon.Image = global::QuanLyHieuThuoc.Properties.Resources.icons8_invoice_40;
            this.buttonXuatHoaDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonXuatHoaDon.Location = new System.Drawing.Point(1163, 11);
            this.buttonXuatHoaDon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonXuatHoaDon.Name = "buttonXuatHoaDon";
            this.buttonXuatHoaDon.Size = new System.Drawing.Size(173, 46);
            this.buttonXuatHoaDon.TabIndex = 61;
            this.buttonXuatHoaDon.Text = "Xuất hóa đơn:";
            this.buttonXuatHoaDon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonXuatHoaDon.UseVisualStyleBackColor = false;
            this.buttonXuatHoaDon.Click += new System.EventHandler(this.buttonXuatHoaDon_Click);
            // 
            // FormTaoHoaDonBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1396, 708);
            this.ControlBox = false;
            this.Controls.Add(this.buttonXuatHoaDon);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.buttonLuuHoaDon);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GroupBoxThongTinHoaDon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormTaoHoaDonBanHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tạo hóa đơn bán hàng";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormTaoHoaDonBanHang_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.numericGiaBan)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChiTietHD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSoLuong)).EndInit();
            this.GroupBoxThongTinHoaDon.ResumeLayout(false);
            this.GroupBoxThongTinHoaDon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHoaDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericGiaBan;
        private System.Windows.Forms.Button buttonXoaSP;
        private System.Windows.Forms.Button buttonThemSP;
        private System.Windows.Forms.Button buttonXoaHoaDon;
        private System.Windows.Forms.Button buttonSuaHoaDon;
        private System.Windows.Forms.RichTextBox richTextBoxGhiChu2;
        private System.Windows.Forms.Button buttonTaoHoaDon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBoxGhiChu1;
        private System.Windows.Forms.ComboBox comboBoxPhuongThucThanhToan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxTenThuoc;
        private System.Windows.Forms.Button buttonLuuHoaDon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numericUpDownSoLuong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox GroupBoxThongTinHoaDon;
        private System.Windows.Forms.Label labelSDTKH;
        private System.Windows.Forms.TextBox textBoxMaHoaDonBanHang;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxSDT;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonXuatHoaDon;
        private System.Windows.Forms.DataGridView dataGridViewHoaDon;
        private System.Windows.Forms.DataGridView dataGridViewChiTietHD;
    }
}