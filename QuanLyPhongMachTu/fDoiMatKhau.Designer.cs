namespace QuanLyPhongMachTu
{
    partial class fDoiMatKhau
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Doimatkhau = new System.Windows.Forms.Label();
            this.lbl_Matkhauhientai = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Bisque;
            this.panel1.Controls.Add(this.lbl_Matkhauhientai);
            this.panel1.Controls.Add(this.lbl_Doimatkhau);
            this.panel1.Location = new System.Drawing.Point(220, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(484, 459);
            this.panel1.TabIndex = 0;
            // 
            // lbl_Doimatkhau
            // 
            this.lbl_Doimatkhau.AutoSize = true;
            this.lbl_Doimatkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.97015F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Doimatkhau.ForeColor = System.Drawing.Color.IndianRed;
            this.lbl_Doimatkhau.Location = new System.Drawing.Point(133, 47);
            this.lbl_Doimatkhau.Name = "lbl_Doimatkhau";
            this.lbl_Doimatkhau.Size = new System.Drawing.Size(211, 30);
            this.lbl_Doimatkhau.TabIndex = 0;
            this.lbl_Doimatkhau.Text = "ĐỔI MẬT KHẨU";
            // 
            // lbl_Matkhauhientai
            // 
            this.lbl_Matkhauhientai.AutoSize = true;
            this.lbl_Matkhauhientai.Location = new System.Drawing.Point(60, 111);
            this.lbl_Matkhauhientai.Name = "lbl_Matkhauhientai";
            this.lbl_Matkhauhientai.Size = new System.Drawing.Size(111, 16);
            this.lbl_Matkhauhientai.TabIndex = 1;
            this.lbl_Matkhauhientai.Text = "Mật khẩu hiện tại*";
            // 
            // fDoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(933, 609);
            this.Controls.Add(this.panel1);
            this.Name = "fDoiMatKhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fDoiMatKhau";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Doimatkhau;
        private System.Windows.Forms.Label lbl_Matkhauhientai;
    }
}