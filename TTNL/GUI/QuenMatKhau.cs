using BUS;
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
    public partial class QuenMatKhau : Form
    {
        BUS_ACCOUNT a;
        public QuenMatKhau()
        {
            InitializeComponent();
        }

        private void btnGetPass_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;   
            a = new BUS_ACCOUNT();
            if (a.getPassWord(email).Rows.Count > 0)
            {
                label3.ForeColor = Color.Red;
                label3.Text = "Mật khẩu:" + a.getPassWord(email).Rows[0]["matKhau"].ToString(); 
            }
            else
            {
                label3.ForeColor = Color.Red;
                label3.Text = "Không tồn tại tài khoản!";
            }
        }
    }
}
