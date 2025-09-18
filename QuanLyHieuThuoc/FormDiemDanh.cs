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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace QuanLyHieuThuoc
{
    public partial class FormDiemDanh: Form
    {
        string nguon = NguonData.nguon;
        public FormDiemDanh()
        {
            InitializeComponent();
            textBoxMaNv.Text = TaiKhoanDongBo.TenTaiKhoan;
            loadDiemDanh();
            checkDiemDanhVao();
            checkDiemDanhVe();
        }
       void loadDiemDanh()
        {
            SqlConnection conn = new SqlConnection(nguon);
            conn.Open();
            SqlDataAdapter xem = new SqlDataAdapter("SELECT * FROM ChamCong WHERE YEAR(NgayLam) = YEAR(@NgayDiemDanh) " +
                "AND MONTH(NgayLam) = MONTH(@NgayDiemDanh) AND MaNhanVien=@MaNhanVien", conn);
            xem.SelectCommand.Parameters.AddWithValue("@NgayDiemDanh", dateDiemDanh.Value);
            xem.SelectCommand.Parameters.AddWithValue("@MaNhanVien", textBoxMaNv.Text);
            DataTable dt = new DataTable();
            xem.Fill(dt);
            dataGridViewDiemDanh.DataSource = dt;
            conn.Close();
            dataGridViewDiemDanh.Columns["MaNhanVien"].HeaderText = "Mã nhân viên";
            dataGridViewDiemDanh.Columns["NgayLam"].HeaderText = "Thời gian";
            dataGridViewDiemDanh.Columns["GioVao"].HeaderText = "Giờ vào làm việc";
            dataGridViewDiemDanh.Columns["GioVe"].HeaderText = "Giờ về";
            dataGridViewDiemDanh.Columns["SoGioLam"].HeaderText = "Số tiếng làm việc";
            dataGridViewDiemDanh.Columns["GhiChu"].HeaderText = "Ghi chú";
        }
        void checkDiemDanhVao()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(nguon))
                {
                    conn.Open();
                    string checkQuery = "SELECT COUNT(*) FROM ChamCong WHERE MaNhanVien = @MaNhanVien AND CONVERT(date, NgayLam) = CONVERT(date, GETDATE())";
                    SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                    checkCmd.Parameters.AddWithValue("@MaNhanVien", textBoxMaNv.Text);
                    int count = (int)checkCmd.ExecuteScalar();

                    if (count > 0)
                    {
                        buttonDiemDanhVao.Enabled = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void checkDiemDanhVe()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(nguon))
                {
                    conn.Open();
                    string checkQuery = "SELECT COUNT(*) FROM ChamCong " +
                                        "WHERE MaNhanVien = @MaNhanVien AND CONVERT(date, NgayLam) = CONVERT(date, GETDATE()) AND GioVe IS NOT NULL";
                    SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                    checkCmd.Parameters.AddWithValue("@MaNhanVien", textBoxMaNv.Text);
                    int count = (int)checkCmd.ExecuteScalar();

                    if (count > 0)
                    {
                        buttonDiemDanhVe.Enabled = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonDiemDanhVao_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(nguon))
                {
                    conn.Open();
                        string insert = "INSERT INTO ChamCong (MaNhanVien, NgayLam, GioVao, GhiChu) VALUES (@MaNhanVien, GETDATE(), CAST(GETDATE() AS TIME), @GhiChu)";
                        SqlCommand cmd = new SqlCommand(insert, conn);
                        cmd.Parameters.AddWithValue("@MaNhanVien", textBoxMaNv.Text);
                        cmd.Parameters.AddWithValue("@GhiChu", richTextBoxGhiChu.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Điểm danh đầu giờ thành công");
                        loadDiemDanh();
                    checkDiemDanhVao();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDiemDanhVe_Click(object sender, EventArgs e)
        {
         try
            {
                using (SqlConnection conn = new SqlConnection(nguon))
                {
                    conn.Open();
                    string insert = "UPDATE ChamCong SET GioVe = CAST(GETDATE() AS TIME),SoGioLam = DATEDIFF(MINUTE, GioVao, CAST(GETDATE() AS TIME)) / 60.0,GhiChu=@GhiCHu " +
                                     "WHERE MaNhanVien = @MaNhanVien AND CONVERT(date, NgayLam) = CONVERT(date, GETDATE())";
                    SqlCommand cmd = new SqlCommand(insert, conn);
                    cmd.Parameters.AddWithValue("@MaNhanVien", textBoxMaNv.Text);
                    cmd.Parameters.AddWithValue("@GhiChu", richTextBoxGhiChu.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Điểm danh về thành công");
                    loadDiemDanh();
                    checkDiemDanhVe();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonTaiLai_Click(object sender, EventArgs e)
        {
            loadDiemDanh();
        }
    }
}
