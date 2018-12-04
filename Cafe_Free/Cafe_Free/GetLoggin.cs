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
    public partial class GetLoggin : Form
    {
        public GetLoggin()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Database db;
            db = new Database();

            SqlConnection conn = new SqlConnection();
            string strSQL = " select *from User where user = '" + txtUser.Text + "'and password = '" +txtPass.Text + "'";
            db.ExecuteNonQuery(strSQL);
            {
                this.Hide();
                MessageBox.Show("Đăng Nhập Thành Công","Thông Báo");
                Form1 main = new Form1();
                main.Show();
            }
        }
    }
}
