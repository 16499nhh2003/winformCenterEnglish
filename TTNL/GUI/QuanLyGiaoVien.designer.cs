namespace GUI
{
    partial class QuanLyGiaoVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.maGvTxb = new System.Windows.Forms.TextBox();
            this.tenGvTxb = new System.Windows.Forms.TextBox();
            this.ngaySinhGvDTP = new System.Windows.Forms.DateTimePicker();
            this.giaTheoGioGvTxb = new System.Windows.Forms.TextBox();
            this.diaChiGvTxb = new System.Windows.Forms.TextBox();
            this.sexGvPnl = new System.Windows.Forms.Panel();
            this.nuRBtn = new System.Windows.Forms.RadioButton();
            this.namRBtn = new System.Windows.Forms.RadioButton();
            this.cccdGvTxb = new System.Windows.Forms.TextBox();
            this.chucVuGvCbb = new System.Windows.Forms.ComboBox();
            this.sdtGvTxb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.themBtn = new System.Windows.Forms.Button();
            this.SuaBtn = new System.Windows.Forms.Button();
            this.sexGvPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // maGvTxb
            // 
            this.maGvTxb.Enabled = false;
            this.maGvTxb.Location = new System.Drawing.Point(133, 19);
            this.maGvTxb.Name = "maGvTxb";
            this.maGvTxb.Size = new System.Drawing.Size(234, 22);
            this.maGvTxb.TabIndex = 0;
            this.maGvTxb.TextChanged += new System.EventHandler(this.maGvTxb_TextChanged);
            // 
            // tenGvTxb
            // 
            this.tenGvTxb.Location = new System.Drawing.Point(133, 60);
            this.tenGvTxb.Name = "tenGvTxb";
            this.tenGvTxb.Size = new System.Drawing.Size(234, 22);
            this.tenGvTxb.TabIndex = 1;
            this.tenGvTxb.TextChanged += new System.EventHandler(this.tenGvTxb_TextChanged);
            // 
            // ngaySinhGvDTP
            // 
            this.ngaySinhGvDTP.Location = new System.Drawing.Point(492, 18);
            this.ngaySinhGvDTP.Name = "ngaySinhGvDTP";
            this.ngaySinhGvDTP.Size = new System.Drawing.Size(265, 22);
            this.ngaySinhGvDTP.TabIndex = 2;
            this.ngaySinhGvDTP.ValueChanged += new System.EventHandler(this.ngaySinhGvDTP_ValueChanged);
            // 
            // giaTheoGioGvTxb
            // 
            this.giaTheoGioGvTxb.Location = new System.Drawing.Point(492, 144);
            this.giaTheoGioGvTxb.Name = "giaTheoGioGvTxb";
            this.giaTheoGioGvTxb.Size = new System.Drawing.Size(265, 22);
            this.giaTheoGioGvTxb.TabIndex = 3;
            this.giaTheoGioGvTxb.TextChanged += new System.EventHandler(this.giaTheoGioGvTxb_TextChanged);
            // 
            // diaChiGvTxb
            // 
            this.diaChiGvTxb.Location = new System.Drawing.Point(133, 101);
            this.diaChiGvTxb.Name = "diaChiGvTxb";
            this.diaChiGvTxb.Size = new System.Drawing.Size(234, 22);
            this.diaChiGvTxb.TabIndex = 4;
            this.diaChiGvTxb.TextChanged += new System.EventHandler(this.diaChiGvTxb_TextChanged);
            // 
            // sexGvPnl
            // 
            this.sexGvPnl.Controls.Add(this.nuRBtn);
            this.sexGvPnl.Controls.Add(this.namRBtn);
            this.sexGvPnl.Location = new System.Drawing.Point(492, 90);
            this.sexGvPnl.Name = "sexGvPnl";
            this.sexGvPnl.Size = new System.Drawing.Size(265, 49);
            this.sexGvPnl.TabIndex = 5;
            // 
            // nuRBtn
            // 
            this.nuRBtn.AutoSize = true;
            this.nuRBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nuRBtn.Location = new System.Drawing.Point(121, 15);
            this.nuRBtn.Name = "nuRBtn";
            this.nuRBtn.Size = new System.Drawing.Size(45, 20);
            this.nuRBtn.TabIndex = 1;
            this.nuRBtn.Text = "Nữ";
            this.nuRBtn.UseVisualStyleBackColor = true;
            // 
            // namRBtn
            // 
            this.namRBtn.AutoSize = true;
            this.namRBtn.Checked = true;
            this.namRBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.namRBtn.Location = new System.Drawing.Point(30, 15);
            this.namRBtn.Name = "namRBtn";
            this.namRBtn.Size = new System.Drawing.Size(57, 20);
            this.namRBtn.TabIndex = 0;
            this.namRBtn.TabStop = true;
            this.namRBtn.Text = "Nam";
            this.namRBtn.UseVisualStyleBackColor = true;
            this.namRBtn.CheckedChanged += new System.EventHandler(this.namRBtn_CheckedChanged);
            // 
            // cccdGvTxb
            // 
            this.cccdGvTxb.Location = new System.Drawing.Point(133, 182);
            this.cccdGvTxb.Name = "cccdGvTxb";
            this.cccdGvTxb.Size = new System.Drawing.Size(234, 22);
            this.cccdGvTxb.TabIndex = 6;
            this.cccdGvTxb.TextChanged += new System.EventHandler(this.cccdGvTxb_TextChanged);
            // 
            // chucVuGvCbb
            // 
            this.chucVuGvCbb.FormattingEnabled = true;
            this.chucVuGvCbb.Location = new System.Drawing.Point(492, 60);
            this.chucVuGvCbb.Name = "chucVuGvCbb";
            this.chucVuGvCbb.Size = new System.Drawing.Size(265, 24);
            this.chucVuGvCbb.TabIndex = 7;
            this.chucVuGvCbb.SelectedIndexChanged += new System.EventHandler(this.chucVuGvCbb_SelectedIndexChanged);
            // 
            // sdtGvTxb
            // 
            this.sdtGvTxb.Location = new System.Drawing.Point(133, 143);
            this.sdtGvTxb.Name = "sdtGvTxb";
            this.sdtGvTxb.Size = new System.Drawing.Size(234, 22);
            this.sdtGvTxb.TabIndex = 8;
            this.sdtGvTxb.TextChanged += new System.EventHandler(this.sdtGvTxb_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Mã giáo viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tên giáo viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(390, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Giá theo giờ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(402, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Ngày sinh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Địa chỉ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(415, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Giới tính";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(60, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "CCCD";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(77, 146);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "Sdt";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(415, 63);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 16);
            this.label9.TabIndex = 17;
            this.label9.Text = "Chức vụ";
            // 
            // themBtn
            // 
            this.themBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.themBtn.Location = new System.Drawing.Point(492, 197);
            this.themBtn.Name = "themBtn";
            this.themBtn.Size = new System.Drawing.Size(115, 60);
            this.themBtn.TabIndex = 19;
            this.themBtn.Text = "Thêm";
            this.themBtn.UseVisualStyleBackColor = true;
            this.themBtn.Click += new System.EventHandler(this.themBtn_Click);
            // 
            // SuaBtn
            // 
            this.SuaBtn.Location = new System.Drawing.Point(642, 197);
            this.SuaBtn.Name = "SuaBtn";
            this.SuaBtn.Size = new System.Drawing.Size(115, 60);
            this.SuaBtn.TabIndex = 21;
            this.SuaBtn.Text = "Sửa";
            this.SuaBtn.UseVisualStyleBackColor = true;
            this.SuaBtn.Click += new System.EventHandler(this.SuaBtn_Click);
            // 
            // QuanLyGiaoVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 276);
            this.Controls.Add(this.SuaBtn);
            this.Controls.Add(this.themBtn);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sdtGvTxb);
            this.Controls.Add(this.chucVuGvCbb);
            this.Controls.Add(this.cccdGvTxb);
            this.Controls.Add(this.sexGvPnl);
            this.Controls.Add(this.diaChiGvTxb);
            this.Controls.Add(this.giaTheoGioGvTxb);
            this.Controls.Add(this.ngaySinhGvDTP);
            this.Controls.Add(this.tenGvTxb);
            this.Controls.Add(this.maGvTxb);
            this.Name = "QuanLyGiaoVien";
            this.Text = "QuanLyGiaoVien";
            this.Load += new System.EventHandler(this.QuanLyGiaoVien_Load);
            this.sexGvPnl.ResumeLayout(false);
            this.sexGvPnl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox maGvTxb;
        private System.Windows.Forms.TextBox tenGvTxb;
        private System.Windows.Forms.DateTimePicker ngaySinhGvDTP;
        private System.Windows.Forms.TextBox giaTheoGioGvTxb;
        private System.Windows.Forms.TextBox diaChiGvTxb;
        private System.Windows.Forms.Panel sexGvPnl;
        private System.Windows.Forms.RadioButton nuRBtn;
        private System.Windows.Forms.RadioButton namRBtn;
        private System.Windows.Forms.TextBox cccdGvTxb;
        private System.Windows.Forms.ComboBox chucVuGvCbb;
        private System.Windows.Forms.TextBox sdtGvTxb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button themBtn;
        private System.Windows.Forms.Button SuaBtn;
    }
}