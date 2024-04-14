namespace BTL_LTHSK
{
    partial class QLKH
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TB_makhachhang = new System.Windows.Forms.TextBox();
            this.btn_timkiem = new System.Windows.Forms.Button();
            this.ma = new System.Windows.Forms.Label();
            this.TB_ten = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbMa = new System.Windows.Forms.ComboBox();
            this.TB_sdtKH = new System.Windows.Forms.TextBox();
            this.TB_diachi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_themKH = new System.Windows.Forms.Button();
            this.btn_suaKH = new System.Windows.Forms.Button();
            this.btn_XoaKH = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.dgvKH = new System.Windows.Forms.DataGridView();
            this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKH)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TB_makhachhang);
            this.groupBox1.Controls.Add(this.btn_timkiem);
            this.groupBox1.Controls.Add(this.ma);
            this.groupBox1.Controls.Add(this.TB_ten);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbMa);
            this.groupBox1.Controls.Add(this.TB_sdtKH);
            this.groupBox1.Controls.Add(this.TB_diachi);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(897, 309);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Khách hàng ";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // TB_makhachhang
            // 
            this.TB_makhachhang.Location = new System.Drawing.Point(146, 35);
            this.TB_makhachhang.Name = "TB_makhachhang";
            this.TB_makhachhang.Size = new System.Drawing.Size(277, 22);
            this.TB_makhachhang.TabIndex = 19;
            this.TB_makhachhang.TextChanged += new System.EventHandler(this.TB_makhachhang_TextChanged);
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.Location = new System.Drawing.Point(487, 232);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(92, 24);
            this.btn_timkiem.TabIndex = 9;
            this.btn_timkiem.Text = "Tìm kiếm";
            this.btn_timkiem.UseVisualStyleBackColor = true;
            this.btn_timkiem.Click += new System.EventHandler(this.btn_timkiem_Click);
            // 
            // ma
            // 
            this.ma.AutoSize = true;
            this.ma.Location = new System.Drawing.Point(10, 38);
            this.ma.Name = "ma";
            this.ma.Size = new System.Drawing.Size(98, 16);
            this.ma.TabIndex = 18;
            this.ma.Text = "Mã khách hàng";
            // 
            // TB_ten
            // 
            this.TB_ten.Location = new System.Drawing.Point(148, 74);
            this.TB_ten.Name = "TB_ten";
            this.TB_ten.Size = new System.Drawing.Size(277, 22);
            this.TB_ten.TabIndex = 17;
            this.TB_ten.TextChanged += new System.EventHandler(this.TB_ten_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Tên khách hàng";
            // 
            // cmbMa
            // 
            this.cmbMa.FormattingEnabled = true;
            this.cmbMa.Location = new System.Drawing.Point(161, 232);
            this.cmbMa.Name = "cmbMa";
            this.cmbMa.Size = new System.Drawing.Size(277, 24);
            this.cmbMa.TabIndex = 15;
            this.cmbMa.SelectedIndexChanged += new System.EventHandler(this.cmbMa_SelectedIndexChanged);
            // 
            // TB_sdtKH
            // 
            this.TB_sdtKH.Location = new System.Drawing.Point(146, 173);
            this.TB_sdtKH.Name = "TB_sdtKH";
            this.TB_sdtKH.Size = new System.Drawing.Size(219, 22);
            this.TB_sdtKH.TabIndex = 14;
            this.TB_sdtKH.TextChanged += new System.EventHandler(this.TB_sdtKH_TextChanged);
            // 
            // TB_diachi
            // 
            this.TB_diachi.Location = new System.Drawing.Point(146, 118);
            this.TB_diachi.Name = "TB_diachi";
            this.TB_diachi.Size = new System.Drawing.Size(367, 22);
            this.TB_diachi.TabIndex = 13;
            this.TB_diachi.TextChanged += new System.EventHandler(this.TB_diachi_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Số điện thoại";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Địa chỉ ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã khách hàng đã tạo";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 441);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(143, 16);
            this.label11.TabIndex = 2;
            this.label11.Text = "Danh sách khách hàng";
            // 
            // btn_themKH
            // 
            this.btn_themKH.Location = new System.Drawing.Point(49, 346);
            this.btn_themKH.Name = "btn_themKH";
            this.btn_themKH.Size = new System.Drawing.Size(129, 41);
            this.btn_themKH.TabIndex = 3;
            this.btn_themKH.Text = "Thêm ";
            this.btn_themKH.UseVisualStyleBackColor = true;
            this.btn_themKH.Click += new System.EventHandler(this.btn_themKH_Click);
            // 
            // btn_suaKH
            // 
            this.btn_suaKH.Location = new System.Drawing.Point(290, 346);
            this.btn_suaKH.Name = "btn_suaKH";
            this.btn_suaKH.Size = new System.Drawing.Size(113, 41);
            this.btn_suaKH.TabIndex = 4;
            this.btn_suaKH.Text = "Sửa";
            this.btn_suaKH.UseVisualStyleBackColor = true;
            this.btn_suaKH.Click += new System.EventHandler(this.btn_suaKH_Click);
            // 
            // btn_XoaKH
            // 
            this.btn_XoaKH.Location = new System.Drawing.Point(509, 346);
            this.btn_XoaKH.Name = "btn_XoaKH";
            this.btn_XoaKH.Size = new System.Drawing.Size(114, 41);
            this.btn_XoaKH.TabIndex = 5;
            this.btn_XoaKH.Text = "Xoá";
            this.btn_XoaKH.UseVisualStyleBackColor = true;
            this.btn_XoaKH.Click += new System.EventHandler(this.btn_XoaKH_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(733, 346);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(114, 41);
            this.btn_exit.TabIndex = 6;
            this.btn_exit.Text = "Thoát";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // dgvKH
            // 
            this.dgvKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKH,
            this.tenKH,
            this.Diachi,
            this.SDT});
            this.dgvKH.Location = new System.Drawing.Point(10, 461);
            this.dgvKH.Name = "dgvKH";
            this.dgvKH.RowHeadersWidth = 51;
            this.dgvKH.RowTemplate.Height = 24;
            this.dgvKH.Size = new System.Drawing.Size(899, 278);
            this.dgvKH.TabIndex = 10;
            this.dgvKH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKH_CellClick);
            // 
            // MaKH
            // 
            this.MaKH.DataPropertyName = "MaDT";
            this.MaKH.HeaderText = "Mã khách hàng";
            this.MaKH.MinimumWidth = 6;
            this.MaKH.Name = "MaKH";
            this.MaKH.ReadOnly = true;
            this.MaKH.Width = 125;
            // 
            // tenKH
            // 
            this.tenKH.DataPropertyName = "TenDT";
            this.tenKH.HeaderText = "Tên khách hàng";
            this.tenKH.MinimumWidth = 6;
            this.tenKH.Name = "tenKH";
            this.tenKH.ReadOnly = true;
            this.tenKH.Width = 125;
            // 
            // Diachi
            // 
            this.Diachi.DataPropertyName = "DiaChi";
            this.Diachi.HeaderText = "Địa chỉ ";
            this.Diachi.MinimumWidth = 6;
            this.Diachi.Name = "Diachi";
            this.Diachi.ReadOnly = true;
            this.Diachi.Width = 125;
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "Số điện thoại";
            this.SDT.MinimumWidth = 6;
            this.SDT.Name = "SDT";
            this.SDT.ReadOnly = true;
            this.SDT.Width = 125;
            // 
            // QLKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 750);
            this.Controls.Add(this.dgvKH);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_XoaKH);
            this.Controls.Add(this.btn_suaKH);
            this.Controls.Add(this.btn_themKH);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox1);
            this.Name = "QLKH";
            this.Text = "Quản lý khách hàng ";
            this.Load += new System.EventHandler(this.LoadQLKH);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_themKH;
        private System.Windows.Forms.Button btn_suaKH;
        private System.Windows.Forms.Button btn_XoaKH;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.TextBox TB_diachi;
        private System.Windows.Forms.TextBox TB_sdtKH;
        private System.Windows.Forms.Button btn_timkiem;
        private System.Windows.Forms.TextBox TB_ten;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbMa;
        private System.Windows.Forms.DataGridView dgvKH;
        private System.Windows.Forms.TextBox TB_makhachhang;
        private System.Windows.Forms.Label ma;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
    }
}

