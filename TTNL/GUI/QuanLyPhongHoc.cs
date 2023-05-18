using BUS;
using OfficeOpenXml.LoadFunctions.Params;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace GUI
{
    public partial class QuanLyPhongHoc : Form
    {
        BUS_PHONGHOC a;
        int d = 0;
        public QuanLyPhongHoc()
        {
            InitializeComponent();
        }

        void refesh()
        {
            txtId.Clear();
            txtPhong.Clear();
            dup.Value = 30;
        }
        private void QuanLyPhongHoc_Load(object sender, EventArgs e)
        {
            loadPhong();
        }
        void loadPhong()
        {
            a = new BUS_PHONGHOC();
            dataGridView1.DataSource = a.getAll();
            hienthiphonghoc();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtPhong.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            dup.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            a = new BUS_PHONGHOC();
            txtId.Text = a.ps();
            d = 1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
             
            if (d == 1)
            {
                if(a.add(txtId.Text, txtPhong.Text, int.Parse(dup.Value.ToString())))
                    {
                    MessageBox.Show("Thêm phòng thành công");
                    refesh();
                }
                else
                {
                    MessageBox.Show("Thêm Phòng Thất Bại");
                }
            }
            else
            {
                if (a.update(txtId.Text, txtPhong.Text, int.Parse(dup.Value.ToString())))
                {
                    MessageBox.Show("Thay đổi phòng thành công");
                    refesh();
                }
                else
                {
                    MessageBox.Show("Thay đổi Phòng Thất Bại");
                }
            }
            loadPhong();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xac Nhan Xóa phòng " + txtPhong.Text, "Thong Bao", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (a.delete(txtId.Text))
                {
                    MessageBox.Show("Xóa phòng thành công");
                }
                else
                {
                    MessageBox.Show("Xóa Phòng Thất Bại");
                }
            }
            loadPhong();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int d = 2;
        }
        
        void hienthiphonghoc()
        {
            flowLayoutPanel1.Controls.Clear();
            for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
            {
                Button dynamicButton = new Button();
                dynamicButton.Height = 70;
                dynamicButton.Width = 70;
                dynamicButton.BackColor = Color.Green;
                dynamicButton.Text = dataGridView1.Rows[i].Cells[1].Value.ToString() + "\n\n" + dataGridView1.Rows[i].Cells[2].Value.ToString();
                flowLayoutPanel1.Controls.Add(dynamicButton);
            }
        }
    }
}
