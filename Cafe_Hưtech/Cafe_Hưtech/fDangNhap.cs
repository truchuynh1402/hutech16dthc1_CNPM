using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe_Hưtech
{
    public partial class fDangNhap : Form
    {
        public fDangNhap()
        {
            ChucNang nv = new ChucNang();
            InitializeComponent();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn chắc Chắn Muốn Thoát", "Thông Báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void btDangNhap_Click(object sender, EventArgs e)
        {
            //    SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=QuanLyCafe;Integrated Security=True"); // making connection   
            //    SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Acc WHERE UserName='" + txtUser.Text + "' AND PassAcc='" + txtPass.Text + "'", con);
            //    /* in above line the program is selecting the whole data from table and the matching it with the user name and password provided by user. */
            //    DataTable dt = new DataTable(); //this is creating a virtual table  
            //    con.Open();
            //    sda.Fill(dt);
            //    con.Close();
            //    if (dt.Rows[0][0].ToString() == "1")
            //    {
            //        /* I have made a new page called home page. If the user is successfully authenticated then the form will be moved to the next form */
            //        fBanHang f = new fBanHang();
            //        this.Hide();
            //        f.ShowDialog();
            //        this.Show();
            //    }
            //    else
            //        MessageBox.Show("Invalid username or password");

            //}

            string UserName = txtUser.Text;
            string PassWord = txtPass.Text;
            if (Login(UserName, PassWord))
            {
                fBanHang f = new fBanHang();
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Sai ten tai khoan hoac mat khau", "thong bao", MessageBoxButtons.OK);
            }
        }
        bool Login(string UserName, String PassWord)
        {
              return DangNhapLogin.Instance.Login(UserName, PassWord);
        }

        private void fDangNhap_Load(object sender, EventArgs e)
        {
            
        }
    }
}
