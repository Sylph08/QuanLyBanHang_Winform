using QuanLyBanHang_MaiKet.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang_MaiKet.DAO
{
    public class NoTienDAO
    {
        private static NoTienDAO instance;

        public static NoTienDAO Instance
        {
            get
            {
                if (instance == null) instance = new NoTienDAO();
                return instance;
            }
            private set => instance = value;
        }
        private NoTienDAO() { }
        public List<NoTien> GetListWithQuery(string query)
        {
            List<NoTien> ds = new List<NoTien>();
            DataTable table = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow item in table.Rows)
            {
                NoTien n1 = new NoTien(item);
                ds.Add(n1);
            }

            return ds;
        }
    }
}
