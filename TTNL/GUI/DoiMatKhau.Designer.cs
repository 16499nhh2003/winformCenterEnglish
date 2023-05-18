namespace GUI
{
    partial class DoiMatKhau
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
            this.lb = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtold = new System.Windows.Forms.TextBox();
            this.txtnew = new System.Windows.Forms.TextBox();
            this.txtconfirm = new System.Windows.Forms.TextBox();
            this.btOk = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mật Khẩu hiện tại";
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Location = new System.Drawing.Point(83, 140);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(86, 16);
            this.lb.TabIndex = 1;
            this.lb.Text = "Mật khẩu mới";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Xác Nhận Mật Khẩu mới";
            // 
            // txtold
            // 
            this.txtold.Location = new System.Drawing.Point(252, 83);
            this.txtold.Name = "txtold";
            this.txtold.Size = new System.Drawing.Size(140, 22);
            this.txtold.TabIndex = 4;
            this.txtold.UseSystemPasswordChar = true;
            // 
            // txtnew
            // 
            this.txtnew.Location = new System.Drawing.Point(252, 140);
            this.txtnew.Name = "txtnew";
            this.txtnew.Size = new System.Drawing.Size(140, 22);
            this.txtnew.TabIndex = 5;
            this.txtnew.UseSystemPasswordChar = true;
            // 
            // txtconfirm
            // 
            this.txtconfirm.Location = new System.Drawing.Point(252, 190);
            this.txtconfirm.Name = "txtconfirm";
            this.txtconfirm.Size = new System.Drawing.Size(140, 22);
            this.txtconfirm.TabIndex = 6;
            this.txtconfirm.UseSystemPasswordChar = true;
            // 
            // btOk
            // 
            this.btOk.Location = new System.Drawing.Point(110, 238);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(132, 52);
            this.btOk.TabIndex = 7;
            this.btOk.Text = "Đổi Mật Khẩu";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(260, 238);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(132, 52);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // DoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 342);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.txtconfirm);
            this.Controls.Add(this.txtnew);
            this.Controls.Add(this.txtold);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.label1);
            this.Name = "DoiMatKhau";
            this.Text = "DoiMatKhau";
            this.Load += new System.EventHandler(this.DoiMatKhau_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtold;
        private System.Windows.Forms.TextBox txtnew;
        private System.Windows.Forms.TextBox txtconfirm;
        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.Button btnExit;
    }
}