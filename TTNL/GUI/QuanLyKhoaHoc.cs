using BUS;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Globalization;

namespace GUI
{
    public partial class QuanLyKhoaHoc : Form
    {
        BUS_KHOAHOC a;
        int d = 0;
        public QuanLyKhoaHoc()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dtp2_Load(object sender, EventArgs e)
        {
            a = new BUS_KHOAHOC();
            loadcbCaHoc();
            loadcbNgayHoc();
            loadgrd();
        }
        void loadcbCaHoc()
        {
            cbCaHoc.DataSource = a.getCaHoc();
            cbCaHoc.DisplayMember = "ten";
            cbCaHoc.ValueMember = "id";
        }
        void loadcbNgayHoc()
        {
            cbNgayHoc.DataSource = a.getNgayHoc();
            cbNgayHoc.DisplayMember = "ten";
            cbNgayHoc.ValueMember = "id";
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            refesh();
        }
        void refesh()
        {
            txtId.Clear();
            txtName.Clear();
            txtPrice.Clear();
            dtp1.Text = "";
            dtp2.Text = "";
            dup.Value = 10;
            cbCaHoc.Text = "";
            cbNgayHoc.Text = "";
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            d = 1;
            refesh();
            txtId.Text = a.ps();
        }
        void loadgrd()
        {
            dataGridView1.DataSource = a.getAllKhoaHoc();
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }
        public static string RemoveUnicode(string text)
        {
            string[] arr1 = new string[] { "á", "à", "ả", "ã", "ạ", "â", "ấ", "ầ", "ẩ", "ẫ", "ậ", "ă", "ắ", "ằ", "ẳ", "ẵ", "ặ",
            "đ",
            "é","è","ẻ","ẽ","ẹ","ê","ế","ề","ể","ễ","ệ",
            "í","ì","ỉ","ĩ","ị",
            "ó","ò","ỏ","õ","ọ","ô","ố","ồ","ổ","ỗ","ộ","ơ","ớ","ờ","ở","ỡ","ợ",
            "ú","ù","ủ","ũ","ụ","ư","ứ","ừ","ử","ữ","ự",
            "ý","ỳ","ỷ","ỹ","ỵ",};
            string[] arr2 = new string[] { "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a",
            "d",
            "e","e","e","e","e","e","e","e","e","e","e",
            "i","i","i","i","i",
            "o","o","o","o","o","o","o","o","o","o","o","o","o","o","o","o","o",
            "u","u","u","u","u","u","u","u","u","u","u",
            "y","y","y","y","y",};
            for (int i = 0; i < arr1.Length; i++)
            {
                text = text.Replace(arr1[i], arr2[i]);
                text = text.Replace(arr1[i].ToUpper(), arr2[i].ToUpper());
            }
            return text;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            DateTime bd = dtp1.Value;
            DateTime kt = dtp2.Value;
            if (name.Length == 0)
            {
                MessageBox.Show("Vui lòng Nhập Tên!"); txtName.Focus(); return;
            }
            if (!Regex.IsMatch(RemoveUnicode(name), "^[a-zA-Z ]"))
            {
                MessageBox.Show("Tên không hợp lệ!"); txtName.Focus(); return;
            }
            if (txtPrice.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập giá tiền"); txtPrice.Focus(); return;
            }
            float hocphi = float.Parse(txtPrice.Text);

            if (hocphi < 10000)
            {
                MessageBox.Show("Vui lòng chọn học phí!"); txtPrice.Focus(); return;
            }
            if (bd < DateTime.Now)
            {
                MessageBox.Show("Ngày bắt đầu khóa học phải lớn hơn ngày hiện tại"); dtp1.Focus(); return;
            }
            if (bd > kt)
            {
                MessageBox.Show("Ngày kết thúc không được sớm hơn ngày bắt đầu"); dtp1.Focus(); return;
            }
            try
            {
                if (d == 1)
                {
                    string cahoc = cbCaHoc.SelectedValue.ToString();
                    string ngayhoc = cbNgayHoc.SelectedValue.ToString();
                    float price = float.Parse(txtPrice.Text);
                    int sobuoi = int.Parse(dup.Value.ToString());
                    //add
                    if (a.add(txtId.Text, txtName.Text, cahoc, ngayhoc, dtp1.Value, dtp2.Value, price, 0, sobuoi))
                    {
                        MessageBox.Show("Thêm thành công");
                    }
                    else
                    {
                        MessageBox.Show("Thêm thất bại");
                    }
                }
            }
            catch{
                MessageBox.Show("Không thể thêm được vì trùng khoá học");
            }
            if(d == 2)
            {
                string cahoc = cbCaHoc.SelectedValue.ToString();
                string ngayhoc = cbNgayHoc.SelectedValue.ToString();
                float price = float.Parse(txtPrice.Text);
                int sobuoi = int.Parse(dup.Value.ToString());
                //update
                if (a.update(txtId.Text, txtName.Text, cahoc, ngayhoc, dtp1.Value, dtp2.Value, price, 0, sobuoi))
                {
                    MessageBox.Show("Thay đổi thành công");
                }
                else
                {
                    MessageBox.Show("Thay đổi thất bại");
                }
            }
            loadgrd();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                dtp1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                dtp2.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                txtPrice.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                cbCaHoc.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                cbNgayHoc.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                dup.Value = int.Parse(dataGridView1.CurrentRow.Cells[7].Value.ToString());
            }
            catch{
                MessageBox.Show("Không còn khóa học");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa khóa học : " + txtName.Text, "Thong Bao", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (a.delete(txtId.Text))
                {
                    MessageBox.Show("Xóa Thành Công");
                }
                else
                {
                    MessageBox.Show("Xóa Thất Bại");
                }

            }
            loadgrd();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int d = 2;
        }

        // Handle event btn search
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchContent = '%' + txtSearch.Text.Trim() +'%';
            if (searchContent.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập thông tin cần chọn");
                return;
            }
            dataGridView1.DataSource = a.timkiem(searchContent);
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            loadgrd();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "PDF (*.pdf)|*.pdf";
                save.FileName = "Result.pdf";
                bool ErrorMessage = false;
                if (save.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(save.FileName))
                    {
                        try
                        {
                            File.Delete(save.FileName);
                        }
                        catch (Exception ex)
                        {
                            ErrorMessage = true;
                            MessageBox.Show("Unable to wride data in disk" + ex.Message);
                        }
                    }
                    if (!ErrorMessage)
                    {
                        try
                        {
                            PdfPTable pTable = new PdfPTable(dataGridView1.Columns.Count);
                            pTable.DefaultCell.Padding = 2;
                            pTable.WidthPercentage = 100;
                            pTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            for (int i = 0; i < dataGridView1.Rows.Count - 1; ++i)
                            {
                                for (int j = 0; j < dataGridView1.Columns.Count; ++j)
                                {
                                    if (j == 2 || j==3)
                                    {
                                        string[]  t = dataGridView1.Rows[i].Cells[j].Value.ToString().Split(' ');
                                        pTable.AddCell(t[0]);
                                    }
                                    else
                                    {
                                        pTable.AddCell(dataGridView1.Rows[i].Cells[j].Value.ToString());
                                    }
                                }
                            }

                            using (FileStream fileStream = new FileStream(save.FileName, FileMode.Create))
                            {
                                Document document = new Document(PageSize.A4, 8f, 16f, 16f, 8f);
                                PdfWriter.GetInstance(document, fileStream);
                                document.Open();
                                document.Add(pTable);
                                document.Close();
                                fileStream.Close();
                            }
                            MessageBox.Show("Xuất file PDF thành công", "info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Thất Bại", "Info");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
