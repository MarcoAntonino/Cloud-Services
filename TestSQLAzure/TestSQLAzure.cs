using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestSQLAzure
{
    public partial class TestSQLAzure : Form
    {
        public TestSQLAzure()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strConn = "Server=tcp:avtestdbserver.database.windows.net,1433;Database=avtestdatabase;User ID=pippo@avtestdbserver;Password=Tom&Jerry;Trusted_Connection=False;Encrypt=True;";
            DataTable dt = new DataTable();
            string sql = "SELECT * FROM dbo.Antonino";
            SqlDataAdapter sda = new SqlDataAdapter(
                sql, strConn);
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
