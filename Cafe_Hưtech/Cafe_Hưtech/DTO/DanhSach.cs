using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe_Hưtech.DTO
{
    class DanhSach
    {
        public DanhSach(int id, string name, string trangthai)
        {
            this.ID = id;
            this.Name = name;
            this.TrangThai = trangthai;
        }

        private string name;

        private string trangThai;

        private int iD;

        public int ID
        {
            get
            {
                return iD;
            }

            set
            {
                iD = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string TrangThai
        {
            get
            {
                return trangThai;
            }

            set
            {
                trangThai = value;
            }
        }
    }
}
