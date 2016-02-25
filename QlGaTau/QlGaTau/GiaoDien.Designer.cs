namespace QlGaTau
{
    partial class GiaoDien
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
            this.QLDangNhap = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // QLDangNhap
            // 
            this.QLDangNhap.Location = new System.Drawing.Point(54, 61);
            this.QLDangNhap.Name = "QLDangNhap";
            this.QLDangNhap.Size = new System.Drawing.Size(118, 49);
            this.QLDangNhap.TabIndex = 0;
            this.QLDangNhap.Text = "Quản lý Tài khoản";
            this.QLDangNhap.UseVisualStyleBackColor = true;
            this.QLDangNhap.Click += new System.EventHandler(this.QLDangNhap_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(226, 61);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 49);
            this.button2.TabIndex = 1;
            this.button2.Text = "Quản lý Tàu";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(411, 61);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(118, 49);
            this.button3.TabIndex = 2;
            this.button3.Text = "Quản lý Toa";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(226, 182);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(118, 48);
            this.button5.TabIndex = 4;
            this.button5.Text = "Quản lý Chuyến đi";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(411, 182);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(118, 48);
            this.button6.TabIndex = 5;
            this.button6.Text = "Đặt vé";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(54, 182);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 49);
            this.button1.TabIndex = 6;
            this.button1.Text = "Quản lý ghế";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GiaoDien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 323);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.QLDangNhap);
            this.Name = "GiaoDien";
            this.Text = "Giao Diện";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button QLDangNhap;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button1;
    }
}