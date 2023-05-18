using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class DangKy : Form
    {
        BUS_ACCOUNT a;
        public DangKy()
        {
            InitializeComponent();
        }
        
        // check account
        public bool checkAccount(string a)
        {
            return Regex.IsMatch(a, "^[a-zA-Z0-9]{6,24}");
        }

        // check email
        public bool checkEmail(string e)
        {
            return Regex.IsMatch(e, "^[a-zA-z0-9_.]{3,20}@gmail.com(.vn|)$");
        }
        
        // event btnOk
        private void btnOk_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string pass = txtPass.Text;
            string conPass = txtConfirm.Text;
            string email = txtEmail.Text;
            a = new BUS_ACCOUNT();
            // check username
            if (!checkAccount(username)) { MessageBox.Show("Vui lòng nhập tên tài khoản 6-24 ký tự,với các ký tự chữ,số,chữ hoa và chữ thường!");return;}
            // check pass
            if (!checkAccount(pass)) { MessageBox.Show("Vui lòng nhập mật khẩu 6-24 ký tự,với các ký tự chữ,số,chữ hoa và chữ thường!"); return; }
            // check confirm
            if (pass != conPass) { MessageBox.Show("Mật khẩu không khớp!"); return; }
            //check email
            if (!checkEmail(email)) { MessageBox.Show("Vui lòng nhập đúng định dạng!"); return; }
            if(a.getByUserName(username).Rows.Count > 0)
            {
                MessageBox.Show("Tên đăng nhập đã tồn tại!");
            }
            else
            {
                if(a.add(username, pass, email))
                {
                    MessageBox.Show("Tạo tài khoản thành công!","Thông báo");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Tạo tài khoản thất bại", "Thất Bại");
                }
                
            }
        }
    }
}
