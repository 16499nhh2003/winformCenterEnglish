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
    public partial class Home : Form
    {
        private string _username;
        private Form currentFormChild;
        private void OpenChildForm(Form children)
        {
            if(currentFormChild!= null)
            {
                currentFormChild.Close();
            }
            currentFormChild = children;
            children.TopLevel = false;
            children.FormBorderStyle = FormBorderStyle.None;    
            children.Dock = DockStyle.Fill;
            panel3.Controls.Add(children);
            panel3.Tag = children;
            children.BringToFront();
            children.Show();
        }
        public Home()
        {
            InitializeComponent();
        }
        public Home(string username):this()
        {
            _username = username;
            label3.Text = _username;
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn đăng xuất không?","Thông báo", MessageBoxButtons.YesNo,MessageBoxIcon.Information)==DialogResult.Yes)
            {
                this.Hide();
                DangNhap a = new DangNhap();
                a.ShowDialog();
            }
        }

        private void danhMụcToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DoiMatKhau(label3.Text));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new NhanVien());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DangKiKhoaHoc());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QuanLyKhoaHoc());

        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QuanLyHocVien());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new LopHoc());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QuanLyGiaoVien());

        }

        private void button8_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DoanhThu());
        }

        private void button9_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QuanLyPhongHoc());

        }
    }
}
