using QuanLyHieuThuoc.QuanLyNhanVien;
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
    public partial class FormQuanLy: Form
    {
        public FormQuanLy()
        {
            InitializeComponent();
        }

        private void buttonXemNv_Click(object sender, EventArgs e)
        {
            UC_NhanVien.Visible = true;
            UC_NhanVien.BringToFront();
        }

        private void buttonTaiKhoan_Click(object sender, EventArgs e)
        {
            UC_TaiKhoan.Visible = true;
           UC_TaiKhoan.BringToFront();
        }
    }
}
