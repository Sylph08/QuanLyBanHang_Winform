using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang_MaiKet.DTO
{
    public class ChiTietDepartment
    {
        public ChiTietDepartment(int id, int iddep, string dcct)
        {
            this.Id = id;
            this.IdDep = iddep;
            this.DiaChiChiTiet = dcct;
        }
        public ChiTietDepartment(DataRow row)
        {
            this.Id = (int)row["id"];
            this.IdDep = (int)row["iddep"];
            this.DiaChiChiTiet = row["diachichitiet"].ToString();
        }
        private int id;
        private int idDep;
        private string diaChiChiTiet;

        public int Id { get => id; set => id = value; }
        public int IdDep { get => idDep; set => idDep = value; }
        public string DiaChiChiTiet { get => diaChiChiTiet; set => diaChiChiTiet = value; }
    }
}
