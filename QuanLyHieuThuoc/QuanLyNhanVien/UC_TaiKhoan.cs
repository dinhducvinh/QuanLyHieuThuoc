using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLyHieuThuoc.QuanLyNhanVien
{
    public partial class UC_TaiKhoan : UserControl
    {
        private DataGridView dataGridViewTaiKhoan;
        private object richTextBoxGhiChu;
        private Panel panel1;
        private RichTextBox richTextBoxNote;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel2;
        private System.Windows.Forms.Button buttonXoa;
        private System.Windows.Forms.Button buttonSua;
        private System.Windows.Forms.Button buttonTao;
        private System.Windows.Forms.TextBox textPassword;
        private PictureBox pictureBox3;
        private Label label3;
        private System.Windows.Forms.TextBox textUsername;
        private PictureBox pictureBox2;
        private Label label2;
        string nguon = "Data Source=vinh;Initial Catalog=QuanLyHieuThuoc;Integrated Security=True;";

        public UC_TaiKhoan()
        {
            InitializeComponent();
            loadTaiKhoan();
        }
        void loadTaiKhoan()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(nguon))
                {
                    conn.Open();
                    SqlDataAdapter xem = new SqlDataAdapter("select * from DangNhap", conn);
                    DataTable dt = new DataTable();
                    xem.Fill(dt);
                    dataGridViewTaiKhoan.DataSource = dt;
                    conn.Close();
                    dataGridViewTaiKhoan.Columns["TaiKhoan"].HeaderText = "Tài khoản";
                    dataGridViewTaiKhoan.Columns["MatKhau"].HeaderText = "Mật khẩu";
                    dataGridViewTaiKhoan.Columns["GhiChu"].HeaderText = "Ghi chú";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Lỗi: {ex.Message}",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewTaiKhoan = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.richTextBoxNote = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.buttonSua = new System.Windows.Forms.Button();
            this.buttonTao = new System.Windows.Forms.Button();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textUsername = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTaiKhoan)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTaiKhoan
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dataGridViewTaiKhoan.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTaiKhoan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewTaiKhoan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTaiKhoan.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTaiKhoan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTaiKhoan.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTaiKhoan.Location = new System.Drawing.Point(16, 256);
            this.dataGridViewTaiKhoan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewTaiKhoan.Name = "dataGridViewTaiKhoan";
            this.dataGridViewTaiKhoan.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTaiKhoan.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewTaiKhoan.RowHeadersWidth = 51;
            this.dataGridViewTaiKhoan.RowTemplate.Height = 24;
            this.dataGridViewTaiKhoan.Size = new System.Drawing.Size(998, 393);
            this.dataGridViewTaiKhoan.TabIndex = 39;
            this.dataGridViewTaiKhoan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTaiKhoan_CellClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.richTextBoxNote);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.buttonXoa);
            this.panel1.Controls.Add(this.buttonSua);
            this.panel1.Controls.Add(this.buttonTao);
            this.panel1.Controls.Add(this.textPassword);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textUsername);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1100, 247);
            this.panel1.TabIndex = 40;
            // 
            // richTextBoxNote
            // 
            this.richTextBoxNote.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.richTextBoxNote.Location = new System.Drawing.Point(47, 183);
            this.richTextBoxNote.Name = "richTextBoxNote";
            this.richTextBoxNote.Size = new System.Drawing.Size(442, 40);
            this.richTextBoxNote.TabIndex = 56;
            this.richTextBoxNote.Text = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::QuanLyHieuThuoc.Properties.Resources.icons8_pencil_drawing_50;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(47, 143);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 34);
            this.pictureBox1.TabIndex = 55;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(83, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 23);
            this.label1.TabIndex = 54;
            this.label1.Text = "Note";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.LightBlue;
            this.panel2.Location = new System.Drawing.Point(47, 229);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(998, 10);
            this.panel2.TabIndex = 53;
            // 
            // buttonXoa
            // 
            this.buttonXoa.AutoSize = true;
            this.buttonXoa.BackColor = System.Drawing.Color.LightCyan;
            this.buttonXoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonXoa.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonXoa.ForeColor = System.Drawing.Color.Black;
            this.buttonXoa.Image = global::QuanLyHieuThuoc.Properties.Resources.icons8_trash_50;
            this.buttonXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonXoa.Location = new System.Drawing.Point(926, 96);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(115, 56);
            this.buttonXoa.TabIndex = 52;
            this.buttonXoa.Text = "Xóa";
            this.buttonXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonXoa.UseVisualStyleBackColor = false;
            this.buttonXoa.Click += new System.EventHandler(this.buttonXoa_Click);
            // 
            // buttonSua
            // 
            this.buttonSua.AutoSize = true;
            this.buttonSua.BackColor = System.Drawing.Color.LightCyan;
            this.buttonSua.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSua.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSua.ForeColor = System.Drawing.Color.Black;
            this.buttonSua.Image = global::QuanLyHieuThuoc.Properties.Resources.icons8_edit_pencil_501;
            this.buttonSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSua.Location = new System.Drawing.Point(786, 96);
            this.buttonSua.Name = "buttonSua";
            this.buttonSua.Size = new System.Drawing.Size(115, 56);
            this.buttonSua.TabIndex = 51;
            this.buttonSua.Text = "Sửa";
            this.buttonSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSua.UseVisualStyleBackColor = false;
            this.buttonSua.Click += new System.EventHandler(this.buttonSua_Click);
            // 
            // buttonTao
            // 
            this.buttonTao.AutoSize = true;
            this.buttonTao.BackColor = System.Drawing.Color.LightCyan;
            this.buttonTao.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonTao.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTao.ForeColor = System.Drawing.Color.Black;
            this.buttonTao.Image = global::QuanLyHieuThuoc.Properties.Resources.icons8_add_50;
            this.buttonTao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTao.Location = new System.Drawing.Point(561, 96);
            this.buttonTao.Name = "buttonTao";
            this.buttonTao.Size = new System.Drawing.Size(179, 56);
            this.buttonTao.TabIndex = 50;
            this.buttonTao.Text = "Tạo tài khoản";
            this.buttonTao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonTao.UseVisualStyleBackColor = false;
            this.buttonTao.Click += new System.EventHandler(this.buttonTao_Click);
            // 
            // textPassword
            // 
            this.textPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textPassword.Location = new System.Drawing.Point(47, 115);
            this.textPassword.Name = "textPassword";
            this.textPassword.Size = new System.Drawing.Size(442, 27);
            this.textPassword.TabIndex = 45;
            this.textPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::QuanLyHieuThuoc.Properties.Resources.password_22;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(47, 75);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(34, 34);
            this.pictureBox3.TabIndex = 49;
            this.pictureBox3.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(83, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 23);
            this.label3.TabIndex = 48;
            this.label3.Text = "Password";
            // 
            // textUsername
            // 
            this.textUsername.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textUsername.ForeColor = System.Drawing.Color.Gray;
            this.textUsername.Location = new System.Drawing.Point(47, 46);
            this.textUsername.Name = "textUsername";
            this.textUsername.Size = new System.Drawing.Size(442, 27);
            this.textUsername.TabIndex = 44;
            this.textUsername.Text = "Nhập mã nhân viên để tạo tài khoản !";
            this.textUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textUsername.Enter += new System.EventHandler(this.textUsername_Enter);
            this.textUsername.Leave += new System.EventHandler(this.textUsername_Leave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::QuanLyHieuThuoc.Properties.Resources.user;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(47, 7);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(34, 34);
            this.pictureBox2.TabIndex = 47;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(84, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 23);
            this.label2.TabIndex = 46;
            this.label2.Text = "Username";
            // 
            // UC_TaiKhoan
            // 
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewTaiKhoan);
            this.Name = "UC_TaiKhoan";
            this.Size = new System.Drawing.Size(1100, 666);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTaiKhoan)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        private void textUsername_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textUsername.Text))
            {
                textUsername.Text = "Nhập mã nhân viên để tạo tài khoản !";
                textUsername.ForeColor = Color.Gray;
            }
        }

        private void textUsername_Enter(object sender, EventArgs e)
        {
            if (textUsername.Text == "Nhập mã nhân viên để tạo tài khoản !")
            {
                textUsername.Text = "";
                textUsername.ForeColor = Color.Black;
            }
        }

        private void buttonTao_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(nguon))
                {
                    conn.Open();
                    string kiemtra = "SELECT COUNT(*) FROM NhanVien WHERE MaNhanVien = @TaiKhoan";
                    SqlCommand checkCmd = new SqlCommand(kiemtra, conn);
                    checkCmd.Parameters.AddWithValue("@TaiKhoan", textUsername.Text);
                    int count=(int)checkCmd.ExecuteScalar();

                    if (count == 0)
                    {
                        MessageBox.Show("Chưa có nhân viên này,chỉ cho phép tạo tài khoản bằng mã nhân viên", "Thông Báo");
                    }
                    else
                    {
                        string insert = "Insert into DangNhap(TaiKhoan,MatKhau,GhiChu) values(@TaiKhoan,@MatKhau,@GhiChu)";
                        SqlCommand cmd = new SqlCommand(insert, conn);
                        cmd.Parameters.AddWithValue("@TaiKhoan", textUsername.Text);
                        cmd.Parameters.AddWithValue("@MatKhau", textPassword.Text);
                        cmd.Parameters.AddWithValue("@GhiChu", richTextBoxNote.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Thêm mới thành công");
                        loadTaiKhoan();
                    }

                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Lỗi: {ex.Message}",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSua_Click(object sender, EventArgs e)
        { try
            { 
            using (SqlConnection conn = new SqlConnection(nguon))
            {
                conn.Open();
                string insert = "Update DangNhap set MatKhau=@MatKhau,GhiChu=@GhiChu where TaiKhoan=@TaiKhoan";
                SqlCommand cmd = new SqlCommand(insert, conn);
                cmd.Parameters.AddWithValue("@TaiKhoan", textUsername.Text);
                cmd.Parameters.AddWithValue("@MatKhau", textPassword.Text);
                cmd.Parameters.AddWithValue("@GhiChu", richTextBoxNote.Text);
                DialogResult rs = MessageBox.Show("Bạn có chắc muốn sửa mật khẩu tài khoản: " + textUsername.Text + " không", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Sửa thành công");
                    loadTaiKhoan();
                }
                else
                {
                    loadTaiKhoan();
                }
            }
        }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Lỗi: {ex.Message}",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
}

        private void dataGridViewTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            try
            {
                DataGridViewRow row = dataGridViewTaiKhoan.Rows[e.RowIndex];
                textUsername.Text = row.Cells["TaiKhoan"].Value.ToString();
                textPassword.Text = row.Cells["MatKhau"].Value.ToString();
                richTextBoxNote.Text = row.Cells["GhiChu"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: dòng này không có dữ liệu nào cả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(nguon))
                {
                    conn.Open();
                    string insert = "Delete from DangNhap where TaiKhoan=@TaiKhoan";
                    SqlCommand cmd = new SqlCommand(insert, conn);
                    cmd.Parameters.AddWithValue("@TaiKhoan", textUsername.Text);
                    DialogResult rs = MessageBox.Show("Bạn có chắc muốn xóa tài khoản: " + textUsername.Text + " không", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (rs == DialogResult.Yes)
                    {
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Đã xóa!");
                        loadTaiKhoan();
                    }
                    else
                    {
                        loadTaiKhoan();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Lỗi: {ex.Message}",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
