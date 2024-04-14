namespace BTL_LTHSK
{
    partial class Hienthongtin
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBCN = new System.Windows.Forms.Button();
            this.btnBCD = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(147, 163);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 72);
            this.button1.TabIndex = 0;
            this.button1.Text = "Khách hàng";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(408, 163);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 72);
            this.button2.TabIndex = 1;
            this.button2.Text = "Nhà cung cấp";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(129, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Chọn đối tượng nhập";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBCD);
            this.groupBox1.Controls.Add(this.btnBCN);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 426);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btnBCN
            // 
            this.btnBCN.Location = new System.Drawing.Point(147, 354);
            this.btnBCN.Name = "btnBCN";
            this.btnBCN.Size = new System.Drawing.Size(235, 40);
            this.btnBCN.TabIndex = 3;
            this.btnBCN.Text = "Hiện danh sách khách hàng là nhà cung cấp";
            this.btnBCN.UseVisualStyleBackColor = true;
            this.btnBCN.Click += new System.EventHandler(this.btnBCN_Click);
            // 
            // btnBCD
            // 
            this.btnBCD.Location = new System.Drawing.Point(147, 291);
            this.btnBCD.Name = "btnBCD";
            this.btnBCD.Size = new System.Drawing.Size(235, 38);
            this.btnBCD.TabIndex = 4;
            this.btnBCD.Text = "Hiện danh sách khách hàng";
            this.btnBCD.UseVisualStyleBackColor = true;
            this.btnBCD.Click += new System.EventHandler(this.btnBCD_Click);
            // 
            // Hienthongtin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Hienthongtin";
            this.Text = "Hienthongtin";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBCD;
        private System.Windows.Forms.Button btnBCN;
    }
}