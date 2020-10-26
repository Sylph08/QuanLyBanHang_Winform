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
    public partial class FrmTinhToan : Form
    {
        public FrmTinhToan()
        {
            InitializeComponent();
        }
        private int tienKhachDua;
        private int tienHang;

        public int TienKhachDua { get => tienKhachDua; set => tienKhachDua = value; }
        public int TienHang { get => tienHang; set => tienHang = value; }

        private void FrmTinhToan_Load(object sender, EventArgs e)
        {
            txtChange.Text = (tienKhachDua - tienHang).ToString();
            //
            CultureInfo culture = new CultureInfo("en-US");
            int value = int.Parse(txtChange.Text, NumberStyles.AllowThousands);
            txtChange.Text = string.Format(culture, "{0:N0}", value);
            txtChange.Select(txtChange.Text.Length, 0);
            //
            QuyDoi(tienKhachDua - tienHang);
            //doi mau textbox
            DoiMauTextBox();
            //foreach (Control item in this.grbQuydoi.Controls)
            //{
            //    if (item is TextBox)
            //    {
            //        TextBox tb = item as TextBox;
            //        if (tb.Text != "0")
            //            tb.BackColor = Color.Blue;
            //    }
                    
            //}
        }
        void DoiMauTextBox()
        {
            if (txt500.Text != "0") { txt500.BackColor = Color.Blue; txt500.ForeColor = Color.White; }
            if (txt200.Text != "0") { txt200.BackColor = Color.Blue; txt200.ForeColor = Color.White; }
            if (txt100.Text != "0") { txt100.BackColor = Color.Blue; txt100.ForeColor = Color.White; }
            if (txt50.Text != "0") { txt50.BackColor = Color.Blue; txt50.ForeColor = Color.White; }
            if (txt20.Text != "0") { txt20.BackColor = Color.Blue; txt20.ForeColor = Color.White; }
            if (txt10.Text != "0") { txt10.BackColor = Color.Blue; txt10.ForeColor = Color.White; }
            if (txt5.Text != "0") { txt5.BackColor = Color.Blue; txt5.ForeColor = Color.White; }
            if (txt2.Text != "0") { txt2.BackColor = Color.Blue; txt2.ForeColor = Color.White; }
            if (txt1.Text != "0") { txt1.BackColor = Color.Blue; txt1.ForeColor = Color.White; }
        }
        private void QuyDoi(int a)
        {
            int[] m = new int[9] { 500000, 200000, 100000, 50000, 20000, 10000, 5000, 2000, 1000};
            int[] soto = new int[9] { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            for(int i=0;i<9;i++)
            {
                while(a>=m[i])
                {
                    a -= m[i];
                    soto[i] = soto[i] + 1;
                }
                if (a > 0 && a < m[i]) continue;
                if (a == 0) break;
            }
            txt500.Text = soto[0].ToString();
            txt200.Text = soto[1].ToString();
            txt100.Text = soto[2].ToString();
            txt50.Text = soto[3].ToString();
            txt20.Text = soto[4].ToString();
            txt10.Text = soto[5].ToString();
            txt5.Text = soto[6].ToString();
            txt2.Text = soto[7].ToString();
            txt1.Text = soto[8].ToString();
        }

    }
}
