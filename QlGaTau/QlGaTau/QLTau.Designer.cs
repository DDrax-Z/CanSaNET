namespace QlGaTau
{
    partial class QLTau
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMatau = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTentau = new System.Windows.Forms.TextBox();
            this.cbLoaiTau = new System.Windows.Forms.ComboBox();
            this.Grid = new System.Windows.Forms.DataGridView();
            this.MaTau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiTau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qLGatauDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLGatauDataSet = new QlGaTau.QLGatauDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLGatauDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLGatauDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã tàu";
            // 
            // txtMatau
            // 
            this.txtMatau.Location = new System.Drawing.Point(122, 37);
            this.txtMatau.Name = "txtMatau";
            this.txtMatau.Size = new System.Drawing.Size(139, 20);
            this.txtMatau.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(307, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên tàu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Loại tàu";
            // 
            // txtTentau
            // 
            this.txtTentau.Location = new System.Drawing.Point(367, 37);
            this.txtTentau.Name = "txtTentau";
            this.txtTentau.Size = new System.Drawing.Size(172, 20);
            this.txtTentau.TabIndex = 4;
            // 
            // cbLoaiTau
            // 
            this.cbLoaiTau.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLoaiTau.FormattingEnabled = true;
            this.cbLoaiTau.Location = new System.Drawing.Point(122, 85);
            this.cbLoaiTau.Name = "cbLoaiTau";
            this.cbLoaiTau.Size = new System.Drawing.Size(139, 21);
            this.cbLoaiTau.TabIndex = 5;
            // 
            // Grid
            // 
            this.Grid.AllowUserToAddRows = false;
            this.Grid.AllowUserToDeleteRows = false;
            this.Grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaTau,
            this.TenTau,
            this.LoaiTau});
            this.Grid.Location = new System.Drawing.Point(57, 197);
            this.Grid.Name = "Grid";
            this.Grid.ReadOnly = true;
            this.Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid.Size = new System.Drawing.Size(481, 191);
            this.Grid.TabIndex = 6;
            this.Grid.SelectionChanged += new System.EventHandler(this.Grid_SelectionChanged);
            // 
            // MaTau
            // 
            this.MaTau.DataPropertyName = "MaTau";
            this.MaTau.HeaderText = "Mã Tàu";
            this.MaTau.Name = "MaTau";
            this.MaTau.ReadOnly = true;
            // 
            // TenTau
            // 
            this.TenTau.DataPropertyName = "TenTau";
            this.TenTau.HeaderText = "Tên Tàu";
            this.TenTau.Name = "TenTau";
            this.TenTau.ReadOnly = true;
            // 
            // LoaiTau
            // 
            this.LoaiTau.DataPropertyName = "LoaiTau";
            this.LoaiTau.HeaderText = "Loại tàu";
            this.LoaiTau.Name = "LoaiTau";
            this.LoaiTau.ReadOnly = true;
            // 
            // qLGatauDataSetBindingSource
            // 
            this.qLGatauDataSetBindingSource.DataSource = this.qLGatauDataSet;
            this.qLGatauDataSetBindingSource.Position = 0;
            // 
            // qLGatauDataSet
            // 
            this.qLGatauDataSet.DataSetName = "QLGatauDataSet";
            this.qLGatauDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(108, 147);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(244, 147);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Sửa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(388, 147);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "Xóa";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // QLTau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 424);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Grid);
            this.Controls.Add(this.cbLoaiTau);
            this.Controls.Add(this.txtTentau);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMatau);
            this.Controls.Add(this.label1);
            this.Name = "QLTau";
            this.Text = "Quản lý tàu";
            this.Load += new System.EventHandler(this.QLTau_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLGatauDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLGatauDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMatau;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTentau;
        private System.Windows.Forms.ComboBox cbLoaiTau;
        private System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTau;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTau;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiTau;
        private System.Windows.Forms.BindingSource qLGatauDataSetBindingSource;
        private QLGatauDataSet qLGatauDataSet;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}