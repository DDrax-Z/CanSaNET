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
    public partial class DatVe : Form
    {
        public DatVe()
        {
            InitializeComponent();
        }

        private void DatVe_Load(object sender, EventArgs e)
        {
            loadCombo();
            loadGrid();
            addItem();
        }

        private void Grid_SelectionChanged(object sender, EventArgs e)
        {
            if (Grid.SelectedRows.Count == 0)
                return;
            DataGridViewRow row = Grid.SelectedRows[0];
            cbMacd.SelectedValue = row.Cells["Macd"].Value;
            txtDiachi.Text = row.Cells["Diachi"].Value.ToString();
            txtHoten.Text = row.Cells["Hoten"].Value.ToString();
            txtSdt.Text = row.Cells["sdt"].Value.ToString();
            cbLoaighe.Text = row.Cells["Loaighe"].Value.ToString();
            loadInfocd();
        }

        private void loadGrid()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Datve", DB.GetConnection());
            DataTable dt = new DataTable();
            da.Fill(dt);
            Grid.DataSource = dt;
        }

        private void loadCombo()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Chuyendi", DB.GetConnection());
            da.Fill(ds, "Chuyendi");
            cbMacd.DataSource = ds.Tables["Chuyendi"];
            cbMacd.DisplayMember = "Macd";
            cbMacd.ValueMember = "Macd";
        }

        private void resetForm()
        {
            txtGakh.Clear();
            txtGakt.Clear();
            txtGakh.Clear();
            txtGiokh.Clear();
            txtDiachi.Clear();
            txtGakt.Clear();
            txtHoten.Clear();
            txtMatau.Clear();
            txtSdt.Clear();
        }

        private void addItem()
        {
            cbLoaighe.Items.Add("Ngồi cứng");
            cbLoaighe.Items.Add("Ngồi mềm");
            cbLoaighe.Items.Add("Giường nằm");
        }

        private void loadInfocd()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Chuyendi WHERE Macd=@macd", DB.GetConnection());
            string a = cbMacd.SelectedValue.ToString();
            cmd.Parameters.AddWithValue("@macd", cbMacd.SelectedValue.ToString());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count == 0) 
                return;
            txtMatau.Text = dt.Rows[0]["Matau"].ToString();
            txtGakh.Text=dt.Rows[0]["Gakh"].ToString();
            txtGakt.Text = dt.Rows[0]["Gad"].ToString();
            txtGiokh.Text = dt.Rows[0]["Giokh"].ToString();
            datePicker.Value = (DateTime)dt.Rows[0]["Ngaykh"];
        }

        private void cbMacd_SelectedIndexChanged(object sender, EventArgs e)
        {
                loadInfocd();
        }

        private void Them_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO Datve (Macd, Loaighe, Hoten, sdt,diachi) VALUES (@macd, @loaighe, @hoten, @sdt, @diachi)", DB.GetConnection());
            cmd.Parameters.AddWithValue("@macd", cbMacd.SelectedValue.ToString());
            cmd.Parameters.AddWithValue("@loaighe", cbLoaighe.GetItemText(cbLoaighe.SelectedItem));
            cmd.Parameters.AddWithValue("@hoten", txtHoten.Text);
            cmd.Parameters.AddWithValue("@sdt", txtSdt.Text);
            cmd.Parameters.AddWithValue("@diachi", txtDiachi.Text);
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
            String id = row.Cells["id"].Value.ToString();
            SqlCommand cmd = new SqlCommand("UPDATE Datve SET Macd=@macd, loaighe=@loaighe, hoten=@hoten, sdt=@sdt, diachi=@diachi WHERE id=@id", DB.GetConnection());
            cmd.Parameters.AddWithValue("@macd", cbMacd.SelectedValue.ToString());
            cmd.Parameters.AddWithValue("@loaighe", cbLoaighe.GetItemText(cbLoaighe.SelectedItem));
            cmd.Parameters.AddWithValue("@hoten", txtHoten.Text);
            cmd.Parameters.AddWithValue("@sdt", txtSdt.Text);
            cmd.Parameters.AddWithValue("@diachi", txtDiachi.Text);
            cmd.Parameters.AddWithValue("@id", id);
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
            string id = Grid.SelectedRows[0].Cells["id"].Value.ToString();
            SqlCommand cmd = new SqlCommand("DELETE FROM Datve WHERE id=@id", DB.GetConnection());
            cmd.Parameters.AddWithValue("@id", id);
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
