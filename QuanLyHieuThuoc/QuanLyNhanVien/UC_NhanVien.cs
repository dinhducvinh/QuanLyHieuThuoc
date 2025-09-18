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
    public partial class UC_NhanVien: UserControl
    {
        string nguon = "Data Source=vinh;Initial Catalog=QuanLyHieuThuoc;Integrated Security=True;";
        public UC_NhanVien()
        {
            InitializeComponent();
            loadNhanVien();
        }
        void loadNhanVien()
        {
            SqlConnection conn = new SqlConnection(nguon);
            conn.Open();
            SqlDataAdapter xem = new SqlDataAdapter("select * from NhanVien", conn);
            DataTable dt = new DataTable();
            xem.Fill(dt);
            dataGridViewNhanVien.DataSource = dt;
            conn.Close();
            dataGridViewNhanVien.Columns["MaNhanVien"].HeaderText = "Mã nhân viên";
            dataGridViewNhanVien.Columns["Ho"].HeaderText = "Họ";
            dataGridViewNhanVien.Columns["Ten"].HeaderText = "Tên";
            dataGridViewNhanVien.Columns["GioiTinh"].HeaderText = "Giới tính";
            dataGridViewNhanVien.Columns["DiaChi"].HeaderText = "Địa chỉ";
            dataGridViewNhanVien.Columns["Email"].HeaderText = "Email";
            dataGridViewNhanVien.Columns["SoDienThoai"].HeaderText = "Số điện thoại";
            dataGridViewNhanVien.Columns["Luong1H"].HeaderText = "Lương 1 giờ";
            dataGridViewNhanVien.Columns["VaiTro"].HeaderText = "Vai trò";
            dataGridViewNhanVien.Columns["NgaySinh"].HeaderText = "Ngày Sinh";
            dataGridViewNhanVien.Columns["NgayTuyenDung"].HeaderText = "Ngày tuyển dụng";
            dataGridViewNhanVien.Columns["GhiChu"].HeaderText = "Ghi chú";
        }

    

        private void textBoxTimKiem_Enter(object sender, EventArgs e)
        {
            if (textBoxTimKiem.Text == "Nhập tên nhân viên để tìm")
            {
                textBoxTimKiem.Text = "";
                textBoxTimKiem.ForeColor = Color.Gray;
            }
        }

        private void textBoxTimKiem_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxTimKiem.Text))
            {
                textBoxTimKiem.Text = "Nhập tên nhân viên để tìm";
                textBoxTimKiem.ForeColor = Color.Gray;
            }
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
          
            try
            {
                using (SqlConnection conn = new SqlConnection(nguon))
                {
                    conn.Open();
                    string insert = "Insert into NhanVien(MaNhanVien,Ho,Ten,GioiTinh,DiaChi,Email,SoDienThoai,Luong1H,VaiTro,NgaySinh,GhiChu) values(@MaNhanVien,@Ho,@Ten,@GioiTinh,@DiaChi,@Email,@SoDienThoai,@Luong1H,@VaiTro,@NgaySinh,@GhiChu)";
                    SqlCommand cmd = new SqlCommand(insert, conn);
                    cmd.Parameters.AddWithValue("@MaNhanVien", textBoxMaNv.Text);
                    cmd.Parameters.AddWithValue("@Ho", textBoxHo.Text);
                    cmd.Parameters.AddWithValue("@Ten", textBoxTen.Text);
                    cmd.Parameters.AddWithValue("@GioiTinh", comboBoxGioiTinh.SelectedItem?.ToString());
                    cmd.Parameters.AddWithValue("@DiaChi", textBoxDiaChi.Text);
                    cmd.Parameters.AddWithValue("@Email", textBoxEmail.Text);
                    cmd.Parameters.AddWithValue("@SoDienThoai", maskedTextBoxSDT.Text);
                    cmd.Parameters.AddWithValue("@Luong1H", maskedTextBoxLuong.Text);
                    cmd.Parameters.AddWithValue("@VaiTro", comboBoxVaiTro.SelectedItem?.ToString());
                    cmd.Parameters.AddWithValue("@NgaySinh", dateTimeNgaySinh.Value);
                    cmd.Parameters.AddWithValue("@GhiChu", richTextBoxGhiChu.Text);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Thêm mới thành công");
                    loadNhanVien();
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

        private void maskedTextBoxLuong_Click(object sender, EventArgs e)
        {
            maskedTextBoxLuong.SelectionStart = maskedTextBoxLuong.Text.Length;
        }

        private void dataGridViewNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            try
            {
                DataGridViewRow row = dataGridViewNhanVien.Rows[e.RowIndex];
                textBoxMaNv.Text = row.Cells["MaNhanVien"].Value.ToString();
                textBoxHo.Text = row.Cells["Ho"].Value.ToString();
                textBoxTen.Text = row.Cells["Ten"].Value.ToString();
                comboBoxGioiTinh.Text = row.Cells["GioiTinh"].Value.ToString();
                textBoxDiaChi.Text = row.Cells["DiaChi"].Value.ToString();
                textBoxEmail.Text = row.Cells["Email"].Value.ToString();
                maskedTextBoxSDT.Text = row.Cells["SoDienThoai"].Value.ToString();
                maskedTextBoxLuong.Text = row.Cells["Luong1H"].Value.ToString();
                if (row.Cells["VaiTro"].Value != null)
                {
                    comboBoxVaiTro.Text = row.Cells["VaiTro"].Value.ToString();
                }
                dateTimeNgaySinh.Text = row.Cells["NgaySinh"].Value.ToString();
                richTextBoxGhiChu.Text = row.Cells["GhiChu"].Value.ToString() ;
            }
            catch (Exception ex)
            {
                MessageBox.Show("dòng này chưa có dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(nguon))
                {
                    conn.Open();
                    string insert = "Delete from NhanVien where MaNhanVien=@MaNhanVien";
                    SqlCommand cmd = new SqlCommand(insert, conn);
                    cmd.Parameters.AddWithValue("@MaNhanVien", textBoxMaNv.Text);
                    DialogResult rs = MessageBox.Show("Bạn có chắc muốn xóa nhân viên: "+ textBoxMaNv.Text+" không", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (rs == DialogResult.Yes)
                    {
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Xóa thành công");
                        loadNhanVien();
                    }
                    else
                    {
                        loadNhanVien();
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

        private void buttonSua_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(nguon))
                {
                    conn.Open();
                    string insert = "Update NhanVien SET Ho=@Ho,Ten=@Ten,GioiTinh=@GioiTinh,DiaChi=@DiaChi,Email=@Email,SoDienThoai=@SoDienThoai,Luong1H=@Luong1H,VaiTro=@VaiTro,NgaySinh=@NgaySinh,GhiChu=@GhiChu where MaNhanVien=@MaNhanVien";
                    SqlCommand cmd = new SqlCommand(insert, conn);
                    cmd.Parameters.AddWithValue("@MaNhanVien", textBoxMaNv.Text);
                    cmd.Parameters.AddWithValue("@Ho", textBoxHo.Text);
                    cmd.Parameters.AddWithValue("@Ten", textBoxTen.Text);
                    cmd.Parameters.AddWithValue("@GioiTinh", comboBoxGioiTinh.SelectedItem?.ToString());
                    cmd.Parameters.AddWithValue("@DiaChi", textBoxDiaChi.Text);
                    cmd.Parameters.AddWithValue("@Email", textBoxEmail.Text);
                    cmd.Parameters.AddWithValue("@SoDienThoai", maskedTextBoxSDT.Text);
                    cmd.Parameters.AddWithValue("@Luong1H", maskedTextBoxLuong.Text);
                    cmd.Parameters.AddWithValue("@VaiTro", comboBoxVaiTro.SelectedItem?.ToString());
                    cmd.Parameters.AddWithValue("@NgaySinh", dateTimeNgaySinh.Value);
                    cmd.Parameters.AddWithValue("@GhiChu", richTextBoxGhiChu.Text);
                    DialogResult rs = MessageBox.Show("Bạn có chắc muốn sửa nhân viên: " + textBoxMaNv.Text + " không", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (rs == DialogResult.Yes)
                    {
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Sửa thành công");
                        loadNhanVien();
                    }
                    else
                    {
                        loadNhanVien();
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

        private void buttonTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(nguon))
                {
                    if (textBoxTimKiem.Text == "Nhập tên nhân viên để tìm")
                    {
                        MessageBox.Show("Vui lòng nhập tên nhân viên !", "Thông Báo");
                    }
                    else
                    {
                        conn.Open();
                        SqlDataAdapter laydulieu = new SqlDataAdapter("SELECT * from NhanVien where Ten like N'%' + @TenNhanVien + N'%'", conn);
                        laydulieu.SelectCommand.Parameters.AddWithValue("@TenNhanVien", textBoxTimKiem.Text);
                        DataTable dt = new DataTable();
                        laydulieu.Fill(dt);
                        if (dt.Rows.Count > 0)
                        {
                            dataGridViewNhanVien.DataSource = dt;
                            conn.Close();
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy nhân viên", "Thông Báo");
                        }
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

        private void buttonTaiLai_Click(object sender, EventArgs e)
        {
            loadNhanVien();
        }

        private void maskedTextBoxSDT_Click(object sender, EventArgs e)
        {
            maskedTextBoxSDT.SelectionStart = maskedTextBoxSDT.Text.Length;
        }
        private void Xuat_Excel()
        {
            Microsoft.Office.Interop.Excel.Application XcelApp = new Microsoft.Office.Interop.Excel.Application();
            XcelApp.Application.Workbooks.Add(Type.Missing);


            for (int i = 1; i < dataGridViewNhanVien.Columns.Count + 1; i++)
            {
                XcelApp.Cells[1, i] = dataGridViewNhanVien.Columns[i - 1].HeaderText;
            }

            for (int i = 0; i < dataGridViewNhanVien.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridViewNhanVien.Columns.Count; j++)
                {

                    XcelApp.Cells[i + 2, j + 1] = dataGridViewNhanVien.Rows[i].Cells[j].Value?.ToString() ?? "";
                }
            }

            Microsoft.Office.Interop.Excel.Range headerRange = XcelApp.Range[XcelApp.Cells[1, 1], XcelApp.Cells[1, dataGridViewNhanVien.Columns.Count]];
            headerRange.Font.Bold = true; // In đậm tiêu đề
            headerRange.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightGray); // Màu nền xám nhạt

            int lastRow = dataGridViewNhanVien.Rows.Count + 1; // Bao gồm cả hàng tiêu đề
            int lastColumn = dataGridViewNhanVien.Columns.Count;
            Microsoft.Office.Interop.Excel.Range range = XcelApp.Range[XcelApp.Cells[1, 1], XcelApp.Cells[lastRow, lastColumn]];

            range.Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous; // Đường viền liền
            range.Borders.Weight = Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin; // Độ dày mỏng

            XcelApp.Columns.AutoFit();
            XcelApp.Visible = true;
        }

        private void buttonXuat_Click(object sender, EventArgs e)
        {
            Xuat_Excel();
        }
    }
}
