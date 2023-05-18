using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class ThanhToanOffiline : Form
    {
        private double _sotiencanthanhtoan;

        public ThanhToanOffiline()
        {
            InitializeComponent();
        }
        public ThanhToanOffiline(double sotiencanthanhtoan):this()
        {
            _sotiencanthanhtoan = sotiencanthanhtoan;
            label4.Text = "";
            label4.Text = _sotiencanthanhtoan.ToString();
        }

        private void ThanhToanOffiline_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Report rp = new Report(label4.Text, txtSotien.Text);
            rp.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
