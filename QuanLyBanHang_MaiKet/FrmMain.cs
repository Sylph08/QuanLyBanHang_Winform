using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang_MaiKet
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            Form f = new AddProduct();
            f.ShowDialog();
        }

        private void btnSearchProduct_Click(object sender, EventArgs e)
        {
            Form f = new SearchProduct();
            f.ShowDialog();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn thoát không?","Thông báo",MessageBoxButtons.OKCancel)!=DialogResult.OK)
            {
                e.Cancel = true;
            }
                
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                FrmTinhToan f = new FrmTinhToan();
                string sobitru = txtCustomerMoney.Text.Replace(",", "");
                string sotru=txtProductValue.Text.Replace(",", "");
                
                f.TienKhachDua = Convert.ToInt32(sobitru);
                f.TienHang = Convert.ToInt32(sotru);
                f.Show();
                txtProductValue.Text = "";
                txtCustomerMoney.Text = "";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }            
        }      

        private void txtProductValue_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                Process.Start("calc.exe");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCreateBill_Click(object sender, EventArgs e)
        {
            Form f = new FrmBill();
            f.Show();
        }
        //thêm dấu , cho hàng nghìn
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
        private void txtCustomerMoney_TextChanged(object sender, EventArgs e)
        {
            DinhDangChoTextboxSo(txtCustomerMoney);
        }

        private void txtProductValue_TextChanged(object sender, EventArgs e)
        {
            DinhDangChoTextboxSo(txtProductValue);
        }

        private void btnListBill_Click(object sender, EventArgs e)
        {
            Form f = new FrmListBill();
            f.Show();
        }

        private void btnNoTien_Click(object sender, EventArgs e)
        {
            Form f = new FrmNoTien();
            f.Show();
        }
        void HienThiTheoViTri(string sql)
        {
            DataTable table = DataProvider.Instance.ExecuteQuery(sql);
            FrmShowProductDetail f = new FrmShowProductDetail();
            f.TableSent = table;
            f.Show();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            string sql = "select * from Product where idvitri= 3";
            HienThiTheoViTri(sql);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string sql = "select * from Product where idvitri= 2";
            HienThiTheoViTri(sql);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sql = "select * from Product where idvitri= 1";
            HienThiTheoViTri(sql);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            string sql = "select * from Product where idvitri= 6";
            HienThiTheoViTri(sql);
        }

        private void button29_Click(object sender, EventArgs e)
        {
            string sql = "select * from Product where idvitri= 4";
            HienThiTheoViTri(sql);
        }

        private void button28_Click(object sender, EventArgs e)
        {
            string sql = "select * from Product where idvitri= 5";
            HienThiTheoViTri(sql);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            string sql = "select * from Product where idvitri= 10";
            HienThiTheoViTri(sql);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            string sql = "select * from Product where idvitri= 11";
            HienThiTheoViTri(sql);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string sql = "select * from Product where idvitri= 12";
            HienThiTheoViTri(sql);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            string sql = "select * from Product where idvitri= 7";
            HienThiTheoViTri(sql);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            string sql = "select * from Product where idvitri= 8";
            HienThiTheoViTri(sql);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            string sql = "select * from Product where idvitri= 9";
            HienThiTheoViTri(sql);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string sql = "select * from Product where idvitri= 13";
            HienThiTheoViTri(sql);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string sql = "select * from Product where idvitri= 14";
            HienThiTheoViTri(sql);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string sql = "select * from Product where idvitri= 15";
            HienThiTheoViTri(sql);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            string sql = "select * from Product where idvitri= 17";
            HienThiTheoViTri(sql);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            string sql = "select * from Product where idvitri= 18";
            HienThiTheoViTri(sql);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            string sql = "select * from Product where idvitri= 19";
            HienThiTheoViTri(sql);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            string sql = "select * from Product where idvitri= 20";
            HienThiTheoViTri(sql);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            string sql = "select * from Product where idvitri= 21";
            HienThiTheoViTri(sql);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string sql = "select * from Product where idvitri= 22";
            HienThiTheoViTri(sql);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            string sql = "select * from Product where idvitri= 24";
            HienThiTheoViTri(sql);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            string sql = "select * from Product where idvitri= 23";
            HienThiTheoViTri(sql);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            string sql = "select * from Product where idvitri= 25";
            HienThiTheoViTri(sql);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "select * from Product where idvitri= 16";
            HienThiTheoViTri(sql);
        }
    }
}
