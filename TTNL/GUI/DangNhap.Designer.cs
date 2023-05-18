namespace GUI
{
    partial class DangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangNhap));
            this.linkLabel1_QuenMatKhau = new System.Windows.Forms.LinkLabel();
            this.linkLabel2_DangKi = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtUserPass = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLabel1_QuenMatKhau
            // 
            this.linkLabel1_QuenMatKhau.AutoSize = true;
            this.linkLabel1_QuenMatKhau.BackColor = System.Drawing.Color.LightGray;
            this.linkLabel1_QuenMatKhau.Location = new System.Drawing.Point(162, 300);
            this.linkLabel1_QuenMatKhau.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel1_QuenMatKhau.Name = "linkLabel1_QuenMatKhau";
            this.linkLabel1_QuenMatKhau.Size = new System.Drawing.Size(91, 13);
            this.linkLabel1_QuenMatKhau.TabIndex = 6;
            this.linkLabel1_QuenMatKhau.TabStop = true;
            this.linkLabel1_QuenMatKhau.Text = "Quên Mật Khẩu ?";
            this.linkLabel1_QuenMatKhau.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_QuenMatKhau_LinkClicked);
            // 
            // linkLabel2_DangKi
            // 
            this.linkLabel2_DangKi.AutoSize = true;
            this.linkLabel2_DangKi.BackColor = System.Drawing.Color.LightGray;
            this.linkLabel2_DangKi.Location = new System.Drawing.Point(318, 300);
            this.linkLabel2_DangKi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel2_DangKi.Name = "linkLabel2_DangKi";
            this.linkLabel2_DangKi.Size = new System.Drawing.Size(47, 13);
            this.linkLabel2_DangKi.TabIndex = 7;
            this.linkLabel2_DangKi.TabStop = true;
            this.linkLabel2_DangKi.Text = "Đăng Kí";
            this.linkLabel2_DangKi.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_DangKi_LinkClicked);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGray;
            this.button1.Location = new System.Drawing.Point(204, 338);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 33);
            this.button1.TabIndex = 8;
            this.button1.Text = "Đăng Nhập";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.SystemColors.Control;
            this.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.txtUserName.Location = new System.Drawing.Point(233, 152);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(180, 38);
            this.txtUserName.TabIndex = 9;
            // 
            // txtUserPass
            // 
            this.txtUserPass.BackColor = System.Drawing.SystemColors.Control;
            this.txtUserPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.txtUserPass.Location = new System.Drawing.Point(233, 221);
            this.txtUserPass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtUserPass.Name = "txtUserPass";
            this.txtUserPass.PasswordChar = '*';
            this.txtUserPass.Size = new System.Drawing.Size(180, 38);
            this.txtUserPass.TabIndex = 10;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(135, 221);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 30);
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::GUI.Properties.Resources.user;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Image = global::GUI.Properties.Resources.user;
            this.pictureBox2.Location = new System.Drawing.Point(135, 152);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(554, 418);
            this.Controls.Add(this.txtUserPass);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.linkLabel2_DangKi);
            this.Controls.Add(this.linkLabel1_QuenMatKhau);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "DangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập";
            this.Load += new System.EventHandler(this.DangNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.LinkLabel linkLabel1_QuenMatKhau;
        private System.Windows.Forms.LinkLabel linkLabel2_DangKi;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtUserPass;
        public System.Windows.Forms.Button button1;
    }
}

