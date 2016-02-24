using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QlGaTau
{
    public partial class QLToa : Form
    {
        public QLToa()
        {
            InitializeComponent();
        }

        private void QLToa_Load(object sender, EventArgs e)
        {
            loadGrid();
            addItem();
            loadCombo();
        }

        private void loadGrid()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Toa", DB.GetConnection());
            DataTable dt = new DataTable();
            da.Fill(dt);
            Grid.DataSource = dt;
        }

        private void loadInfo()
        {
            if (Grid.SelectedRows.Count == 0)
                return;
            DataGridViewRow row = Grid.SelectedRows[0];
            txtMatoa.Text = row.Cells["Matoa"].Value.ToString();
            cbLoaitoa.SelectedItem = row.Cells["LoaiToa"].Value.ToString();
            cbMatau.Text = row.Cells["MaTau"].Value.ToString();
        }

        private void addItem()
        {
            cbLoaitoa.Items.Add("Toa hàng");
            cbLoaitoa.Items.Add("Ngồi cứng");
            cbLoaitoa.Items.Add("Ngồi mềm");
            cbLoaitoa.Items.Add("Giường nằm");
        }

        private void loadCombo()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Tau", DB.GetConnection());
            da.Fill(ds, "Tau");
            cbMatau.DataSource = ds.Tables["Tau"];
            cbMatau.DisplayMember = "MaTau";
            cbMatau.ValueMember = "MaTau";
        }

        private void resetForm()
        {
            cbMatau.SelectedIndex = -1;
            cbLoaitoa.SelectedIndex = -1;
            txtMatoa.Clear();
        }

        private void Them_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO Toa (MaTau, MaToa, LoaiToa) VALUES (@matau, @matoa,@loaitoa)", DB.GetConnection());
            cmd.Parameters.AddWithValue("@matau", cbMatau.GetItemText(cbMatau.SelectedItem));
            cmd.Parameters.AddWithValue("@matoa", txtMatoa.Text);
            cmd.Parameters.AddWithValue("@loaitoa", cbLoaitoa.GetItemText(cbLoaitoa.SelectedItem));
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm mới thành công", "Thông báo");
                loadGrid();
                resetForm();
            }
            catch (SqlException)
            {
                MessageBox.Show("Lỗi");
            }
        }

        private void Sua_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = Grid.SelectedRows[0];
            String ma_old = row.Cells["MaToa"].Value.ToString();
            SqlCommand cmd = new SqlCommand("UPDATE Toa SET MaTau=@matau, MaToa=@matoa, LoaiToa=@loaitoa WHERE Matau=@ma_old", DB.GetConnection());
            cmd.Parameters.AddWithValue("@matau", cbMatau.GetItemText(cbMatau.SelectedItem));
            cmd.Parameters.AddWithValue("@matoa", txtMatoa.Text);
            cmd.Parameters.AddWithValue("@ma_old", ma_old);
            cmd.Parameters.AddWithValue("@loaitoa", cbLoaitoa.GetItemText(cbLoaitoa.SelectedItem));
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cập nhật thành công", "Thông báo");
                loadGrid();
            }
            catch (SqlException)
            {
                MessageBox.Show("Lỗi");
            }
        }

        private void Xoa_Click(object sender, EventArgs e)
        {
            string id = Grid.SelectedRows[0].Cells["MaToa"].Value.ToString();
            SqlCommand cmd = new SqlCommand("DELETE FROM Toa WHERE MaToa=@matoa", DB.GetConnection());
            cmd.Parameters.AddWithValue("@matoa", id);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa thành công", "Thông báo");
                loadGrid();
                resetForm();
            }
            catch (SqlException)
            {
                MessageBox.Show("Lỗi");
            }
        }

        private void Grid_SelectionChanged(object sender, EventArgs e)
        {
            loadInfo();
        }
    }
}
