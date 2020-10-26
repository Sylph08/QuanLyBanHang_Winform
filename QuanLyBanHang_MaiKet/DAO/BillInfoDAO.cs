using QuanLyBanHang_MaiKet.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang_MaiKet.DAO
{
    public class BillInfoDAO
    {
        private static BillInfoDAO instance;

        public static BillInfoDAO Instance
        {
            get
            {
                if (instance == null) instance = new BillInfoDAO();
                return BillInfoDAO.instance;
            }
            private set => instance = value;
        }
        private BillInfoDAO() { }
        public List<BillInfo> GetListBillInfoInBill(int id)
        {
            List<BillInfo> listBillInfo = new List<BillInfo>();
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from BillInfo where idBill=" + id);
            foreach (DataRow item in data.Rows)
            {
                BillInfo info = new BillInfo(item);
                listBillInfo.Add(info);
            }
            return listBillInfo;
        }
        public void InsertBillInfo(int idBill, int idpro, int quan)
        {
            DataProvider.Instance.ExecuteNonQuery("exec USP_InsertBillInfo @idBill , @idpro , @quan ", new object[] { idBill, idpro, quan });
        }
    }
}
