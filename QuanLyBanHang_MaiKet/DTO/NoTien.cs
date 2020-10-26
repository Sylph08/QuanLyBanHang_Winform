using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang_MaiKet.DTO
{
    public class NoTien
    {
        public NoTien(DataRow row)
        {
            this.IdNoTien = (int)row["idnotien"];
            this.Ten = row["ten"].ToString();
            this.Diachi = row["diachi"].ToString();
            this.Sotien = (int)row["sotienno"];
            this.Ngayno = (DateTime)row["ngayno"];
            this.Ghichu = row["ghichu"].ToString();
        }
        public NoTien(int id, string ten,string dc,int sotien,DateTime ngayno,string gchu)
        {
            this.IdNoTien = id;
            this.Ten = ten;
            this.Diachi = dc;
            this.Sotien = sotien;
            this.Ngayno = ngayno;
            this.Ghichu = gchu;
        }
        private int idNoTien;
        private string ten;
        private string diachi;
        private int sotien;
        private DateTime ngayno;
        private string ghichu;

        public int IdNoTien { get => idNoTien; set => idNoTien = value; }
        public string Ten { get => ten; set => ten = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public int Sotien { get => sotien; set => sotien = value; }
        public DateTime Ngayno { get => ngayno; set => ngayno = value; }
        public string Ghichu { get => ghichu; set => ghichu = value; }
    }
}
