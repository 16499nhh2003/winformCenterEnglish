using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TTNL;

namespace GUI
{
    public partial class QuanLyNhanVien : Form
    {
        public QuanLyNhanVien()
        {
            InitializeComponent();
        }
        public string Id;
        string TenNhanVien;
        string Sdt;
        string Email;
        string NgaySinh;
        int GioiTinh;
        string ChucVu;
        int hanhDongQly;
        public int HanhDong { get { return hanhDongQly; } set { hanhDongQly = value;} }
        BUS_NhanVien bus_Nv = new BUS_NhanVien();
        BUS_ChucVu bus_CV = new BUS_ChucVu();
        List<ChucVu> chucVuList = new List<ChucVu>();
        public string IdNhanVien { get { return Id; } set { Id = value; } }
        private void button1_Click(object sender, EventArgs e)
        {
            DTO_NhanVien dto_Nv = new DTO_NhanVien(TenNhanVien, GioiTinh, Sdt, NgaySinh, Email, ChucVu);
            string errorMsg = bus_Nv.checkData(dto_Nv);
            if (!string.IsNullOrEmpty(errorMsg))
            {
                MessageBox.Show(errorMsg);
            }
            else
            {
                if (pictureBox.Image != null && pictureBox.ImageLocation.Length > 0)
                {
                    string folderPath = Path.GetDirectoryName(pictureBox.ImageLocation);
                    string fileName = Path.GetFileName(pictureBox.ImageLocation);
                    string maAnh = getNameImage();
                    dto_Nv.MaAnh = getNameImage();
                    if (!bus_Nv.checkMaAnh(maAnh))
                    {
                        bus_Nv.insertAnh(maAnh, folderPath, fileName);
                    }
                }
                getData();
                bus_Nv.insertData(dto_Nv);
                MessageBox.Show("Thêm thành công");
                NhanVien.getInstance().Show();
                NhanVien.getInstance().reloadDataGridView();
                this.Dispose();
            }
        }

        private void LoadChucVu()
        {
            chucVuList = bus_CV.getListChucVu();
            comboBox.DataSource = chucVuList;
            comboBox.DisplayMember = "Name";
        }

        private void QuanLyNhanVien_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            TenNvTxb.TabStop = false;
            ThemBtn.Enabled = false;
            SuaBtn.Enabled = false;
            XoaBtn.Enabled = false;
            ReloadBtn.Enabled = false;
            LoadChucVu(); 
            GioiTinh = 1;
            NgaySinh = dateTimePicker.Value.ToString("MM/dd/yyyy");
            if (hanhDongQly == 1)
            {
                loadData();
                loadImage();
            }
        }
        private void getData()
        {
            Id = MaNvTxb.Text.ToString();
            TenNhanVien = TenNvTxb.Text.ToString();
            Sdt = SdtNvTxb.Text.ToString();
            Email = EmailNvTxb.Text.ToString();
            NgaySinh = dateTimePicker.Value.ToString("MM/dd/yyyy");
            if(comboBox.Items.Count > 0 )
            {
                ChucVu = (comboBox.SelectedValue as ChucVu).Name.ToString();
            }
            setGioiTinh();
        }
        public Button getThemButton()
        {
            return ThemBtn;
        }

        public Button getXoaButton()
        {
            return XoaBtn;
        }

        public Button getSuaButton() {
            return SuaBtn;
        }

        public Button getReloadBtn()
        {
            return ReloadBtn;
        }
        public TextBox getMaNhanVienTextBox()
        {
            return MaNvTxb;
        }
        private void MaNvTxb_TextChanged(object sender, EventArgs e)
        {
            Id = MaNvTxb.Text.ToString();
        }

        private void TenNvTxb_TextChanged(object sender, EventArgs e)
        {
            TenNhanVien = TenNvTxb.Text.ToString();
        }

        private void SdtNvTxb_TextChanged(object sender, EventArgs e)
        {
            Sdt = SdtNvTxb.Text.ToString();
        }

        private void EmailNvTxb_TextChanged(object sender, EventArgs e)
        {
            Email = EmailNvTxb.Text.ToString();
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            NgaySinh = dateTimePicker.Value.ToString("MM/dd/yyyy");
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChucVu = (comboBox.SelectedValue as ChucVu).Name.ToString();
        }


