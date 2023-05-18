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
using System.Windows.Media.Imaging;

namespace GUI
{
    public partial class Report : Form
    {
        private string _a;
        private string _b;
        public Report()
        {
            InitializeComponent();
        }
        public Report(string a,string b):this()
        {
            _a = a;
            label5.Text = "";
            label6.Text = ""; 
            _b = b;
            label6.Text = _b;
            label5.Text = _a;
        }
        private void Report_Load(object sender, EventArgs e)
        {
            float tongtien = float.Parse(label5.Text);
            float tienkhachdua = float.Parse(label6.Text);
            double tienthoi = tienkhachdua - tongtien;
            CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");   // try with "en-US"
            string a = double.Parse(tienthoi.ToString()).ToString("#,###", cul.NumberFormat);
            label7.Text = "";
            label7.Text = a;
        }

        Bitmap bmp;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }

        private void Report_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            bmp = new Bitmap(this.Size.Width, this.Size.Height, g);
            Graphics mg = Graphics.FromImage(bmp);
            mg.CopyFromScreen(this.Location.X, this.Location.Y,20,20, this.Size);
            printPreviewDialog1.ShowDialog();
        }
    }
}
