namespace QuanLyHieuThuoc
{
    partial class FormLuongNhanVien
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GroupBoxTruyVan = new System.Windows.Forms.GroupBox();
            this.buttonTimKiem = new System.Windows.Forms.Button();
            this.ButtonTruyVan = new System.Windows.Forms.Button();
            this.textBoxTimKiem = new System.Windows.Forms.TextBox();
            this.dateTimeDenNgay = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimeTuNgay = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewBangCong = new System.Windows.Forms.DataGridView();
            this.buttonXuat = new System.Windows.Forms.Button();
            this.GroupBoxTruyVan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBangCong)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBoxTruyVan
            // 
            this.GroupBoxTruyVan.BackColor = System.Drawing.SystemColors.Control;
            this.GroupBoxTruyVan.Controls.Add(this.buttonTimKiem);
            this.GroupBoxTruyVan.Controls.Add(this.ButtonTruyVan);
            this.GroupBoxTruyVan.Controls.Add(this.textBoxTimKiem);
            this.GroupBoxTruyVan.Controls.Add(this.dateTimeDenNgay);
            this.GroupBoxTruyVan.Controls.Add(this.label1);
            this.GroupBoxTruyVan.Controls.Add(this.dateTimeTuNgay);
            this.GroupBoxTruyVan.Controls.Add(this.label2);
            this.GroupBoxTruyVan.Dock = System.Windows.Forms.DockStyle.Top;
            this.GroupBoxTruyVan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GroupBoxTruyVan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBoxTruyVan.Location = new System.Drawing.Point(0, 0);
            this.GroupBoxTruyVan.Name = "GroupBoxTruyVan";
            this.GroupBoxTruyVan.Size = new System.Drawing.Size(1396, 69);
            this.GroupBoxTruyVan.TabIndex = 49;
            this.GroupBoxTruyVan.TabStop = false;
            this.GroupBoxTruyVan.Text = "Truy vấn chấm công";
            // 
            // buttonTimKiem
            // 
            this.buttonTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonTimKiem.AutoSize = true;
            this.buttonTimKiem.BackColor = System.Drawing.Color.MistyRose;
            this.buttonTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonTimKiem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonTimKiem.Image = global::QuanLyHieuThuoc.Properties.Resources.icons8_search_25;
            this.buttonTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTimKiem.Location = new System.Drawing.Point(1271, 20);
            this.buttonTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonTimKiem.Name = "buttonTimKiem";
            this.buttonTimKiem.Size = new System.Drawing.Size(113, 39);
            this.buttonTimKiem.TabIndex = 48;
            this.buttonTimKiem.Text = "Tìm kiếm";
            this.buttonTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonTimKiem.UseVisualStyleBackColor = false;
            this.buttonTimKiem.Click += new System.EventHandler(this.buttonTimKiem_Click);
            // 
            // ButtonTruyVan
            // 
            this.ButtonTruyVan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ButtonTruyVan.AutoSize = true;
            this.ButtonTruyVan.BackColor = System.Drawing.Color.MistyRose;
            this.ButtonTruyVan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonTruyVan.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonTruyVan.ForeColor = System.Drawing.Color.Black;
            this.ButtonTruyVan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonTruyVan.Location = new System.Drawing.Point(625, 22);
            this.ButtonTruyVan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonTruyVan.Name = "ButtonTruyVan";
            this.ButtonTruyVan.Size = new System.Drawing.Size(88, 33);
            this.ButtonTruyVan.TabIndex = 57;
            this.ButtonTruyVan.Text = "Truy vấn";
            this.ButtonTruyVan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonTruyVan.UseVisualStyleBackColor = false;
            this.ButtonTruyVan.Click += new System.EventHandler(this.ButtonTruyVan_Click);
            // 
            // textBoxTimKiem
            // 
            this.textBoxTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTimKiem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxTimKiem.ForeColor = System.Drawing.Color.Gray;
            this.textBoxTimKiem.Location = new System.Drawing.Point(1121, 28);
            this.textBoxTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxTimKiem.Name = "textBoxTimKiem";
            this.textBoxTimKiem.Size = new System.Drawing.Size(144, 27);
            this.textBoxTimKiem.TabIndex = 47;
            this.textBoxTimKiem.Text = "Nhập mã nhân viên";
            this.textBoxTimKiem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxTimKiem.Enter += new System.EventHandler(this.textBoxTimKiem_Enter);
            this.textBoxTimKiem.Leave += new System.EventHandler(this.textBoxTimKiem_Leave);
            // 
            // dateTimeDenNgay
            // 
            this.dateTimeDenNgay.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateTimeDenNgay.CustomFormat = "dd/MM/yyyy";
            this.dateTimeDenNgay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dateTimeDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeDenNgay.Location = new System.Drawing.Point(485, 25);
            this.dateTimeDenNgay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimeDenNgay.Name = "dateTimeDenNgay";
            this.dateTimeDenNgay.Size = new System.Drawing.Size(115, 27);
            this.dateTimeDenNgay.TabIndex = 56;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(390, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 23);
            this.label1.TabIndex = 55;
            this.label1.Text = "Đến ngày:";
            // 
            // dateTimeTuNgay
            // 
            this.dateTimeTuNgay.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateTimeTuNgay.CustomFormat = "dd/MM/yyyy";
            this.dateTimeTuNgay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dateTimeTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeTuNgay.Location = new System.Drawing.Point(259, 24);
            this.dateTimeTuNgay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimeTuNgay.Name = "dateTimeTuNgay";
            this.dateTimeTuNgay.Size = new System.Drawing.Size(115, 27);
            this.dateTimeTuNgay.TabIndex = 54;
            this.dateTimeTuNgay.Value = new System.DateTime(2025, 9, 6, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(178, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 23);
            this.label2.TabIndex = 45;
            this.label2.Text = "Từ ngày:";
            // 
            // dataGridViewBangCong
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dataGridViewBangCong.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewBangCong.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewBangCong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBangCong.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewBangCong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewBangCong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewBangCong.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewBangCong.Location = new System.Drawing.Point(12, 87);
            this.dataGridViewBangCong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewBangCong.Name = "dataGridViewBangCong";
            this.dataGridViewBangCong.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewBangCong.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewBangCong.RowHeadersWidth = 51;
            this.dataGridViewBangCong.RowTemplate.Height = 24;
            this.dataGridViewBangCong.Size = new System.Drawing.Size(1372, 498);
            this.dataGridViewBangCong.TabIndex = 50;
            // 
            // buttonXuat
            // 
            this.buttonXuat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonXuat.AutoSize = true;
            this.buttonXuat.BackColor = System.Drawing.Color.MistyRose;
            this.buttonXuat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonXuat.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonXuat.ForeColor = System.Drawing.Color.Black;
            this.buttonXuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonXuat.Location = new System.Drawing.Point(1284, 590);
            this.buttonXuat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonXuat.Name = "buttonXuat";
            this.buttonXuat.Size = new System.Drawing.Size(102, 33);
            this.buttonXuat.TabIndex = 58;
            this.buttonXuat.Text = "Xuất excel";
            this.buttonXuat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonXuat.UseVisualStyleBackColor = false;
            this.buttonXuat.Click += new System.EventHandler(this.buttonXuat_Click);
            // 
            // FormLuongNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1396, 674);
            this.ControlBox = false;
            this.Controls.Add(this.buttonXuat);
            this.Controls.Add(this.dataGridViewBangCong);
            this.Controls.Add(this.GroupBoxTruyVan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormLuongNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormLuongNhanVien";
            this.GroupBoxTruyVan.ResumeLayout(false);
            this.GroupBoxTruyVan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBangCong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBoxTruyVan;
        private System.Windows.Forms.Button buttonTimKiem;
        private System.Windows.Forms.Button ButtonTruyVan;
        private System.Windows.Forms.TextBox textBoxTimKiem;
        private System.Windows.Forms.DateTimePicker dateTimeDenNgay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimeTuNgay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewBangCong;
        private System.Windows.Forms.Button buttonXuat;
    }
}