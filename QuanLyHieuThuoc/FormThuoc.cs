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
    public partial class FormThuoc: Form
    {
        string nguon = NguonData.nguon;
        public FormThuoc()
        {
            InitializeComponent();
            loadThuoc();
        }
        void loadThuoc()
        {
            SqlConnection conn = new SqlConnection(nguon);
            conn.Open();
            SqlDataAdapter xem = new SqlDataAdapter("select * from Thuoc", conn);
            DataTable dt = new DataTable();
            xem.Fill(dt);
            dataGridViewThuoc.DataSource = dt;
            conn.Close();
            dataGridViewThuoc.Columns["MaThuoc"].HeaderText = "Mã thuốc";
            dataGridViewThuoc.Columns["TenThuoc"].HeaderText = "Tên thuốc";
            dataGridViewThuoc.Columns["GiaBan"].HeaderText = "Giá bán";
            dataGridViewThuoc.Columns["SoLuongTon"].HeaderText = "Số lượng tồn kho";
            dataGridViewThuoc.Columns["DonVi"].HeaderText = "Đơn vị";
            dataGridViewThuoc.Columns["NgayTao"].HeaderText = "Ngày tạo";
            dataGridViewThuoc.Columns["GhiChu"].HeaderText = "Ghi chú";
            dataGridViewThuoc.Columns["GiaBan"].DefaultCellStyle.Format = "N0";
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(nguon))
                {
                    conn.Open();
                    string insert = "Insert into Thuoc(MaThuoc,TenThuoc,GiaBan,SoLuongTon,DonVi,NgayTao,GhiChu) values(@MaThuoc,@TenThuoc,@GiaBan,0,@DonVi,GETDATE(),@GhiChu) ";
                    SqlCommand cmd = new SqlCommand(insert, conn);
                    cmd.Parameters.AddWithValue("@MaThuoc", textBoxMaThuoc.Text);
                    cmd.Parameters.AddWithValue("@TenThuoc", textBoxTenThuoc.Text);
                    cmd.Parameters.AddWithValue("@GiaBan", numericGiaBan.Value);
                    cmd.Parameters.AddWithValue("@DonVi", textBoxDonVi.Text);
                    cmd.Parameters.AddWithValue("@GhiChu", richTextBoxGhiChu.Text);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Thêm sản phẩm mới thành công");
                    loadThuoc();
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

        private void dataGridViewThuoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            try
            {
                DataGridViewRow row = dataGridViewThuoc.Rows[e.RowIndex];
                textBoxMaThuoc.Text = row.Cells["MaThuoc"].Value.ToString();
                textBoxTenThuoc.Text = row.Cells["TenThuoc"].Value.ToString();
                numericGiaBan.Value = (int)row.Cells["GiaBan"].Value;
                textBoxDonVi.Text = row.Cells["DonVi"].Value.ToString();
                richTextBoxGhiChu.Text = row.Cells["GhiChu"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dòng này chưa có dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(nguon))
                {
                    conn.Open();
                    string insert = "Update Thuoc SET TenThuoc=@TenThuoc,GiaBan=@GiaBan,DonVi=@DonVi,GhiChu=@GhiChu where MaThuoc=@MaThuoc";
                    SqlCommand cmd = new SqlCommand(insert, conn);
                    cmd.Parameters.AddWithValue("@MaThuoc", textBoxMaThuoc.Text);
                    cmd.Parameters.AddWithValue("@TenThuoc", textBoxTenThuoc.Text);
                    cmd.Parameters.AddWithValue("@GiaBan", numericGiaBan.Value);
                    cmd.Parameters.AddWithValue("@DonVi", textBoxDonVi.Text);
                    cmd.Parameters.AddWithValue("@GhiChu", richTextBoxGhiChu.Text);
                    DialogResult rs = MessageBox.Show("Bạn có chắc muốn sửa thuốc: " + textBoxTenThuoc.Text + " không", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (rs == DialogResult.Yes)
                    {
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Sửa thành công");
                        loadThuoc();
                    }
                    else
                    {
                        loadThuoc();
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
                    string delete = "Delete from Thuoc where TenThuoc=@TenThuoc";
                    SqlCommand cmd = new SqlCommand(delete, conn);
                    cmd.Parameters.AddWithValue("@TenThuoc", textBoxTenThuoc.Text);
                    DialogResult rs = MessageBox.Show("Bạn có chắc muốn xóa thuốc: " + textBoxTenThuoc.Text + " không", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (rs == DialogResult.Yes)
                    {
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Xóa thành công");
                        loadThuoc();
                    }
                    else
                    {
                        loadThuoc();
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

        private void textBoxTimKiem_Enter(object sender, EventArgs e)
        {
            if (textBoxTimKiem.Text == "Nhập tên thuốc để tìm")
            {
                textBoxTimKiem.Text = "";
                textBoxTimKiem.ForeColor = Color.Gray;
            }
        }

        private void textBoxTimKiem_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxTimKiem.Text))
            {
                textBoxTimKiem.Text = "Nhập tên thuốc để tìm";
                textBoxTimKiem.ForeColor = Color.Gray;
            }
        }

        private void buttonTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(nguon))
                {
                    if (textBoxTimKiem.Text == "Nhập tên thuốc để tìm")
                    {
                        MessageBox.Show("Vui lòng nhập tên thuốc !", "Thông Báo");
                    }
                    else
                    {
                        conn.Open();
                        SqlDataAdapter laydulieu = new SqlDataAdapter("SELECT * FROM Thuoc WHERE TenThuoc LIKE N'%' + @TenThuoc + N'%'", conn);
                        laydulieu.SelectCommand.Parameters.AddWithValue("@TenThuoc", textBoxTimKiem.Text);
                        DataTable dt = new DataTable();
                        laydulieu.Fill(dt);
                        if (dt.Rows.Count > 0)
                        {
                            dataGridViewThuoc.DataSource = dt;
                            conn.Close();
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy thuốc", "Thông Báo");
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
            loadThuoc();
        }

        private void buttonNhapHang_Click(object sender, EventArgs e)
        { 
            FormNhapHang formNhapHang = new FormNhapHang();
            formNhapHang.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormTaoHoaDonBanHang form= new FormTaoHoaDonBanHang();
            form.Show();
        }
    }
}
