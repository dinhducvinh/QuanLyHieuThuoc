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
    public partial class FormNhapHang: Form
    {
        string nguon = NguonData.nguon;
        string manhanvien = TaiKhoanDongBo.TenTaiKhoan;
        public FormNhapHang()
        {  
            InitializeComponent();
            buttonXoaHoaDon.Enabled = false;
            buttonXoaSP.Enabled = false;
            buttonThemSP.Enabled = false;
            loadComboBoxNhaCungCap();
            loadComboBoxTenThuoc();
        }
        void loadComboBoxNhaCungCap()
        {
            SqlConnection conn = new SqlConnection(nguon);
            conn.Open();
            SqlDataAdapter xem = new SqlDataAdapter("select MaNhaCungCap from NhaCungCap", conn);
            DataTable dt = new DataTable();
            xem.Fill(dt);
            comboBoxNhaCungCap.DataSource = dt;
            comboBoxNhaCungCap.DisplayMember = "MaNhaCungCap";
            conn.Close();

        }
        void loadComboBoxTenThuoc()
        { //chu ý dropdown để nhập
            SqlConnection conn = new SqlConnection(nguon);
            conn.Open();
            SqlDataAdapter xem = new SqlDataAdapter("select TenThuoc from Thuoc", conn);
            DataTable dt = new DataTable();
            xem.Fill(dt);
            comboBoxTenThuoc.DataSource = dt;
            comboBoxTenThuoc.DisplayMember = "TenThuoc";
            conn.Close();
        }
        void loadHoaDon()
        {
            SqlConnection conn = new SqlConnection(nguon);
            conn.Open();
            string laydata = "SELECT TOP 1 MaHoaDonNhapHang,MaNhaCungCap,TongTien,PhuongThucThanhToan,GhiChu FROM HoaDonNhapHang " +
                       "WHERE MaNhanVien ='" + manhanvien + "' ORDER BY NgayTao DESC;";
            SqlDataAdapter xem = new SqlDataAdapter(laydata, conn);
            DataTable dt = new DataTable();
            xem.Fill(dt);
            dataGridViewHoaDon.DataSource = dt;
            conn.Close();
            dataGridViewHoaDon.Columns["MaHoaDonNhapHang"].HeaderText = "Mã HĐ nhập hàng";
            dataGridViewHoaDon.Columns["MaNhaCungCap"].HeaderText = "Mã nhà cung cấp";
            dataGridViewHoaDon.Columns["TongTien"].HeaderText = "Tổng tiền";
            dataGridViewHoaDon.Columns["PhuongThucThanhToan"].HeaderText = "PTTT";
            dataGridViewHoaDon.Columns["GhiChu"].HeaderText = "Ghi chú";
            dataGridViewHoaDon.Columns["TongTien"].DefaultCellStyle.Format = "N0";
            /*"N0": Định dạng số với dấu phân cách hàng nghìn (dấu phẩy sau mỗi 3 chữ số) và không hiển thị số thập phân.
           Nếu bạn muốn hiển thị số thập phân (ví dụ: 1,000,000.00), hãy thay "N0" bằng "N".*/
        }
        void loadSanPham()
        {
                SqlConnection conn = new SqlConnection(nguon);
                conn.Open();
                SqlDataAdapter xem = new SqlDataAdapter("select MaHoaDonNhapHang,TenThuoc,SoLuong,GiaNhap,ThanhTien,GhiChu from ChiTietHoaDonNhapHang where MaHoaDonNhapHang=@MaHoaDonNhapHang ", conn);
                xem.SelectCommand.Parameters.AddWithValue("@MaHoaDonNhapHang", textBoxMaHoaDonNhapHang.Text);
                DataTable dt = new DataTable();
                xem.Fill(dt);
                dataGridViewChiTietHD.DataSource = dt;
                conn.Close();
                dataGridViewChiTietHD.Columns["MaHoaDonNhapHang"].HeaderText = "Mã hóa đơn";
                dataGridViewChiTietHD.Columns["TenThuoc"].HeaderText = "Tên thuốc";
                dataGridViewChiTietHD.Columns["SoLuong"].HeaderText = "Số lượng";
                dataGridViewChiTietHD.Columns["GiaNhap"].HeaderText = "Giá nhập";
                dataGridViewChiTietHD.Columns["ThanhTien"].HeaderText = "Thành tiền";
                dataGridViewChiTietHD.Columns["GhiChu"].HeaderText = "Ghi chú";
            dataGridViewChiTietHD.Columns["ThanhTien"].DefaultCellStyle.Format = "N0";
            dataGridViewChiTietHD.Columns["GiaNhap"].DefaultCellStyle.Format = "N0";
        }
        void updateSLTon()
        {
            using (SqlConnection conn = new SqlConnection(nguon))
            {
                conn.Open();

                // Lưu trữ dữ liệu từ ChiTietHoaDon vào danh sách tạm
                List<(string TenThuoc, int SoLuong)> chiTietList = new List<(string, int)>();
                string selectChiTiet = "SELECT TenThuoc, SoLuong FROM ChiTietHoaDonNhapHang WHERE MaHoaDonNhapHang = @MaHoaDon";
                SqlCommand cmdSelect = new SqlCommand(selectChiTiet, conn);
                cmdSelect.Parameters.AddWithValue("@MaHoaDon", textBoxMaHoaDonNhapHang.Text);
                SqlDataReader reader = cmdSelect.ExecuteReader();

                // Đọc dữ liệu và lưu vào danh sách
                while (reader.Read())
                {
                    string tenThuoc = reader["TenThuoc"].ToString();
                    int soLuong = Convert.ToInt32(reader["SoLuong"]);
                    chiTietList.Add((tenThuoc, soLuong));
                }
                reader.Close();

                // Cập nhật số lượng tồn cho từng sản phẩm
                foreach (var chiTiet in chiTietList)
                {
                    string updateThuoc = "UPDATE Thuoc SET SoLuongTon = SoLuongTon + @SoLuong WHERE TenThuoc = @TenThuoc";
                    SqlCommand cmdUpdate = new SqlCommand(updateThuoc, conn);
                    cmdUpdate.Parameters.AddWithValue("@SoLuong", chiTiet.SoLuong);
                    cmdUpdate.Parameters.AddWithValue("@TenThuoc", chiTiet.TenThuoc);
                    cmdUpdate.ExecuteNonQuery();
                }
            }
        }
        void tinhTongTien()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(nguon))
                {
                    conn.Open();
                    string insert = " UPDATE HoaDonNhapHang SET TongTien = ( SELECT SUM(ThanhTien) FROM ChiTietHoaDonNhapHang " +
                       "WHERE MaHoaDonNhapHang=@MaHoaDon) where MaHoaDonNhapHang=@MaHoaDon ";
                    SqlCommand cmdtongtien = new SqlCommand(insert, conn);
                    cmdtongtien.Parameters.AddWithValue("@MaHoaDon", textBoxMaHoaDonNhapHang.Text);
                    cmdtongtien.ExecuteNonQuery();
                    loadHoaDon();
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
        private void buttonThemNhaCungCap_Click(object sender, EventArgs e)
        {
            FormThemNhaCungCap themNhaCungCap = new FormThemNhaCungCap();
            themNhaCungCap.Show();
        }

        private void buttonLuuHoaDon_Click(object sender, EventArgs e)
        { 
            this.Close();
        }

        private void buttonTaoHoaDon_Click(object sender, EventArgs e)
        {
            int indexMaNhaCC = comboBoxNhaCungCap.FindStringExact(comboBoxNhaCungCap.Text);
            if (indexMaNhaCC < 0)
            {
                MessageBox.Show("Vui lòng chọn nhà cung cấp hợp lệ từ danh sách gợi ý!");
                comboBoxTenThuoc.Focus();
                return;
            }
            try
            {
                using (SqlConnection conn = new SqlConnection(nguon))
                {
                    conn.Open();
                    String sql = "insert into HoaDonNhapHang (MaNhaCungCap,MaNhanVien,PhuongThucThanhToan,NgayTao,GhiChu) " +
                        "values (@MaNhaCungCap,@MaNhanVien,@PhuongThucThanhToan,GETDATE(),@GhiChu)";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@MaNhaCungCap", comboBoxNhaCungCap.Text);
                    cmd.Parameters.AddWithValue("@MaNhanVien", manhanvien);
                    cmd.Parameters.AddWithValue("@PhuongThucThanhToan", comboBoxPhuongThucThanhToan.Text);
                    cmd.Parameters.AddWithValue("@GhiChu", richTextBoxGhiChu1.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Tạo hóa đơn mới thành công!");
                    loadHoaDon();
                    conn.Close();
                    buttonXoaHoaDon.Enabled = true;
                    buttonTaoHoaDon.Enabled = false;
                    buttonThemSP.Enabled = true;
                    buttonXoaSP.Enabled = true;
                    if (dataGridViewHoaDon.Rows.Count > 0)
                    {

                        DataGridViewRow row = dataGridViewHoaDon.Rows[0];
                        textBoxMaHoaDonNhapHang.Text = row.Cells["MaHoaDonNhapHang"].Value.ToString();
                        comboBoxNhaCungCap.Text = row.Cells["MaNhaCungCap"].Value.ToString();
                        comboBoxPhuongThucThanhToan.Text = row.Cells["PhuongThucThanhToan"].Value.ToString();
                        richTextBoxGhiChu1.Text = row.Cells["GhiChu"].Value.ToString();
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

        private void buttonXoaHoaDon_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(nguon))
                {
                    conn.Open();
                    string delete = "Delete from HoaDonNhapHang where MaHoaDonNhapHang=@MaHoaDon";
                    SqlCommand cmd = new SqlCommand(delete, conn);
                    cmd.Parameters.AddWithValue("@MaHoaDon", textBoxMaHoaDonNhapHang.Text);
                    DialogResult rs = MessageBox.Show("Bạn có chắc muốn xóa hóa đơn: " + textBoxMaHoaDonNhapHang.Text + " không", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (rs == DialogResult.Yes)
                    {
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Xóa thành công");
                        dataGridViewHoaDon.DataSource = null;
                        dataGridViewChiTietHD.DataSource = null;
                        buttonXoaHoaDon.Enabled = false;
                        buttonTaoHoaDon.Enabled = true;
                        buttonXoaSP.Enabled = false;
                        buttonThemSP.Enabled = false;
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
        private void buttonThemSP_Click(object sender, EventArgs e)
        {
            int index = comboBoxTenThuoc.FindStringExact(comboBoxTenThuoc.Text);
            if (index < 0)
            {
                MessageBox.Show("Vui lòng chọn tên thuốc hợp lệ từ danh sách gợi ý!");
                comboBoxTenThuoc.Focus();
                return;
            }
                try
            {
                int thanhTien = (int)(numericUpDownSoLuong.Value * numericGiaNhap.Value);
                using (SqlConnection conn = new SqlConnection(nguon))
                {
                    conn.Open();
                    String sql = "Insert into ChiTietHoaDonNhapHang(MaHoaDonNhapHang,TenThuoc,SoLuong,GiaNhap,ThanhTien,NgayTao,GhiChu)" +
                        "values(@MaHoaDonNhapHang,@TenThuoc,@SoLuong,@GiaNhap,@ThanhTien,GetDate(),@GhiChu)";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@MaHoaDonNhapHang", textBoxMaHoaDonNhapHang.Text);
                    cmd.Parameters.AddWithValue("@TenThuoc", comboBoxTenThuoc.Text);
                    cmd.Parameters.AddWithValue("@SoLuong", numericUpDownSoLuong.Value);
                    cmd.Parameters.AddWithValue("@GiaNhap", numericGiaNhap.Value);
                    cmd.Parameters.AddWithValue("@ThanhTien", thanhTien);
                    cmd.Parameters.AddWithValue("@GhiChu", richTextBoxGhiChu2.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm sản phẩm vào hóa đơn thành công!");
                    tinhTongTien();
                    loadSanPham();
                }
            }
            
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Chú ý tạo hóa đơn trước khi thêm sản phẩm: {ex.Message}",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }

        private void buttonXoaSP_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(nguon))
                {
                    conn.Open();
                    string delete = "Delete from ChiTietHoaDonNhapHang where TenThuoc=@TenThuoc and MaHoaDonNhapHang=@MaHoaDonNhapHang";
                    SqlCommand cmd = new SqlCommand(delete, conn);
                    cmd.Parameters.AddWithValue("@MaHoaDonNhapHang", textBoxMaHoaDonNhapHang.Text);
                    cmd.Parameters.AddWithValue("@TenThuoc", comboBoxTenThuoc.Text);
                    cmd.ExecuteNonQuery();
                    tinhTongTien();
                    loadSanPham();
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

        private void dataGridViewChiTietHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            try
            {
                DataGridViewRow row = dataGridViewChiTietHD.Rows[e.RowIndex];
                comboBoxTenThuoc.Text = row.Cells["TenThuoc"].Value.ToString();
                numericUpDownSoLuong.Value = (int)row.Cells["SoLuong"].Value;
                numericGiaNhap.Value = (int)row.Cells["GiaNhap"].Value;
                richTextBoxGhiChu2.Text = row.Cells["GhiChu"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dòng này chưa có dữ liệu nào cả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSuaHoaDon_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(nguon))
                {
                    conn.Open();
                    string insert = "Update HoaDonNhapHang Set MaNhaCungCap=@MaNhaCungCap,PhuongThucThanhToan=@PhuongThucThanhToan,GhiChu=@GhiChu where MaHoaDonNhapHang=@MaHoaDonNhapHang";
                    SqlCommand cmd = new SqlCommand(insert, conn);
                    cmd.Parameters.AddWithValue("@MaHoaDonNhapHang", textBoxMaHoaDonNhapHang.Text);
                    cmd.Parameters.AddWithValue("@MaNhaCungCap", comboBoxNhaCungCap.Text);
                    cmd.Parameters.AddWithValue("@PhuongThucThanhToan", comboBoxPhuongThucThanhToan.Text);
                    cmd.Parameters.AddWithValue("@GhiChu", richTextBoxGhiChu1.Text);
                    cmd.ExecuteNonQuery();
                    DialogResult rs = MessageBox.Show("Bạn có chắc muốn sửa hóa đơn: " + textBoxMaHoaDonNhapHang.Text + " không", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (rs == DialogResult.Yes)
                    {
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Sửa thành công");
                        loadHoaDon();
                    }
                    else
                    {
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

        private void FormNhapHang_FormClosing(object sender, FormClosingEventArgs e)
        {
            updateSLTon();
        }

        private void comboBoxNhaCungCap_Enter(object sender, EventArgs e)
        {
            loadComboBoxNhaCungCap();
        }
    }
}