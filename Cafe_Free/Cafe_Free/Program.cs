using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe_Free
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if(new login().ShowDialog()==DialogResult.OK)
            {
                Application.Run(new Form1());
            }
            if(new login().ShowDialog()==DialogResult.Yes)
                    {
                Application.Run(new Oder());
            }
        }
    }
}
