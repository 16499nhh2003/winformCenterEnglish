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
using TTNL;

namespace GUI
{
    public partial class LopHoc : Form
    {
        DTO_LopHoc_1 lopHoc = new DTO_LopHoc_1();
        List<DTO_Part_KhoaHoc> listPKh = new List<DTO_Part_KhoaHoc>();
        List<DTO_Part_PhongHoc> listPPh = new List<DTO_Part_PhongHoc> { };
        BUS_LopHoc_1 busLh = new BUS_LopHoc_1();
        string idSelected;
        private static LopHoc uniqueLopHoc = null;
        public LopHoc()
        {
            InitializeComponent();
        }
        public static LopHoc getUnique()
        {
            if(uniqueLopHoc == null || uniqueLopHoc.IsDisposed)
            {
                uniqueLopHoc = new LopHoc();
            }
            return uniqueLopHoc;
        }
        private void LopHoc_Load(object sender, EventArgs e)
        {
            firstLoad();
        }

        private void firstLoad()
        {
            lopHoc.TinhTrang = "1";
            maLopHocTxb.Text = busLh.idLopHoc();
            listPKh = busLh.getListKhoaHoc();
            maKhoaHocCbb.DataSource = listPKh;
            maKhoaHocCbb.DisplayMember = "tenKhoaHoc";
            listPPh = busLh.getListPhongHoc();
            maPhongHocCbb.DataSource = listPPh;
            maPhongHocCbb.DisplayMember = "tenPhongHoc";
            setTinhTrang();
            loadListView();
            XoaBtn.Enabled = false;
            BoChonBtn.Enabled = false;
            hocVienBtn.Enabled = false;
        }

        private void clearForm()
        {
            foreach(Control item in lopHocPnl.Controls)
            {
                if(item is TextBox)
                {
                    ((TextBox)item).Text = string.Empty;
                }
                else if(item is ComboBox)
                {
                    ((ComboBox)item).SelectedIndex = 0;
                }
            }
            maLopHocTxb.Text = busLh.idLopHoc();
            lopHocLv.SelectedItems.Clear();
            NotFullRBtn.Checked= true;
            FullRBtn.Checked = false;
        }
        private void loadListView()
        {
            lopHocLv.Items.Clear();
            DataTable dt = busLh.selectData();
            if(dt.Rows.Count > 0)
            {
                foreach(DataRow dr in dt.Rows)
                {
                    ListViewItem lI = new ListViewItem(dr["id"].ToString());
                    lopHocLv.Items.Add(lI);
                    lI.SubItems.Add(dr["tenLopHoc"].ToString());
                    lI.SubItems.Add(dr["idKhoaHoc"].ToString());
                    lI.SubItems.Add(dr["idGiangVien"].ToString());
                    lI.SubItems.Add(dr["idNhanVien"].ToString());
                    lI.SubItems.Add(dr["idPhongHoc"].ToString());
                    lI.SubItems.Add(dr["tinhtrang"].ToString());
                }
            }
        }
        private void maLopHocTxb_TextChanged(object sender, EventArgs e)
        {
            lopHoc.IdLopHoc = maLopHocTxb.Text;
        }

        private void tenLopHocTxb_TextChanged(object sender, EventArgs e)
        {
            lopHoc.TenLopHoc = tenLopHocTxb.Text;   
        }

        private void maGiaoVienTxb_TextChanged(object sender, EventArgs e)
        {
            lopHoc.IdGiangVien = maGiaoVienTxb.Text;
        }

        private void maTroGiangTxb_TextChanged(object sender, EventArgs e)
        {
            lopHoc.IdTroGiang = maTroGiangTxb.Text;
        }

        private void maKhoaHocCbb_SelectedIndexChanged(object sender, EventArgs e)
        {
            lopHoc.IdKhoaHoc = (maKhoaHocCbb.SelectedValue as DTO_Part_KhoaHoc).Id;
        }

