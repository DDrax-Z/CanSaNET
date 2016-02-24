namespace QlGaTau
{
    partial class QLToa
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
            this.txtMatoa = new System.Windows.Forms.TextBox();
            this.cbLoaitoa = new System.Windows.Forms.ComboBox();
            this.cbMatau = new System.Windows.Forms.ComboBox();
            this.Grid = new System.Windows.Forms.DataGridView();
            this.Them = new System.Windows.Forms.Button();
            this.Sua = new System.Windows.Forms.Button();
            this.Xoa = new System.Windows.Forms.Button();
            this.MaTau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaToa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiToa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã tàu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã toa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Loại toa";
            // 
            // txtMatoa
            // 
            this.txtMatoa.Location = new System.Drawing.Point(143, 70);
            this.txtMatoa.Name = "txtMatoa";
            this.txtMatoa.Size = new System.Drawing.Size(121, 20);
            this.txtMatoa.TabIndex = 4;
            // 
            // cbLoaitoa
            // 
            this.cbLoaitoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLoaitoa.FormattingEnabled = true;
            this.cbLoaitoa.Location = new System.Drawing.Point(143, 106);
            this.cbLoaitoa.Name = "cbLoaitoa";
            this.cbLoaitoa.Size = new System.Drawing.Size(121, 21);
            this.cbLoaitoa.TabIndex = 5;
            // 
            // cbMatau
            // 
            this.cbMatau.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMatau.FormattingEnabled = true;
            this.cbMatau.Location = new System.Drawing.Point(143, 35);
            this.cbMatau.Name = "cbMatau";
            this.cbMatau.Size = new System.Drawing.Size(121, 21);
            this.cbMatau.TabIndex = 6;
            // 
            // Grid
            // 
            this.Grid.AllowUserToAddRows = false;
            this.Grid.AllowUserToDeleteRows = false;
            this.Grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaTau,
            this.MaToa,
            this.LoaiToa});
            this.Grid.Location = new System.Drawing.Point(32, 197);
            this.Grid.Name = "Grid";
            this.Grid.ReadOnly = true;
            this.Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid.Size = new System.Drawing.Size(434, 159);
            this.Grid.TabIndex = 7;
            this.Grid.SelectionChanged += new System.EventHandler(this.Grid_SelectionChanged);
            // 
            // Them
            // 
            this.Them.Location = new System.Drawing.Point(76, 152);
            this.Them.Name = "Them";
            this.Them.Size = new System.Drawing.Size(75, 23);
            this.Them.TabIndex = 8;
            this.Them.Text = "Thêm ";
            this.Them.UseVisualStyleBackColor = true;
            this.Them.Click += new System.EventHandler(this.Them_Click);
            // 
            // Sua
            // 
            this.Sua.Location = new System.Drawing.Point(208, 152);
            this.Sua.Name = "Sua";
            this.Sua.Size = new System.Drawing.Size(75, 23);
            this.Sua.TabIndex = 9;
            this.Sua.Text = "Sửa";
            this.Sua.UseVisualStyleBackColor = true;
            this.Sua.Click += new System.EventHandler(this.Sua_Click);
            // 
            // Xoa
            // 
            this.Xoa.Location = new System.Drawing.Point(358, 152);
            this.Xoa.Name = "Xoa";
            this.Xoa.Size = new System.Drawing.Size(75, 23);
            this.Xoa.TabIndex = 10;
            this.Xoa.Text = "Xóa";
            this.Xoa.UseVisualStyleBackColor = true;
            this.Xoa.Click += new System.EventHandler(this.Xoa_Click);
            // 
            // MaTau
            // 
            this.MaTau.DataPropertyName = "MaTau";
            this.MaTau.HeaderText = "Mã Tàu";
            this.MaTau.Name = "MaTau";
            this.MaTau.ReadOnly = true;
            // 
            // MaToa
            // 
            this.MaToa.DataPropertyName = "MaToa";
            this.MaToa.HeaderText = "Mã Toa";
            this.MaToa.Name = "MaToa";
            this.MaToa.ReadOnly = true;
            // 
            // LoaiToa
            // 
            this.LoaiToa.DataPropertyName = "LoaiToa";
            this.LoaiToa.HeaderText = "Loại Toa";
            this.LoaiToa.Name = "LoaiToa";
            this.LoaiToa.ReadOnly = true;
            // 
            // QLToa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 381);
            this.Controls.Add(this.Xoa);
            this.Controls.Add(this.Sua);
            this.Controls.Add(this.Them);
            this.Controls.Add(this.Grid);
            this.Controls.Add(this.cbMatau);
            this.Controls.Add(this.cbLoaitoa);
            this.Controls.Add(this.txtMatoa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "QLToa";
            this.Text = "Quản lý Toa";
            this.Load += new System.EventHandler(this.QLToa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMatoa;
        private System.Windows.Forms.ComboBox cbLoaitoa;
        private System.Windows.Forms.ComboBox cbMatau;
        private System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.Button Them;
        private System.Windows.Forms.Button Sua;
        private System.Windows.Forms.Button Xoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTau;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaToa;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiToa;
    }
}