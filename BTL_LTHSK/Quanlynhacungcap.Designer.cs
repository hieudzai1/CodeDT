namespace BTL_LTHSK
{
    partial class Quanlynhacungcap
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.GBncc = new System.Windows.Forms.GroupBox();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.TB_MaNCC = new System.Windows.Forms.TextBox();
            this.TB_TenNCC = new System.Windows.Forms.TextBox();
            this.TB_DCNCC = new System.Windows.Forms.TextBox();
            this.TB_SDTNCC = new System.Windows.Forms.TextBox();
            this.cmbMancc = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.dgvNCC = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.MaNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenncc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdtncc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GBncc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNCC)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhà cung cấp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên nhà cung cấp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Địa chỉ nhà cung cấp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số điện thoại nhà cung cấp ";
            // 
            // GBncc
            // 
            this.GBncc.Controls.Add(this.btntimkiem);
            this.GBncc.Controls.Add(this.TB_MaNCC);
            this.GBncc.Controls.Add(this.TB_TenNCC);
            this.GBncc.Controls.Add(this.TB_DCNCC);
            this.GBncc.Controls.Add(this.TB_SDTNCC);
            this.GBncc.Controls.Add(this.cmbMancc);
            this.GBncc.Controls.Add(this.label5);
            this.GBncc.Controls.Add(this.label4);
            this.GBncc.Controls.Add(this.label3);
            this.GBncc.Controls.Add(this.label2);
            this.GBncc.Controls.Add(this.label1);
            this.GBncc.Location = new System.Drawing.Point(12, 12);
            this.GBncc.Name = "GBncc";
            this.GBncc.Size = new System.Drawing.Size(862, 291);
            this.GBncc.TabIndex = 4;
            this.GBncc.TabStop = false;
            this.GBncc.Text = "Nhà cung cấp";
            // 
            // btntimkiem
            // 
            this.btntimkiem.Location = new System.Drawing.Point(484, 216);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(90, 23);
            this.btntimkiem.TabIndex = 10;
            this.btntimkiem.Text = "Tìm kiếm";
            this.btntimkiem.UseVisualStyleBackColor = true;
            // 
            // TB_MaNCC
            // 
            this.TB_MaNCC.Location = new System.Drawing.Point(183, 33);
            this.TB_MaNCC.Name = "TB_MaNCC";
            this.TB_MaNCC.Size = new System.Drawing.Size(255, 22);
            this.TB_MaNCC.TabIndex = 9;
            this.TB_MaNCC.TextChanged += new System.EventHandler(this.TB_MaNCC_TextChanged);
            // 
            // TB_TenNCC
            // 
            this.TB_TenNCC.Location = new System.Drawing.Point(183, 76);
            this.TB_TenNCC.Name = "TB_TenNCC";
            this.TB_TenNCC.Size = new System.Drawing.Size(255, 22);
            this.TB_TenNCC.TabIndex = 8;
            this.TB_TenNCC.TextChanged += new System.EventHandler(this.TB_TenNCC_TextChanged);
            // 
            // TB_DCNCC
            // 
            this.TB_DCNCC.Location = new System.Drawing.Point(183, 117);
            this.TB_DCNCC.Name = "TB_DCNCC";
            this.TB_DCNCC.Size = new System.Drawing.Size(357, 22);
            this.TB_DCNCC.TabIndex = 7;
            this.TB_DCNCC.TextChanged += new System.EventHandler(this.TB_DCNCC_TextChanged);
            // 
            // TB_SDTNCC
            // 
            this.TB_SDTNCC.Location = new System.Drawing.Point(183, 168);
            this.TB_SDTNCC.Name = "TB_SDTNCC";
            this.TB_SDTNCC.Size = new System.Drawing.Size(255, 22);
            this.TB_SDTNCC.TabIndex = 6;
            this.TB_SDTNCC.TextChanged += new System.EventHandler(this.TB_SDTNCC_TextChanged);
            // 
            // cmbMancc
            // 
            this.cmbMancc.FormattingEnabled = true;
            this.cmbMancc.Location = new System.Drawing.Point(183, 216);
            this.cmbMancc.Name = "cmbMancc";
            this.cmbMancc.Size = new System.Drawing.Size(255, 24);
            this.cmbMancc.TabIndex = 5;
            this.cmbMancc.SelectedIndexChanged += new System.EventHandler(this.cmbMancc_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mã nhà cung cấp đã tạo";
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(41, 327);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(91, 44);
            this.btn_Them.TabIndex = 5;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(250, 327);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(91, 44);
            this.btn_Sua.TabIndex = 6;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(461, 327);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(91, 44);
            this.btn_Xoa.TabIndex = 7;
            this.btn_Xoa.Text = "Xoá";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(697, 327);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(91, 44);
            this.btn_Thoat.TabIndex = 8;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // dgvNCC
            // 
            this.dgvNCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNCC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNCC,
            this.tenncc,
            this.diachi,
            this.sdtncc});
            this.dgvNCC.Location = new System.Drawing.Point(12, 417);
            this.dgvNCC.Name = "dgvNCC";
            this.dgvNCC.RowHeadersWidth = 51;
            this.dgvNCC.RowTemplate.Height = 24;
            this.dgvNCC.Size = new System.Drawing.Size(862, 270);
            this.dgvNCC.TabIndex = 9;
            this.dgvNCC.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNCC_CellClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 398);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Danh sách nhà cung cấp";
            // 
            // MaNCC
            // 
            this.MaNCC.DataPropertyName = "MaDT";
            this.MaNCC.HeaderText = "Mã nhà cung cấp";
            this.MaNCC.MinimumWidth = 6;
            this.MaNCC.Name = "MaNCC";
            this.MaNCC.ReadOnly = true;
            this.MaNCC.Width = 200;
            // 
            // tenncc
            // 
            this.tenncc.DataPropertyName = "TenDT";
            this.tenncc.HeaderText = "Tên nhà cung cấp";
            this.tenncc.MinimumWidth = 6;
            this.tenncc.Name = "tenncc";
            this.tenncc.ReadOnly = true;
            this.tenncc.Width = 200;
            // 
            // diachi
            // 
            this.diachi.DataPropertyName = "DiaChi";
            this.diachi.HeaderText = "Địa chỉ";
            this.diachi.MinimumWidth = 6;
            this.diachi.Name = "diachi";
            this.diachi.ReadOnly = true;
            this.diachi.Width = 250;
            // 
            // sdtncc
            // 
            this.sdtncc.DataPropertyName = "SDT";
            this.sdtncc.HeaderText = "Số điện thoại";
            this.sdtncc.MinimumWidth = 6;
            this.sdtncc.Name = "sdtncc";
            this.sdtncc.ReadOnly = true;
            this.sdtncc.Width = 175;
            // 
            // Quanlynhacungcap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 699);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvNCC);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.GBncc);
            this.Name = "Quanlynhacungcap";
            this.Text = "Quanlynhacungcap";
            this.Load += new System.EventHandler(this.Quanlynhacungcap_Load);
            this.GBncc.ResumeLayout(false);
            this.GBncc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNCC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox GBncc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TB_MaNCC;
        private System.Windows.Forms.TextBox TB_TenNCC;
        private System.Windows.Forms.TextBox TB_DCNCC;
        private System.Windows.Forms.TextBox TB_SDTNCC;
        private System.Windows.Forms.ComboBox cmbMancc;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.DataGridView dgvNCC;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenncc;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdtncc;
    }
}