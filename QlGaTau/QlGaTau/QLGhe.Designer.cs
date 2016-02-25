namespace QlGaTau
{
    partial class QLGhe
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
            this.cbMatoa = new System.Windows.Forms.ComboBox();
            this.txtMaghe = new System.Windows.Forms.TextBox();
            this.Them = new System.Windows.Forms.Button();
            this.Sua = new System.Windows.Forms.Button();
            this.Xoa = new System.Windows.Forms.Button();
            this.Grid = new System.Windows.Forms.DataGridView();
            this.Maghe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Matoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã ghế";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã toa";
            // 
            // cbMatoa
            // 
            this.cbMatoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMatoa.FormattingEnabled = true;
            this.cbMatoa.Location = new System.Drawing.Point(137, 90);
            this.cbMatoa.Name = "cbMatoa";
            this.cbMatoa.Size = new System.Drawing.Size(185, 21);
            this.cbMatoa.TabIndex = 2;
            // 
            // txtMaghe
            // 
            this.txtMaghe.Location = new System.Drawing.Point(137, 53);
            this.txtMaghe.Name = "txtMaghe";
            this.txtMaghe.Size = new System.Drawing.Size(185, 20);
            this.txtMaghe.TabIndex = 3;
            // 
            // Them
            // 
            this.Them.Location = new System.Drawing.Point(40, 134);
            this.Them.Name = "Them";
            this.Them.Size = new System.Drawing.Size(75, 23);
            this.Them.TabIndex = 4;
            this.Them.Text = "Thêm";
            this.Them.UseVisualStyleBackColor = true;
            this.Them.Click += new System.EventHandler(this.Them_Click);
            // 
            // Sua
            // 
            this.Sua.Location = new System.Drawing.Point(156, 134);
            this.Sua.Name = "Sua";
            this.Sua.Size = new System.Drawing.Size(75, 23);
            this.Sua.TabIndex = 5;
            this.Sua.Text = "Sửa";
            this.Sua.UseVisualStyleBackColor = true;
            this.Sua.Click += new System.EventHandler(this.Sua_Click);
            // 
            // Xoa
            // 
            this.Xoa.Location = new System.Drawing.Point(271, 134);
            this.Xoa.Name = "Xoa";
            this.Xoa.Size = new System.Drawing.Size(75, 23);
            this.Xoa.TabIndex = 6;
            this.Xoa.Text = "Xóa";
            this.Xoa.UseVisualStyleBackColor = true;
            this.Xoa.Click += new System.EventHandler(this.Xoa_Click);
            // 
            // Grid
            // 
            this.Grid.AllowUserToAddRows = false;
            this.Grid.AllowUserToDeleteRows = false;
            this.Grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Maghe,
            this.Matoa});
            this.Grid.Location = new System.Drawing.Point(31, 176);
            this.Grid.Name = "Grid";
            this.Grid.ReadOnly = true;
            this.Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid.Size = new System.Drawing.Size(326, 107);
            this.Grid.TabIndex = 7;
            this.Grid.SelectionChanged += new System.EventHandler(this.Grid_SelectionChanged);
            // 
            // Maghe
            // 
            this.Maghe.DataPropertyName = "Maghe";
            this.Maghe.HeaderText = "Mã ghế";
            this.Maghe.Name = "Maghe";
            this.Maghe.ReadOnly = true;
            // 
            // Matoa
            // 
            this.Matoa.DataPropertyName = "Matoa";
            this.Matoa.HeaderText = "Mã toa";
            this.Matoa.Name = "Matoa";
            this.Matoa.ReadOnly = true;
            // 
            // QLGhe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 312);
            this.Controls.Add(this.Grid);
            this.Controls.Add(this.Xoa);
            this.Controls.Add(this.Sua);
            this.Controls.Add(this.Them);
            this.Controls.Add(this.txtMaghe);
            this.Controls.Add(this.cbMatoa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "QLGhe";
            this.Text = "Quản lý ghế";
            this.Load += new System.EventHandler(this.QLGhe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbMatoa;
        private System.Windows.Forms.TextBox txtMaghe;
        private System.Windows.Forms.Button Them;
        private System.Windows.Forms.Button Sua;
        private System.Windows.Forms.Button Xoa;
        private System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Maghe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Matoa;
    }
}