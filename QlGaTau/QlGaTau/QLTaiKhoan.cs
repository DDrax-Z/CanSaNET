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
    public partial class QLTaiKhoan : Form
    {
        public QLTaiKhoan()
        {
            InitializeComponent();
        }

        private void loadGrid()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM DangNhap", DB.GetConnection());
            DataTable dt = new DataTable();
            da.Fill(dt);
            Grid.DataSource = dt;
        }

        private void QLTaiKhoan_Load(object sender, EventArgs e)
        {
            loadGrid();
        }

        private void loadInfo()
        {
            if (Grid.SelectedRows.Count == 0)
                return;
            DataGridViewRow row = Grid.SelectedRows[0];
            txtHoten.Text = row.Cells["Hoten"].Value.ToString();
            txtUser.Text = row.Cells["Taikhoan"].Value.ToString();
            txtEmail.Text = row.Cells["Email"].Value.ToString();
        }

        private void Grid_SelectionChanged(object sender, EventArgs e)
        {
            loadInfo();
        }

        private void resetFrom()
        {
            txtEmail.Clear();
            txtHoten.Clear();
            txtPass.Clear();
            txtRepass.Clear();
            txtUser.Clear();
        }

        private bool checkPass()
        {
            if (txtPass.Text != txtRepass.Text)
            {
                MessageBox.Show("Mật khẩu không khớp");
                return false;
            }
            if (txtPass.Text.Length < 6)
            {
                MessageBox.Show("Mật khẩu phải có ít nhất 6 kí tự");
                return false;
            }
            if (txtPass.Text.Length == 0)
            {
                MessageBox.Show("Không được để trống mật khẩu");
                return false;
            }
            return true;
        }

        private void Them_Click(object sender, EventArgs e)
        {
            if (checkPass() == true)
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO DangNhap (Hoten, Taikhoan, MatKhau, Email) VALUES (@hoten, @taikhoan,@Matkhau, @email)", DB.GetConnection());
                cmd.Parameters.AddWithValue("@hoten", txtHoten.Text);
                cmd.Parameters.AddWithValue("@taikhoan", txtUser.Text);
                cmd.Parameters.AddWithValue("@matkhau", txtPass.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm mới thành công", "Thông báo");
                    loadGrid();
                    resetFrom();
                }
                catch (SqlException)
                {
                    MessageBox.Show("Lỗi");
                }
            }
        }

        private void Sua_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = Grid.SelectedRows[0];
            String ma = row.Cells["ID"].Value.ToString();
            if (checkPass() == true)
            {
                SqlCommand cmd = new SqlCommand("UPDATE DangNhap SET Hoten=@hoten, Taikhoan=@taikhoan, MatKhau=@matkhau, Email=@email WHERE ID=@ma", DB.GetConnection());
                cmd.Parameters.AddWithValue("@hoten", txtHoten.Text);
                cmd.Parameters.AddWithValue("@taikhoan", txtUser.Text);
                cmd.Parameters.AddWithValue("@matkhau", txtPass.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@ma", ma);
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
        }

        private void Xoa_Click(object sender, EventArgs e)
        {
            string id = Grid.SelectedRows[0].Cells["ID"].Value.ToString();
            SqlCommand cmd = new SqlCommand("DELETE FROM DangNhap WHERE ID=@id", DB.GetConnection());
            cmd.Parameters.AddWithValue("@id", id);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa thành công", "Thông báo");
                loadGrid();
                resetFrom();
            }
            catch (SqlException)
            {
                MessageBox.Show("Lỗi");
            }
        }


    }


}
