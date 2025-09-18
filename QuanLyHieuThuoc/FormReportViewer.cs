using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHieuThuoc
{
    public partial class FormReportViewer : Form
    {
        public FormReportViewer()
        {
            InitializeComponent();
        }
        public void LoadXuatHoaDon(DataTable dtHoaDon, DataTable dtChiTietHD)
        {
            reportViewer1.LocalReport.ReportPath = "D:\\C#\\Thi\\QuanLyHieuThuoc\\QuanLyHieuThuoc\\BillBanHang.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();

            // Thêm DataSource cho bảng hóa đơn (dùng để đổ vào TextBox)
            if (dtHoaDon.Rows.Count > 0)
            {
                reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataHoaDon", dtHoaDon));
            }

            // Thêm DataSource cho bảng chi tiết hóa đơn
            if (dtChiTietHD.Rows.Count > 0)
            {
                reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataCTHoaDon", dtChiTietHD));
            }

            reportViewer1.RefreshReport();
        }
        }
}
