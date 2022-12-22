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

        SqlConnection db;

        private void Enterance_Load(object sender, EventArgs e)
        {
            db = new SqlConnection();
            db.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\vasil\OneDrive\Desktop\Документы\VS\PriceList\LP\LP\Database.mdf";
            db.Open();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string userId = textBox1.Text;
            string userPassword = textBox2.Text;

            DataTable table = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter();

            SqlCommand command = new SqlCommand("SELECT * FROM Users WHERE UserId = @uI AND UserPassword = @uP", db);

            command.Parameters.Add("uI", SqlDbType.VarChar).Value = userId;
            command.Parameters.Add("uP", SqlDbType.VarChar).Value = userPassword;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Авторизация прошла успешнo");
                FurtitureType f = new FurtitureType();
                f.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Нет такого логина или пароля");
            }
        }        
    }
}