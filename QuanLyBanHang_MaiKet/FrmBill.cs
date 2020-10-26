using QuanLyBanHang_MaiKet.DAO;
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
using Menu = QuanLyBanHang_MaiKet.DTO.Menu;

namespace QuanLyBanHang_MaiKet
{
    public partial class FrmBill : Form
    {
        public FrmBill()
        {
            InitializeComponent();
        }

        private void FrmBill_Load(object sender, EventArgs e)
        {
            string sql = "insert into Bill (DateCreate,status) values (GETDATE(),0)";
            int x = DataProvider.Instance.ExecuteNonQuery(sql);                  
            
        }
        private int GetIdOfBill()
        {
            string sql = "select max(idBill) from Bill";
            int id = (int)DataProvider.Instance.ExecuteScalar(sql);
            return id;
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string sql = "select * from product where name like N'%" + txtSearch.Text + "%'";
            DataTable table = DataProvider.Instance.ExecuteQuery(sql);
            grvSearchResult.DataSource = table;
            grvSearchResult.Columns[0].HeaderText = "Mã sản phẩm";
            grvSearchResult.Columns[1].HeaderText = "Tên sản phẩm";
            grvSearchResult.Columns[2].HeaderText = "Giá tiền";
            grvSearchResult.Columns[3].Visible = false;
            grvSearchResult.Columns[4].Visible = false;
        }
        int tongtien = 0;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //lấy mã sp của sp được chọn
            int rowid_selected = grvSearchResult.CurrentCell.RowIndex;
            int idsp = Convert.ToInt32(grvSearchResult.Rows[rowid_selected].Cells[0].Value.ToString());
            int giaSP = Convert.ToInt32(grvSearchResult.Rows[rowid_selected].Cells[2].Value.ToString());
            string tenSP = grvSearchResult.Rows[rowid_selected].Cells[1].Value.ToString();
            //
            int soluong = (int)nmudQuantity.Value;
            BillInfoDAO.Instance.InsertBillInfo(GetIdOfBill(), idsp, soluong);
            //hien thi len listview
            ShowBill(GetIdOfBill());
            nmudQuantity.Value = 1;
        }
        void DieuChinhDoRongChoListView(ListView lv)
        {
            lv.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lv.Columns[0].Width = (lv.Columns[0].Width < 50 ? 50 : lv.Columns[0].Width);
            lv.Columns[1].Width = (lv.Columns[1].Width < 85 ? 85 : lv.Columns[1].Width);
            lv.Columns[2].Width = (lv.Columns[2].Width < 80 ? 80 : lv.Columns[2].Width);
            lv.Columns[3].Width = (lv.Columns[3].Width < 60 ? 60 : lv.Columns[3].Width);
            lv.Columns[4].Width = (lv.Columns[4].Width < 80 ? 80 : lv.Columns[4].Width);
        }
        private void ShowBill(int idbill)
        {
            tongtien = 0;
            lsvBill.Items.Clear();
            List<Menu> listBillInfoInBill = MenuDAO.Instance.GetMenuOfBill(idbill);
            foreach(Menu item in listBillInfoInBill)
            {
                ListViewItem lsvItem = new ListViewItem(item.IdBillInfo.ToString());
                lsvItem.SubItems.Add(item.TenSanPham.ToString());
                lsvItem.SubItems.Add(item.SoLuong.ToString());
                lsvItem.SubItems.Add(item.DonGia.ToString());
                lsvItem.SubItems.Add(item.ThanhTien.ToString());
                lsvBill.Items.Add(lsvItem);
                DieuChinhDoRongChoListView(lsvBill);
                tongtien += item.ThanhTien;
            }            
            txtTongTienHang.Text = tongtien.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int x = 0;
                foreach (ListViewItem item in lsvBill.Items)
                {
                    if (item.Checked == true)
                    {
                        int i = item.Index;
                        string query = "delete from billinfo where idbillinfo=" + lsvBill.Items[i].Text;
                        x += DataProvider.Instance.ExecuteNonQuery(query);
                        tongtien -= Convert.ToInt32(lsvBill.Items[i].SubItems[4].Text);
                        txtTongTienHang.Text = tongtien.ToString();
                        item.Remove();
                    }
                }
                MessageBox.Show("Đã xóa " + x.ToString() + " sản phẩm khỏi danh sách.");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txtGhiChu_MouseClick(object sender, MouseEventArgs e)
        {
            txtGhiChu.Text = "";
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            string sobitru = txtTienKhachDua.Text.Replace(",", "");
            string sotru = txtTongTienHang.Text.Replace(",", "");
            //
            string sql = "update Bill set status = 1, tongtien="+sotru+", ghichu= N'" + txtGhiChu.Text + "' where idbill=" + GetIdOfBill().ToString();
            int x = DataProvider.Instance.ExecuteNonQuery(sql);
            MessageBox.Show(x.ToString() + " hóa đơn đã được thanh toán.");
            //
            FrmTinhToan f = new FrmTinhToan();        
            f.TienHang = Convert.ToInt32(sotru);
            f.TienKhachDua = Convert.ToInt32(sobitru);
            f.Show();
            this.Close();
        }

        private void txtTienKhachDua_TextChanged(object sender, EventArgs e)
        {
            DinhDangChoTextboxSo(txtTienKhachDua);
        }
        void DinhDangChoTextboxSo(TextBox box)
        {
            if (box.Text != "")
            {
                CultureInfo culture = new CultureInfo("en-US");
                int value = Int32.Parse(box.Text, NumberStyles.AllowThousands);
                box.Text = string.Format(culture, "{0:N0}", value);
                box.Select(box.Text.Length, 0);
            }
        }

        private void txtTongTienHang_TextChanged(object sender, EventArgs e)
        {
            DinhDangChoTextboxSo(txtTongTienHang);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
