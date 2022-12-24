using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LP
{
    public partial class Enterance : Form
    {


        public Enterance()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StartPage f = new StartPage();
            f.Show();
            this.Hide();
        }

        Connection con;

        private void Enterance_Load(object sender, EventArgs e)
        {
            con = new Connection();
            con.OpenConnection();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable table = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter();

            SqlCommand command = new SqlCommand("SELECT * FROM Users WHERE UserId = @uI AND UserPassword = @uP", con.connection);

            command.Parameters.AddWithValue("uI", textBox1.Text);
            command.Parameters.AddWithValue("uP", textBox2.Text);

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                FurtitureType f = new FurtitureType();
                f.Show();
                this.Hide();
                con.CloseConnection();
            }
            else
            {
                MessageBox.Show("Нет такого логина или пароля");
            }
        }        
    }
}