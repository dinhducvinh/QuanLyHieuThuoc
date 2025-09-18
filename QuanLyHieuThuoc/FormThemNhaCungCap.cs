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

namespace QuanLyHieuThuoc
{
    public partial class FormThemNhaCungCap: Form
    {
        string nguon = "Data Source=vinh;Initial Catalog=QuanLyHieuThuoc;Integrated Security=True;";
        public FormThemNhaCungCap()
        {
            InitializeComponent();
            loadNhaCungCap();
        }
         void loadNhaCungCap()
        {  SqlConnection conn= new SqlConnection(nguon);
            string sql = "select * from NhaCungCap";
            conn.Open();
            SqlDataAdapter xem=new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            xem.Fill(dt);
            dataGridViewNhaCungCap.DataSource = dt;
            conn.Close();
            dataGridViewNhaCungCap.Columns["MaNhaCungCap"].HeaderText = "Mã nhà cung cấp";
            dataGridViewNhaCungCap.Columns["TenNhaCungCap"].HeaderText = "Tên nhà cung cấp";
            dataGridViewNhaCungCap.Columns["NguoiLienHe"].HeaderText = "Người liên hệ";
            dataGridViewNhaCungCap.Columns["SoDienThoai"].HeaderText = "Số điện thoại";
            dataGridViewNhaCungCap.Columns["DiaChi"].HeaderText = "Địa chỉ";
            dataGridViewNhaCungCap.Columns["NgayTao"].HeaderText = "Ngày tạo";
            dataGridViewNhaCungCap.Columns["GhiChu"].HeaderText = "Ghi chú";
        }

        private void textBoxTimKiem_Enter(object sender, EventArgs e)
        {
            if (textBoxTimKiem.Text == "Nhập tên nhà cung cấp để tìm")
            {
                textBoxTimKiem.Text = "";
                textBoxTimKiem.ForeColor = Color.Gray;
            }
        }

