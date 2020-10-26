using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang_MaiKet.DTO
{
    public class Product
    {
        public Product(DataRow row)
        {
            this.IdPro = (int)row["idpro"];
            this.Name = row["name"].ToString();
            this.Price = (int)row["price"];
            this.IdVitri = (int)row["idvitri"];
            this.Outlook = (byte[])row["outlook"];
        }
        public Product(int id,string name, int price, int idvitri, byte[]img)
        {
            this.IdPro = id;
            this.Name = name;
            this.Price = price;
            this.IdVitri = idvitri;
            this.Outlook = outlook;
        }
        private byte[] outlook;
        private int idVitri;
        private int price;
        private string name;
        private int idPro;

        public int IdPro { get => idPro; set => idPro = value; }
        public string Name { get => name; set => name = value; }
        public int Price { get => price; set => price = value; }
        public int IdVitri { get => idVitri; set => idVitri = value; }
        public byte[] Outlook { get => outlook; set => outlook = value; }
    }
}
