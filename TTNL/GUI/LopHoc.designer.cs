namespace GUI
{
    partial class LopHoc
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
            this.label1 = new System.Windows.Forms.Label();
            this.maLopHocTxb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.maGiaoVienTxb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tenLopHocTxb = new System.Windows.Forms.TextBox();
            this.lopHocLv = new System.Windows.Forms.ListView();
            this.maLopHocClm = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tenLopHocClm = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.maKhoaHocClm = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.maGiaoVienClm = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.maTroGiangClm = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.maPhongHocClm = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tinhTrangClm = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.maKhoaHocCbb = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.maPhongHocCbb = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.maTroGiangTxb = new System.Windows.Forms.TextBox();
            this.trangThaiPnl = new System.Windows.Forms.Panel();
            this.FullRBtn = new System.Windows.Forms.RadioButton();
            this.NotFullRBtn = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.lopHocPnl = new System.Windows.Forms.Panel();
            this.ThemBtn = new System.Windows.Forms.Button();
            this.ViewBtn = new System.Windows.Forms.Button();
            this.searchPnl = new System.Windows.Forms.Panel();
            this.tenLopHocCbb = new System.Windows.Forms.ComboBox();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.maKhoaHocCbb_S = new System.Windows.Forms.ComboBox();
            this.tenLopHocRBtn = new System.Windows.Forms.RadioButton();
            this.maKhoaHocRBtn = new System.Windows.Forms.RadioButton();
            this.ExportBtn = new System.Windows.Forms.Button();
            this.SuaBtn = new System.Windows.Forms.Button();
            this.XoaBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.BoChonBtn = new System.Windows.Forms.Button();
            this.hocVienBtn = new System.Windows.Forms.Button();
            this.trangThaiPnl.SuspendLayout();
            this.lopHocPnl.SuspendLayout();
            this.searchPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã lớp học";
            // 
            // maLopHocTxb
            // 
            this.maLopHocTxb.Enabled = false;
            this.maLopHocTxb.Location = new System.Drawing.Point(117, 13);
            this.maLopHocTxb.Name = "maLopHocTxb";
            this.maLopHocTxb.Size = new System.Drawing.Size(179, 22);
            this.maLopHocTxb.TabIndex = 1;
            this.maLopHocTxb.TextChanged += new System.EventHandler(this.maLopHocTxb_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(325, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã khóa học";
            // 
            // maGiaoVienTxb
            // 
            this.maGiaoVienTxb.Location = new System.Drawing.Point(117, 74);
            this.maGiaoVienTxb.Name = "maGiaoVienTxb";
            this.maGiaoVienTxb.Size = new System.Drawing.Size(179, 22);
            this.maGiaoVienTxb.TabIndex = 3;
            this.maGiaoVienTxb.TextChanged += new System.EventHandler(this.maGiaoVienTxb_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên lớp học";
            // 
            // tenLopHocTxb
            // 
            this.tenLopHocTxb.Location = new System.Drawing.Point(117, 43);
            this.tenLopHocTxb.Name = "tenLopHocTxb";
            this.tenLopHocTxb.Size = new System.Drawing.Size(179, 22);
            this.tenLopHocTxb.TabIndex = 6;
            this.tenLopHocTxb.TextChanged += new System.EventHandler(this.tenLopHocTxb_TextChanged);
            // 
            // lopHocLv
            // 
            this.lopHocLv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lopHocLv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.maLopHocClm,
            this.tenLopHocClm,
            this.maKhoaHocClm,
            this.maGiaoVienClm,
            this.maTroGiangClm,
            this.maPhongHocClm,
            this.tinhTrangClm});
            this.lopHocLv.FullRowSelect = true;
            this.lopHocLv.GridLines = true;
            this.lopHocLv.HideSelection = false;
            this.lopHocLv.Location = new System.Drawing.Point(19, 246);
            this.lopHocLv.MultiSelect = false;
            this.lopHocLv.Name = "lopHocLv";
            this.lopHocLv.Size = new System.Drawing.Size(1070, 259);
            this.lopHocLv.TabIndex = 7;
            this.lopHocLv.UseCompatibleStateImageBehavior = false;
            this.lopHocLv.View = System.Windows.Forms.View.Details;
            this.lopHocLv.SelectedIndexChanged += new System.EventHandler(this.lopHocLv_SelectedIndexChanged);
            this.lopHocLv.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lopHocLv_MouseDoubleClick);
            // 
            // maLopHocClm
            // 
            this.maLopHocClm.Text = "Mã lớp học";
            this.maLopHocClm.Width = 100;
            // 
            // tenLopHocClm
            // 
            this.tenLopHocClm.Text = "Tên lớp  học";
            this.tenLopHocClm.Width = 200;
            // 
            // maKhoaHocClm
            // 
            this.maKhoaHocClm.Text = "Mã khóa học";
            this.maKhoaHocClm.Width = 100;
            // 
            // maGiaoVienClm
            // 
            this.maGiaoVienClm.Text = "Mã giáo viên";
            this.maGiaoVienClm.Width = 100;
            // 
            // maTroGiangClm
            // 
            this.maTroGiangClm.Text = "Mã nhân viên";
            this.maTroGiangClm.Width = 100;
            // 
            // maPhongHocClm
            // 
            this.maPhongHocClm.Text = "Mã phòng học";
            this.maPhongHocClm.Width = 100;
            // 
            // tinhTrangClm
            // 
            this.tinhTrangClm.Text = "Tình trạng";
            this.tinhTrangClm.Width = 100;
            // 
            // maKhoaHocCbb
            // 
            this.maKhoaHocCbb.FormattingEnabled = true;
            this.maKhoaHocCbb.Location = new System.Drawing.Point(422, 43);
            this.maKhoaHocCbb.Name = "maKhoaHocCbb";
            this.maKhoaHocCbb.Size = new System.Drawing.Size(220, 24);
            this.maKhoaHocCbb.TabIndex = 8;
            this.maKhoaHocCbb.SelectedIndexChanged += new System.EventHandler(this.maKhoaHocCbb_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Mã giáo viên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(317, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Mã phòng học";
            // 
            // maPhongHocCbb
            // 
            this.maPhongHocCbb.FormattingEnabled = true;
            this.maPhongHocCbb.Location = new System.Drawing.Point(422, 74);
            this.maPhongHocCbb.Name = "maPhongHocCbb";
            this.maPhongHocCbb.Size = new System.Drawing.Size(220, 24);
            this.maPhongHocCbb.TabIndex = 11;
            this.maPhongHocCbb.SelectedIndexChanged += new System.EventHandler(this.maPhongHocCbb_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(323, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Mã nhân viên";
            // 
            // maTroGiangTxb
            // 
            this.maTroGiangTxb.Location = new System.Drawing.Point(422, 15);
            this.maTroGiangTxb.Name = "maTroGiangTxb";
            this.maTroGiangTxb.Size = new System.Drawing.Size(220, 22);
            this.maTroGiangTxb.TabIndex = 13;
            this.maTroGiangTxb.TextChanged += new System.EventHandler(this.maTroGiangTxb_TextChanged);
            // 
            // trangThaiPnl
            // 
            this.trangThaiPnl.Controls.Add(this.FullRBtn);
            this.trangThaiPnl.Controls.Add(this.NotFullRBtn);
            this.trangThaiPnl.Location = new System.Drawing.Point(648, 32);
            this.trangThaiPnl.Name = "trangThaiPnl";
            this.trangThaiPnl.Size = new System.Drawing.Size(131, 74);
            this.trangThaiPnl.TabIndex = 14;
            this.trangThaiPnl.Paint += new System.Windows.Forms.PaintEventHandler(this.trangThaiPnl_Paint);
            // 
            // FullRBtn
            // 
            this.FullRBtn.AutoSize = true;
            this.FullRBtn.Location = new System.Drawing.Point(14, 42);
            this.FullRBtn.Name = "FullRBtn";
            this.FullRBtn.Size = new System.Drawing.Size(80, 20);
            this.FullRBtn.TabIndex = 1;
            this.FullRBtn.Text = "Đủ người";
            this.FullRBtn.UseVisualStyleBackColor = true;
            // 
            // NotFullRBtn
            // 
            this.NotFullRBtn.AutoSize = true;
            this.NotFullRBtn.Checked = true;
            this.NotFullRBtn.Location = new System.Drawing.Point(14, 16);
            this.NotFullRBtn.Name = "NotFullRBtn";
            this.NotFullRBtn.Size = new System.Drawing.Size(98, 20);
            this.NotFullRBtn.TabIndex = 0;
            this.NotFullRBtn.TabStop = true;
            this.NotFullRBtn.Text = "Có thể thêm";
            this.NotFullRBtn.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(645, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Trạng thái";
            // 
            // lopHocPnl
            // 
            this.lopHocPnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lopHocPnl.Controls.Add(this.label7);
            this.lopHocPnl.Controls.Add(this.trangThaiPnl);
            this.lopHocPnl.Controls.Add(this.maTroGiangTxb);
            this.lopHocPnl.Controls.Add(this.label6);
            this.lopHocPnl.Controls.Add(this.maPhongHocCbb);
            this.lopHocPnl.Controls.Add(this.label5);
            this.lopHocPnl.Controls.Add(this.label4);
            this.lopHocPnl.Controls.Add(this.maKhoaHocCbb);
            this.lopHocPnl.Controls.Add(this.tenLopHocTxb);
            this.lopHocPnl.Controls.Add(this.label3);
            this.lopHocPnl.Controls.Add(this.maGiaoVienTxb);
            this.lopHocPnl.Controls.Add(this.label2);
            this.lopHocPnl.Controls.Add(this.maLopHocTxb);
            this.lopHocPnl.Controls.Add(this.label1);
            this.lopHocPnl.Location = new System.Drawing.Point(16, 5);
            this.lopHocPnl.Name = "lopHocPnl";
            this.lopHocPnl.Size = new System.Drawing.Size(813, 121);
            this.lopHocPnl.TabIndex = 16;
            this.lopHocPnl.Paint += new System.Windows.Forms.PaintEventHandler(this.lopHocPnl_Paint);
            // 
            // ThemBtn
            // 
            this.ThemBtn.Location = new System.Drawing.Point(848, 7);
            this.ThemBtn.Name = "ThemBtn";
            this.ThemBtn.Size = new System.Drawing.Size(66, 53);
            this.ThemBtn.TabIndex = 17;
            this.ThemBtn.Text = "Thêm";
            this.ThemBtn.UseVisualStyleBackColor = true;
            this.ThemBtn.Click += new System.EventHandler(this.ThemBtn_Click);
            // 
            // ViewBtn
            // 
            this.ViewBtn.Location = new System.Drawing.Point(585, 168);
            this.ViewBtn.Name = "ViewBtn";
            this.ViewBtn.Size = new System.Drawing.Size(96, 40);
            this.ViewBtn.TabIndex = 18;
            this.ViewBtn.Text = "Xem";
            this.ViewBtn.UseVisualStyleBackColor = true;
            // 
            // searchPnl
            // 
            this.searchPnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchPnl.Controls.Add(this.tenLopHocCbb);
            this.searchPnl.Controls.Add(this.SearchBtn);
            this.searchPnl.Controls.Add(this.maKhoaHocCbb_S);
            this.searchPnl.Controls.Add(this.tenLopHocRBtn);
            this.searchPnl.Controls.Add(this.maKhoaHocRBtn);
            this.searchPnl.Location = new System.Drawing.Point(16, 137);
            this.searchPnl.Name = "searchPnl";
            this.searchPnl.Size = new System.Drawing.Size(548, 92);
            this.searchPnl.TabIndex = 21;
            // 
            // tenLopHocCbb
            // 
            this.tenLopHocCbb.FormattingEnabled = true;
            this.tenLopHocCbb.Location = new System.Drawing.Point(212, 39);
            this.tenLopHocCbb.Name = "tenLopHocCbb";
            this.tenLopHocCbb.Size = new System.Drawing.Size(198, 24);
            this.tenLopHocCbb.TabIndex = 3;
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(431, 30);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(96, 40);
            this.SearchBtn.TabIndex = 22;
            this.SearchBtn.Text = "Tìm kiếm";
            this.SearchBtn.UseVisualStyleBackColor = true;
            // 
            // maKhoaHocCbb_S
            // 
            this.maKhoaHocCbb_S.FormattingEnabled = true;
            this.maKhoaHocCbb_S.Location = new System.Drawing.Point(29, 39);
            this.maKhoaHocCbb_S.Name = "maKhoaHocCbb_S";
            this.maKhoaHocCbb_S.Size = new System.Drawing.Size(141, 24);
            this.maKhoaHocCbb_S.TabIndex = 2;
            // 
            // tenLopHocRBtn
            // 
            this.tenLopHocRBtn.AutoSize = true;
            this.tenLopHocRBtn.Location = new System.Drawing.Point(212, 13);
            this.tenLopHocRBtn.Name = "tenLopHocRBtn";
            this.tenLopHocRBtn.Size = new System.Drawing.Size(99, 20);
            this.tenLopHocRBtn.TabIndex = 1;
            this.tenLopHocRBtn.TabStop = true;
            this.tenLopHocRBtn.Text = "Tên lớp học";
            this.tenLopHocRBtn.UseVisualStyleBackColor = true;
            // 
            // maKhoaHocRBtn
            // 
            this.maKhoaHocRBtn.AutoSize = true;
            this.maKhoaHocRBtn.Location = new System.Drawing.Point(29, 13);
            this.maKhoaHocRBtn.Name = "maKhoaHocRBtn";
            this.maKhoaHocRBtn.Size = new System.Drawing.Size(105, 20);
            this.maKhoaHocRBtn.TabIndex = 0;
            this.maKhoaHocRBtn.TabStop = true;
            this.maKhoaHocRBtn.Text = "Mã khóa học";
            this.maKhoaHocRBtn.UseVisualStyleBackColor = true;
            // 
            // ExportBtn
            // 
            this.ExportBtn.Location = new System.Drawing.Point(848, 73);
            this.ExportBtn.Name = "ExportBtn";
            this.ExportBtn.Size = new System.Drawing.Size(66, 53);
            this.ExportBtn.TabIndex = 23;
            this.ExportBtn.Text = "Xuất ra excel";
            this.ExportBtn.UseVisualStyleBackColor = true;
            // 
            // SuaBtn
            // 
            this.SuaBtn.Location = new System.Drawing.Point(934, 7);
            this.SuaBtn.Name = "SuaBtn";
            this.SuaBtn.Size = new System.Drawing.Size(66, 53);
            this.SuaBtn.TabIndex = 24;
            this.SuaBtn.Text = "Sửa";
            this.SuaBtn.UseVisualStyleBackColor = true;
            this.SuaBtn.Click += new System.EventHandler(this.SuaBtn_Click);
            // 
            // XoaBtn
            // 
            this.XoaBtn.Location = new System.Drawing.Point(1023, 6);
            this.XoaBtn.Name = "XoaBtn";
            this.XoaBtn.Size = new System.Drawing.Size(66, 53);
            this.XoaBtn.TabIndex = 25;
            this.XoaBtn.Text = "Xóa";
            this.XoaBtn.UseVisualStyleBackColor = true;
            this.XoaBtn.Click += new System.EventHandler(this.XoaBtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(825, 197);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 26;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BoChonBtn
            // 
            this.BoChonBtn.Location = new System.Drawing.Point(988, 197);
            this.BoChonBtn.Name = "BoChonBtn";
            this.BoChonBtn.Size = new System.Drawing.Size(101, 43);
            this.BoChonBtn.TabIndex = 27;
            this.BoChonBtn.Text = "Bỏ chọn";
            this.BoChonBtn.UseVisualStyleBackColor = true;
            this.BoChonBtn.Click += new System.EventHandler(this.BoChonBtn_Click);
            // 
            // hocVienBtn
            // 
            this.hocVienBtn.Location = new System.Drawing.Point(934, 76);
            this.hocVienBtn.Name = "hocVienBtn";
            this.hocVienBtn.Size = new System.Drawing.Size(66, 50);
            this.hocVienBtn.TabIndex = 28;
            this.hocVienBtn.Text = "Học viên";
            this.hocVienBtn.UseVisualStyleBackColor = true;
            this.hocVienBtn.Click += new System.EventHandler(this.hocVienBtn_Click);
            // 
            // LopHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 517);
            this.Controls.Add(this.hocVienBtn);
            this.Controls.Add(this.BoChonBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.XoaBtn);
            this.Controls.Add(this.SuaBtn);
            this.Controls.Add(this.ExportBtn);
            this.Controls.Add(this.searchPnl);
            this.Controls.Add(this.ViewBtn);
            this.Controls.Add(this.ThemBtn);
            this.Controls.Add(this.lopHocPnl);
            this.Controls.Add(this.lopHocLv);
            this.Name = "LopHoc";
            this.Text = "1";
            this.Load += new System.EventHandler(this.LopHoc_Load);
            this.trangThaiPnl.ResumeLayout(false);
            this.trangThaiPnl.PerformLayout();
            this.lopHocPnl.ResumeLayout(false);
            this.lopHocPnl.PerformLayout();
            this.searchPnl.ResumeLayout(false);
            this.searchPnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox maLopHocTxb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox maGiaoVienTxb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tenLopHocTxb;
        private System.Windows.Forms.ListView lopHocLv;
        private System.Windows.Forms.ComboBox maKhoaHocCbb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox maPhongHocCbb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox maTroGiangTxb;
        private System.Windows.Forms.Panel trangThaiPnl;
        private System.Windows.Forms.RadioButton FullRBtn;
        private System.Windows.Forms.RadioButton NotFullRBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel lopHocPnl;
        private System.Windows.Forms.ColumnHeader maLopHocClm;
        private System.Windows.Forms.ColumnHeader tenLopHocClm;
        private System.Windows.Forms.ColumnHeader maKhoaHocClm;
        private System.Windows.Forms.ColumnHeader maGiaoVienClm;
        private System.Windows.Forms.ColumnHeader maTroGiangClm;
        private System.Windows.Forms.ColumnHeader maPhongHocClm;
        private System.Windows.Forms.ColumnHeader tinhTrangClm;
        private System.Windows.Forms.Button ThemBtn;
        private System.Windows.Forms.Button ViewBtn;
        private System.Windows.Forms.Panel searchPnl;
        private System.Windows.Forms.ComboBox tenLopHocCbb;
        private System.Windows.Forms.ComboBox maKhoaHocCbb_S;
        private System.Windows.Forms.RadioButton tenLopHocRBtn;
        private System.Windows.Forms.RadioButton maKhoaHocRBtn;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Button ExportBtn;
        private System.Windows.Forms.Button SuaBtn;
        private System.Windows.Forms.Button XoaBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BoChonBtn;
        private System.Windows.Forms.Button hocVienBtn;
    }
}