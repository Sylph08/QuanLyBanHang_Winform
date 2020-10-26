using QuanLyBanHang_MaiKet.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang_MaiKet.DAO
{
    public class DepartmentDAO
    {
        private static DepartmentDAO instance;

        public static DepartmentDAO Instance
        {
            get
            {
                if (instance == null) instance = new DepartmentDAO();
                return instance;
            }
            private set => instance = value;
        }
        private DepartmentDAO() { }
        public List<Department> GetDepartments()
        {
            List<Department> list = new List<Department>();
            DataTable table = DataProvider.Instance.ExecuteQuery("select * from Department");
            foreach(DataRow item in table.Rows)
            {
                Department d1 = new Department(item);
                list.Add(d1);
            }
            return list;
        }
        public Department GetDepartmentsWithIdOfChitiet(int iddep)
        {            
            DataTable table = DataProvider.Instance.ExecuteQuery("select * from Department where iddep="+iddep);
            Department d1 = new Department(table.Rows[0]);
            return d1;
        }
        
    }
}
