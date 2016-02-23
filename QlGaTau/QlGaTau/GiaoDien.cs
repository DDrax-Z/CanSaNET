using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QlGaTau
{
    public partial class GiaoDien : Form
    {
        public GiaoDien()
        {
            InitializeComponent();
        }

        private void QLDangNhap_Click(object sender, EventArgs e)
        {
            (new QLTaiKhoan()).Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            (new QLTau()).Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            (new QLToa()).Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            (new QLGhe()).Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            (new QLChuyenDi()).Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            (new DatVe()).Show();
        }
    }
}
