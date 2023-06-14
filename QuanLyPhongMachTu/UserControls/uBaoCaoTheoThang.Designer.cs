namespace QuanLyPhongMachTu.UserControls
{
    partial class uBaoCaoTheoThang
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
            this.dgv_baocao = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoBenhNhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoanhThu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TyLe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_NgayThang = new System.Windows.Forms.Label();
            this.lb_Baocaodoanhthu = new System.Windows.Forms.Label();
            this.cbb_thang = new System.Windows.Forms.ComboBox();
            this.lbl_nam = new System.Windows.Forms.Label();
            this.cbb_nam = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_baocao)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_baocao
            // 
            this.dgv_baocao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_baocao.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_baocao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_baocao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.Ngay,
            this.SoBenhNhan,
            this.DoanhThu,
            this.TyLe});
            this.dgv_baocao.Location = new System.Drawing.Point(162, 208);
            this.dgv_baocao.Name = "dgv_baocao";
            this.dgv_baocao.RowHeadersVisible = false;
            this.dgv_baocao.RowHeadersWidth = 57;
            this.dgv_baocao.RowTemplate.Height = 24;
            this.dgv_baocao.Size = new System.Drawing.Size(983, 402);
            this.dgv_baocao.TabIndex = 7;
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 7;
            this.STT.Name = "STT";
            // 
            // Ngay
            // 
            this.Ngay.HeaderText = "Ngày";
            this.Ngay.MinimumWidth = 7;
            this.Ngay.Name = "Ngay";
            // 
            // SoBenhNhan
            // 
            this.SoBenhNhan.HeaderText = "Số Bệnh Nhân";
            this.SoBenhNhan.MinimumWidth = 7;
            this.SoBenhNhan.Name = "SoBenhNhan";
            // 
            // DoanhThu
            // 
            this.DoanhThu.HeaderText = "Doanh Thu";
            this.DoanhThu.MinimumWidth = 7;
            this.DoanhThu.Name = "DoanhThu";
            // 
            // TyLe
            // 
            this.TyLe.HeaderText = "Tỷ Lệ";
            this.TyLe.MinimumWidth = 7;
            this.TyLe.Name = "TyLe";
            // 
            // lbl_NgayThang
            // 
            this.lbl_NgayThang.AutoSize = true;
            this.lbl_NgayThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.059701F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NgayThang.Location = new System.Drawing.Point(392, 134);
            this.lbl_NgayThang.Name = "lbl_NgayThang";
            this.lbl_NgayThang.Size = new System.Drawing.Size(54, 18);
            this.lbl_NgayThang.TabIndex = 6;
            this.lbl_NgayThang.Text = "Tháng";
            // 
            // lb_Baocaodoanhthu
            // 
            this.lb_Baocaodoanhthu.AutoSize = true;
            this.lb_Baocaodoanhthu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.97015F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Baocaodoanhthu.ForeColor = System.Drawing.Color.IndianRed;
            this.lb_Baocaodoanhthu.Location = new System.Drawing.Point(482, 62);
            this.lb_Baocaodoanhthu.Name = "lb_Baocaodoanhthu";
            this.lb_Baocaodoanhthu.Size = new System.Drawing.Size(277, 31);
            this.lb_Baocaodoanhthu.TabIndex = 5;
            this.lb_Baocaodoanhthu.Text = "Báo Cáo Doanh Thu";
            // 
            // cbb_thang
            // 
            this.cbb_thang.FormattingEnabled = true;
            this.cbb_thang.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbb_thang.Location = new System.Drawing.Point(473, 134);
            this.cbb_thang.Name = "cbb_thang";
            this.cbb_thang.Size = new System.Drawing.Size(121, 24);
            this.cbb_thang.TabIndex = 8;
            // 
            // lbl_nam
            // 
            this.lbl_nam.AutoSize = true;
            this.lbl_nam.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.059701F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nam.Location = new System.Drawing.Point(641, 135);
            this.lbl_nam.Name = "lbl_nam";
            this.lbl_nam.Size = new System.Drawing.Size(43, 18);
            this.lbl_nam.TabIndex = 9;
            this.lbl_nam.Text = "Năm";
            // 
            // cbb_nam
            // 
            this.cbb_nam.FormattingEnabled = true;
            this.cbb_nam.Items.AddRange(new object[] {
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023"});
            this.cbb_nam.Location = new System.Drawing.Point(723, 135);
            this.cbb_nam.Name = "cbb_nam";
            this.cbb_nam.Size = new System.Drawing.Size(121, 24);
            this.cbb_nam.TabIndex = 10;
            // 
            // uBaoCaoTheoThang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.Controls.Add(this.cbb_nam);
            this.Controls.Add(this.lbl_nam);
            this.Controls.Add(this.cbb_thang);
            this.Controls.Add(this.dgv_baocao);
            this.Controls.Add(this.lbl_NgayThang);
            this.Controls.Add(this.lb_Baocaodoanhthu);
            this.Name = "uBaoCaoTheoThang";
            this.Size = new System.Drawing.Size(1343, 698);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_baocao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_baocao;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngay;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoBenhNhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoanhThu;
        private System.Windows.Forms.DataGridViewTextBoxColumn TyLe;
        private System.Windows.Forms.Label lbl_NgayThang;
        private System.Windows.Forms.Label lb_Baocaodoanhthu;
        private System.Windows.Forms.ComboBox cbb_thang;
        private System.Windows.Forms.Label lbl_nam;
        private System.Windows.Forms.ComboBox cbb_nam;
    }
}
