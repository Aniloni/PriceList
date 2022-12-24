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
    public partial class Registration : Form
    {
        public Registration()
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

        private void Registration_Load(object sender, EventArgs e)
        {
            con = new Connection();
            con.OpenConnection();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string userId = textBox1.Text;
            string userPassword = textBox2.Text;

            if (userId == "Логин")
            {
                MessageBox.Show("Введите логин");
                return;
            }

            if (userPassword == "Пароль")
            {
                MessageBox.Show("Введите пароль");
                return;
            }

            if (IsIdExists())
                return;

            SqlCommand command = new SqlCommand("INSERT INTO[dbo].[Users]([UserId], [UserPassword]) VALUES(@uI, @uP)", con.connection);

            command.Parameters.AddWithValue("uI", textBox1.Text);
            command.Parameters.AddWithValue("uP", textBox2.Text);

            if (command.ExecuteNonQuery() == 1) 
            {
                MessageBox.Show("Аккаунт был создан");
                Enterance f = new Enterance();
                f.Show();
                this.Hide();
                con.CloseConnection();
            }
            else
                MessageBox.Show("Аккаунт не был создан");
        }    
        public bool IsIdExists()
        {
            string userId = textBox1.Text;

            DataTable table = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter();

            SqlCommand command = new SqlCommand("SELECT * FROM Users WHERE UserId = @uI", con.connection);

            command.Parameters.Add("uI", SqlDbType.VarChar).Value = userId;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Такой логин уже существует, введите другой");
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
