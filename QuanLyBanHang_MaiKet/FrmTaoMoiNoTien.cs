using QuanLyBanHang_MaiKet.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang_MaiKet
{
    public partial class FrmTaoMoiNoTien : Form
    {
              
        int idSend = 0;
        public FrmTaoMoiNoTien()
        {
            InitializeComponent();
            txtTen.Text = "";
            txtDiachi.Text = "";
            txtSotien.Text = "";
            txtGhiChu.Text = "";
            dtpNgayNo.Value = DateTime.Today;
            btnOK.Text = "OK";
        }
        
        public FrmTaoMoiNoTien(NoTien rowsend)
        {
            InitializeComponent();
            idSend = rowsend.IdNoTien;
            txtTen.Text = rowsend.Ten;
            txtDiachi.Text = rowsend.Diachi;
            txtSotien.Text = rowsend.Sotien.ToString();
            txtGhiChu.Text = rowsend.Ghichu;
            dtpNgayNo.Value = rowsend.Ngayno;
            btnOK.Text = "Cập nhật";
        }
        
        private void btnOK_Click(object sender, EventArgs e)
        {
            if(btnOK.Text=="OK")
            {
                if (txtTen.Text != "" && txtSotien.Text != "")
                {
                    string sotien = txtSotien.Text.Replace(",", "");
                    string sql = "insert into NoTien (ten, diachi, sotienno,ngayno,ghichu) " +
                    "values (N'" + txtTen.Text + "',N'" + txtDiachi.Text + "'," + sotien + ",'" + dtpNgayNo.Value.ToString("yyyy-MM-dd") + "',N'" + txtGhiChu.Text + "')";
                    int x = DataProvider.Instance.ExecuteNonQuery(sql);
                    MessageBox.Show("Đã thêm " + x.ToString() + " người nợ tiền vào danh sách.");
                    this.Close();
                }
                else MessageBox.Show("Tên người nợ và số tiền nợ không được để trống.");
            }
            else
            {
                if (txtTen.Text != "" && txtSotien.Text != "")
                {
                    string sotien = txtSotien.Text.Replace(",", "");
                    string sql = "update Notien set ten=N'" + txtTen.Text + "',diachi=N'" + txtDiachi.Text + "',sotienno=" + sotien + ",ngayno='" + dtpNgayNo.Value.ToString("yyyy-MM-dd") + "',ghichu=N'" + txtGhiChu.Text + "' where idnotien=" + idSend.ToString();
                    int x = DataProvider.Instance.ExecuteNonQuery(sql);
                    this.Close();
                    MessageBox.Show(x.ToString() + " bản ghi đã được chỉnh sửa.");
                }
                else MessageBox.Show("Tên người nợ và số tiền nợ không được để trống.");
            }
            
        }
        private void txtSotien_TextChanged(object sender, EventArgs e)
        {
            if (txtSotien.Text != "")
            {
                CultureInfo culture = new CultureInfo("en-US");
                int value = Int32.Parse(txtSotien.Text, NumberStyles.AllowThousands);
                txtSotien.Text = string.Format(culture, "{0:N0}", value);
                txtSotien.Select(txtSotien.Text.Length, 0);
            }
        }
    }
}
