using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHieuThuoc
{
    public partial class FormDangNhap: Form
    {
        public string TenTaiKhoan => textUsername.Text;
        bool trangthainutthoat = false;
        string nguon = NguonData.nguon;
        public FormDangNhap()
        {
            InitializeComponent();
        }
        private void buttonDangNhap_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(nguon);
                conn.Open();
                SqlDataAdapter xem = new SqlDataAdapter("SELECT TaiKhoan, MatKhau FROM DangNhap", conn);
                    DataTable dt = new DataTable();
                    xem.Fill(dt);
                    bool trangthaidangnhap = false;
                    foreach (DataRow row in dt.Rows)
                    {
                        string TK = row["TaiKhoan"].ToString().Trim();
                        string matKhau = row["MatKhau"].ToString().Trim();
                        if (textUsername.Text == TK && textPassword.Text == matKhau)
                        {
                            trangthaidangnhap = true;
                            break;
                        }
                    }
                    if (trangthaidangnhap)
                    {
                        this.DialogResult= DialogResult.OK;
                        this.Close();
                        MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác","Đăng nhập thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    conn.Close();

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

        private void clickquenmk(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Vui lòng liên hệ quản lý để lấy lại mật khẩu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            trangthainutthoat = true;
        }

         private void FormDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (trangthainutthoat || this.DialogResult != DialogResult.OK && e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult rs = MessageBox.Show(
                    "Bạn có chắc muốn thoát không?",
                    "Thông Báo",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (rs == DialogResult.No)
                {
                    e.Cancel = true; // Không cho phép đóng form
                }
                else
                {
                    trangthainutthoat = false;
                    Application.Exit(); // Thoát chương trình nếu chọn Yes
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textPassword.PasswordChar = checkBox1.Checked ? '\0' : '*';
        }
    }
}
