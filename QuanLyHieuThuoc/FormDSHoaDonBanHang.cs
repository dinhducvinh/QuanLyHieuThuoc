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
    public partial class FormDSHoaDonBanHang : Form
    { string nguon = NguonData.nguon;
        public FormDSHoaDonBanHang()
        {
            InitializeComponent();
            loadData();
        }
        public void LoadReportDSBanHang(DataTable dtHoaDonBanHang, DataTable dtChiTietHoaDon)
        {
            reportViewer1.LocalReport.DataSources.Clear();
            // Thêm DataSource cho bảng hóa đơn (dùng để đổ vào TextBox)
            if (dtHoaDonBanHang.Rows.Count > 0)
            {
                reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataHoaDonBanHang", dtHoaDonBanHang));
            }

            // Thêm DataSource cho bảng chi tiết hóa đơn
            if (dtChiTietHoaDon.Rows.Count > 0)
            {
                reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataChiTietHoaDon", dtChiTietHoaDon));
            }

            Microsoft.Reporting.WinForms.ReportParameter tuNgayParam = new Microsoft.Reporting.WinForms.ReportParameter("TuNgay", dateTimeTuNgay.Value.ToString());
            Microsoft.Reporting.WinForms.ReportParameter denNgayParam = new Microsoft.Reporting.WinForms.ReportParameter("DenNgay", dateTimeDenNgay.Value.ToString());
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter[] { tuNgayParam, denNgayParam });



            reportViewer1.RefreshReport();
        }

        void loadData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(nguon))
                {
                    conn.Open();
                    SqlDataAdapter laydlHoaDon = new SqlDataAdapter("SELECT * FROM HoaDon WHERE NgayTao BETWEEN @TuNgay AND @DenNgay", conn);
                    laydlHoaDon.SelectCommand.Parameters.AddWithValue("@TuNgay", dateTimeTuNgay.Value);
                    laydlHoaDon.SelectCommand.Parameters.AddWithValue("@DenNgay", dateTimeDenNgay.Value);
                    DataTable dtHoaDon = new DataTable();
                    laydlHoaDon.Fill(dtHoaDon);
      

                    SqlDataAdapter laydlChiTietHoaDon = new SqlDataAdapter("SELECT * FROM ChiTietHoaDon WHERE NgayTao BETWEEN @TuNgay AND @DenNgay", conn);
                    laydlChiTietHoaDon.SelectCommand.Parameters.AddWithValue("@TuNgay", dateTimeTuNgay.Value);
                    laydlChiTietHoaDon.SelectCommand.Parameters.AddWithValue("@DenNgay", dateTimeDenNgay.Value);
                    DataTable dtChiTiet = new DataTable();
                    laydlChiTietHoaDon.Fill(dtChiTiet);

                    LoadReportDSBanHang( dtHoaDon, dtChiTiet);

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
            void LoadDataTheoTimKiem()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(nguon))
                {
                    conn.Open();
                    SqlDataAdapter laydlHoaDon = new SqlDataAdapter("SELECT * FROM HoaDon WHERE MaHoaDon=@MaHoaDon", conn);
                    laydlHoaDon.SelectCommand.Parameters.AddWithValue("@MaHoaDon", textBoxTimKiem.Text);
                    DataTable dtHoaDon = new DataTable();
                    laydlHoaDon.Fill(dtHoaDon);

                    
                    SqlDataAdapter laydl = new SqlDataAdapter("Select * from ChiTietHoaDon where MaHoaDon=@MaHoaDon", conn);
                    laydl.SelectCommand.Parameters.AddWithValue("@MaHoaDon", textBoxTimKiem.Text);
                    DataTable dtChiTiet = new DataTable();
                    laydl.Fill(dtChiTiet);

                    LoadReportDSBanHang(dtHoaDon, dtChiTiet);

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
            if (textBoxTimKiem.Text == "Nhập mã HĐ")
            {
                textBoxTimKiem.Text = "";
                textBoxTimKiem.ForeColor = Color.Gray;
            }
        }

        private void textBoxTimKiem_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxTimKiem.Text))
            {
                textBoxTimKiem.Text = "Nhập mã HĐ";
                textBoxTimKiem.ForeColor = Color.Gray;
            }
        }

        private void buttonTimKiem_Click(object sender, EventArgs e)
        {
            
                    LoadDataTheoTimKiem();
        }

        private void ButtonTruyVan_Click(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
