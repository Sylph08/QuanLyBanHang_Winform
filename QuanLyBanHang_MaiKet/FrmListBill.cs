using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang_MaiKet
{
    public partial class FrmListBill : Form
    {
        public FrmListBill()
        {
            InitializeComponent();
            LoadcbByStatus();
            
        }

        private void FrmListBill_Load(object sender, EventArgs e)
        {
            LoadGridBill();
            grvBill.Columns[0].HeaderText = "Mã hóa đơn";
            grvBill.Columns[1].HeaderText = "Ngày tạo";
            grvBill.Columns[2].HeaderText = "Trạng thái";
            grvBill.Columns[3].HeaderText = "Giá trị";
            grvBill.Columns[4].HeaderText = "Ghi chú";
        }

        private void LoadGridBill()
        {
            string sql = "select * from bill";
            DataTable table = DataProvider.Instance.ExecuteQuery(sql);
            grvBill.DataSource = table;
        }

        private void rdbByDate_CheckedChanged(object sender, EventArgs e)
        {
            dtpByDate.Enabled = true;
            cbByStatus.Enabled = false;
        }

        private void dtpByDate_ValueChanged(object sender, EventArgs e)
        {
            string sql = "select * from bill where datecreate='" + dtpByDate.Value.ToString("yyyy-MM-dd") + "'";
            DataTable table = DataProvider.Instance.ExecuteQuery(sql);
            grvBill.DataSource = table;
        }

        private void rdbByStatus_CheckedChanged(object sender, EventArgs e)
        {
            dtpByDate.Enabled = false;
            cbByStatus.Enabled = true;
            cbByStatus.SelectedIndex = 0;
        }

        private void LoadcbByStatus()
        {            
            cbByStatus.Items.Insert(0, "Chưa thanh toán");
            cbByStatus.Items.Insert(1, "Đã thanh toán");
        }

        private void cbByStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "";
            if (cbByStatus.SelectedIndex == 0)
            {
                sql = "select * from bill where status=0";
            }
            if (cbByStatus.SelectedIndex == 1)
            {
                sql = "select * from bill where status=1";
            }
            DataTable table = DataProvider.Instance.ExecuteQuery(sql);
            grvBill.DataSource = table;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int index = grvBill.CurrentCell.RowIndex;
                int idbillSelected = Convert.ToInt32(grvBill.Rows[index].Cells[0].Value.ToString());
                string sql = "";
                //xoa trong bang billinfo
                sql = "delete from billinfo where idbill=" + idbillSelected.ToString();
                DataProvider.Instance.ExecuteNonQuery(sql);
                //xoa trong bang bill
                sql = "delete from bill where idbill=" + idbillSelected.ToString();
                int x = DataProvider.Instance.ExecuteNonQuery(sql);
                MessageBox.Show("Đã xóa " + x.ToString() + " hóa đơn.");
                LoadGridBill();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
