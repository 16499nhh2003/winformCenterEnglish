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
    public partial class DoiMatKhau : Form
    {
        BUS_ACCOUNT a;
        private string _mess;
        public DoiMatKhau()
        {
            InitializeComponent();
        }

        public DoiMatKhau(string mess):this()
        {
            _mess = mess;
            lb.Text = _mess;
        }

        // Handle event btn Update
        private void btOk_Click(object sender, EventArgs e)
        {
            string username = lb.Text;
            string passold = txtold.Text;
            string passnew = txtnew.Text;   
            string passconfirm = txtconfirm.Text;
            if(passold == passnew)
            {
                MessageBox.Show("Mật Khẩu cũ và mới đã bị trùng nhau");return;
            }
            if(passconfirm != passnew)
            {
                MessageBox.Show("Xác nhận mật khẩu không khớp ");return;
            }
            a = new BUS_ACCOUNT();
            if(a.updatePass(username,passold,passnew))
            {
                MessageBox.Show("Đổi mật khẩu thành công");
                txtold.Clear();
                txtnew.Clear();
                txtconfirm.Clear();
            }
            else
            {
                MessageBox.Show("Đổi mật khẩu thất bại!");
            }
        }

        private void DoiMatKhau_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
