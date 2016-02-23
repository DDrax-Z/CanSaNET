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
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void login_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * from DangNhap where TaiKhoan = @username and MatKhau = @password ", DB.GetConnection());
            cmd.Parameters.Add(new SqlParameter("@username", txtUser.Text));
            cmd.Parameters.Add(new SqlParameter("@password", txtPass.Text));
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Đăng nhập thành công! ", "Đăng nhập");
                Hide();
                dr.Close();
                (new GiaoDien()).Show();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc tên đăng nhập chưa đúng!", "Cảnh báo");
                dr.Close();
            }
        }
    }
}
