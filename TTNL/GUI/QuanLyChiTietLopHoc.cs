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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI
{
    public partial class QuanLyChiTietLopHoc : Form
    {
        BUS_QuanLyCTLH busQl = new BUS_QuanLyCTLH();
        string idLopHoc;
        public string IdLophoc { get { return idLopHoc;} set { idLopHoc = value; } }
        public QuanLyChiTietLopHoc()
        {
            InitializeComponent();
        }

        private void QuanLyChiTietLopHoc_Load(object sender, EventArgs e)
        {
            loadListView();
           
        }

        private void loadListView()
        {
           
            DataTable data = busQl.selectData();
            if(data.Rows.Count > 0)
            {
                foreach(DataRow row in data.Rows)
                {
                    ListViewItem item = new ListViewItem(row["id"].ToString());
                    hocVienLv.Items.Add(item);
                    item.SubItems.Add(row["tenHocVien"].ToString());
                    if (row["gioitinh"] != DBNull.Value)
                    {
                        int sex = Convert.ToInt32(row["gioitinh"].ToString());
                        if (sex == 1)
                        {
                            item.SubItems.Add("1");
                        }
                        else
                        {
                            item.SubItems.Add("0");
                        }
                    }
                    else
                    {
                        item.SubItems.Add("");
                    }
                    item.SubItems.Add(row["sdt"].ToString());
                    DateTime ngaySinh = (DateTime)row["ngaySinh"];
                    item.SubItems.Add(ngaySinh.ToString("MM/dd/yyyy"));
                    item.SubItems.Add("");
                }
            }
            DataTable dataChecked = busQl.selectDataChecked(idLopHoc);
            if(dataChecked.Rows.Count > 0)
            {
                foreach(DataRow row in dataChecked.Rows)
                {
                    for(int i = 0; i < hocVienLv.Items.Count; i++)
                    {
                        if (hocVienLv.Items[i].Text == row["id"].ToString())
                        {
                            hocVienLv.Items[i].Checked = true;
                            break;
                        }
                    }
                }
            }
        }

      
        private void hocVienLv_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            bool isChecked = (e.NewValue == CheckState.Checked);
            if (isChecked)
            {
                hocVienLv.Items[e.Index].ForeColor = Color.Green;
            }
            else
            {
                hocVienLv.Items[e.Index].ForeColor = Color.Black;
            }
        }

        private void hocVienLv_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(hocVienLv.SelectedItems.Count > 0)
            {
                ListViewItem item = hocVienLv.SelectedItems[0];
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.ListView.CheckedListViewItemCollection checkedItems = hocVienLv.CheckedItems;
            int count = 0;
            foreach (ListViewItem item in checkedItems)
            {
                count++;
            }
            MessageBox.Show(count.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(busQl.selectDataChecked(idLopHoc).Rows.Count.ToString());
        }

        private void thayDoiBtn_Click(object sender, EventArgs e)
        {
            busQl.deleteData(idLopHoc);
            foreach(ListViewItem item in hocVienLv.Items)
            {
                if (item.Checked)
                {
                    busQl.insertCTData(idLopHoc,item.Text);  
                }
            }
            MessageBox.Show("Thay đổi thành công");
        }
    }
}
