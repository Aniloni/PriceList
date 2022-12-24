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

namespace LP
{
    public partial class Chair : Form
    {
        public Chair()
        {
            InitializeComponent();
        }

        private void Chair_Load(object sender, EventArgs e)
        {
            Connection con = new Connection();
            con.OpenConnection();

            DataTable table = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter();

            SqlCommand command = new SqlCommand("SELECT * FROM [dbo].[Pricelist] WHERE [Тип мебели] = N'Стул'", con.connection);

            adapter.SelectCommand = command;
            adapter.Fill(table);

            dataGridView1.DataSource = table;

            con.CloseConnection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FurtitureType f = new FurtitureType();
            f.Show();
            this.Hide();
        }
    }
}
