namespace GUI
{
    partial class QuanLyChiTietLopHoc
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
            this.hocVienLv = new System.Windows.Forms.ListView();
            this.idHocVienClmH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tenHocVienClmH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gioiTinhClmH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sdtClmH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ngaySinhClmH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.thayDoiBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // hocVienLv
            // 
            this.hocVienLv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hocVienLv.CheckBoxes = true;
            this.hocVienLv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idHocVienClmH,
            this.tenHocVienClmH,
            this.gioiTinhClmH,
            this.sdtClmH,
            this.ngaySinhClmH});
            this.hocVienLv.FullRowSelect = true;
            this.hocVienLv.GridLines = true;
            this.hocVienLv.HideSelection = false;
            this.hocVienLv.Location = new System.Drawing.Point(38, 30);
            this.hocVienLv.Name = "hocVienLv";
            this.hocVienLv.Size = new System.Drawing.Size(935, 402);
            this.hocVienLv.TabIndex = 0;
            this.hocVienLv.UseCompatibleStateImageBehavior = false;
            this.hocVienLv.View = System.Windows.Forms.View.Details;
            this.hocVienLv.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.hocVienLv_ItemCheck);
            this.hocVienLv.SelectedIndexChanged += new System.EventHandler(this.hocVienLv_SelectedIndexChanged);
            // 
            // idHocVienClmH
            // 
            this.idHocVienClmH.Text = "Id Học viên";
            this.idHocVienClmH.Width = 120;
            // 
            // tenHocVienClmH
            // 
            this.tenHocVienClmH.Text = "Tên học viên";
            this.tenHocVienClmH.Width = 200;
            // 
            // gioiTinhClmH
            // 
            this.gioiTinhClmH.Text = "Giới tính";
            this.gioiTinhClmH.Width = 100;
            // 
            // sdtClmH
            // 
            this.sdtClmH.Text = "Số điện thoại";
            this.sdtClmH.Width = 130;
            // 
            // ngaySinhClmH
            // 
            this.ngaySinhClmH.Text = "Ngày sinh";
            this.ngaySinhClmH.Width = 150;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(486, 438);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(346, 438);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // thayDoiBtn
            // 
            this.thayDoiBtn.Location = new System.Drawing.Point(887, 438);
            this.thayDoiBtn.Name = "thayDoiBtn";
            this.thayDoiBtn.Size = new System.Drawing.Size(86, 54);
            this.thayDoiBtn.TabIndex = 3;
            this.thayDoiBtn.Text = "Thay đổi";
            this.thayDoiBtn.UseVisualStyleBackColor = true;
            this.thayDoiBtn.Click += new System.EventHandler(this.thayDoiBtn_Click);
            // 
            // QuanLyChiTietLopHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 504);
            this.Controls.Add(this.thayDoiBtn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.hocVienLv);
            this.Name = "QuanLyChiTietLopHoc";
            this.Text = "QuanLyChiTietLopHoc";
            this.Load += new System.EventHandler(this.QuanLyChiTietLopHoc_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView hocVienLv;
        private System.Windows.Forms.ColumnHeader idHocVienClmH;
        private System.Windows.Forms.ColumnHeader tenHocVienClmH;
        private System.Windows.Forms.ColumnHeader gioiTinhClmH;
        private System.Windows.Forms.ColumnHeader sdtClmH;
        private System.Windows.Forms.ColumnHeader ngaySinhClmH;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button thayDoiBtn;
    }
}