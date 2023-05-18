using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class DoanhThu : Form
    {
        BUS_KHOAHOC kh;
        public DoanhThu()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            kh = new BUS_KHOAHOC();
            dataGridView1.DataSource = kh.PS_ShowDoanhThu(dtp1.Value, dtp2.Value);
            string doanhthu = kh.PS_DOANHTHU(dtp1.Value, dtp2.Value).Rows[0][0].ToString();
            CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");   // try with "en-US"
            string a = double.Parse(doanhthu.ToString()).ToString("#,###", cul.NumberFormat);
            lbDoanhThu.Text = "";
            lbDoanhThu.Text = a;
        }

        private void DoanhThu_Load(object sender, EventArgs e)
        {

        }
    }
}
