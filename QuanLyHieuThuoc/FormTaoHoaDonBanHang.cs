using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHieuThuoc
{
    public partial class FormTaoHoaDonBanHang : Form
    {
        string nguon = NguonData.nguon;
        string manhanvien = TaiKhoanDongBo.TenTaiKhoan;

        public FormTaoHoaDonBanHang()
        {
            InitializeComponent();
            buttonXoaHoaDon.Enabled = false;
            buttonThemSP.Enabled = false;
            buttonXoaSP.Enabled = false;
            loadComboBoxTenThuoc();
            loadGiaBan();
        }
        void loadComboBoxTenThuoc()
        { 
            SqlConnection conn = new SqlConnection(nguon);
            conn.Open();
            SqlDataAdapter xem = new SqlDataAdapter("select TenThuoc,GiaBan from Thuoc", conn);
            DataTable dt = new DataTable();
            xem.Fill(dt);
            comboBoxTenThuoc.DataSource = dt;
            comboBoxTenThuoc.DisplayMember = "TenThuoc";
            comboBoxTenThuoc.ValueMember = "GiaBan";
            conn.Close();
        }
        void loadGiaBan()
        { 
                int giaBan = Convert.ToInt32(comboBoxTenThuoc.SelectedValue);
                numericGiaBan.Value = giaBan;
        }
        private void comboBoxTenThuoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadGiaBan();
        }
        void loadHoaDon()
        {
            SqlConnection conn = new SqlConnection(nguon);
            conn.Open();
            string laydata = "SELECT TOP 1 MaHoaDon,SDTKhachHang,PhuongThucThanhToan,TongTien,GhiChu FROM HoaDon " +
                       "WHERE MaNhanVien ='" + manhanvien + "' ORDER BY NgayTao DESC;";
            SqlDataAdapter xem = new SqlDataAdapter(laydata, conn);
            DataTable dt = new DataTable();
            xem.Fill(dt);
            dataGridViewHoaDon.DataSource = dt;
            dataGridViewHoaDon.Columns["MaHoaDon"].HeaderText = "Mã hóa đơn";
            dataGridViewHoaDon.Columns["SDTKhachHang"].HeaderText = "SDT KH";
            dataGridViewHoaDon.Columns["PhuongThucThanhToan"].HeaderText = "PTTT";
            dataGridViewHoaDon.Columns["TongTien"].HeaderText = "Tổng tiền";
            dataGridViewHoaDon.Columns["GhiChu"].HeaderText = "Ghi chú";
            dataGridViewHoaDon.Columns["TongTien"].DefaultCellStyle.Format = "N0";
            conn.Close();
        }
        void loadSanPham()
        {
            SqlConnection conn = new SqlConnection(nguon);
            conn.Open();
            SqlDataAdapter xem = new SqlDataAdapter("select MaHoaDon,TenThuoc,SoLuong,ThanhTien,GhiChu from ChiTietHoaDon where MaHoaDon=@MaHoaDon ", conn);
            xem.SelectCommand.Parameters.AddWithValue("@MaHoaDon", textBoxMaHoaDonBanHang.Text);
            DataTable dt = new DataTable();
            xem.Fill(dt);
            dataGridViewChiTietHD.DataSource = dt;
            conn.Close();
            dataGridViewChiTietHD.Columns["MaHoaDon"].HeaderText = "Mã hóa đơn";
            dataGridViewChiTietHD.Columns["TenThuoc"].HeaderText = "Tên thuốc";
            dataGridViewChiTietHD.Columns["SoLuong"].HeaderText = "Số lượng";
            dataGridViewChiTietHD.Columns["ThanhTien"].HeaderText = "Thành tiền";
            dataGridViewChiTietHD.Columns["GhiChu"].HeaderText = "Ghi chú";
            dataGridViewChiTietHD.Columns["ThanhTien"].DefaultCellStyle.Format = "N0";
        }
        void tinhTongTien()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(nguon))
                {
                    conn.Open();
                    string insert = " UPDATE HoaDon SET TongTien = ( SELECT SUM(ThanhTien) FROM ChiTietHoaDon " +
                      "WHERE MaHoaDon=@MaHoaDon) where MaHoaDon=@MaHoaDon ";
                    SqlCommand cmdtongtien = new SqlCommand(insert, conn);
                    cmdtongtien.Parameters.AddWithValue("@MaHoaDon", textBoxMaHoaDonBanHang.Text);
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
        void updateSLTon()
        {
            using (SqlConnection conn = new SqlConnection(nguon))
            {
                conn.Open();

                // Lưu trữ dữ liệu từ ChiTietHoaDon vào danh sách tạm
                List<(string TenThuoc, int SoLuong)> chiTietList = new List<(string, int)>();
                string selectChiTiet = "SELECT TenThuoc, SoLuong FROM ChiTietHoaDon WHERE MaHoaDon = @MaHoaDon";
                SqlCommand cmdSelect = new SqlCommand(selectChiTiet, conn);
                cmdSelect.Parameters.AddWithValue("@MaHoaDon", textBoxMaHoaDonBanHang.Text);
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
                    string updateThuoc = "UPDATE Thuoc SET SoLuongTon = SoLuongTon - @SoLuong WHERE TenThuoc = @TenThuoc";
                    SqlCommand cmdUpdate = new SqlCommand(updateThuoc, conn);
                    cmdUpdate.Parameters.AddWithValue("@SoLuong", chiTiet.SoLuong);
                    cmdUpdate.Parameters.AddWithValue("@TenThuoc", chiTiet.TenThuoc);
                    cmdUpdate.ExecuteNonQuery();
                }
           
            }
        }
        private void buttonTaoHoaDon_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(nguon))
                {
                    conn.Open();
                    String sql = "insert into HoaDon (SDTKhachHang,MaNhanVien,PhuongThucThanhToan,NgayTao,GhiChu) " +
                        "values (@SDTKhachHang,@MaNhanVien,@PhuongThucThanhToan,GETDATE(),@GhiChu)";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@SDTKhachHang", maskedTextBoxSDT.Text);
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
                        textBoxMaHoaDonBanHang.Text = row.Cells["MaHoaDon"].Value.ToString();
                        maskedTextBoxSDT.Text = row.Cells["SDTKhachHang"].Value.ToString();
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

        private void maskedTextBoxSDT_Click(object sender, EventArgs e)
        {
            maskedTextBoxSDT.SelectionStart = maskedTextBoxSDT.Text.Length;
        }

        private void buttonXoaHoaDon_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(nguon))
                {
                    conn.Open();
                    string delete = "Delete from HoaDon where MaHoaDon=@MaHoaDon";
                    SqlCommand cmd = new SqlCommand(delete, conn);
                    cmd.Parameters.AddWithValue("@MaHoaDon", textBoxMaHoaDonBanHang.Text);
                    DialogResult rs = MessageBox.Show("Bạn có chắc muốn xóa hóa đơn: " + textBoxMaHoaDonBanHang.Text + " không", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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

        private void buttonSuaHoaDon_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(nguon))
                {
                    conn.Open();
                    string insert = "Update HoaDon Set SDTKhachHang=@SDTKhachHang,PhuongThucThanhToan=@PhuongThucThanhToan,GhiChu=@GhiChu where MaHoaDon=@MaHoaDon";
                    SqlCommand cmd = new SqlCommand(insert, conn);
                    cmd.Parameters.AddWithValue("@MaHoaDon", textBoxMaHoaDonBanHang.Text);
                    cmd.Parameters.AddWithValue("@SDTKhachHang", maskedTextBoxSDT.Text);
                    cmd.Parameters.AddWithValue("@PhuongThucThanhToan", comboBoxPhuongThucThanhToan.Text);
                    cmd.Parameters.AddWithValue("@GhiChu", richTextBoxGhiChu1.Text);
                    cmd.ExecuteNonQuery();
                    DialogResult rs = MessageBox.Show("Bạn có chắc muốn sửa hóa đơn: " + textBoxMaHoaDonBanHang.Text + " không", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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

        private void buttonThemSP_Click(object sender, EventArgs e)
        { 
            try
            {
                int index = comboBoxTenThuoc.FindStringExact(comboBoxTenThuoc.Text);
                if (index < 0)
                {
                    MessageBox.Show("Vui lòng chọn tên thuốc hợp lệ từ danh sách gợi ý!");
                    comboBoxTenThuoc.Focus();
                    return;
                }

                int thanhTien = (int)(numericUpDownSoLuong.Value * numericGiaBan.Value);
                using (SqlConnection conn = new SqlConnection(nguon))
                {
                    conn.Open();
                    String sql = "Insert into ChiTietHoaDon(MaHoaDon,TenThuoc,SoLuong,ThanhTien,NgayTao,GhiChu)" +
                        "values(@MaHoaDon,@TenThuoc,@SoLuong,@ThanhTien,GetDate(),@GhiChu)";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@MaHoaDon", textBoxMaHoaDonBanHang.Text);
                    cmd.Parameters.AddWithValue("@TenThuoc", comboBoxTenThuoc.Text);
                    cmd.Parameters.AddWithValue("@SoLuong", numericUpDownSoLuong.Value);
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
                    $"Chú ý tạo hóa đơn: {ex.Message}",
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
                    string delete = "Delete from ChiTietHoaDon where TenThuoc=@TenThuoc and MaHoaDon=@MaHoaDon";
                    SqlCommand cmd = new SqlCommand(delete, conn);
                    cmd.Parameters.AddWithValue("@MaHoaDon", textBoxMaHoaDonBanHang.Text);
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
                DataGridViewRow row = dataGridViewHoaDon.Rows[e.RowIndex];
                comboBoxTenThuoc.Text = row.Cells["TenThuoc"].Value.ToString();
                numericUpDownSoLuong.Value = (int)row.Cells["SoLuong"].Value;
                richTextBoxGhiChu2.Text = row.Cells["GhiChu"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dòng này không có dữ liệu nào cả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonLuuHoaDon_Click(object sender, EventArgs e)
        { 
            this.Close();
        }

        private void buttonXuatHoaDon_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(nguon);
            conn.Open();
            SqlDataAdapter laydata = new SqlDataAdapter("SELECT* from HoaDon where MaHoaDon=@MaHoaDon", conn);
            laydata.SelectCommand.Parameters.AddWithValue("@MaHoaDon", textBoxMaHoaDonBanHang.Text);
            DataTable dtHoaDon = new DataTable();
            laydata.Fill(dtHoaDon);
           
            SqlDataAdapter laydlCTHD = new SqlDataAdapter("select MaHoaDon,TenThuoc,SoLuong,ThanhTien,GhiChu from ChiTietHoaDon where MaHoaDon=@MaHoaDon ", conn);
            laydlCTHD.SelectCommand.Parameters.AddWithValue("@MaHoaDon", textBoxMaHoaDonBanHang.Text);
            DataTable dtChiTietHD = new DataTable();
            laydlCTHD.Fill(dtChiTietHD);
       

            FormReportViewer frmXuat = new FormReportViewer();
            frmXuat.LoadXuatHoaDon(dtHoaDon, dtChiTietHD);
            frmXuat.ShowDialog();
        }

        private void FormTaoHoaDonBanHang_FormClosing(object sender, FormClosingEventArgs e)
        {
            updateSLTon();
        }
    }
}
