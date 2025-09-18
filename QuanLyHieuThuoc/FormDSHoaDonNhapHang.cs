using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHieuThuoc
{
    public partial class FormDSHoaDonNhapHang : Form
    {
        string nguon = NguonData.nguon;
        public FormDSHoaDonNhapHang()
        {
            InitializeComponent();
            loadData();
        }
        void loadReport(DataTable dtHoaDon,DataTable dtChiTietHoaDon)
        { reportViewer1.LocalReport.DataSources.Clear();
            if (dtHoaDon.Rows.Count>0)
            {
                reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataHoaDonNhapHang", dtHoaDon));
            }    
            if(dtChiTietHoaDon.Rows.Count>0)
            {
                reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataChiTietHoaDonNhapHang", dtChiTietHoaDon));
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
                    SqlDataAdapter laydlHoaDon = new SqlDataAdapter("SELECT * FROM HoaDonNhapHang WHERE NgayTao BETWEEN @TuNgay AND @DenNgay", conn);
                    laydlHoaDon.SelectCommand.Parameters.AddWithValue("@TuNgay", dateTimeTuNgay.Value);
                    laydlHoaDon.SelectCommand.Parameters.AddWithValue("@DenNgay", dateTimeDenNgay.Value);
                    DataTable dtHoaDon= new DataTable();
                    laydlHoaDon.Fill(dtHoaDon);
                    

                    SqlDataAdapter laydlChiTietHoaDon = new SqlDataAdapter("SELECT * FROM ChiTietHoaDonNhapHang WHERE NgayTao BETWEEN @TuNgay AND @DenNgay", conn);
                    laydlChiTietHoaDon.SelectCommand.Parameters.AddWithValue("@TuNgay", dateTimeTuNgay.Value);
                    laydlChiTietHoaDon.SelectCommand.Parameters.AddWithValue("@DenNgay", dateTimeDenNgay.Value);
                    DataTable dt = new DataTable();
                    laydlChiTietHoaDon.Fill(dt);

                    loadReport( dtHoaDon, dt);

                }    

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

        void loadDataTimKiem()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(nguon))
                {
                    conn.Open();
                    SqlDataAdapter laydlHoaDon = new SqlDataAdapter("SELECT * FROM HoaDonNhapHang WHERE NgayTao BETWEEN @TuNgay AND @DenNgay", conn);
                    laydlHoaDon.SelectCommand.Parameters.AddWithValue("@TuNgay", dateTimeTuNgay.Value);
                    laydlHoaDon.SelectCommand.Parameters.AddWithValue("@DenNgay", dateTimeDenNgay.Value);
                    DataTable dtHoaDon = new DataTable();
                    laydlHoaDon.Fill(dtHoaDon);


                    conn.Open();
                    SqlDataAdapter laydl = new SqlDataAdapter("Select * from ChitietHoaDonNhapHang where MaHoaDonNhapHang=@MaHoaDon", conn);
                    laydl.SelectCommand.Parameters.AddWithValue("@MaHoaDon", textBoxTimKiem.Text);
                    DataTable dt = new DataTable();
                    laydl.Fill(dt);

                    loadReport(dtHoaDon, dt);

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
           
          loadDataTimKiem();
        }

        private void ButtonTruyVan_Click(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
