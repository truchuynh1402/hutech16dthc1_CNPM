using System;
using Cafe_Hưtech.DAO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Cafe_Hưtech
{
   public class DataProvider
    {

        private static DataProvider instance;



        public static DataProvider Instance
        {
            get
            {
                if (instance == null) instance = new DataProvider();
                return DataProvider.instance;
            }

            private set
            {
                DataProvider.instance = value;
            }
        }
        private DataProvider()
        { }

        private string sqlConn = "Data Source=.\\SQLEXPRESS;Initial Catalog=QuanLyCafe;Integrated Security=True";
        public DataTable ExecuteQuery(string query = null, object[] parameter = null)

        {
            DataTable data = new DataTable();
            using (SqlConnection conn = new SqlConnection(sqlConn))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(data);
                conn.Close();
            }
            return data;
        }
        public int ExecuteNonQuery(string query = null, object[] parameter = null)

        {
            int data = 0;
            using (SqlConnection conn = new SqlConnection(sqlConn))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                data = cmd.ExecuteNonQuery();

                conn.Close();
            }
            return data;
        }
        public object ExecuteSaclar(string query = null, object[] parameter = null)

        {
            object data = 0;
            using (SqlConnection conn = new SqlConnection(sqlConn))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                data = cmd.ExecuteScalar();
                conn.Close();
            }
            return data;
        }






        //SqlConnection sqlConn;
        //SqlDataAdapter da;
        //DataSet ds;
        //public DataProvider()

        //{
        //    string sqlConn = "Data Source=.\\SQLEXPRESS;Initial Catalog=QuanLyCafe;Integrated Security=True";

        //    SqlConnection conn = new SqlConnection(sqlConn);

        //}
        //public DataTable execute(string sqlstr)
        //{
        //    da = new SqlDataAdapter(sqlstr, sqlConn);
        //    ds = new DataSet();
        //    da.Fill(ds);
        //    return ds.Tables[0];
        //}
        //public void ExecuteNonQuery(string strSQL)
        //{
        //    SqlCommand sqlcmd = new SqlCommand(strSQL, sqlConn);
        //    sqlConn.Open();
        //    sqlcmd.ExecuteNonQuery();
        //    sqlConn.Close();
        //}
    }
}