        private void setGioiTinh()
        {
            foreach(Control control in panel.Controls)
            {
                if(control is RadioButton rbtn && rbtn.Checked == true)
                {
                    string str = rbtn.Text.ToString();
                    if(str.CompareTo("Nam") == 0)
                    {
                        GioiTinh = 1;
                    }
                    else
                    {
                        GioiTinh = 0;
                    }
                }
            }
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            OpenFileDialog opD = new OpenFileDialog();
            opD.Filter = "Image Files (*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (opD.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Image selectedImage = Image.FromFile(opD.FileName);
                    pictureBox.Image = selectedImage;
                    pictureBox.ImageLocation =  opD.FileName.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading image: " + ex.Message);
                }
            }
        }
        private string getNameImage()
        {
            string fileName = "";
            string name = "";
            if (!string.IsNullOrEmpty(Path.GetFileName(pictureBox.ImageLocation.ToString())))
            {
                fileName = Path.GetFileName(pictureBox.ImageLocation.ToString());
            }
            if (fileName.Length > 0)
            {
                char[] charArr = fileName.ToCharArray();
                for(int i = 0; i < charArr.Length; i++)
                {
                    if (charArr[i] == '.')
                    {
                        break;
                    }
                    name = name + charArr[i];
                }
            }
            return name;
        }
        private void loadDataInForm()
        {
            
            DTO_NhanVien nv = bus_Nv.getDataBaseOnId(Id);
            if (nv != null)
            {
                TenNvTxb.Text = nv.TenNhanVien;
                SdtNvTxb.Text = nv.Sdt;
                EmailNvTxb.Text = nv.Email;
                dateTimePicker.Value = Convert.ToDateTime(nv.NgaySinh);
                if (nv.GioiTinh == 0)
                {
                    NuRb.Checked = true;
                }
                comboBox.Text = nv.ChucVu;
            }
        }

        private void loadData()
        {
            if(HanhDong == 1)
            {
                loadDataInForm();
            }
        }

        private void loadImage()
        {
            string maAnh = bus_Nv.getMaAnh(Id);
            if (!string.IsNullOrEmpty(maAnh))
            {
                byte[] imageData = bus_Nv.getAnh(maAnh);
                MemoryStream ms = new MemoryStream(imageData);
                pictureBox.Image = Image.FromStream(ms);
                pictureBox.ImageLocation = bus_Nv.getDuongDan(maAnh);
            }
        }

        private void XoaBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Id))
            {
                DialogResult result;
                result = MessageBox.Show("Bạn có muốn xóa không ?","Xóa nhân viên",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if(result == DialogResult.Yes)
                {
                    bus_Nv.deleteData(Id);
                    MessageBox.Show("Xóa thành công");
                    this.Dispose();
                    NhanVien.getInstance().Show();
                    NhanVien.getInstance().reloadDataGridView();
                }
            }
        }

        private void clearForm()
        {
            foreach(Control item in this.Controls)
            {
                if(item is TextBox textbox)
                {
                    textbox.Clear();
                }
                else if(item is ComboBox combobox)
                {
                    comboBox.SelectedIndex = 0;
                }
                else if(item is DateTimePicker dtp)
                {
                    dtp.Value = DateTime.Now;   
                }
            }
            NameRb.Checked = true;
        }
        private void ReloadBtn_Click(object sender, EventArgs e)
        {
            clearForm();
            MaNvTxb.Text = bus_Nv.futureId();
        }

        private DTO_NhanVien getNv()
        {
            DTO_NhanVien nv = new DTO_NhanVien(TenNhanVien, GioiTinh, Sdt, NgaySinh, Email, ChucVu);
            nv.Id = Id;
            return nv;
        }
        private void SuaBtn_Click(object sender, EventArgs e)
        {
            DTO_NhanVien dto_Nv = getNv();
            string errorMsg = bus_Nv.checkData(dto_Nv);
            if (!string.IsNullOrEmpty(errorMsg))
            {
                MessageBox.Show(errorMsg);
            }
            else
            {
                if (pictureBox.Image != null && pictureBox.ImageLocation.Length > 0)
                {
                    string folderPath = Path.GetDirectoryName(pictureBox.ImageLocation);
                    string fileName = Path.GetFileName(pictureBox.ImageLocation);
                    string maAnh = getNameImage();
                    dto_Nv.MaAnh = getNameImage();
                    if (!bus_Nv.checkMaAnh(maAnh))
                    {
                        bus_Nv.insertAnh(maAnh, folderPath, fileName);
                    }
                }
                getData();
                bus_Nv.updateData(dto_Nv);
                MessageBox.Show("Sửa thành công");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NhanVien.getInstance().Show();
            NhanVien.getInstance().reloadDataGridView();
            this.Dispose();
        }
    }
}
