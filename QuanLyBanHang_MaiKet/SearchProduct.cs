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

namespace QuanLyBanHang_MaiKet
{
    public partial class SearchProduct : Form
    {
        public SearchProduct()
        {
            InitializeComponent();
            LoadDepartment();            
        }
        void DisableAllContentOfRadioButton()
        {
            txtSearchByID.Enabled = false;
            txtSearchByID.Text = "";
            txtSearchByName.Enabled = false;
            txtSearchByName.Text = "";
            cbDepartment.Enabled = false; cbChitietDepartment.Enabled = false;
            cbDepartment.SelectedItem = null;cbChitietDepartment.SelectedItem = null;
            txtSearchByPrice.Enabled = false;
            txtSearchByPrice.Text = "";
        }
        void LoadDepartment()
        {
            List<Department> list = DepartmentDAO.Instance.GetDepartments();
            cbDepartment.DataSource = list;
            cbDepartment.DisplayMember = "location";
        }
        void LoadChitietDepartmentByidDep(int idDep)
        {
            List<ChiTietDepartment> list = ChiTietDepartmentDAO.Instance.GetChiTietDepartments(idDep);
            cbChitietDepartment.DataSource = list;
            cbChitietDepartment.DisplayMember = "diachichitiet";
        }
        private void cbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null) return;
            Department slt = cb.SelectedItem as Department;
            id = slt.IdDep;
            LoadChitietDepartmentByidDep(id);
        }

        private void rdbID_CheckedChanged(object sender, EventArgs e)
        {
            DisableAllContentOfRadioButton();
            txtSearchByID.Enabled = true;
        }

        private void rdbLoacation_CheckedChanged(object sender, EventArgs e)
        {
            DisableAllContentOfRadioButton();
            cbDepartment.Enabled = true; cbChitietDepartment.Enabled = true;
        }

        private void rdbName_CheckedChanged(object sender, EventArgs e)
        {
            DisableAllContentOfRadioButton();
            txtSearchByName.Enabled = true;
        }

        private void rdbPrice_CheckedChanged(object sender, EventArgs e)
        {
            DisableAllContentOfRadioButton();
            txtSearchByPrice.Enabled = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string query = "";
            //
            if(rdbID.Checked==true)
            {
                query = "select * from Product where idPro =" + txtSearchByID.Text.ToString();
            }
            if (rdbName.Checked == true)
            {
                query = "select * from Product where name like '%" + txtSearchByName.Text + "%'";
            }
            if (rdbLoacation.Checked == true)
            {
                query = "select * from Product where idVitri =" + (cbChitietDepartment.SelectedItem as ChiTietDepartment).Id.ToString();
            }
            if (rdbPrice.Checked == true)
            {
                string gia = txtSearchByPrice.Text.Replace(",", "");
                query = "select * from Product where price =" + gia;
            }
            //
            
                DataTable table = DataProvider.Instance.ExecuteQuery(query);                
                if (table.Rows.Count == 0)
                {
                    MessageBox.Show("Sản phẩm không tồn tại.");
                }
                else
                {
                    FrmShowProductDetail f = new FrmShowProductDetail();
                    f.TableSent = table;
                    f.ShowDialog();
                }
                  
        }

        private void btnShowAllPro_Click(object sender, EventArgs e)
        {
            string sql = "select * from product";
            DataTable table = DataProvider.Instance.ExecuteQuery(sql);
            FrmShowProductDetail f = new FrmShowProductDetail();
            f.TableSent = table;
            f.ShowDialog();
        }

        private void txtSearchByPrice_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchByPrice.Text != "")
            {
                CultureInfo culture = new CultureInfo("en-US");
                int value = Int32.Parse(txtSearchByPrice.Text, NumberStyles.AllowThousands);
                txtSearchByPrice.Text = string.Format(culture, "{0:N0}", value);
                txtSearchByPrice.Select(txtSearchByPrice.Text.Length, 0);
            }
        }
    }
}
