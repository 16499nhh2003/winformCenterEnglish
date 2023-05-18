using BUS;
using iTextSharp.text.xml;
using OfficeOpenXml.FormulaParsing.ExpressionGraph.FunctionCompilers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using System.Xml.Linq;

namespace GUI
{
    public partial class DangKiKhoaHoc : Form
    {
        BUS_KHOAHOC kh;
        BUS_HOCVIEN hv;
        public DangKiKhoaHoc()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dtp1.Text = "";
            dtp2.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kh = new BUS_KHOAHOC();
            hv = new BUS_HOCVIEN();
            DateTime t1 = dtp1.Value;
            DateTime t2 = dtp2.Value;
            if(t1 > t2)
            {
                MessageBox.Show("Không hợp lệ");return;
            }
            //if (t2 < DateTime.Now)
            //{
            //    MessageBox.Show("Không có khóa học nào trong khoảng thời gian này");return;
            //}
            if (kh.PS_searchnbdbnkt(t1, t2).Rows.Count < 1)
            {
                MessageBox.Show("Không tìm thấy");
            }
            cbKhoaHoc.DataSource = kh.PS_searchnbdbnkt(t1, t2);
            cbKhoaHoc.DisplayMember = "ABC";
            cbKhoaHoc.ValueMember = "id";
            loadHocVien();
        }
        void loadHocVien()  
        {
            cbTenHocVien.DataSource = hv.getHocVien();
            cbTenHocVien.DisplayMember = "Tên Học Viên";
            cbTenHocVien.ValueMember = "Mã Học Viên";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string idHocVien = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            string idLopHoc = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            MessageBox.Show(idLopHoc + idHocVien);
            if (MessageBox.Show("Xác nhận xóa đăng kí ? ", "Thong Bao", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (kh.deleteChiTietLopHoc(idLopHoc, idHocVien))
                {
                    MessageBox.Show("Xóa Thành Công");
                    dataGridView1.DataSource = kh.PS_XemKhoaHocHocvienDangky(cbTenHocVien.SelectedValue.ToString());
                }
                else
                {
                    MessageBox.Show("Xóa Thất Bại");
                }
            }
            dtp1.Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (kh.PS_InsertDangKyKhoaHoc(cbLop.SelectedValue.ToString(), dtp3.Value, cbTenHocVien.SelectedValue.ToString()))
                {
                    MessageBox.Show("Thêm Thành công");
                    dataGridView1.DataSource = kh.PS_XemKhoaHocHocvienDangky(cbTenHocVien.SelectedValue.ToString());
                    if (MessageBox.Show("Có muốn thanh toán và in hóa đơn không? ", "Thong Bao", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        this.Hide();
                        string username = kh.PS_getNamebyIDHv(cbTenHocVien.SelectedValue.ToString()).Rows[0][0].ToString();
                        string ngaydangki = dtp3.Value.ToString();
                        string khoahoc = kh.PS_GetNameByIdMaKhoaHoc(cbKhoaHoc.SelectedValue.ToString()).Rows[0][0].ToString();
                        DongHocPhi f = new DongHocPhi(username,ngaydangki,float.Parse(kh.PS_GetPriceByKhoaHoc(cbKhoaHoc.SelectedValue.ToString()).Rows[0][0].ToString()));
                        f.Show();
                    }
                    else
                    {
                    }
                }
            }
            catch
            {
                MessageBox.Show("Thêm thất bại");
            }
        }

        private void DangKiKhoaHoc_Load(object sender, EventArgs e)
        {
        }

        private void cbKhoaHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            BUS_LOPHOC lh = new BUS_LOPHOC();
            if (cbKhoaHoc.SelectedIndex != -1)
            {
                cbLop.DataSource = lh.PS_searchLopHocbyKhoaHoc(cbKhoaHoc.SelectedValue.ToString());
                cbLop.DisplayMember = "tenLopHoc";
                cbLop.ValueMember = "mã lớp";
            }
        }
        private void cbTenHocVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTenHocVien.SelectedIndex != -1)
            {
                dataGridView1.DataSource = kh.PS_XemKhoaHocHocvienDangky(cbTenHocVien.SelectedValue.ToString());
            }
        }
    }
}
