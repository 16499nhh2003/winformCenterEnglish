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
    public partial class NhanVien : Form
    {
        BUS_NhanVien bus_NV = new BUS_NhanVien();
        BUS_ChucVu bus_CV = new BUS_ChucVu();
        List<ChucVu> chucVuList = new List<ChucVu>();
        int rowIndex;
        private static NhanVien instance = null;
        string tenChucVu;
        string gioiTinh;
        string tenNhanVien;
        public NhanVien()
        {
            InitializeComponent();
        }

        public static NhanVien getInstance()
        {
            if(instance == null || instance.IsDisposed)
            {
                instance = new NhanVien();
            }
            return instance;
        }
        private void NhanVien_Load(object sender, EventArgs e)
        {
            dataGridViewSetData();
            NhanViendtgv.ClearSelection();
            LoadChucVu();
            LoadGioiTinh();
            tenChucVu = (PositionCbb.SelectedValue as ChucVu).Name.ToString();
            gioiTinh =(SexCbb.SelectedValue).ToString();
            tenNhanVien = NameTxb.Text.ToString();
            instance = this;
        }

        private void dataGridViewSetData()
        {
            NhanViendtgv.DataSource = bus_NV.getData();
            NhanViendtgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            NhanViendtgv.AllowUserToAddRows = false;
        }

        private void reloadDtgv()
        {
            dataGridViewSetData();
            NhanViendtgv.ClearSelection();
        }

        public void reloadDataGridView()
        {
            reloadDtgv();
        }
        private void LoadChucVu()
        {
            chucVuList = bus_CV.getListChucVu();
            PositionCbb.DataSource = chucVuList;
            PositionCbb.DisplayMember = "Name";
        }

        private void LoadGioiTinh()
        {
            List<string> gioiTinh = new List<string>();
            gioiTinh.Add("Nam");
            gioiTinh.Add("Nữ");
            SexCbb.DataSource = gioiTinh;  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(NhanViendtgv.Rows[rowIndex].Cells[0].Value.ToString());
        }

        private void PositionCbb_SelectedIndexChanged(object sender, EventArgs e)
        {
            tenChucVu = (PositionCbb.SelectedValue as ChucVu).Name.ToString();
        }

        private void SexCbb_SelectedIndexChanged(object sender, EventArgs e)
        {
            gioiTinh = (SexCbb.SelectedValue).ToString();
        }

        private void NameTxb_TextChanged(object sender, EventArgs e)
        {
            tenNhanVien = NameTxb.Text.ToString();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            NhanViendtgv.DataSource = bus_NV.searchData(tenChucVu, gioiTinh, tenNhanVien);
        }

        private void ViewBtn_Click(object sender, EventArgs e)
        {
            reloadDtgv();
        }

        private void ThemNvBtn_Click(object sender, EventArgs e)
        {
            NhanVien.getInstance().Hide();
            NhanVien.getInstance().Visible = false;
            QuanLyNhanVien qlnv = new QuanLyNhanVien();
            qlnv.Show();
            qlnv.getThemButton().Enabled = true;
            qlnv.getReloadBtn().Enabled = true;
            qlnv.getMaNhanVienTextBox().Text = bus_NV.futureId();
        }

        private void NhanViendtgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            NhanVien.getInstance().Hide();
            NhanVien.getInstance().Visible = false;
            string maNhanVien = NhanViendtgv.Rows[rowIndex].Cells[0].Value.ToString();
            QuanLyNhanVien qlnv = new QuanLyNhanVien();
            qlnv.HanhDong = 1;
            qlnv.getMaNhanVienTextBox().Text = maNhanVien;
            qlnv.Show();
            qlnv.getXoaButton().Enabled = true;
            qlnv.getSuaButton().Enabled= true;
            
        }

        private void NhanViendtgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void NhanViendtgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //rowIndex = NhanViendtgv.CurrentCell.RowIndex;
            int row = e.RowIndex;
            if(row >= 0)
            {
                rowIndex = e.RowIndex;
            }
        }
    }
}
