using BUS;
using OfficeOpenXml;
using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Data;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace GUI
{
    public partial class QuanLyHocVien : Form
    {
        BUS_HOCVIEN hv;
        BUS_KHOAHOC kh;
        BUS_LOPHOC lh;

        int d = 0;
        public QuanLyHocVien()
        {
            InitializeComponent();
        }

        private void QuanLyHocVien_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoResizeColumns();
            loadHocVien();
            loadKhoaHoc();
            loadLopHoc();
        }
        void loadHocVien()
        {
            hv = new BUS_HOCVIEN();
            dataGridView1.DataSource = hv.getHocVien();
        }
        void loadKhoaHoc()
        {
            kh = new BUS_KHOAHOC();
            cbKhoa.DataSource = kh.getAllKhoaHoc();
            cbKhoa.DisplayMember = "Tên Khóa Học";
            cbKhoa.ValueMember = "Mã Khóa Học";

        }
        void loadLopHoc()
        {
            lh = new BUS_LOPHOC();
            cbLop.DataSource = lh.getAllLopHoc();
            cbLop.DisplayMember = "tenLopHoc";
            cbLop.ValueMember = "Mã Lớp Học";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtSdt.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtEmail.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtcccd.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            dtp.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            if (dataGridView1.CurrentRow.Cells[2].Value.ToString() == "Nam")
            {
                rbNam.Checked = true;
            }
            else
            {
                rbNu.Checked = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            hv = new BUS_HOCVIEN();
            refesh();
            txtId.Text = hv.ps();
            txtName.Focus();
            d = 1;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            hv = new BUS_HOCVIEN();
            d = 2;
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
            string sdt = txtSdt.Text;
            string email = txtEmail.Text;
            string cccd = txtcccd.Text;
            DateTime dob = dtp.Value;
            if (name.Length == 0)
            {
                MessageBox.Show("Vui lòng Nhập Tên!"); txtName.Focus(); return;
            }
            if (!Regex.IsMatch(RemoveUnicode(name), "^[a-zA-Z ]"))
            {
                MessageBox.Show("Tên không hợp lệ!"); txtName.Focus(); return;
            }
            if (cccd.Length == 0)
            {
                MessageBox.Show("Vui lòng Nhập căn cước công dân!"); txtcccd.Focus(); return;
            }
            if (!Regex.IsMatch(cccd.Trim(), "^[0-9]"))
            {
                MessageBox.Show("Căn cước công dân chỉ gồm các số 0 - 9"); txtcccd.Focus(); return;
            }
            if (sdt.Length == 0)
            {
                MessageBox.Show("Vui lòng số điện thoại"); txtSdt.Focus(); return;
            }
            if (!Regex.IsMatch(sdt.Trim(), "^[0-9]"))
            {
                MessageBox.Show("Số điện thoại chỉ gồm các số 0 - 9!"); txtSdt.Focus(); return;
            }
            if (dob > DateTime.Now)
            {
                MessageBox.Show("Ngày sinh không hợp lệ"); return;
            }
            if (DateTime.Now.Year - dob.Year > 100)
            {
                MessageBox.Show("Sorrry không được chọn số tuổi quá 100"); return;
            }
            if (email.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập email"); return;
            }
            if (!Regex.IsMatch(email, "^[a-zA-z0-9_.]{3,20}@gmail.com(.vn|)$"))
            {
                MessageBox.Show("Email không đúng định dạng"); return;
            }
            int gt = 0;
            if (rbNu.Checked == true)
            {
                gt = 1;
            }
            else
            {
                gt = 0;
            }
            if (d == 1)
            {
                //add
                if (hv.add(txtId.Text, name, gt, sdt, email, "", cccd, dob, 0, DateTime.Now))
                {
                    MessageBox.Show("Theem thanh cong");
                }
                else
                {
                    MessageBox.Show("THEM THAT BAI");
                }
            }
            else
            {
                //update
                if (hv.update(txtId.Text, name, gt, sdt, email, "", cccd, dob, DateTime.Now))
                {
                    MessageBox.Show("Thay doi thanh cong");
                }
                else
                {
                    MessageBox.Show("Thay doi that bai");
                }
            }

            loadHocVien();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xac Nhan xoa hoc vien " + txtName.Text, "Thong Bao", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (hv.delete(txtId.Text))
                {
                    MessageBox.Show("Xoa Thanh Cong");
                }
                else
                {
                    MessageBox.Show("Xoa That Bai");
                }

            }
            loadHocVien();
        }
        void refesh()
        {
            txtName.Clear();
            txtId.Clear();
            txtcccd.Clear();
            dtp.Text = "";
            rbNam.Checked = false;
            rbNu.Checked = false;
            txtSdt.Clear();
            txtEmail.Clear();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            refesh();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = " Export File Excel";
            saveFileDialog.Filter = "Excel (*.xlsx)|*.xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Export(saveFileDialog.FileName);
                    MessageBox.Show("Xuất file thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xảy ra lỗi " + ex.Message + "\nXuat file That bai");
                }
            }

        }

        void Export(string path)
        {
            Excel.Application application = new Excel.Application();
            application.Application.Workbooks.Add(Type.Missing);
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                application.Cells[1, i + 1] = dataGridView1.Columns[i].HeaderText;
            }
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    application.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value;
                }
            }
            application.Columns.AutoFit();
            application.ActiveWorkbook.SaveCopyAs(path);
            application.ActiveWorkbook.Saved = true;

        }
        
        void Import(string path)
        {
            using (ExcelPackage excelPackage = new ExcelPackage(new FileInfo(path)))
            {
                ExcelWorksheet excelWorksheet = excelPackage.Workbook.Worksheets[0];
                DataTable dataTable = new DataTable();
                for(int i= excelWorksheet.Dimension.Start.Column;i<=excelWorksheet.Dimension.End.Column;i++)
                {
                    dataTable.Columns.Add(excelWorksheet.Cells[1,i].Value.ToString());
                }
                for (int i = excelWorksheet.Dimension.Start.Row + 1; i <= excelWorksheet.Dimension.End.Row; i++)
                {
                    
                    List<string> listRows = new List<string>();
                    for(int j= excelWorksheet.Dimension.Start.Column;j<= excelWorksheet.Dimension.End.Column;j++)
                    {
                        listRows.Add(excelWorksheet.Cells[i, j].Value.ToString());
                    }
                    dataTable.Rows.Add(listRows.ToArray());
                }
                dataGridView1.DataSource = dataTable;
            }
            //hv.deleteAll();
            //for(int i= 0;i<dataGridView1.Rows.Count;i++)
            //{
            //    for(int j = 0; j < dataGridView1.Columns.Count; j++)
            //    {

            //    }
            //}
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = " Import File Excel";
            openFileDialog.Filter = "Excel (*.xlsx)|*.xlsx";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Import(openFileDialog.FileName);
                    MessageBox.Show("Nhập file thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xảy ra lỗi " + ex.Message + "\nNhập file Thất Bại");
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            lh = new BUS_LOPHOC();
            if (cbKhoa.SelectedIndex > -1 && cbLop.SelectedIndex > -1)
            {
                dataGridView1.DataSource = lh.PS_searchbykhoaandlop(cbKhoa.SelectedValue.ToString(), cbLop.SelectedValue.ToString());
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadHocVien();
        }
    }
}

