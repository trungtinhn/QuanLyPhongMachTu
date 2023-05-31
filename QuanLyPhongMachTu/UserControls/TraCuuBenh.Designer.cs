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
            this.Title = new System.Windows.Forms.Label();
            this.txtMaBN = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTraCuuBenh = new System.Windows.Forms.Button();
            this.txtHotenBN = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MaBenh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenBenh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrieuChungBenh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLuuBenh = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTrieuChungBenh = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold);
            this.Title.ForeColor = System.Drawing.Color.Salmon;
            this.Title.Location = new System.Drawing.Point(275, 13);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(324, 39);
            this.Title.TabIndex = 3;
            this.Title.Text = "THÔNG TIN BỆNH";
            this.Title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Title.Click += new System.EventHandler(this.Title_Click);
            // 
            // txtMaBN
            // 
            this.txtMaBN.Location = new System.Drawing.Point(371, 105);
            this.txtMaBN.Margin = new System.Windows.Forms.Padding(1);
            this.txtMaBN.Name = "txtMaBN";
            this.txtMaBN.Size = new System.Drawing.Size(164, 22);
            this.txtMaBN.TabIndex = 52;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(266, 105);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 16);
            this.label10.TabIndex = 51;
            this.label10.Text = "Mã loại bệnh:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(286, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 50;
            this.label1.Text = "Tên bệnh:";
            // 
            // btnTraCuuBenh
            // 
            this.btnTraCuuBenh.Location = new System.Drawing.Point(271, 249);
            this.btnTraCuuBenh.Name = "btnTraCuuBenh";
            this.btnTraCuuBenh.Size = new System.Drawing.Size(82, 30);
            this.btnTraCuuBenh.TabIndex = 57;
            this.btnTraCuuBenh.Text = "Tra cứu";
            this.btnTraCuuBenh.UseVisualStyleBackColor = true;
            // 
            // txtHotenBN
            // 
            this.txtHotenBN.Location = new System.Drawing.Point(371, 139);
            this.txtHotenBN.Margin = new System.Windows.Forms.Padding(1);
            this.txtHotenBN.Name = "txtHotenBN";
            this.txtHotenBN.Size = new System.Drawing.Size(164, 22);
            this.txtHotenBN.TabIndex = 49;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaBenh,
            this.TenBenh,
            this.TrieuChungBenh});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridView1.Location = new System.Drawing.Point(154, 345);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 49;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(525, 150);
            this.dataGridView1.TabIndex = 58;
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
            // btnLuuBenh
            // 
            this.btnLuuBenh.Location = new System.Drawing.Point(500, 249);
            this.btnLuuBenh.Name = "btnLuuBenh";
            this.btnLuuBenh.Size = new System.Drawing.Size(88, 30);
            this.btnLuuBenh.TabIndex = 59;
            this.btnLuuBenh.Text = "Lưu bệnh";
            this.btnLuuBenh.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(240, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 16);
            this.label2.TabIndex = 60;
            this.label2.Text = "Triệu chứng bệnh:";
            // 
            // txtTrieuChungBenh
            // 
            this.txtTrieuChungBenh.Location = new System.Drawing.Point(371, 176);
            this.txtTrieuChungBenh.Margin = new System.Windows.Forms.Padding(1);
            this.txtTrieuChungBenh.Multiline = true;
            this.txtTrieuChungBenh.Name = "txtTrieuChungBenh";
            this.txtTrieuChungBenh.Size = new System.Drawing.Size(164, 34);
            this.txtTrieuChungBenh.TabIndex = 61;
            // 
            // ManHinhTraCuuBenhNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.txtTrieuChungBenh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLuuBenh);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnTraCuuBenh);
            this.Controls.Add(this.txtMaBN);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtHotenBN);
            this.Controls.Add(this.Title);
            this.Name = "ManHinhTraCuuBenhNhan";
            this.Size = new System.Drawing.Size(818, 495);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.TextBox txtMaBN;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTraCuuBenh;
        private System.Windows.Forms.TextBox txtHotenBN;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaBenh;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenBenh;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrieuChungBenh;
        private System.Windows.Forms.Button btnLuuBenh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTrieuChungBenh;
    }
}
