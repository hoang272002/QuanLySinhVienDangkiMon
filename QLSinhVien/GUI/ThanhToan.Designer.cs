namespace GUI
{
    partial class ThanhToan
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.txtTong = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxPTH = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã hóa đơn: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.cbxPTH);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtTong);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMaHD);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(108, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(415, 279);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin hóa đơn";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(800, 390);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 2;
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(216, 44);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(126, 22);
            this.txtMaHD.TabIndex = 1;
            // 
            // txtTong
            // 
            this.txtTong.Location = new System.Drawing.Point(216, 169);
            this.txtTong.Name = "txtTong";
            this.txtTong.Size = new System.Drawing.Size(126, 22);
            this.txtTong.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tổng tiền: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Chọn phương thức thanh toán: ";
            // 
            // cbxPTH
            // 
            this.cbxPTH.FormattingEnabled = true;
            this.cbxPTH.Items.AddRange(new object[] {
            "Credit card",
            "Thanh toán sau khi nhận hàng",
            "Thẻ ngân hàng",
            "MOMO"});
            this.cbxPTH.Location = new System.Drawing.Point(216, 109);
            this.cbxPTH.Name = "cbxPTH";
            this.cbxPTH.Size = new System.Drawing.Size(141, 24);
            this.cbxPTH.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(161, 218);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 43);
            this.button1.TabIndex = 6;
            this.button1.Text = "Thanh toán";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 374);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "ThanhToan";
            this.Text = "Thanh toán";
            this.Load += new System.EventHandler(this.ThanhToan_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbxPTH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.TextBox textBox1;
    }
}