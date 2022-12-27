using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LP
{
    public partial class Enterance : Form //Класс формы для авторизации
    {
        public Enterance() //Конструктор класса
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //Метод, запускающийся при нажатии кнопки назад и открывающий форму StartPage
        {
            StartPage f = new StartPage();
            f.Show();
            this.Hide();
        }

        Connection con; //Поле типа Connection, использующееся для подключения к базе данных

        private void Enterance_Load(object sender, EventArgs e) //Метод, запускающийся при загрузке формы Enterance
        {
            con = new Connection();
            con.OpenConnection();
        }

        private void button2_Click(object sender, EventArgs e) //Метод, запускающийся при нажатии кнопки вход
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
                FurnitureType f = new FurnitureType();
                f.Show();
                this.Hide();
                con.CloseConnection();
            }
            else
            {
                MessageBox.Show("Нет такого логина или пароля");
            }
        }

        private void textBox1_Enter(object sender, EventArgs e) //Метод, запускающийся при нажатии на textBox1
        {
            if (textBox1.Text == "Логин")
                textBox1.Text = "";
        }

        private void textBox2_Enter(object sender, EventArgs e) //Метод, запускающийся при нажатии на textBox2
        {
            if (textBox2.Text == "Пароль")
                textBox2.Text = "";
        }

        private void textBox1_Leave(object sender, EventArgs e) //Метод, запускающийся при выходе из поля textBox1
        {
            if (textBox1.Text == "")
                textBox1.Text = "Логин";
        }

        private void textBox2_Leave(object sender, EventArgs e) //Метод, запускающийся при выходе из поля textBox2
        {
            if (textBox2.Text == "")
                textBox2.Text = "Пароль";
        }
    }
}