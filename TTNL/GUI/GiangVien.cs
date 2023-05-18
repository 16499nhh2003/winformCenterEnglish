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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI
{
    public partial class GiangVien : Form
    {
        BUS_GiaoVien busGv = new BUS_GiaoVien();
        private static GiangVien uniqueGv;
        DataTable data;
        int selectedIndex;
        string ma;
        private GiangVien()
        {
            InitializeComponent();
           
        }

        public static GiangVien getUniqueInstance()
        {
            if(uniqueGv == null || uniqueGv.IsDisposed)
            {
                uniqueGv = new GiangVien();
            }
            return uniqueGv;
        }
        public void loadSizeColumn()
        {
            foreach(ColumnHeader item in giaoVienLv.Columns)
            {
                item.Width = item.Text.Length + 100;
                if (item == tenGv)
                    item.Width = item.Text.Length + 200;
                item.TextAlign = HorizontalAlignment.Center;
            }
        }

        private void themBtn_Click(object sender, EventArgs e)
        {
            GiangVien.getUniqueInstance().Visible= false;
            QuanLyGiaoVien qlgv = new QuanLyGiaoVien();
            qlgv.Show();
            qlgv.getThem().Enabled = true;
        }
        private void loadListView()
        {
            giaoVienLv.Items.Clear();
            data = busGv.dataTableGv();
            if(data.Rows.Count > 0)
            {
                foreach (DataRow rows in data.Rows)
                {
                    ListViewItem item = new ListViewItem(rows["id"].ToString());
                    giaoVienLv.Items.Add(item);
                    item.SubItems.Add(rows["tenGiangVien"].ToString());
                    item.SubItems.Add(Convert.ToDateTime(rows["ngaySinh"]).ToString("MM/dd/yyyy"));
                    item.SubItems.Add(rows["cccd"].ToString());
                    if ((bool)rows["gioitinh"])
                        item.SubItems.Add("Nam");
                    else
                        item.SubItems.Add("Nữ");
                    item.SubItems.Add(rows["diachi"].ToString());
                    string ma = rows["loaiGiangVien"].ToString();
                    if(ma.Length > 0)
                    {
                        item.SubItems.Add(busGv.selectTenGv(ma));
                    }
                    item.SubItems.Add(rows["giaTheoGio"].ToString());
                }
            }
        }
        private void loadSearch(DataTable data)
        {
            giaoVienLv.Items.Clear();
            if (data.Rows.Count > 0)
            {
                foreach (DataRow rows in data.Rows)
                {
                    ListViewItem item = new ListViewItem(rows["id"].ToString());
                    giaoVienLv.Items.Add(item);
                    item.SubItems.Add(rows["tenGiangVien"].ToString());
                    item.SubItems.Add(Convert.ToDateTime(rows["ngaySinh"]).ToString("MM/dd/yyyy"));
                    item.SubItems.Add(rows["cccd"].ToString());
                    if ((bool)rows["gioitinh"])
                        item.SubItems.Add("Nam");
                    else
                        item.SubItems.Add("Nữ");
                    item.SubItems.Add(rows["diachi"].ToString());
                    string ma = rows["loaiGiangVien"].ToString();
                    if (ma.Length > 0)
                    {
                        item.SubItems.Add(busGv.selectTenGv(ma));
                    }
                    item.SubItems.Add(rows["giaTheoGio"].ToString());
                }
            }
        }
        public void loadLV()
        {
            loadListView();
        }
        private void giaoVienLv_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (giaoVienLv.SelectedItems.Count > 0)
            {
                // Get the index of the selected row in the ListView
                selectedIndex = giaoVienLv.SelectedIndices[0];
                ma = giaoVienLv.SelectedItems[0].SubItems[0].Text;
            }
            else
            {
                // No item is selected, handle the error or take other action
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            if(maGvRbtn.Checked == true)
            {
                if (!string.IsNullOrEmpty(maGvTxb.Text))
                    loadSearch(busGv.searchBMaGv(maGvTxb.Text.ToString()));
            }
            else if(tenGvRbtn.Checked == true)
            {
                if (!string.IsNullOrEmpty(tenGvTxb.Text))
                    loadSearch(busGv.searchBTenGv(tenGvTxb.Text.ToString()));
            }
        }

        private void GiangVien_Load(object sender, EventArgs e)
        {
            loadSizeColumn();
            loadListView();
        }

        private void XoaBtn_Click(object sender, EventArgs e)
        {
            
            DialogResult dialog = MessageBox.Show("Bạn có muốn xóa không ??","Thông báo xóa",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(dialog == DialogResult.Yes)
            {
                busGv.deleteGv(ma);
                MessageBox.Show("Xóa thành công");
                loadListView();
            }
        }

        private void SuaBtn_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(ma))
            {
                GiangVien.getUniqueInstance().Visible = false;
                QuanLyGiaoVien gv = new QuanLyGiaoVien();
                gv.Show();
                gv.load(busGv.selectGV(ma));
                gv.getSua().Enabled = true;
            }
            
        }

        private void XemBtn_Click(object sender, EventArgs e)
        {
            loadListView();
        }
    }
}