        private void maPhongHocCbb_SelectedIndexChanged(object sender, EventArgs e)
        {
            lopHoc.IdPhongHoc = (maPhongHocCbb.SelectedValue as DTO_Part_PhongHoc).Id;
        }

        private void trangThaiPnl_Paint(object sender, PaintEventArgs e)
        {
            if (lopHoc.TinhTrang.CompareTo("1") == 0)
            {
                NotFullRBtn.Checked = true;
            }
            else
            {
                FullRBtn.Checked = true;
            }
            
        }

        private void setTinhTrang()
        {
            foreach(Control item in trangThaiPnl.Controls)
            {
                if(item is RadioButton)
                {
                    RadioButton rbtn = (RadioButton)item;
                    if(rbtn.Checked == true)
                    {
                        if (rbtn == NotFullRBtn)
                            lopHoc.TinhTrang = "1";
                        else if (rbtn == FullRBtn)
                            lopHoc.TinhTrang = "0";
                    }
                }
            }
        }
        private void lopHocLv_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lopHocLv.SelectedItems.Count > 0)
            {
                idSelected = lopHocLv.SelectedItems[0].SubItems[0].Text;
                if (!string.IsNullOrEmpty(idSelected))
                {
                    try
                    {
                        selectLop();
                    }
                    catch(Exception ex) { MessageBox.Show(ex.Message); }
                    
                    ThemBtn.Enabled = false;
                    XoaBtn.Enabled = true;
                    BoChonBtn.Enabled = true;
                    SuaBtn.Enabled = true;
                    hocVienBtn.Enabled = true;
                }
                else
                    XoaBtn.Enabled = false;
            }
            else { }
        }
        private void ThemBtn_Click(object sender, EventArgs e)
        {
            //setTinhTrang();
            string errorMsg = busLh.errorCheck(lopHoc);
            if(errorMsg.CompareTo("Success") != 0)
            {
                MessageBox.Show(errorMsg);
            }
            else
            {
                busLh.insertData(lopHoc);
                MessageBox.Show("Thêm thành công");
                loadListView();
                clearForm();
            }
        }

        private void SuaBtn_Click(object sender, EventArgs e)
        {

        }

        private void XoaBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(idSelected))
            {
                DialogResult dialog = MessageBox.Show("Bạn có muốn xóa không ??", "Thông báo xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    busLh.deleteData(idSelected);
                    MessageBox.Show("Xóa thành công");
                    loadListView();
                }
            }
        }
        private void selectLop()
        {
            
            DTO_LopHoc_1 lhSelected = busLh.selectLop(idSelected);
            if (lhSelected != null)
            {
                maLopHocTxb.Text = lhSelected.IdLopHoc;
                if(!string.IsNullOrEmpty(lhSelected.IdGiangVien)) 
                    maGiaoVienTxb.Text = lhSelected.IdGiangVien;
                if(!string.IsNullOrEmpty(lhSelected.IdKhoaHoc))
                    maKhoaHocCbb.Text = lhSelected.IdKhoaHoc;
                if (!string.IsNullOrEmpty(lhSelected.IdTroGiang))
                    maTroGiangTxb.Text = lhSelected.IdTroGiang;
                else
                    maTroGiangTxb.Text = "";
                tenLopHocTxb.Text = lhSelected.TenLopHoc;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(lopHoc.IdLopHoc);
        }

        private void BoChonBtn_Click(object sender, EventArgs e)
        {
            ThemBtn.Enabled = true;
            SuaBtn.Enabled = false;
            XoaBtn.Enabled = false;
            clearForm();
            BoChonBtn.Enabled = false;
            hocVienBtn.Enabled = false;
        }

        private void hocVienBtn_Click(object sender, EventArgs e)
        {
            QuanLyChiTietLopHoc q = new QuanLyChiTietLopHoc();
            q.IdLophoc = lopHoc.IdLopHoc;
            q.Show();
        }

        private void lopHocLv_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void lopHocPnl_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
