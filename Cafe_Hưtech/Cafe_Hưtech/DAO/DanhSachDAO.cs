using System;
using Cafe_Hưtech.DAO;
using Cafe_Hưtech.DTO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


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

        public List<DanhSach> LoadDanhSachBan()
        {
            List<DanhSach> DanhSachList = new List<DanhSach>();
            DataTable data = new DataProvider.Instance.ExecuteQuery("");
            return DanhSachList;

        }
    }
}
