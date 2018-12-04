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

namespace Cafe_Free
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Hide();

        }

        private void btDangNhap_Click(object sender, EventArgs e)
        {
            string user = txtNameUser.Text;
            string pass = txtPassUser.Text;
            if (user == "admin" && pass == "quang0898") 
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            if(user =="nhanvien" && pass =="123456")
            {
                this.DialogResult = System.Windows.Forms.DialogResult.Yes;
            }
            else
            {
                MessageBox.Show("Nhập Sai Rồi Bạn Ơi!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNameUser.Clear();
                txtPassUser.Clear();
            }

            /////////////////////////////////////
            //Database db;
            //SqlConnection conn = new SqlConnection();
            //string strSQL = "Select * from User where NameUser ='" +txtNameUser.Text+ "' and PassUser = '"+txtPassUser.Text+"'" ;
            
            //SqlCommand cmd = new SqlCommand(strSQL, conn);
            //SqlDataReader reader = cmd.ExecuteReader();
            //if(reader.Read()==true)
            //{
            //    this.Hide();
            //    Form1 main = new Form1();
            //    main.Show();
            //////////////////////////////////////
            }

        private void btThoatLg_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void login_Load(object sender, EventArgs e)
        {
            
        }
    }
    }

