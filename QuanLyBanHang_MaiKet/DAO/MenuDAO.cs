using QuanLyBanHang_MaiKet.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang_MaiKet.DAO
{
    public class MenuDAO
    {
        private static MenuDAO instance;

        public static MenuDAO Instance
        {
            get
            {
                if (instance == null) instance = new MenuDAO();
                return MenuDAO.instance;
            }
            private set => instance = value;
        }
        private MenuDAO() { }
        public List<Menu> GetMenuOfBill(int idbill)
        {
            List<Menu> listMenu = new List<Menu>();
            string query = "select idbillinfo, name,Quantity,price, (Quantity*price) as Thanhtien " +
                "from product, billinfo " +
                "where product.idpro=billinfo.idpro and idbill=" + idbill.ToString();
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Menu menu = new Menu(item);
                listMenu.Add(menu);
            }

            return listMenu;
        }
    }
}
