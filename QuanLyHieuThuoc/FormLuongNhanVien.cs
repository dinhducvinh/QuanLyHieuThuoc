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
    public partial class FormLuongNhanVien : Form
    { string nguon=NguonData.nguon;
        public FormLuongNhanVien()
        {
            InitializeComponent();
            loadData();
        }
        void loadData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(nguon))
                {
                    conn.Open();
                    SqlDataAdapter laydlALL = new SqlDataAdapter("SELECT cc.MaNhanVien, nv.Ho,nv.Ten,nv.SoDienThoai,cc.NgayLam,cc.GioVao,cc.GioVe,cc.SoGioLam,cc.GhiChu " +
                        "FROM ChamCong cc INNER JOIN NhanVien nv ON cc.MaNhanVien = nv.MaNhanVien " +
                        "WHERE NgayLam BETWEEN @TuNgay AND @DenNgay " +
                        "GROUP BY cc.MaNhanVien, nv.Ho, nv.Ten,nv.SoDienThoai,cc.NgayLam,cc.GioVao,cc.GioVe,cc.SoGioLam,cc.GhiChu;", conn);
                    laydlALL.SelectCommand.Parameters.AddWithValue("@TuNgay", dateTimeTuNgay.Value);
                    laydlALL.SelectCommand.Parameters.AddWithValue("@DenNgay", dateTimeDenNgay.Value);
                    DataTable dtChamCong = new DataTable();
                    laydlALL.Fill(dtChamCong);
                    dataGridViewBangCong.DataSource = dtChamCong;
                    dataGridViewBangCong.Columns["MaNhanVien"].HeaderText = "Mã nhân viên";
                    dataGridViewBangCong.Columns["Ho"].HeaderText = "Họ";
                    dataGridViewBangCong.Columns["Ten"].HeaderText = "Tên";
                    dataGridViewBangCong.Columns["SoDienThoai"].HeaderText = "Số điện thoại";
                    dataGridViewBangCong.Columns["NgayLam"].HeaderText = "Ngày làm";
                    dataGridViewBangCong.Columns["GioVao"].HeaderText = "Giờ vào";
                    dataGridViewBangCong.Columns["GioVe"].HeaderText = "Giờ về";
                    dataGridViewBangCong.Columns["SoGioLam"].HeaderText = "Số giờ làm";
                    dataGridViewBangCong.Columns["GhiChu"].HeaderText = "Ghi chú";


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
            if (textBoxTimKiem.Text == "Nhập mã nhân viên")
            {
                textBoxTimKiem.Text = "";
                textBoxTimKiem.ForeColor = Color.Gray;
            }
        }

        private void textBoxTimKiem_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxTimKiem.Text))
            {
                textBoxTimKiem.Text = "Nhập mã nhân viên";
                textBoxTimKiem.ForeColor = Color.Gray;
            }
        }

        private void buttonTimKiem_Click(object sender, EventArgs e)
        {
            using(SqlConnection conn=new SqlConnection(nguon))
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter laydltk= new SqlDataAdapter ("SELECT cc.MaNhanVien, nv.Ho,nv.Ten,nv.SoDienThoai,cc.NgayLam,cc.GioVao,cc.GioVe,cc.SoGioLam,cc.GhiChu " +
                        "FROM ChamCong cc INNER JOIN NhanVien nv ON cc.MaNhanVien = nv.MaNhanVien " +
                        "WHERE cc.MaNhanVien=@MaNhanVien AND NgayLam BETWEEN @TuNgay AND @DenNgay " +
                        "GROUP BY cc.MaNhanVien, nv.Ho, nv.Ten,nv.SoDienThoai,cc.NgayLam,cc.GioVao,cc.GioVe,cc.SoGioLam,cc.GhiChu;", conn);
                    laydltk.SelectCommand.Parameters.AddWithValue("@MaNhanVien", textBoxTimKiem.Text);
                    laydltk.SelectCommand.Parameters.AddWithValue("@TuNgay", dateTimeTuNgay.Value);
                    laydltk.SelectCommand.Parameters.AddWithValue("@DenNgay", dateTimeDenNgay.Value);
                    DataTable dtChamCong = new DataTable();
                    laydltk.Fill(dtChamCong);
                    dataGridViewBangCong.DataSource = dtChamCong;
                    dataGridViewBangCong.Columns["MaNhanVien"].HeaderText = "Mã nhân viên";
                    dataGridViewBangCong.Columns["Ho"].HeaderText = "Họ";
                    dataGridViewBangCong.Columns["Ten"].HeaderText = "Tên";
                    dataGridViewBangCong.Columns["SoDienThoai"].HeaderText = "Số điện thoại";
                    dataGridViewBangCong.Columns["NgayLam"].HeaderText = "Ngày làm";
                    dataGridViewBangCong.Columns["GioVao"].HeaderText = "Giờ vào";
                    dataGridViewBangCong.Columns["GioVe"].HeaderText = "Giờ về";
                    dataGridViewBangCong.Columns["SoGioLam"].HeaderText = "Số giờ làm";
                }
                catch(Exception ex)
                {
                    MessageBox.Show(
                        $"Lỗi: {ex.Message}",
                        "Lỗi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }    
        }
        private void Xuat_Excel()
        {
            Microsoft.Office.Interop.Excel.Application XcelApp = new Microsoft.Office.Interop.Excel.Application();
            XcelApp.Application.Workbooks.Add(Type.Missing);

             
            for (int i = 1; i < dataGridViewBangCong.Columns.Count + 1; i++)
            {
                XcelApp.Cells[1, i] = dataGridViewBangCong.Columns[i - 1].HeaderText;
            }

            Microsoft.Office.Interop.Excel.Range headerRange = XcelApp.Range[XcelApp.Cells[1, 1], XcelApp.Cells[1, dataGridViewBangCong.Columns.Count]];
            headerRange.Font.Bold = true; // In đậm tiêu đề
            headerRange.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightGray); // Màu nền xám nhạt
            for (int i = 0; i < dataGridViewBangCong.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridViewBangCong.Columns.Count; j++)
                {
                    
                    XcelApp.Cells[i + 2, j + 1] = dataGridViewBangCong.Rows[i].Cells[j].Value?.ToString() ?? "";
                }
            }
            int lastRow = dataGridViewBangCong.Rows.Count + 1; // Bao gồm cả hàng tiêu đề
            int lastColumn = dataGridViewBangCong.Columns.Count;
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

        private void ButtonTruyVan_Click(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
