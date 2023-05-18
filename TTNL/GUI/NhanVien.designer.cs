namespace GUI
{
    partial class NhanVien
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
            this.NhanViendtgv = new System.Windows.Forms.DataGridView();
            this.PositionCbb = new System.Windows.Forms.ComboBox();
            this.NameTxb = new System.Windows.Forms.TextBox();
            this.SexCbb = new System.Windows.Forms.ComboBox();
            this.PositionLb = new System.Windows.Forms.Label();
            this.SexLb = new System.Windows.Forms.Label();
            this.NameLb = new System.Windows.Forms.Label();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.ViewBtn = new System.Windows.Forms.Button();
            this.ThemNvBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NhanViendtgv)).BeginInit();
            this.SuspendLayout();
            // 
            // NhanViendtgv
            // 
            this.NhanViendtgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NhanViendtgv.Location = new System.Drawing.Point(14, 68);
            this.NhanViendtgv.Name = "NhanViendtgv";
            this.NhanViendtgv.ReadOnly = true;
            this.NhanViendtgv.RowHeadersWidth = 51;
            this.NhanViendtgv.RowTemplate.Height = 24;
            this.NhanViendtgv.Size = new System.Drawing.Size(959, 333);
            this.NhanViendtgv.TabIndex = 0;
            this.NhanViendtgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.NhanViendtgv_CellClick);
            this.NhanViendtgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.NhanViendtgv_CellContentClick);
            this.NhanViendtgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.NhanViendtgv_CellDoubleClick);
            // 
            // PositionCbb
            // 
            this.PositionCbb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PositionCbb.FormattingEnabled = true;
            this.PositionCbb.Location = new System.Drawing.Point(83, 24);
            this.PositionCbb.Name = "PositionCbb";
            this.PositionCbb.Size = new System.Drawing.Size(171, 24);
            this.PositionCbb.Sorted = true;
            this.PositionCbb.TabIndex = 1;
            this.PositionCbb.SelectedIndexChanged += new System.EventHandler(this.PositionCbb_SelectedIndexChanged);
            // 
            // NameTxb
            // 
            this.NameTxb.Location = new System.Drawing.Point(580, 24);
            this.NameTxb.Name = "NameTxb";
            this.NameTxb.Size = new System.Drawing.Size(222, 22);
            this.NameTxb.TabIndex = 2;
            this.NameTxb.TextChanged += new System.EventHandler(this.NameTxb_TextChanged);
            // 
            // SexCbb
            // 
            this.SexCbb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SexCbb.FormattingEnabled = true;
            this.SexCbb.Location = new System.Drawing.Point(332, 24);
            this.SexCbb.Name = "SexCbb";
            this.SexCbb.Size = new System.Drawing.Size(117, 24);
            this.SexCbb.TabIndex = 3;
            this.SexCbb.SelectedIndexChanged += new System.EventHandler(this.SexCbb_SelectedIndexChanged);
            // 
            // PositionLb
            // 
            this.PositionLb.AutoSize = true;
            this.PositionLb.Location = new System.Drawing.Point(23, 27);
            this.PositionLb.Name = "PositionLb";
            this.PositionLb.Size = new System.Drawing.Size(54, 16);
            this.PositionLb.TabIndex = 4;
            this.PositionLb.Text = "Chức vụ";
            // 
            // SexLb
            // 
            this.SexLb.AutoSize = true;
            this.SexLb.Location = new System.Drawing.Point(271, 27);
            this.SexLb.Name = "SexLb";
            this.SexLb.Size = new System.Drawing.Size(54, 16);
            this.SexLb.TabIndex = 5;
            this.SexLb.Text = "Giới tính";
            // 
            // NameLb
            // 
            this.NameLb.AutoSize = true;
            this.NameLb.Location = new System.Drawing.Point(474, 27);
            this.NameLb.Name = "NameLb";
            this.NameLb.Size = new System.Drawing.Size(91, 16);
            this.NameLb.TabIndex = 6;
            this.NameLb.Text = "Tên nhân viên";
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(877, 15);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(96, 40);
            this.SearchBtn.TabIndex = 7;
            this.SearchBtn.Text = "Tìm kiếm";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // ViewBtn
            // 
            this.ViewBtn.Location = new System.Drawing.Point(14, 407);
            this.ViewBtn.Name = "ViewBtn";
            this.ViewBtn.Size = new System.Drawing.Size(110, 37);
            this.ViewBtn.TabIndex = 8;
            this.ViewBtn.Text = "Xem";
            this.ViewBtn.UseVisualStyleBackColor = true;
            this.ViewBtn.Click += new System.EventHandler(this.ViewBtn_Click);
            // 
            // ThemNvBtn
            // 
            this.ThemNvBtn.Location = new System.Drawing.Point(159, 407);
            this.ThemNvBtn.Name = "ThemNvBtn";
            this.ThemNvBtn.Size = new System.Drawing.Size(143, 37);
            this.ThemNvBtn.TabIndex = 9;
            this.ThemNvBtn.Text = "Thêm nhân viên";
            this.ThemNvBtn.UseVisualStyleBackColor = true;
            this.ThemNvBtn.Click += new System.EventHandler(this.ThemNvBtn_Click);
            // 
            // NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 450);
            this.Controls.Add(this.ThemNvBtn);
            this.Controls.Add(this.ViewBtn);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.NameLb);
            this.Controls.Add(this.SexLb);
            this.Controls.Add(this.PositionLb);
            this.Controls.Add(this.SexCbb);
            this.Controls.Add(this.NameTxb);
            this.Controls.Add(this.PositionCbb);
            this.Controls.Add(this.NhanViendtgv);
            this.Name = "NhanVien";
            this.Text = "NhanVien";
            this.Load += new System.EventHandler(this.NhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NhanViendtgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView NhanViendtgv;
        private System.Windows.Forms.ComboBox PositionCbb;
        private System.Windows.Forms.TextBox NameTxb;
        private System.Windows.Forms.ComboBox SexCbb;
        private System.Windows.Forms.Label PositionLb;
        private System.Windows.Forms.Label SexLb;
        private System.Windows.Forms.Label NameLb;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Button ViewBtn;
        private System.Windows.Forms.Button ThemNvBtn;
    }
}