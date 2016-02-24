namespace QlGaTau
{
    partial class QLChuyenDi
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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Grid = new System.Windows.Forms.DataGridView();
            this.txtMacd = new System.Windows.Forms.TextBox();
            this.txtGakh = new System.Windows.Forms.TextBox();
            this.txtGakt = new System.Windows.Forms.TextBox();
            this.cbTentau = new System.Windows.Forms.ComboBox();
            this.Them = new System.Windows.Forms.Button();
            this.Sua = new System.Windows.Forms.Button();
            this.Xoa = new System.Windows.Forms.Button();
            this.Macd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Matau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gakh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GaD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Giokh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngaykh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtGioKH = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã chuyến đi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(292, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên tàu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ga khởi hành";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(292, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ga kết thúc";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Giờ khởi hành";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(292, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ngày khởi hành";
            // 
            // Grid
            // 
            this.Grid.AllowUserToAddRows = false;
            this.Grid.AllowUserToDeleteRows = false;
            this.Grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Macd,
            this.Matau,
            this.Gakh,
            this.GaD,
            this.Giokh,
            this.Ngaykh});
            this.Grid.Location = new System.Drawing.Point(35, 232);
            this.Grid.Name = "Grid";
            this.Grid.ReadOnly = true;
            this.Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid.Size = new System.Drawing.Size(481, 185);
            this.Grid.TabIndex = 6;
            this.Grid.SelectionChanged += new System.EventHandler(this.Grid_SelectionChanged);
            // 
            // txtMacd
            // 
            this.txtMacd.Location = new System.Drawing.Point(128, 37);
            this.txtMacd.Name = "txtMacd";
            this.txtMacd.Size = new System.Drawing.Size(100, 20);
            this.txtMacd.TabIndex = 1;
            // 
            // txtGakh
            // 
            this.txtGakh.Location = new System.Drawing.Point(128, 81);
            this.txtGakh.Name = "txtGakh";
            this.txtGakh.Size = new System.Drawing.Size(100, 20);
            this.txtGakh.TabIndex = 3;
            // 
            // txtGakt
            // 
            this.txtGakt.Location = new System.Drawing.Point(383, 81);
            this.txtGakt.Name = "txtGakt";
            this.txtGakt.Size = new System.Drawing.Size(121, 20);
            this.txtGakt.TabIndex = 4;
            // 
            // cbTentau
            // 
            this.cbTentau.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTentau.FormattingEnabled = true;
            this.cbTentau.Location = new System.Drawing.Point(383, 37);
            this.cbTentau.Name = "cbTentau";
            this.cbTentau.Size = new System.Drawing.Size(121, 21);
            this.cbTentau.TabIndex = 2;
            // 
            // Them
            // 
            this.Them.Location = new System.Drawing.Point(93, 180);
            this.Them.Name = "Them";
            this.Them.Size = new System.Drawing.Size(75, 23);
            this.Them.TabIndex = 13;
            this.Them.Text = "Thêm";
            this.Them.UseVisualStyleBackColor = true;
            this.Them.Click += new System.EventHandler(this.Them_Click);
            // 
            // Sua
            // 
            this.Sua.Location = new System.Drawing.Point(236, 180);
            this.Sua.Name = "Sua";
            this.Sua.Size = new System.Drawing.Size(75, 23);
            this.Sua.TabIndex = 14;
            this.Sua.Text = "Sửa";
            this.Sua.UseVisualStyleBackColor = true;
            this.Sua.Click += new System.EventHandler(this.Sua_Click);
            // 
            // Xoa
            // 
            this.Xoa.Location = new System.Drawing.Point(383, 180);
            this.Xoa.Name = "Xoa";
            this.Xoa.Size = new System.Drawing.Size(75, 23);
            this.Xoa.TabIndex = 15;
            this.Xoa.Text = "Xóa";
            this.Xoa.UseVisualStyleBackColor = true;
            this.Xoa.Click += new System.EventHandler(this.Xoa_Click);
            // 
            // Macd
            // 
            this.Macd.DataPropertyName = "Macd";
            this.Macd.HeaderText = "Mã CĐ";
            this.Macd.Name = "Macd";
            this.Macd.ReadOnly = true;
            // 
            // Matau
            // 
            this.Matau.DataPropertyName = "Matau";
            this.Matau.HeaderText = "Mã Tàu";
            this.Matau.Name = "Matau";
            this.Matau.ReadOnly = true;
            // 
            // Gakh
            // 
            this.Gakh.DataPropertyName = "Gakh";
            this.Gakh.HeaderText = "Ga KH";
            this.Gakh.Name = "Gakh";
            this.Gakh.ReadOnly = true;
            // 
            // GaD
            // 
            this.GaD.DataPropertyName = "GaD";
            this.GaD.HeaderText = "Ga KT";
            this.GaD.Name = "GaD";
            this.GaD.ReadOnly = true;
            // 
            // Giokh
            // 
            this.Giokh.DataPropertyName = "Giokh";
            this.Giokh.HeaderText = "Giờ KH";
            this.Giokh.Name = "Giokh";
            this.Giokh.ReadOnly = true;
            // 
            // Ngaykh
            // 
            this.Ngaykh.DataPropertyName = "Ngaykh";
            this.Ngaykh.HeaderText = "Ngày KH";
            this.Ngaykh.Name = "Ngaykh";
            this.Ngaykh.ReadOnly = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(383, 124);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(121, 20);
            this.dateTimePicker1.TabIndex = 6;
            this.dateTimePicker1.Value = new System.DateTime(2016, 2, 24, 0, 0, 0, 0);
            // 
            // txtGioKH
            // 
            this.txtGioKH.Location = new System.Drawing.Point(128, 127);
            this.txtGioKH.Name = "txtGioKH";
            this.txtGioKH.Size = new System.Drawing.Size(100, 20);
            this.txtGioKH.TabIndex = 5;
            // 
            // QLChuyenDi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 447);
            this.Controls.Add(this.txtGioKH);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Xoa);
            this.Controls.Add(this.Sua);
            this.Controls.Add(this.Them);
            this.Controls.Add(this.cbTentau);
            this.Controls.Add(this.txtGakt);
            this.Controls.Add(this.txtGakh);
            this.Controls.Add(this.txtMacd);
            this.Controls.Add(this.Grid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "QLChuyenDi";
            this.Text = "Quản lý chuyến đi";
            this.Load += new System.EventHandler(this.QLChuyenDi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.TextBox txtMacd;
        private System.Windows.Forms.TextBox txtGakh;
        private System.Windows.Forms.TextBox txtGakt;
        private System.Windows.Forms.ComboBox cbTentau;
        private System.Windows.Forms.Button Them;
        private System.Windows.Forms.Button Sua;
        private System.Windows.Forms.Button Xoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Macd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Matau;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gakh;
        private System.Windows.Forms.DataGridViewTextBoxColumn GaD;
        private System.Windows.Forms.DataGridViewTextBoxColumn Giokh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngaykh;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtGioKH;
    }
}