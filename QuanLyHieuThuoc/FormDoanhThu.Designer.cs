namespace QuanLyHieuThuoc
{
    partial class FormDoanhThu
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
            this.GroupBoxTruyVan = new System.Windows.Forms.GroupBox();
            this.ButtonTruyVan = new System.Windows.Forms.Button();
            this.dateTimeDenNgay = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimeTuNgay = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.GroupBoxTruyVan.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBoxTruyVan
            // 
            this.GroupBoxTruyVan.BackColor = System.Drawing.SystemColors.Control;
            this.GroupBoxTruyVan.Controls.Add(this.ButtonTruyVan);
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
            this.GroupBoxTruyVan.Text = "Truy vấn hóa đơn";
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
            this.ButtonTruyVan.Location = new System.Drawing.Point(882, 21);
            this.ButtonTruyVan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonTruyVan.Name = "ButtonTruyVan";
            this.ButtonTruyVan.Size = new System.Drawing.Size(88, 33);
            this.ButtonTruyVan.TabIndex = 57;
            this.ButtonTruyVan.Text = "Truy vấn";
            this.ButtonTruyVan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonTruyVan.UseVisualStyleBackColor = false;
            this.ButtonTruyVan.Click += new System.EventHandler(this.ButtonTruyVan_Click);
            // 
            // dateTimeDenNgay
            // 
            this.dateTimeDenNgay.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateTimeDenNgay.CustomFormat = "dd/MM/yyyy";
            this.dateTimeDenNgay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dateTimeDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeDenNgay.Location = new System.Drawing.Point(742, 24);
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
            this.label1.Location = new System.Drawing.Point(647, 27);
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
            this.dateTimeTuNgay.Location = new System.Drawing.Point(516, 23);
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
            this.label2.Location = new System.Drawing.Point(435, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 23);
            this.label2.TabIndex = 45;
            this.label2.Text = "Từ ngày:";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyHieuThuoc.ReporDoanhThu.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 69);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1396, 605);
            this.reportViewer1.TabIndex = 50;
            // 
            // FormDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1396, 674);
            this.ControlBox = false;
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.GroupBoxTruyVan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormDoanhThu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Doanh thu";
            this.Load += new System.EventHandler(this.FormDoanhThu_Load);
            this.GroupBoxTruyVan.ResumeLayout(false);
            this.GroupBoxTruyVan.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBoxTruyVan;
        private System.Windows.Forms.Button ButtonTruyVan;
        private System.Windows.Forms.DateTimePicker dateTimeDenNgay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimeTuNgay;
        private System.Windows.Forms.Label label2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}