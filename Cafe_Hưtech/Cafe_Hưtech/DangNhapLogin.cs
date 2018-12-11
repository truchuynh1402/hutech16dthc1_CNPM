using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Cafe_Hưtech
{
    public class DangNhapLogin
    {
        private static DangNhapLogin instance;

        public static DangNhapLogin Instance
        {
            get
            {
                if (instance == null) instance = new DangNhapLogin();
                return instance;
            }

          private  set
            {
                instance = value;
            }
            
        }
        private DangNhapLogin()
        { }
        public bool Login(string UserName, string PassWord)
        {
            string query = "select * From dbo.Acc Where UserName = N'" + UserName + "' and PassAcc = N'" + PassWord + "'";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            return result.Rows.Count > 0;
            // return false;
        }
    }
}
