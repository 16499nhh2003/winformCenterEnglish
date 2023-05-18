using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using ZXing.QrCode.Internal;
using ZXing.Common;
using ZXing.Rendering;

namespace GUI
{
    public partial class DongHocPhi : Form
    {
        BUS_KHOAHOC kh;
        private string _name;
        private string _ngayLapDon;
        private float _sotien;
        //private string _tenkhoahoc;
        public DongHocPhi()
        {
            InitializeComponent();
        }
        public DongHocPhi(string name, string ngayLapDon, float sotien):this()
        {
            _name = name;
            _ngayLapDon = ngayLapDon;
            _sotien = sotien;  

            label10.Text = _name;
            label11.Text = _ngayLapDon;
            label12.Text = _sotien.ToString();
        }

        // load học phí
        private void DongHocPhi_Load(object sender, EventArgs e)
        {
            kh = new BUS_KHOAHOC();
            txtId.Text = kh.psphieuthu();
        }
        private float money;
        private void btnCaculator_Click(object sender, EventArgs e)
        {

            float phantramgiam = float.Parse(nup.Value.ToString())/100;
            float sotiengiam = _sotien * phantramgiam;
            label14.Text = sotiengiam.ToString();
            float thanhtien = float.Parse(label12.Text) - float.Parse(label14.Text);
            money = thanhtien;
            CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");   // try with "en-US"
            string a = double.Parse(thanhtien.ToString()).ToString("#,###", cul.NumberFormat);
            label15.Text = a;
        }

        // xử lí sự kiện nhấn nút thanh toán
        private void button1_Click(object sender, EventArgs e)
        {
            
            string id = txtId.Text;
            DateTime thoigian = Convert.ToDateTime(label11.Text);
            float tien = money;
            try
            {
                kh.PS_InsertPhieuThu(id, thoigian, tien);
            }
            catch(Exception ex)
            {
                MessageBox.Show("error" + ex);
            }
            this.Hide();
            // lưu vào database phiếu thu
            ThanhToanOffiline fOffline = new ThanhToanOffiline(money); 
            fOffline.ShowDialog();
            this.Show();
        }

        // nút thoát
        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var qrcode_text = $"2|99|{0906919299}|{"NGUYEN HUY HOA"}|{"nguyenhuyhoa2003@gmail.com"}|0|0|{label15.Text.Trim()}";
            BarcodeWriter barcodeWriter = new BarcodeWriter();
            EncodingOptions encodingOptions = new EncodingOptions() { Width = 250, Height = 250, Margin = 0, PureBarcode = false };
            encodingOptions.Hints.Add(EncodeHintType.ERROR_CORRECTION, ErrorCorrectionLevel.H);
            barcodeWriter.Renderer = new BitmapRenderer();
            barcodeWriter.Options = encodingOptions;
            barcodeWriter.Format = BarcodeFormat.QR_CODE;
            Bitmap bitmap = barcodeWriter.Write(qrcode_text);
           // Bitmap logo = resizeImage(Properties.Resources.momo, 64, 64) as Bitmap;
            Graphics g = Graphics.FromImage(bitmap);
            //.DrawImage(logo, new Point((bitmap.Width - logo.Width) / 2, (bitmap.Height - logo.Height) / 2));
            //.Image = bitmap;
        }
    }                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              
}
