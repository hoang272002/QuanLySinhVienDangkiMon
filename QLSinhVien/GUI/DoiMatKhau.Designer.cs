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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMKcu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMKmoi = new System.Windows.Forms.TextBox();
            this.btnDoi = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDoi);
            this.groupBox1.Controls.Add(this.txtMKmoi);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMKcu);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(67, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 222);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Đổi mật khẩu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mật khẩu cũ:";
            // 
            // txtMKcu
            // 
            this.txtMKcu.Location = new System.Drawing.Point(143, 46);
            this.txtMKcu.Name = "txtMKcu";
            this.txtMKcu.Size = new System.Drawing.Size(129, 22);
            this.txtMKcu.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mật khẩu mới:";
            // 
            // txtMKmoi
            // 
            this.txtMKmoi.Location = new System.Drawing.Point(143, 102);
            this.txtMKmoi.Name = "txtMKmoi";
            this.txtMKmoi.Size = new System.Drawing.Size(129, 22);
            this.txtMKmoi.TabIndex = 3;
            // 
            // btnDoi
            // 
            this.btnDoi.Location = new System.Drawing.Point(114, 157);
            this.btnDoi.Name = "btnDoi";
            this.btnDoi.Size = new System.Drawing.Size(90, 47);
            this.btnDoi.TabIndex = 4;
            this.btnDoi.Text = "Đổi mật khẩu";
            this.btnDoi.UseVisualStyleBackColor = true;
            this.btnDoi.Click += new System.EventHandler(this.btnDoi_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(33, 274);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(94, 34);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Quay lại";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // DoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 320);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.groupBox1);
            this.Name = "DoiMatKhau";
            this.Text = "Đổi mật khẩu";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDoi;
        private System.Windows.Forms.TextBox txtMKmoi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMKcu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBack;
    }
}