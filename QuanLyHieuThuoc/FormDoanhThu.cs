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
    public partial class FormDoanhThu : Form
    { String nguon=NguonData.nguon;
        public FormDoanhThu()
        {
            InitializeComponent();
            loadData();
        }

        private void FormDoanhThu_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
        public void LoadReportDoanhThu(DataTable dtHoaDonNhapHang, DataTable dtHoaDonBanHang)
        {
            reportViewer1.LocalReport.ReportPath = "D:\\C#\\Thi\\QuanLyHieuThuoc\\QuanLyHieuThuoc\\ReporDoanhThu.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();

            // Thêm DataSource cho bảng hóa đơn (dùng để đổ vào TextBox)
            if (dtHoaDonBanHang.Rows.Count > 0)
            {
                reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataHoaDonBanHang", dtHoaDonBanHang));
            }

            // Thêm DataSource cho bảng chi tiết hóa đơn
            if (dtHoaDonNhapHang.Rows.Count > 0)
            {
                reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataHoaDonNhapHang", dtHoaDonNhapHang));
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
                    SqlDataAdapter laydlHoaDonNhapHang = new SqlDataAdapter("SELECT * FROM HoaDonNhapHang WHERE NgayTao BETWEEN @TuNgay AND @DenNgay", conn);
                    laydlHoaDonNhapHang.SelectCommand.Parameters.AddWithValue("@TuNgay", dateTimeTuNgay.Value);
                    laydlHoaDonNhapHang.SelectCommand.Parameters.AddWithValue("@DenNgay", dateTimeDenNgay.Value);
                    DataTable dtHoaDonNhapHang = new DataTable();
                    laydlHoaDonNhapHang.Fill(dtHoaDonNhapHang);

                    SqlDataAdapter laydlHoaDonBanHang = new SqlDataAdapter("SELECT * FROM HoaDon WHERE NgayTao BETWEEN @TuNgay AND @DenNgay", conn);
                    laydlHoaDonBanHang.SelectCommand.Parameters.AddWithValue("@TuNgay", dateTimeTuNgay.Value);
                    laydlHoaDonBanHang.SelectCommand.Parameters.AddWithValue("@DenNgay", dateTimeDenNgay.Value);
                    DataTable dtHoaDonBanHang = new DataTable();
                    laydlHoaDonBanHang.Fill(dtHoaDonBanHang);

                    LoadReportDoanhThu(dtHoaDonNhapHang, dtHoaDonBanHang);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void ButtonTruyVan_Click(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
