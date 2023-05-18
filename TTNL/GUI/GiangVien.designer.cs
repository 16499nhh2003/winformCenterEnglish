namespace GUI
{
    partial class GiangVien
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
            this.maGvRbtn = new System.Windows.Forms.RadioButton();
            this.tenGvRbtn = new System.Windows.Forms.RadioButton();
            this.tenGvTxb = new System.Windows.Forms.TextBox();
            this.searchPnl = new System.Windows.Forms.Panel();
            this.searchBtn = new System.Windows.Forms.Button();
            this.themBtn = new System.Windows.Forms.Button();
            this.giaoVienLv = new System.Windows.Forms.ListView();
            this.maGv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tenGv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ngaySinhGv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cccdGv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gioiTinhGv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.diaChiGv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.loaiGv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.giaGv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.XoaBtn = new System.Windows.Forms.Button();
            this.SuaBtn = new System.Windows.Forms.Button();
            this.XemBtn = new System.Windows.Forms.Button();
            this.searchPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // maGvTxb
            // 
            this.maGvTxb.Location = new System.Drawing.Point(148, 15);
            this.maGvTxb.Name = "maGvTxb";
            this.maGvTxb.Size = new System.Drawing.Size(142, 22);
            this.maGvTxb.TabIndex = 1;
            // 
            // maGvRbtn
            // 
            this.maGvRbtn.AutoSize = true;
            this.maGvRbtn.Location = new System.Drawing.Point(21, 17);
            this.maGvRbtn.Name = "maGvRbtn";
            this.maGvRbtn.Size = new System.Drawing.Size(105, 20);
            this.maGvRbtn.TabIndex = 2;
            this.maGvRbtn.TabStop = true;
            this.maGvRbtn.Text = "Mã giáo viên";
            this.maGvRbtn.UseVisualStyleBackColor = true;
            // 
            // tenGvRbtn
            // 
            this.tenGvRbtn.AutoSize = true;
            this.tenGvRbtn.Location = new System.Drawing.Point(320, 15);
            this.tenGvRbtn.Name = "tenGvRbtn";
            this.tenGvRbtn.Size = new System.Drawing.Size(110, 20);
            this.tenGvRbtn.TabIndex = 3;
            this.tenGvRbtn.TabStop = true;
            this.tenGvRbtn.Text = "Tên giáo viên";
            this.tenGvRbtn.UseVisualStyleBackColor = true;
            // 
            // tenGvTxb
            // 
            this.tenGvTxb.Location = new System.Drawing.Point(441, 17);
            this.tenGvTxb.Name = "tenGvTxb";
            this.tenGvTxb.Size = new System.Drawing.Size(148, 22);
            this.tenGvTxb.TabIndex = 5;
            // 
            // searchPnl
            // 
            this.searchPnl.Controls.Add(this.tenGvTxb);
            this.searchPnl.Controls.Add(this.tenGvRbtn);
            this.searchPnl.Controls.Add(this.maGvRbtn);
            this.searchPnl.Controls.Add(this.maGvTxb);
            this.searchPnl.Location = new System.Drawing.Point(14, 23);
            this.searchPnl.Name = "searchPnl";
            this.searchPnl.Size = new System.Drawing.Size(610, 69);
            this.searchPnl.TabIndex = 6;
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(648, 40);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 23);
            this.searchBtn.TabIndex = 7;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // themBtn
            // 
            this.themBtn.Location = new System.Drawing.Point(973, 23);
            this.themBtn.Name = "themBtn";
            this.themBtn.Size = new System.Drawing.Size(83, 69);
            this.themBtn.TabIndex = 8;
            this.themBtn.Text = "Thêm";
            this.themBtn.UseVisualStyleBackColor = true;
            this.themBtn.Click += new System.EventHandler(this.themBtn_Click);
            // 
            // giaoVienLv
            // 
            this.giaoVienLv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.maGv,
            this.tenGv,
            this.ngaySinhGv,
            this.cccdGv,
            this.gioiTinhGv,
            this.diaChiGv,
            this.loaiGv,
            this.giaGv});
            this.giaoVienLv.FullRowSelect = true;
            this.giaoVienLv.HideSelection = false;
            this.giaoVienLv.Location = new System.Drawing.Point(14, 114);
            this.giaoVienLv.Name = "giaoVienLv";
            this.giaoVienLv.Size = new System.Drawing.Size(1312, 486);
            this.giaoVienLv.TabIndex = 9;
            this.giaoVienLv.UseCompatibleStateImageBehavior = false;
            this.giaoVienLv.View = System.Windows.Forms.View.Details;
            this.giaoVienLv.SelectedIndexChanged += new System.EventHandler(this.giaoVienLv_SelectedIndexChanged);
            // 
            // maGv
            // 
            this.maGv.Text = "Mã giáo viên";
            this.maGv.Width = 101;
            // 
            // tenGv
            // 
            this.tenGv.Text = "Tên giáo viên";
            // 
            // ngaySinhGv
            // 
            this.ngaySinhGv.Text = "Ngày sinh";
            // 
            // cccdGv
            // 
            this.cccdGv.Text = "CCCD";
            // 
            // gioiTinhGv
            // 
            this.gioiTinhGv.Text = "GIới tính";
            // 
            // diaChiGv
            // 
            this.diaChiGv.Text = "Địa chỉ";
            // 
            // loaiGv
            // 
            this.loaiGv.Text = "Loại giáo viên";
            // 
            // giaGv
            // 
            this.giaGv.Text = "Giá theo giờ";
            // 
            // XoaBtn
            // 
            this.XoaBtn.Location = new System.Drawing.Point(1111, 23);
            this.XoaBtn.Name = "XoaBtn";
            this.XoaBtn.Size = new System.Drawing.Size(83, 69);
            this.XoaBtn.TabIndex = 10;
            this.XoaBtn.Text = "Xóa";
            this.XoaBtn.UseVisualStyleBackColor = true;
            this.XoaBtn.Click += new System.EventHandler(this.XoaBtn_Click);
            // 
            // SuaBtn
            // 
            this.SuaBtn.Location = new System.Drawing.Point(1243, 23);
            this.SuaBtn.Name = "SuaBtn";
            this.SuaBtn.Size = new System.Drawing.Size(83, 69);
            this.SuaBtn.TabIndex = 11;
            this.SuaBtn.Text = "Sửa";
            this.SuaBtn.UseVisualStyleBackColor = true;
            this.SuaBtn.Click += new System.EventHandler(this.SuaBtn_Click);
            // 
            // XemBtn
            // 
            this.XemBtn.Location = new System.Drawing.Point(821, 23);
            this.XemBtn.Name = "XemBtn";
            this.XemBtn.Size = new System.Drawing.Size(83, 69);
            this.XemBtn.TabIndex = 12;
            this.XemBtn.Text = "Xem";
            this.XemBtn.UseVisualStyleBackColor = true;
            this.XemBtn.Click += new System.EventHandler(this.XemBtn_Click);
            // 
            // GiangVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1342, 628);
            this.Controls.Add(this.XemBtn);
            this.Controls.Add(this.SuaBtn);
            this.Controls.Add(this.XoaBtn);
            this.Controls.Add(this.giaoVienLv);
            this.Controls.Add(this.themBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.searchPnl);
            this.Name = "GiangVien";
            this.Text = "GiangVien";
            this.Load += new System.EventHandler(this.GiangVien_Load);
            this.searchPnl.ResumeLayout(false);
            this.searchPnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox maGvTxb;
        private System.Windows.Forms.RadioButton maGvRbtn;
        private System.Windows.Forms.RadioButton tenGvRbtn;
        private System.Windows.Forms.TextBox tenGvTxb;
        private System.Windows.Forms.Panel searchPnl;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button themBtn;
        private System.Windows.Forms.ListView giaoVienLv;
        private System.Windows.Forms.ColumnHeader maGv;
        private System.Windows.Forms.ColumnHeader tenGv;
        private System.Windows.Forms.ColumnHeader ngaySinhGv;
        private System.Windows.Forms.ColumnHeader cccdGv;
        private System.Windows.Forms.ColumnHeader gioiTinhGv;
        private System.Windows.Forms.ColumnHeader diaChiGv;
        private System.Windows.Forms.ColumnHeader loaiGv;
        private System.Windows.Forms.ColumnHeader giaGv;
        private System.Windows.Forms.Button XoaBtn;
        private System.Windows.Forms.Button SuaBtn;
        private System.Windows.Forms.Button XemBtn;
    }
}