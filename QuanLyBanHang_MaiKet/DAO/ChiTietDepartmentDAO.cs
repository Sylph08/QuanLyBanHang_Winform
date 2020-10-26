using QuanLyBanHang_MaiKet.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang_MaiKet.DAO
{
    public class ChiTietDepartmentDAO
    {
        private static ChiTietDepartmentDAO instance;

        public static ChiTietDepartmentDAO Instance
        {
            get
            {
                if (instance == null) instance = new ChiTietDepartmentDAO();
                return instance;
            }
            private set => instance = value;
        }
        private ChiTietDepartmentDAO() { }
        public List<ChiTietDepartment> GetChiTietDepartments(int id)
        {
            List<ChiTietDepartment> list = new List<ChiTietDepartment>();
            DataTable table = DataProvider.Instance.ExecuteQuery("select * from ChitietDepartment where idDep=" + id);
            foreach(DataRow item in table.Rows)
            {
                ChiTietDepartment c1 = new ChiTietDepartment(item);
                list.Add(c1);
            }

            return list;
        }
        public ChiTietDepartment GetCTDbyid(int id)
        {
            
            DataTable table = DataProvider.Instance.ExecuteQuery("select * from ChitietDepartment where id=" + id);
            ChiTietDepartment c1 = new ChiTietDepartment(table.Rows[0]);

            return c1;
        }
    }
}
