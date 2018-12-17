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
    public partial class fBanHang : Form
    {
        public fBanHang()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void đĂNGXUÁTToolStripMenuItem_Click(object sender, EventArgs e)
        {
           if( MessageBox.Show("Bạn có muốn đằng xuất không", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != System.Windows.Forms.DialogResult.No)
            {
                this.Close();
            }
        }

        private void tHÔNGTINTÀIKHOẢNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fInfoAcc Info = new fInfoAcc();
            Info.ShowDialog();
        }

        private void hỆTHỐNGToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aDMIMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            fadmin QL = new fadmin();
            QL.ShowDialog();

        }

        private void fBanHang_Load(object sender, EventArgs e)
        {

        }

        #region method
        void loadsanhsachBan()
        {

        }

        #endregion 
        #region event
        #endregion 
    }
}
