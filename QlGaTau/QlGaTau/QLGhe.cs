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
    public partial class QLGhe : Form
    {
        public QLGhe()
        {
            InitializeComponent();
        }

        private void QLGhe_Load(object sender, EventArgs e)
        {
            loadGrid();
            loadCombo();
        }

        private void Grid_SelectionChanged(object sender, EventArgs e)
        {
            loadInfo();
        }

        private void loadGrid()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Ghe", DB.GetConnection());
            DataTable dt = new DataTable();
            da.Fill(dt);
            Grid.DataSource = dt;
        }

        private void loadInfo()
        {
            if (Grid.SelectedRows.Count == 0)
                return;
            DataGridViewRow row = Grid.SelectedRows[0];
            txtMaghe.Text = row.Cells["Maghe"].Value.ToString();
            cbMatoa.Text = row.Cells["MaToa"].Value.ToString();
        }

        private void loadCombo()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Toa", DB.GetConnection());
            da.Fill(ds, "Toa");
            cbMatoa.DataSource = ds.Tables["Toa"];
            cbMatoa.DisplayMember = "MaToa";
            cbMatoa.ValueMember = "MaToa";
        }

        private void resetForm()
        {
            cbMatoa.SelectedIndex = -1;
            txtMaghe.Clear();
        }

        private void Them_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO Ghe (MaGhe, MaToa) VALUES (@maghe, @matoa)", DB.GetConnection());
            cmd.Parameters.AddWithValue("@maghe",txtMaghe.Text);
            cmd.Parameters.AddWithValue("@matoa", cbMatoa.SelectedValue.ToString());
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
            String ma_old = row.Cells["Maghe"].Value.ToString();
            SqlCommand cmd = new SqlCommand("UPDATE Ghe SET Maghe=@maghe, MaToa=@matoa WHERE Maghe=@ma_old", DB.GetConnection());
            cmd.Parameters.AddWithValue("@maghe", txtMaghe.Text);
            cmd.Parameters.AddWithValue("@matoa", cbMatoa.SelectedValue);
            cmd.Parameters.AddWithValue("@ma_old", ma_old);
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
            string id = Grid.SelectedRows[0].Cells["Maghe"].Value.ToString();
            SqlCommand cmd = new SqlCommand("DELETE FROM Ghe WHERE Maghe=@maghe", DB.GetConnection());
            cmd.Parameters.AddWithValue("@maghe", id);
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
    }
}
