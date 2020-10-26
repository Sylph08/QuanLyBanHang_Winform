using QuanLyBanHang_MaiKet.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang_MaiKet.DAO
{
    class ProductDAO
    {
        private static ProductDAO instance;
        public static ProductDAO Instance
        {
            get
            {
                if (instance == null) instance = new ProductDAO();
                return instance;
            }
            private set => instance = value;
        }
        private ProductDAO() { }
        public List<Product> GetProductsWithQueryString(string sql)
        {
            List<Product> list = new List<Product>();
            DataTable table = DataProvider.Instance.ExecuteQuery(sql);
            foreach(DataRow item in table.Rows)
            {
                
                Product p1 = new Product(item);
                list.Add(p1);
            }

            return list;
        }
    }
}
