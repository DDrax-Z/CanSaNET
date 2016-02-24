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
    public partial class QLChuyenDi : Form
    {
        public QLChuyenDi()
        {
            InitializeComponent();
        }

        private void QLChuyenDi_Load(object sender, EventArgs e)
        {
            loadGrid();
            loadCombo();
        }

        private void loadGrid()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Chuyendi", DB.GetConnection());
            DataTable dt = new DataTable();
            da.Fill(dt);
            Grid.DataSource = dt;
        }

        private void loadCombo()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Tau", DB.GetConnection());
            da.Fill(ds, "Tau");
            cbTentau.DataSource = ds.Tables["Tau"];
            cbTentau.DisplayMember = "TenTau";
            cbTentau.ValueMember = "MaTau";
        }

        private void resetForm()
        {
            cbTentau.SelectedIndex = -1;
            txtGakh.Clear();
            txtGakt.Clear();
            txtMacd.Clear();
            txtGioKH.Clear();
        }

        private void Grid_SelectionChanged(object sender, EventArgs e)
        {
            if (Grid.SelectedRows.Count == 0)
                return;
            DataGridViewRow row = Grid.SelectedRows[0];
            txtMacd.Text = row.Cells["Macd"].Value.ToString();
            cbTentau.SelectedValue = row.Cells["MaTau"].Value;
            txtGakh.Text = row.Cells["Gakh"].Value.ToString();
            txtGakt.Text = row.Cells["Gad"].Value.ToString();
            txtGioKH.Text = row.Cells["GioKH"].Value.ToString();
            dateTimePicker1.Value = (DateTime)row.Cells["NgayKh"].Value;
        }

        private void Them_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO ChuyenDi (Macd, Matau,GaKH,GaD,NgayKH,GioKH) VALUES (@macd, @matau, @gakh, @gad, @ngaykh, @giokh)", DB.GetConnection());
            cmd.Parameters.AddWithValue("@matau", cbTentau.SelectedValue.ToString());
            cmd.Parameters.AddWithValue("@macd", txtMacd.Text);
            cmd.Parameters.AddWithValue("@gakh", txtGakh.Text);
            cmd.Parameters.AddWithValue("@gad", txtGakt.Text);
            cmd.Parameters.AddWithValue("@ngaykh", dateTimePicker1.Value);
            cmd.Parameters.AddWithValue("@giokh", txtGioKH.Text);
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
            String ma_old = row.Cells["Macd"].Value.ToString();
            SqlCommand cmd = new SqlCommand("UPDATE Chuyendi SET MaTau=@matau, Macd=@macd, Gakh=@gakh, GaD=@gad, NgayKh=@ngaykh, Giokh=@giokh WHERE Macd=@ma_old", DB.GetConnection());
            cmd.Parameters.AddWithValue("@matau", cbTentau.SelectedValue.ToString());
            cmd.Parameters.AddWithValue("@macd", txtMacd.Text);
            cmd.Parameters.AddWithValue("@gakh", txtGakh.Text);
            cmd.Parameters.AddWithValue("@gad", txtGakt.Text);
            cmd.Parameters.AddWithValue("@ngaykh", dateTimePicker1.Value);
            cmd.Parameters.AddWithValue("@giokh", txtGioKH.Text);
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
            string id = Grid.SelectedRows[0].Cells["Macd"].Value.ToString();
            SqlCommand cmd = new SqlCommand("DELETE FROM Chuyendi WHERE Macd=@macd", DB.GetConnection());
            cmd.Parameters.AddWithValue("@macd", id);
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
