using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHieuThuoc
{
    public partial class FormMDI: Form
    {
        string nguon = NguonData.nguon;
        public FormMDI()
        {
            InitializeComponent();
            FormDangNhap dangnhap = new FormDangNhap();
            dangnhap.ShowDialog();
            labelTenTK.Text = dangnhap.TenTaiKhoan;
            TaiKhoanDongBo.TenTaiKhoan = labelTenTK.Text;
        }

        public string TenTaiKhoan => labelTenTK.Text;
        private void điểmDanhToolStripMenuItem_Click(object sender, EventArgs e)
        {  FormDiemDanh diemdanh= new FormDiemDanh();
            diemdanh.MdiParent = this;
            diemdanh.WindowState = FormWindowState.Maximized;
            diemdanh.Show();
        }
        int kiemtratk()
        {
            using (SqlConnection conn = new SqlConnection(nguon))
            {
                conn.Open();
                string kiemtra = "SELECT COUNT(*) FROM NhanVien WHERE MaNhanVien = @TaiKhoan AND VaiTro = N'QuanLy'";
                SqlCommand checkCmd = new SqlCommand(kiemtra, conn);
                checkCmd.Parameters.AddWithValue("@TaiKhoan", labelTenTK.Text);
                int count = (int)checkCmd.ExecuteScalar();
                return count;
            }
        }
        private void danhSáchNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                
                    if (kiemtratk() == 0)
                    {
                        MessageBox.Show("Bạn không có quyền truy cập vào chức năng này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        FormQuanLy quanly = new FormQuanLy();
                        quanly.MdiParent = this;
                        quanly.WindowState = FormWindowState.Maximized;
                        quanly.Show();
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

        private void khoThuốcToolStripMenuItem_Click(object sender, EventArgs e)
        { FormThuoc thuoc=new FormThuoc();
            thuoc.MdiParent = this;
           thuoc.WindowState = FormWindowState.Maximized; 
            thuoc.Show();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void danhSáchHóaĐơnNhậpHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDSHoaDonNhapHang dshdn = new FormDSHoaDonNhapHang();
            dshdn.MdiParent = this;
            dshdn.WindowState = FormWindowState.Maximized;
            dshdn.Show();
            dshdn.BringToFront();
        }

        private void danhSáchHóaĐơnBánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDSHoaDonBanHang dshdb = new FormDSHoaDonBanHang();
            dshdb.MdiParent = this;
            dshdb.WindowState = FormWindowState.Maximized;
            dshdb.Show();
            dshdb.BringToFront();
        }

        private void trangChủToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in this.MdiChildren)
            {
                childForm.Close();
            }
        }

        private void bảngCôngNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                if (kiemtratk() == 0)
                {
                    MessageBox.Show("Bạn không có quyền truy cập vào chức năng này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    FormLuongNhanVien luong = new FormLuongNhanVien();
                    luong.MdiParent = this;
                    luong.WindowState = FormWindowState.Maximized;
                    luong.Show();
                    luong.BringToFront();
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

        private void vốnLãiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (kiemtratk() == 0)
            {
                MessageBox.Show("Bạn không có quyền truy cập vào chức năng này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                FormDoanhThu formDoanhThu = new FormDoanhThu();
                formDoanhThu.MdiParent = this;
                formDoanhThu.WindowState = FormWindowState.Maximized;
                formDoanhThu.Show();
                formDoanhThu.BringToFront();
            }
        }
    }
}
