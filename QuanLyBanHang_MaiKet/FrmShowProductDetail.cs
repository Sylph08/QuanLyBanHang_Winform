using QuanLyBanHang_MaiKet.DAO;
using QuanLyBanHang_MaiKet.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang_MaiKet
{
    public partial class FrmShowProductDetail : Form
    {
        private DataTable tableSent;
        
        public FrmShowProductDetail()
        {
            InitializeComponent();            
        }

        private void LoadDepartment()
        {
            List<Department> list = DepartmentDAO.Instance.GetDepartments();
            cbDepartment.DataSource = list;
            cbDepartment.DisplayMember = "location";
            cbDepartment.ValueMember = "iddep";
        }
        void LoadChitietDepartment(int id)
        {            
            List<ChiTietDepartment> list = ChiTietDepartmentDAO.Instance.GetChiTietDepartments(id);
            cbChitietDepartment.DataSource = list;
            cbChitietDepartment.DisplayMember = "diachichitiet";
            cbChitietDepartment.ValueMember = "id";
        }
        
        public DataTable TableSent { get => tableSent; set => tableSent = value; }
        //
        private byte[] imgTemp = null;
        string DuongDanNoProduct = Application.StartupPath + @"\Images\NoProduct.png";
        //
        private void FrmShowProductDetail_Load(object sender, EventArgs e)
        {
            LoadDataWithQueryString();
            FileStream fs = new FileStream(DuongDanNoProduct, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            imgTemp = br.ReadBytes((int)fs.Length);
        }
        void HienthiDulieuDataGridview(DataTable table)
        {
            txtIDPro.DataBindings.Clear();
            txtIDPro.DataBindings.Add("Text", grvProduct.DataSource, "idPro");
            txtNamePro.DataBindings.Clear();
            txtNamePro.DataBindings.Add("Text", grvProduct.DataSource, "name");
            txtPricePro.DataBindings.Clear();
            txtPricePro.DataBindings.Add("Text", grvProduct.DataSource, "price");
            //
            txtLocationPro.DataBindings.Clear();
            txtLocationPro.DataBindings.Add("Text", grvProduct.DataSource, "idvitri");
           
            //
            ptbImagePro.DataBindings.Clear();
            ptbImagePro.DataBindings.Add("Image", table, "outlook", true);
        }
        private void LoadDataWithQueryString()
        { 
            grvProduct.DataSource = tableSent;                
            grvProduct.Columns[4].Visible = false;
            grvProduct.Columns[0].HeaderText = "Mã sản phẩm";
            grvProduct.Columns[1].HeaderText = "Tên sản phẩm";
            grvProduct.Columns[2].HeaderText = "Giá sản phẩm";
            grvProduct.Columns[3].HeaderText = "Vị trí sản phẩm";
            HienthiDulieuDataGridview(tableSent);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
                       
        void KichHoatKhiAnBtnSua()
        {
            btnUpdate.Enabled = true;
            btnLoadPic.Enabled = true; btnLoadPic.Visible = true;
            btnXoaAnh.Enabled = true; btnXoaAnh.Visible = true;
            txtNamePro.Enabled = true;
            txtPricePro.Enabled = true;
            cbDepartment.Enabled = true; cbChitietDepartment.Enabled = true;
            LoadDepartment();
            btnSua.Enabled = false;
        }
        void KichHoatKhiAnBtnUpdate()
        {
            btnUpdate.Enabled = false;
            btnLoadPic.Enabled = false; btnLoadPic.Visible = false;
            btnXoaAnh.Enabled = false; btnXoaAnh.Visible = false;
            txtNamePro.Enabled = false;
            txtPricePro.Enabled = false;
            cbDepartment.Enabled = false; cbChitietDepartment.Enabled = false;            
            btnSua.Enabled = true;
        }
        private byte[] img = null;
        private void btnSua_Click(object sender, EventArgs e)
        {
            KichHoatKhiAnBtnSua();
            string sql = "select * from product where idpro=" + txtIDPro.Text;
            List<Product> list = ProductDAO.Instance.GetProductsWithQueryString(sql);
            img = list[0].Outlook;
        }

        private void cbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbDepartment.Enabled==true)
            {
                int id = 0;
                ComboBox cb = sender as ComboBox;
                if (cb.SelectedItem == null) return;
                Department slt = cb.SelectedItem as Department;
                id = slt.IdDep;
                LoadChitietDepartment(id);
            }
            
        }

        private void cbChitietDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbChitietDepartment.Enabled==true)
            {
                txtLocationPro.Text = (cbChitietDepartment.SelectedItem as ChiTietDepartment).Id.ToString();
            }
            
        }
        //
        private void btnLoadPic_Click(object sender, EventArgs e)
        {
            try
            {
                string imgLocation = "";
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif|All Files (*.*)|*.*";
                dlg.Title = "Chọn hình ảnh sản phẩm";
                if(dlg.ShowDialog()==DialogResult.OK)
                {
                    imgLocation = dlg.FileName.ToString();
                    ptbImagePro.ImageLocation = imgLocation;
                }
                FileStream fs = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                img = br.ReadBytes((int)fs.Length);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "update Product set name= N'" + txtNamePro.Text + "', price=" + txtPricePro.Text + ", idvitri=" + txtLocationPro.Text + ", outlook= @para where idpro=" + txtIDPro.Text;
                int x = DataProvider.Instance.ENQ_ForPicture(sql, img);
                MessageBox.Show(x.ToString() + " sản phẩm đã được chỉnh sửa.");
                KichHoatKhiAnBtnUpdate();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtIDPro.Text);
            try
            {
                if(MessageBox.Show("Bạn có muốn xóa không?","Cảnh báo",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
                {
                    grvProduct.Rows.RemoveAt(grvProduct.CurrentCell.RowIndex);
                    //
                    string sql = "delete from product where idpro=" + txtIDPro.Text;
                    int x = DataProvider.Instance.ExecuteNonQuery(sql);
                    MessageBox.Show(x.ToString() + " sản phẩm đã được xóa.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       
        private void grvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            List<ChiTietDepartment> cl = new List<ChiTietDepartment>();
            ChiTietDepartment c1 = ChiTietDepartmentDAO.Instance.GetCTDbyid(Convert.ToInt32(txtLocationPro.Text));
            cl.Add(c1);
            cbChitietDepartment.DataSource = cl;
            cbChitietDepartment.DisplayMember = "diachichitiet";
            cbChitietDepartment.SelectedItem = cl[0];

            //--------------
            List<Department> dl = new List<Department>();
            Department d1 = DepartmentDAO.Instance.GetDepartmentsWithIdOfChitiet(c1.IdDep);
            dl.Add(d1);
            cbDepartment.DataSource = dl;
            cbDepartment.DisplayMember = "location";
            cbDepartment.SelectedItem = dl[0];
        }

        private void btnXoaAnh_Click(object sender, EventArgs e)
        {
            img = imgTemp;
            ptbImagePro.ImageLocation = DuongDanNoProduct;
        }

        private void txtPricePro_TextChanged(object sender, EventArgs e)
        {
            DinhDangChoTextboxSo(txtPricePro);
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
    }
}
