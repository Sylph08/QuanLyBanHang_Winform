using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang_MaiKet.DTO
{
    public class Menu
    {
        public Menu(int idbillinfo, string ten, int gia, int soluong, int tt)
        {
            this.IdBillInfo = idbillinfo;
            this.TenSanPham = ten;
            this.DonGia = gia;
            this.SoLuong = soluong;
            this.ThanhTien = tt;
        }
        public Menu(DataRow row)
        {
            this.IdBillInfo = (int)row["idbillinfo"];
            this.TenSanPham = row["name"].ToString();
            this.DonGia = (int)row["price"];
            this.SoLuong = (int)row["quantity"];
            this.ThanhTien = (int)row["Thanhtien"];
        }
        private string tenSanPham;
        private int soLuong;
        private int donGia;
        private int thanhTien;
        private int idBillInfo;

        public string TenSanPham { get => tenSanPham; set => tenSanPham = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public int DonGia { get => donGia; set => donGia = value; }
        public int ThanhTien { get => thanhTien; set => thanhTien = value; }
        public int IdBillInfo { get => idBillInfo; set => idBillInfo = value; }
    }
}
