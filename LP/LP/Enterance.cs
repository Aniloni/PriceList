using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LP
{
    /// <summary>
    /// Класс формы для авторизации
    /// </summary>
    public partial class Enterance : Form 
    {
        /// <summary>
        /// Конструктор класса
        /// </summary>
        public Enterance() 
        {
            InitializeComponent();
        }

        /// <summary>
        /// Метод, запускающийся при нажатии кнопки назад и открывающий форму StartPage
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void button1_Click(object sender, EventArgs e) 
        {
            StartPage f = new StartPage();
            f.Show();
            this.Hide();
        }

        /// <summary>
        /// Поле типа Connection, использующееся для подключения к базе данных
        /// </summary>
        Connection con;

        /// <summary>
        /// Метод, запускающийся при загрузке формы Enterance
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Enterance_Load(object sender, EventArgs e) 
        {
            con = new Connection();
            con.OpenConnection();
        }

        /// <summary>
        /// Метод, запускающийся при нажатии кнопки вход
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void button2_Click(object sender, EventArgs e) 
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

        /// <summary>
        /// Метод, запускающийся при нажатии на textBox1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void textBox1_Enter(object sender, EventArgs e) 
        {
            if (textBox1.Text == "Логин")
                textBox1.Text = "";
        }

        /// <summary>
        /// Метод, запускающийся при нажатии на textBox2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void textBox2_Enter(object sender, EventArgs e) 
        {
            if (textBox2.Text == "Пароль")
                textBox2.Text = "";
        }

        /// <summary>
        /// Метод, запускающийся при выходе из поля textBox1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void textBox1_Leave(object sender, EventArgs e) 
        {
            if (textBox1.Text == "")
                textBox1.Text = "Логин";
        }

        /// <summary>
        /// Метод, запускающийся при выходе из поля textBox2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void textBox2_Leave(object sender, EventArgs e) 
        {
            if (textBox2.Text == "")
                textBox2.Text = "Пароль";
        }
    }
}