using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe_Hưtech
{
    public partial class fInfoAcc : Form
    {
        public fInfoAcc()
        {
            InitializeComponent();
        }

        private void fInfoAcc_Load(object sender, EventArgs e)
        {
            txtHoTen.Enabled = false;
            txtMatKhauCu.Enabled=false;
            txtMatKhauMoi.Enabled = false;
            txtNgaySinh.Enabled = false;
            txtNhapLaiMK.Enabled = false;
            txtSDT.Enabled = false;
            txtTenDangNhap.Enabled = false;
            btLuu.Enabled = false;
            btNhapLai.Enabled = false;

           

        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            txtHoTen.Enabled = true;
            txtMatKhauCu.Enabled = true;
            txtMatKhauMoi.Enabled = true;
            txtNgaySinh.Enabled = true;
            txtNhapLaiMK.Enabled = true;
            txtSDT.Enabled = true;
            txtTenDangNhap.Enabled = true;
            btLuu.Enabled = true;
            btNhapLai.Enabled = true;
        }

        private void btNhapLai_Click(object sender, EventArgs e)
        {
            txtHoTen.Text = "";
            txtMatKhauCu.Text = "";
            txtMatKhauMoi.Text = "";
            txtNgaySinh.Text = "";
            txtNhapLaiMK.Text = "";
            txtSDT.Text = "";
            txtTenDangNhap.Text = "";
        }
    }
}
