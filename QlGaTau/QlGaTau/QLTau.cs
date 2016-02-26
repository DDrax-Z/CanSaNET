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
    public partial class QLTau : Form
    {
        public QLTau()
        {
            InitializeComponent();
        }

        private void loadGrid()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Tau", DB.GetConnection());
            DataTable dt = new DataTable();
            da.Fill(dt);
            Grid.DataSource = dt;
        }

        private void addItem()
        {
            cbLoaiTau.Items.Add("Tàu nhanh");
            cbLoaiTau.Items.Add("Chở hàng");
            cbLoaiTau.Items.Add("Tàu thường");
        }

        private void resetForm()
        {
            txtMatau.Clear();
            cbLoaiTau.SelectedIndex = -1;
            txtTentau.Clear();
        }

        private void loadInfo()
        {
            if (Grid.SelectedRows.Count == 0)
                return;
            DataGridViewRow row = Grid.SelectedRows[0];
            txtMatau.Text = row.Cells["MaTau"].Value.ToString();
            txtTentau.Text = row.Cells["TenTau"].Value.ToString();
            cbLoaiTau.SelectedItem = row.Cells["LoaiTau"].Value.ToString();
        }

        private void QLTau_Load(object sender, EventArgs e)
        {
            loadGrid();
            addItem();
        }


        private void Grid_SelectionChanged(object sender, EventArgs e)
        {
            loadInfo();
        }

        private void Them_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO Tau (MaTau, TenTau, LoaiTau) VALUES (@matau, @tentau,@loaitau)", DB.GetConnection());
            cmd.Parameters.AddWithValue("@matau", txtMatau.Text);
            cmd.Parameters.AddWithValue("@tentau", txtTentau.Text);
            cmd.Parameters.AddWithValue("@loaitau", cbLoaiTau.GetItemText(cbLoaiTau.SelectedItem));
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
            String ma_old = row.Cells["MaTau"].Value.ToString();
            SqlCommand cmd = new SqlCommand("UPDATE Tau SET MaTau=@matau, TenTau=@tentau, LoaiTau=@loaitau WHERE Matau=@ma_old", DB.GetConnection());
            cmd.Parameters.AddWithValue("@matau", txtMatau.Text);
            cmd.Parameters.AddWithValue("@tentau", txtTentau.Text);
            cmd.Parameters.AddWithValue("@ma_old", ma_old);
            cmd.Parameters.AddWithValue("@loaitau", cbLoaiTau.GetItemText(cbLoaiTau.SelectedItem));
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
            string id = Grid.SelectedRows[0].Cells["MaTau"].Value.ToString();
            SqlCommand cmd = new SqlCommand("DELETE FROM Tau WHERE MaTau=@matau", DB.GetConnection());
            cmd.Parameters.AddWithValue("@matau", id);
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
