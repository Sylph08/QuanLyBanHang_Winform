using QuanLyBanHang_MaiKet.DAO;
using QuanLyBanHang_MaiKet.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang_MaiKet
{
    public partial class AddProduct : Form
    {
        //
        private byte[] img = null;
        string DuongDanNoProduct = Application.StartupPath + @"\Images\NoProduct.png";
        //
        public AddProduct()
        {
            InitializeComponent();
            LoadDepartment();
            cbDepartnamt.SelectedItem = null;cbChitietDepartment.SelectedItem = null;
            ptbPicture.ImageLocation = DuongDanNoProduct;
            FileStream fs = new FileStream(DuongDanNoProduct, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            img = br.ReadBytes((int)fs.Length);
        }

        void LoadDepartment()
        {
            List<Department> list = DepartmentDAO.Instance.GetDepartments();
            cbDepartnamt.DataSource = list;
            cbDepartnamt.DisplayMember = "location";           
        }
        void LoadChitietDepartmentByidDep(int idDep)
        {
            List<ChiTietDepartment> list = ChiTietDepartmentDAO.Instance.GetChiTietDepartments(idDep);
            cbChitietDepartment.DataSource = list;
            cbChitietDepartment.DisplayMember = "diachichitiet";
        }

        private void cbDepartnamt_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null) return;
            Department slt = cb.SelectedItem as Department;
            id = slt.IdDep;
            LoadChitietDepartmentByidDep(id);
        }        
        //
        private void btnLoadPic_Click(object sender, EventArgs e)
        {
            try
            {
                string imgLoc = "";
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif|All Files (*.*)|*.*";
                dlg.Title = "Chọn hình ảnh sản phẩm";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    imgLoc = dlg.FileName.ToString();
                    ptbPicture.ImageLocation = imgLoc;
                }
                FileStream fs = new FileStream(imgLoc, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                img = br.ReadBytes((int)fs.Length);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int id = 0;
                ChiTietDepartment c1 = cbChitietDepartment.SelectedItem as ChiTietDepartment;
                id = c1.Id;
                int x;
                string sql = "";
                string gia = txtPrice.Text.Replace(",", "");
                //
                sql = "insert into Product (name, price,idVitri,outlook) values(N'" + txtNameProduct.Text + "'," + gia + "," + id + ", @img )";
                x = DataProvider.Instance.ENQ_ForPicture(sql, img);

                MessageBox.Show(x.ToString() + " sản phẩm đã được thêm.");
                txtNameProduct.Text = "";
                txtPrice.Text = "";
                cbDepartnamt.SelectedItem = null;cbChitietDepartment.SelectedItem = null;
                ptbPicture.ImageLocation = DuongDanNoProduct;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            if (txtPrice.Text != "")
            {
                CultureInfo culture = new CultureInfo("en-US");
                int value = Int32.Parse(txtPrice.Text, NumberStyles.AllowThousands);
                txtPrice.Text = string.Format(culture, "{0:N0}", value);
                txtPrice.Select(txtPrice.Text.Length, 0);
            }
        }
    }    
}
