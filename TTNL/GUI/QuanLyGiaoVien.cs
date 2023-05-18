using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TTNL;

namespace GUI
{
    public partial class QuanLyGiaoVien : Form
    {
        DTO_GiaoVien gv = new DTO_GiaoVien();
        BUS_GiaoVien busGv = new BUS_GiaoVien();
        List<DTO_LoaiGiangVien> listLGV = new List<DTO_LoaiGiangVien>();
        public DTO_GiaoVien GV { get { return gv; } set { gv = value; } }
        public QuanLyGiaoVien()
        {
            InitializeComponent();
        }

        private void QuanLyGiaoVien_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            firstLoad();
            themBtn.Enabled = false;
            SuaBtn.Enabled = false;
        }

        public Button getThem()
        {
            return themBtn;
        }
        public Button getSua()
        {
            return SuaBtn;
        }
        private void firstLoad()
        {
            maGvTxb.Text = busGv.autoCreateId().ToString();
            ngaySinhGvDTP.Value = DateTime.Now;
            gv.GioiTinh = 1;
            listLGV = busGv.listLGV();
            chucVuGvCbb.DataSource = listLGV;
            chucVuGvCbb.DisplayMember = "Ten";
        }
        private void maGvTxb_TextChanged(object sender, EventArgs e)
        {
            gv.MaGiaoVien = maGvTxb.Text.ToString();
        }

        private void tenGvTxb_TextChanged(object sender, EventArgs e)
        {
            gv.TenGiaoVien = tenGvTxb.Text.ToString().Trim();
        }

        private void diaChiGvTxb_TextChanged(object sender, EventArgs e)
        {
            gv.DiaChi = diaChiGvTxb.Text.ToString().Trim();
        }

        private void sdtGvTxb_TextChanged(object sender, EventArgs e)
        {
            gv.SDT = sdtGvTxb.Text.ToString().Trim();
        }

        private void cccdGvTxb_TextChanged(object sender, EventArgs e)
        {
            gv.CCCD = cccdGvTxb.Text.ToString().Trim();
        }

        private void ngaySinhGvDTP_ValueChanged(object sender, EventArgs e)
        {
            gv.NgaySinh = ngaySinhGvDTP.Value.ToString("MM/dd/yyyy");
        }

        private void chucVuGvCbb_SelectedIndexChanged(object sender, EventArgs e)
        {
           gv.LoaiGiaoVien = (chucVuGvCbb.SelectedValue as DTO_LoaiGiangVien).Ma.ToString().Trim();
        }

        private void giaTheoGioGvTxb_TextChanged(object sender, EventArgs e)
        {
            int gia = 0;
            bool success  = int.TryParse(giaTheoGioGvTxb.Text.ToString(),out gia);
            if (success)
            {
                gv.GiaTheoGio = gia;
            }
            else
            {
                MessageBox.Show("Giá tiền không hợp lệ");
                giaTheoGioGvTxb.Text = "0";
            }
        }

        private void namRBtn_CheckedChanged(object sender, EventArgs e)
        {
            if(namRBtn.Checked == true)
            {
                gv.GioiTinh = 1;
            }
            else
            {
                gv.GioiTinh = 0;
            }
        }

        private void themBtn_Click(object sender, EventArgs e)
        {
            string error = busGv.errorCheck(gv);
            if(error.CompareTo("SuccessNoError") != 0)
            {
                MessageBox.Show(error);
            }
            else
            {
                busGv.insertGiaoVien(gv);
                MessageBox.Show("Thêm thành công");
                GiangVien.getUniqueInstance().loadLV();
                GiangVien.getUniqueInstance().Show();
                this.Dispose();
            }
        }

        private void loadForm(DTO_GiaoVien gv)
        {
            maGvTxb.Text = gv.MaGiaoVien;
            tenGvTxb.Text = gv.TenGiaoVien;
            if (!string.IsNullOrEmpty(gv.DiaChi))
            {
                diaChiGvTxb.Text = gv.DiaChi;
            }
            sdtGvTxb.Text = gv.SDT;
            cccdGvTxb.Text = gv.CCCD;
            ngaySinhGvDTP.Value = Convert.ToDateTime(gv.NgaySinh.ToString());
            chucVuGvCbb.Text = busGv.getLoaiGV(gv.LoaiGiaoVien);
            if (gv.GioiTinh == 1)
            {
                namRBtn.Checked = true;
            }
            else
            {
                nuRBtn.Checked = true;
            }
            giaTheoGioGvTxb.Text = gv.GiaTheoGio.ToString();
        }
        public void load(DTO_GiaoVien gv)
        {
            loadForm(gv);
        }

        private void SuaBtn_Click(object sender, EventArgs e)
        {
            busGv.updateLoaiGV(gv);
            GiangVien.getUniqueInstance().loadLV();
        }
       
    }
}
