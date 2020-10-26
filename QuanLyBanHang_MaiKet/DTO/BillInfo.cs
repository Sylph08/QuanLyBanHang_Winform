using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang_MaiKet.DTO
{
    public class BillInfo
    {
        public BillInfo(DataRow row)
        {
            this.ID = (int)row["idbillinfo"];
            this.BillID = (int)row["idbill"];
            this.IdPro = (int)row["idpro"];
            this.Quantity = (int)row["quantity"];
        }
        public BillInfo(int id, int billid, int idpro, int quan)
        {
            this.ID = id;
            this.BillID = billid;
            this.IdPro = idpro;
            this.Quantity = quan;
        }
        private int iD;
        private int billID;
        private int idPro;
        private int quantity;

        public int ID { get => iD; set => iD = value; }
        public int BillID { get => billID; set => billID = value; }
        public int IdPro { get => idPro; set => idPro = value; }
        public int Quantity { get => quantity; set => quantity = value; }
    }
}
