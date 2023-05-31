namespace QuanLyPhongMachTu.UserControls
{
    partial class TraCuuBenh
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
            this.dgvBenh = new System.Windows.Forms.DataGridView();
            this.MaBenh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenBenh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrieuChungBenh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTraCuuBenh = new System.Windows.Forms.Button();
            this.txtMaBN = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHotenBN = new System.Windows.Forms.TextBox();
            this.Title = new System.Windows.Forms.Label();
            this.txtTrieuChungBenh = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLuuBenh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBenh)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBenh
            // 
            this.dgvBenh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBenh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaBenh,
            this.TenBenh,
            this.TrieuChungBenh});
            this.dgvBenh.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvBenh.Location = new System.Drawing.Point(147, 338);
            this.dgvBenh.Name = "dgvBenh";
            this.dgvBenh.RowHeadersVisible = false;
            this.dgvBenh.RowHeadersWidth = 49;
            this.dgvBenh.RowTemplate.Height = 24;
            this.dgvBenh.Size = new System.Drawing.Size(525, 150);
            this.dgvBenh.TabIndex = 68;
            // 
            // MaBenh
            // 
            this.MaBenh.HeaderText = "Mã loại bênh";
            this.MaBenh.MinimumWidth = 6;
            this.MaBenh.Name = "MaBenh";
            this.MaBenh.Width = 90;
            // 
            // TenBenh
            // 
            this.TenBenh.HeaderText = "Tên loại bệnh";
            this.TenBenh.MinimumWidth = 50;
            this.TenBenh.Name = "TenBenh";
            this.TenBenh.Width = 180;
            // 
            // TrieuChungBenh
            // 
            this.TrieuChungBenh.HeaderText = "Triệu chứng bệnh";
            this.TrieuChungBenh.MinimumWidth = 50;
            this.TrieuChungBenh.Name = "TrieuChungBenh";
            this.TrieuChungBenh.Width = 250;
            // 
            // btnTraCuuBenh
            // 
            this.btnTraCuuBenh.Location = new System.Drawing.Point(264, 242);
            this.btnTraCuuBenh.Name = "btnTraCuuBenh";
            this.btnTraCuuBenh.Size = new System.Drawing.Size(82, 30);
            this.btnTraCuuBenh.TabIndex = 67;
            this.btnTraCuuBenh.Text = "Tra cứu";
            this.btnTraCuuBenh.UseVisualStyleBackColor = true;
            // 
            // txtMaBN
            // 
            this.txtMaBN.Location = new System.Drawing.Point(364, 98);
            this.txtMaBN.Margin = new System.Windows.Forms.Padding(1);
            this.txtMaBN.Name = "txtMaBN";
            this.txtMaBN.Size = new System.Drawing.Size(164, 22);
            this.txtMaBN.TabIndex = 66;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(259, 98);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 16);
            this.label10.TabIndex = 65;
            this.label10.Text = "Mã loại bệnh:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(279, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 64;
            this.label1.Text = "Tên bệnh:";
            // 
            // txtHotenBN
            // 
            this.txtHotenBN.Location = new System.Drawing.Point(364, 132);
            this.txtHotenBN.Margin = new System.Windows.Forms.Padding(1);
            this.txtHotenBN.Name = "txtHotenBN";
            this.txtHotenBN.Size = new System.Drawing.Size(164, 22);
            this.txtHotenBN.TabIndex = 63;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold);
            this.Title.ForeColor = System.Drawing.Color.Salmon;
            this.Title.Location = new System.Drawing.Point(268, 6);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(324, 39);
            this.Title.TabIndex = 62;
            this.Title.Text = "THÔNG TIN BỆNH";
            this.Title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtTrieuChungBenh
            // 
            this.txtTrieuChungBenh.Location = new System.Drawing.Point(364, 169);
            this.txtTrieuChungBenh.Margin = new System.Windows.Forms.Padding(1);
            this.txtTrieuChungBenh.Multiline = true;
            this.txtTrieuChungBenh.Name = "txtTrieuChungBenh";
            this.txtTrieuChungBenh.Size = new System.Drawing.Size(164, 34);
            this.txtTrieuChungBenh.TabIndex = 71;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(233, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 16);
            this.label2.TabIndex = 70;
            this.label2.Text = "Triệu chứng bệnh:";
            // 
            // btnLuuBenh
            // 
            this.btnLuuBenh.Location = new System.Drawing.Point(493, 242);
            this.btnLuuBenh.Name = "btnLuuBenh";
            this.btnLuuBenh.Size = new System.Drawing.Size(88, 30);
            this.btnLuuBenh.TabIndex = 69;
            this.btnLuuBenh.Text = "Lưu bệnh";
            this.btnLuuBenh.UseVisualStyleBackColor = true;
            // 
            // TraCuuBenh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.dgvBenh);
            this.Controls.Add(this.btnTraCuuBenh);
            this.Controls.Add(this.txtMaBN);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtHotenBN);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.txtTrieuChungBenh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLuuBenh);
            this.Name = "TraCuuBenh";
            this.Size = new System.Drawing.Size(818, 495);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBenh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBenh;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaBenh;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenBenh;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrieuChungBenh;
        private System.Windows.Forms.Button btnTraCuuBenh;
        private System.Windows.Forms.TextBox txtMaBN;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHotenBN;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.TextBox txtTrieuChungBenh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLuuBenh;
    }
}
