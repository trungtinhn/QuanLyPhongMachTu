namespace QuanLyPhongMachTu.UserControls
{
    partial class uBaoCao
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.vbButton1 = new CustomButton.VBButton();
            this.btn_baocaodoanhthu = new CustomButton.VBButton();
            this.uBaoCaoTheoThang = new QuanLyPhongMachTu.UserControls.uBaoCaoTheoThang();
            this.uBaoCaoSDThuoc = new QuanLyPhongMachTu.UserControls.uBaoCaoSDThuoc();
            this.panel_tool = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel_tool.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.uBaoCaoTheoThang);
            this.panel1.Controls.Add(this.uBaoCaoSDThuoc);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1148, 512);
            this.panel1.TabIndex = 0;
            // 
            // vbButton1
            // 
            this.vbButton1.BackColor = System.Drawing.Color.Maroon;
            this.vbButton1.BackgroundColor = System.Drawing.Color.Maroon;
            this.vbButton1.BorderColor = System.Drawing.Color.MediumVioletRed;
            this.vbButton1.BorderRadius = 20;
            this.vbButton1.BorderSize = 3;
            this.vbButton1.FlatAppearance.BorderSize = 0;
            this.vbButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vbButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.059701F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vbButton1.ForeColor = System.Drawing.Color.Gainsboro;
            this.vbButton1.Location = new System.Drawing.Point(248, 0);
            this.vbButton1.Name = "vbButton1";
            this.vbButton1.Size = new System.Drawing.Size(207, 40);
            this.vbButton1.TabIndex = 1;
            this.vbButton1.Text = "Báo Cáo Sử Dụng Thuốc";
            this.vbButton1.TextColor = System.Drawing.Color.Gainsboro;
            this.vbButton1.UseVisualStyleBackColor = false;
            this.vbButton1.Click += new System.EventHandler(this.vbButton1_Click);
            // 
            // btn_baocaodoanhthu
            // 
            this.btn_baocaodoanhthu.BackColor = System.Drawing.Color.Maroon;
            this.btn_baocaodoanhthu.BackgroundColor = System.Drawing.Color.Maroon;
            this.btn_baocaodoanhthu.BorderColor = System.Drawing.Color.MediumVioletRed;
            this.btn_baocaodoanhthu.BorderRadius = 20;
            this.btn_baocaodoanhthu.BorderSize = 3;
            this.btn_baocaodoanhthu.FlatAppearance.BorderSize = 0;
            this.btn_baocaodoanhthu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_baocaodoanhthu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.059701F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_baocaodoanhthu.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_baocaodoanhthu.Location = new System.Drawing.Point(43, 0);
            this.btn_baocaodoanhthu.Name = "btn_baocaodoanhthu";
            this.btn_baocaodoanhthu.Size = new System.Drawing.Size(174, 40);
            this.btn_baocaodoanhthu.TabIndex = 0;
            this.btn_baocaodoanhthu.Text = "Báo Cáo Doanh Thu";
            this.btn_baocaodoanhthu.TextColor = System.Drawing.Color.Gainsboro;
            this.btn_baocaodoanhthu.UseVisualStyleBackColor = false;
            this.btn_baocaodoanhthu.Click += new System.EventHandler(this.btn_baocaodoanhthu_Click);
            // 
            // uBaoCaoTheoThang
            // 
            this.uBaoCaoTheoThang.BackColor = System.Drawing.Color.PeachPuff;
            this.uBaoCaoTheoThang.Location = new System.Drawing.Point(25, 3);
            this.uBaoCaoTheoThang.Name = "uBaoCaoTheoThang";
            this.uBaoCaoTheoThang.Size = new System.Drawing.Size(1106, 483);
            this.uBaoCaoTheoThang.TabIndex = 0;
            // 
            // uBaoCaoSDThuoc
            // 
            this.uBaoCaoSDThuoc.BackColor = System.Drawing.Color.PeachPuff;
            this.uBaoCaoSDThuoc.Location = new System.Drawing.Point(16, 3);
            this.uBaoCaoSDThuoc.Name = "uBaoCaoSDThuoc";
            this.uBaoCaoSDThuoc.Size = new System.Drawing.Size(1078, 456);
            this.uBaoCaoSDThuoc.TabIndex = 1;
            // 
            // panel_tool
            // 
            this.panel_tool.Controls.Add(this.vbButton1);
            this.panel_tool.Controls.Add(this.btn_baocaodoanhthu);
            this.panel_tool.Location = new System.Drawing.Point(60, 12);
            this.panel_tool.Name = "panel_tool";
            this.panel_tool.Size = new System.Drawing.Size(458, 40);
            this.panel_tool.TabIndex = 2;
            // 
            // uBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.Controls.Add(this.panel_tool);
            this.Controls.Add(this.panel1);
            this.Name = "uBaoCao";
            this.Size = new System.Drawing.Size(1148, 582);
            this.panel1.ResumeLayout(false);
            this.panel_tool.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private CustomButton.VBButton btn_baocaodoanhthu;
        private CustomButton.VBButton vbButton1;
        private uBaoCaoTheoThang uBaoCaoTheoThang;
        private uBaoCaoSDThuoc uBaoCaoSDThuoc;
        private System.Windows.Forms.Panel panel_tool;
    }
}
