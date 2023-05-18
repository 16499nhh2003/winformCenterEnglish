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
    public partial class DangNhap : Form
    {
        BUS_ACCOUNT acc;
        public DangNhap()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text; 
            string pass = txtUserPass.Text;
            //MessageBox.Show(username, pass);
            acc = new BUS_ACCOUNT();
            if (String.IsNullOrEmpty(username)) { MessageBox.Show("Vui lòng nhập tên tài khoản!");return;}
            if (String.IsNullOrEmpty(pass)) { MessageBox.Show("Vui lòng nhập mật khẩu!"); return;}
            else
            {
                if(acc.checkLogin(username,pass).Count > 0)
                {
                    MessageBox.Show("Đăng nhập thành công");
                    this.Hide();    
                    Home home = new Home(txtUserName.Text); 
                    home.ShowDialog();
                    this.Close();   
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại!!!");
                    txtUserPass.Clear();
                    txtUserName.Focus();
                }
            }

        }

        private void linkLabel1_QuenMatKhau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            QuenMatKhau a = new QuenMatKhau();
            a.ShowDialog();
        }

        private void linkLabel2_DangKi_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DangKy a = new DangKy();    
            a.ShowDialog();
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