        private void textBoxTimKiem_Leave(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(textBoxTimKiem.Text))
            {
                textBoxTimKiem.Text = "Nhập tên nhà cung cấp để tìm";
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
                    String sql= "insert into NhaCungCap (MaNhaCungCap, TenNhaCungCap, NguoiLienHe, SoDienThoai,Email, DiaChi, NgayTao, GhiChu) values (@MaNhaCungCap, @TenNhaCungCap, @NguoiLienHe, @SoDienThoai,@Email, @DiaChi, GETDATE(), @GhiChu)";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@MaNhaCungCap", textBoxMaNhaCungCap.Text);
                    cmd.Parameters.AddWithValue("@TenNhaCungCap", textBoxTenNhaCC.Text);
                    cmd.Parameters.AddWithValue("@NguoiLienHe", textBoxNguoiLH.Text);
                    cmd.Parameters.AddWithValue("@SoDienThoai", maskedTextBoxSDT.Text);
                    cmd.Parameters.AddWithValue("@Email", textBoxEmail.Text);
                    cmd.Parameters.AddWithValue("@DiaChi", textBoxDiaChi.Text);
                    cmd.Parameters.AddWithValue("@GhiChu", richTextBoxGhiChu.Text);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Thêm nhà cung cấp thành công!");
                    loadNhaCungCap();
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
                    string update = "Update NhaCungCap SET TenNhaCungCap=@TenNhaCungCap,NguoiLienHe=@NguoiLienHe,SoDienThoai=@SoDienThoai,Email=@Email,DiaChi=@DiaChi,GhiChu=@GhiChu where MaNhaCungCap=@MaNhaCungCap";
                    SqlCommand cmd = new SqlCommand(update, conn);
                    cmd.Parameters.AddWithValue("@MaNhaCungCap", textBoxMaNhaCungCap.Text);
                    cmd.Parameters.AddWithValue("@TenNhaCungCap", textBoxTenNhaCC.Text);
                    cmd.Parameters.AddWithValue("@NguoiLienHe", textBoxNguoiLH.Text);
                    cmd.Parameters.AddWithValue("@SoDienThoai", maskedTextBoxSDT.Text);
                    cmd.Parameters.AddWithValue("@Email", textBoxEmail.Text);
                    cmd.Parameters.AddWithValue("@DiaChi", textBoxDiaChi.Text);
                    cmd.Parameters.AddWithValue("@GhiChu", richTextBoxGhiChu.Text);
                    DialogResult rs = MessageBox.Show("Bạn có chắc muốn sửa nhà cung cấp: " + textBoxMaNhaCungCap.Text + " không", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (rs == DialogResult.Yes)
                    {
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Sửa thành công");
                        loadNhaCungCap();
                    }
                    else
                    {
                        loadNhaCungCap();
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

        private void dataGridViewNhaCungCap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            try
            {
                DataGridViewRow row = dataGridViewNhaCungCap.Rows[e.RowIndex];
                textBoxMaNhaCungCap.Text = row.Cells["MaNhaCungCap"].Value.ToString();
                textBoxTenNhaCC.Text = row.Cells["TenNhaCungCap"].Value.ToString();
                textBoxNguoiLH.Text = row.Cells["NguoiLienHe"].Value.ToString();
                maskedTextBoxSDT.Text = row.Cells["SoDienThoai"].Value.ToString();
                textBoxEmail.Text = row.Cells["Email"].Value.ToString();
                textBoxDiaChi.Text = row.Cells["DiaChi"].Value.ToString();
                richTextBoxGhiChu.Text = row.Cells["GhiChu"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dòng này không có dữ liệu nào cả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(nguon))
                {
                    if (textBoxTimKiem.Text == "Nhập tên nhà cung cấp để tìm")
                    {
                        MessageBox.Show("Vui lòng nhập tên nhà cung cấp !", "Thông Báo");
                    }
                    else
                    {
                        conn.Open();
                        SqlDataAdapter laydulieu = new SqlDataAdapter("SELECT * from NhaCungCap where TenNhaCungCap like N'%' + @TenNhaCungCap + N'%'", conn);
                        laydulieu.SelectCommand.Parameters.AddWithValue("@TenNhaCungCap", textBoxTimKiem.Text);
                        DataTable dt = new DataTable();
                        laydulieu.Fill(dt);
                        if (dt.Rows.Count > 0)
                        {
                            dataGridViewNhaCungCap.DataSource = dt;
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

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(nguon))
                {
                    conn.Open();
                    string delete = "Delete from NhaCungCap where MaNhaCungCap=@MaNhaCungCap";
                    SqlCommand cmd = new SqlCommand(delete, conn);
                    cmd.Parameters.AddWithValue("@MaNhaCungCap", textBoxMaNhaCungCap.Text);
                    DialogResult rs = MessageBox.Show("Bạn có chắc muốn xóa nhà cung cấp: " + textBoxMaNhaCungCap.Text + " không", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (rs == DialogResult.Yes)
                    {
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Xóa thành công");
                        loadNhaCungCap();
                    }
                    else
                    {
                        loadNhaCungCap();
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
            loadNhaCungCap();
        }

        private void buttonVeMDI_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Xuat_Excel()
        {
            Microsoft.Office.Interop.Excel.Application XcelApp = new Microsoft.Office.Interop.Excel.Application();
            XcelApp.Application.Workbooks.Add(Type.Missing);


            for (int i = 1; i < dataGridViewNhaCungCap.Columns.Count + 1; i++)
            {
                XcelApp.Cells[1, i] = dataGridViewNhaCungCap.Columns[i - 1].HeaderText;
            }

            for (int i = 0; i < dataGridViewNhaCungCap.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridViewNhaCungCap.Columns.Count; j++)
                {

                    XcelApp.Cells[i + 2, j + 1] = dataGridViewNhaCungCap.Rows[i].Cells[j].Value?.ToString() ?? "";
                }
            }

            Microsoft.Office.Interop.Excel.Range headerRange = XcelApp.Range[XcelApp.Cells[1, 1], XcelApp.Cells[1, dataGridViewNhaCungCap.Columns.Count]];
            headerRange.Font.Bold = true; // In đậm tiêu đề
            headerRange.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightGray); // Màu nền xám nhạt

            int lastRow = dataGridViewNhaCungCap.Rows.Count + 1;
            int lastColumn = dataGridViewNhaCungCap.Columns.Count;
            Microsoft.Office.Interop.Excel.Range range = XcelApp.Range[XcelApp.Cells[1, 1], XcelApp.Cells[lastRow, lastColumn]];

            // Định dạng border
            range.Borders[Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeTop].LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
            range.Borders[Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeBottom].LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
            range.Borders[Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeLeft].LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
            range.Borders[Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeRight].LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
            range.Borders[Microsoft.Office.Interop.Excel.XlBordersIndex.xlInsideHorizontal].LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
            range.Borders[Microsoft.Office.Interop.Excel.XlBordersIndex.xlInsideVertical].LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
            XcelApp.Columns.AutoFit();
            XcelApp.Visible = true;
        }

        private void buttonXuat_Click(object sender, EventArgs e)
        {
            Xuat_Excel();
        }
    }
}
