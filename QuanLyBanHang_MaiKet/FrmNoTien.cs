using QuanLyBanHang_MaiKet.DTO;
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
    public partial class FrmNoTien : Form
    {
        public FrmNoTien()
        {
            InitializeComponent();
        }

        private void FrmNoTien_Load(object sender, EventArgs e)
        {
            LoadGridNoTien();
            grvNoTien.Columns[0].Visible = false;
            grvNoTien.Columns[1].HeaderText = "Tên người nợ";
            grvNoTien.Columns[2].HeaderText = "Địa chỉ";
            grvNoTien.Columns[3].HeaderText = "Số tiền nợ";
            grvNoTien.Columns[4].HeaderText = "Ngày nợ";
            grvNoTien.Columns[5].HeaderText = "Ghi chú";
            //chỉnh cách hiển thị cột ngày nợ
            grvNoTien.Columns[4].DefaultCellStyle.Format = "dd/MM/yyyy";
        }

        private void LoadGridNoTien()
        {
            string sql = "select * from Notien";
            DataTable table = DataProvider.Instance.ExecuteQuery(sql); ;
            grvNoTien.DataSource = table;
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            FrmTaoMoiNoTien f = new FrmTaoMoiNoTien();
            f.Show();            
        }

        private void btnReLoad_Click(object sender, EventArgs e)
        {
            LoadGridNoTien();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int index = grvNoTien.CurrentCell.RowIndex;
                string idSelected = grvNoTien.Rows[index].Cells[0].Value.ToString();
                string sql = "delete from Notien where idNotien=" + idSelected;
                if (MessageBox.Show("Đồng ý xóa khỏi danh sách?", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    int x = DataProvider.Instance.ExecuteNonQuery(sql);
                    MessageBox.Show("Đã xóa " + x.ToString() + " bản ghi khỏi danh sách.");
                    LoadGridNoTien();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int index = grvNoTien.CurrentCell.RowIndex;
            string idSelected = grvNoTien.Rows[index].Cells[0].Value.ToString();
            string sql = "select * from NoTien where idNotien=" + idSelected;
            DataTable table = DataProvider.Instance.ExecuteQuery(sql);
            NoTien rowSelected = new NoTien(table.Rows[0]);
            FrmTaoMoiNoTien f = new FrmTaoMoiNoTien(rowSelected);
            f.Show();

        }
    }
}
