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
        }

        private void loadCombo()
        {

        }

        private void QLTau_Load(object sender, EventArgs e)
        {
            loadGrid();
            addItem();
        }
    }
}
