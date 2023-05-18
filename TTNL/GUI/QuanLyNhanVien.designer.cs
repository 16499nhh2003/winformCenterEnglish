namespace GUI
{
    partial class QuanLyNhanVien
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
            this.ThemBtn = new System.Windows.Forms.Button();
            this.MaNvTxb = new System.Windows.Forms.TextBox();
            this.MaNVLb = new System.Windows.Forms.Label();
            this.TenNvTxb = new System.Windows.Forms.TextBox();
            this.panel = new System.Windows.Forms.Panel();
            this.NuRb = new System.Windows.Forms.RadioButton();
            this.NameRb = new System.Windows.Forms.RadioButton();
            this.SdtNvTxb = new System.Windows.Forms.TextBox();
            this.EmailNvTxb = new System.Windows.Forms.TextBox();
            this.TenNVLb = new System.Windows.Forms.Label();
            this.SdtNvLb = new System.Windows.Forms.Label();
            this.EmailNvLb = new System.Windows.Forms.Label();
            this.NgaySinhLb = new System.Windows.Forms.Label();
            this.GioiTinhLb = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ChucVuLb = new System.Windows.Forms.Label();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.XoaBtn = new System.Windows.Forms.Button();
            this.SuaBtn = new System.Windows.Forms.Button();
            this.ReloadBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ThemBtn
            // 
            this.ThemBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ThemBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ThemBtn.Location = new System.Drawing.Point(255, 340);
            this.ThemBtn.Name = "ThemBtn";
            this.ThemBtn.Size = new System.Drawing.Size(123, 33);
            this.ThemBtn.TabIndex = 0;
            this.ThemBtn.Text = "Thêm ";
            this.ThemBtn.UseVisualStyleBackColor = false;
            this.ThemBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // MaNvTxb
            // 
            this.MaNvTxb.Enabled = false;
            this.MaNvTxb.Location = new System.Drawing.Point(407, 32);
            this.MaNvTxb.Name = "MaNvTxb";
            this.MaNvTxb.Size = new System.Drawing.Size(266, 22);
            this.MaNvTxb.TabIndex = 1;
            this.MaNvTxb.TextChanged += new System.EventHandler(this.MaNvTxb_TextChanged);
            // 
            // MaNVLb
            // 
            this.MaNVLb.AutoSize = true;
            this.MaNVLb.Location = new System.Drawing.Point(289, 32);
            this.MaNVLb.Name = "MaNVLb";
            this.MaNVLb.Size = new System.Drawing.Size(89, 16);
            this.MaNVLb.TabIndex = 2;
            this.MaNVLb.Text = "Mã Nhân viên";
            // 
            // TenNvTxb
            // 
            this.TenNvTxb.Location = new System.Drawing.Point(407, 71);
            this.TenNvTxb.Name = "TenNvTxb";
            this.TenNvTxb.Size = new System.Drawing.Size(266, 22);
            this.TenNvTxb.TabIndex = 3;
            this.TenNvTxb.TextChanged += new System.EventHandler(this.TenNvTxb_TextChanged);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.NuRb);
            this.panel.Controls.Add(this.NameRb);
            this.panel.Location = new System.Drawing.Point(395, 226);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(238, 40);
            this.panel.TabIndex = 4;
            // 
            // NuRb
            // 
            this.NuRb.AutoSize = true;
            this.NuRb.Location = new System.Drawing.Point(94, 10);
            this.NuRb.Name = "NuRb";
            this.NuRb.Size = new System.Drawing.Size(45, 20);
            this.NuRb.TabIndex = 1;
            this.NuRb.TabStop = true;
            this.NuRb.Text = "Nữ";
            this.NuRb.UseVisualStyleBackColor = true;
            // 
            // NameRb
            // 
            this.NameRb.AutoSize = true;
            this.NameRb.Checked = true;
            this.NameRb.Location = new System.Drawing.Point(12, 10);
            this.NameRb.Name = "NameRb";
            this.NameRb.Size = new System.Drawing.Size(57, 20);
            this.NameRb.TabIndex = 0;
            this.NameRb.TabStop = true;
            this.NameRb.Text = "Nam";
            this.NameRb.UseVisualStyleBackColor = true;
            // 
            // SdtNvTxb
            // 
            this.SdtNvTxb.Location = new System.Drawing.Point(407, 112);
            this.SdtNvTxb.Name = "SdtNvTxb";
            this.SdtNvTxb.Size = new System.Drawing.Size(266, 22);
            this.SdtNvTxb.TabIndex = 5;
            this.SdtNvTxb.TextChanged += new System.EventHandler(this.SdtNvTxb_TextChanged);
            // 
            // EmailNvTxb
            // 
            this.EmailNvTxb.Location = new System.Drawing.Point(407, 150);
            this.EmailNvTxb.Name = "EmailNvTxb";
            this.EmailNvTxb.Size = new System.Drawing.Size(266, 22);
            this.EmailNvTxb.TabIndex = 6;
            this.EmailNvTxb.TextChanged += new System.EventHandler(this.EmailNvTxb_TextChanged);
            // 
            // TenNVLb
            // 
            this.TenNVLb.AutoSize = true;
            this.TenNVLb.Location = new System.Drawing.Point(293, 77);
            this.TenNVLb.Name = "TenNVLb";
            this.TenNVLb.Size = new System.Drawing.Size(91, 16);
            this.TenNVLb.TabIndex = 8;
            this.TenNVLb.Text = "Tên nhân viên";
            // 
            // SdtNvLb
            // 
            this.SdtNvLb.AutoSize = true;
            this.SdtNvLb.Location = new System.Drawing.Point(293, 118);
            this.SdtNvLb.Name = "SdtNvLb";
            this.SdtNvLb.Size = new System.Drawing.Size(85, 16);
            this.SdtNvLb.TabIndex = 9;
            this.SdtNvLb.Text = "Số điện thoại";
            // 
            // EmailNvLb
            // 
            this.EmailNvLb.AutoSize = true;
            this.EmailNvLb.Location = new System.Drawing.Point(337, 156);
            this.EmailNvLb.Name = "EmailNvLb";
            this.EmailNvLb.Size = new System.Drawing.Size(41, 16);
            this.EmailNvLb.TabIndex = 10;
            this.EmailNvLb.Text = "Email";
            // 
            // NgaySinhLb
            // 
            this.NgaySinhLb.AutoSize = true;
            this.NgaySinhLb.Location = new System.Drawing.Point(311, 195);
            this.NgaySinhLb.Name = "NgaySinhLb";
            this.NgaySinhLb.Size = new System.Drawing.Size(67, 16);
            this.NgaySinhLb.TabIndex = 11;
            this.NgaySinhLb.Text = "Ngày sinh";
            // 
            // GioiTinhLb
            // 
            this.GioiTinhLb.AutoSize = true;
            this.GioiTinhLb.Location = new System.Drawing.Point(324, 236);
            this.GioiTinhLb.Name = "GioiTinhLb";
            this.GioiTinhLb.Size = new System.Drawing.Size(54, 16);
            this.GioiTinhLb.TabIndex = 12;
            this.GioiTinhLb.Text = "Giới tính";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(407, 190);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(266, 22);
            this.dateTimePicker.TabIndex = 13;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // ChucVuLb
            // 
            this.ChucVuLb.AutoSize = true;
            this.ChucVuLb.Location = new System.Drawing.Point(324, 275);
            this.ChucVuLb.Name = "ChucVuLb";
            this.ChucVuLb.Size = new System.Drawing.Size(54, 16);
            this.ChucVuLb.TabIndex = 14;
            this.ChucVuLb.Text = "Chức vụ";
            // 
            // comboBox
            // 
            this.comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(407, 272);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(266, 24);
            this.comboBox.TabIndex = 15;
            this.comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // pictureBox
            // 
            this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox.Location = new System.Drawing.Point(36, 60);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(216, 236);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 16;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(93, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 16);
            this.label8.TabIndex = 17;
            this.label8.Text = "Ảnh nhân viên";
            // 
            // XoaBtn
            // 
            this.XoaBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.XoaBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.XoaBtn.Location = new System.Drawing.Point(395, 340);
            this.XoaBtn.Name = "XoaBtn";
            this.XoaBtn.Size = new System.Drawing.Size(132, 33);
            this.XoaBtn.TabIndex = 18;
            this.XoaBtn.Text = "Xóa";
            this.XoaBtn.UseVisualStyleBackColor = false;
            this.XoaBtn.Click += new System.EventHandler(this.XoaBtn_Click);
            // 
            // SuaBtn
            // 
            this.SuaBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SuaBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SuaBtn.Location = new System.Drawing.Point(545, 340);
            this.SuaBtn.Name = "SuaBtn";
            this.SuaBtn.Size = new System.Drawing.Size(128, 33);
            this.SuaBtn.TabIndex = 19;
            this.SuaBtn.Text = "Sửa";
            this.SuaBtn.UseVisualStyleBackColor = false;
            this.SuaBtn.Click += new System.EventHandler(this.SuaBtn_Click);
            // 
            // ReloadBtn
            // 
            this.ReloadBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ReloadBtn.Location = new System.Drawing.Point(113, 340);
            this.ReloadBtn.Name = "ReloadBtn";
            this.ReloadBtn.Size = new System.Drawing.Size(123, 33);
            this.ReloadBtn.TabIndex = 21;
            this.ReloadBtn.Text = "Làm trắng";
            this.ReloadBtn.UseVisualStyleBackColor = true;
            this.ReloadBtn.Click += new System.EventHandler(this.ReloadBtn_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(708, 1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(28, 23);
            this.button2.TabIndex = 22;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // QuanLyNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(738, 419);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ReloadBtn);
            this.Controls.Add(this.SuaBtn);
            this.Controls.Add(this.XoaBtn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.ChucVuLb);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.GioiTinhLb);
            this.Controls.Add(this.NgaySinhLb);
            this.Controls.Add(this.EmailNvLb);
            this.Controls.Add(this.SdtNvLb);
            this.Controls.Add(this.TenNVLb);
            this.Controls.Add(this.EmailNvTxb);
            this.Controls.Add(this.SdtNvTxb);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.TenNvTxb);
            this.Controls.Add(this.MaNVLb);
            this.Controls.Add(this.MaNvTxb);
            this.Controls.Add(this.ThemBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "QuanLyNhanVien";
            this.Text = "QuanLyNhanVien";
            this.Load += new System.EventHandler(this.QuanLyNhanVien_Load);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ThemBtn;
        private System.Windows.Forms.TextBox MaNvTxb;
        private System.Windows.Forms.Label MaNVLb;
        private System.Windows.Forms.TextBox TenNvTxb;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.RadioButton NuRb;
        private System.Windows.Forms.RadioButton NameRb;
        private System.Windows.Forms.TextBox SdtNvTxb;
        private System.Windows.Forms.TextBox EmailNvTxb;
        private System.Windows.Forms.Label TenNVLb;
        private System.Windows.Forms.Label SdtNvLb;
        private System.Windows.Forms.Label EmailNvLb;
        private System.Windows.Forms.Label NgaySinhLb;
        private System.Windows.Forms.Label GioiTinhLb;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label ChucVuLb;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button XoaBtn;
        private System.Windows.Forms.Button SuaBtn;
        private System.Windows.Forms.Button ReloadBtn;
        private System.Windows.Forms.Button button2;
    }
}