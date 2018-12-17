using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Windows.Forms;

namespace Cafe_Hưtech
{
    public partial class fadmin : Form
    {
        public fadmin()
        {
            InitializeComponent();
            //loadshowNhanVien();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //void loadshowNhanVien()
        //{
        //    string query = "EXEC dbo.USP_GetAccByUserName @userName" ;
        //    DataProvider provider = new DataProvider();
             
        //    dataQLNhanVien.DataSource = provider.ExecuteQuery(query, new object[] { "admin" });
        //}

        private void fadmin_Load(object sender, EventArgs e)
        {

        }
    }
}
