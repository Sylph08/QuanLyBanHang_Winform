using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang_MaiKet.DTO
{
    public class Department
    {
        public Department(int id, string loca)
        {
            this.IdDep = id;
            this.Location = loca;
        }
        public Department (DataRow row)
        {
            this.IdDep = (int)row["idDep"];
            this.Location = row["location"].ToString();
        }
        private int idDep;
        private string location;

        public int IdDep { get => idDep; set => idDep = value; }
        public string Location { get => location; set => location = value; }
    }
}
