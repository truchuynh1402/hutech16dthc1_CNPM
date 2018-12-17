using Cafe_Hưtech.DAO;
using Cafe_Hưtech.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Cafe_Hưtech.DAO
{
   public class DanhSachDAO
    {
        private static DanhSachDAO instance;

        public static DanhSachDAO Instance
        {
            get
            {
                if (instance == null) instance = new DanhSachDAO();   return DanhSachDAO.instance;
            }

            set
            {
               DanhSachDAO.instance = value;
            }
        }
        private DanhSachDAO() { }

      public List<DanhSach> loadtablelist ()
        {
            List<DanhSach> datatablelist = new List<DanhSach>();
            DataTable data = new DataProvider
            return datatablelist;
        }
    }
}
