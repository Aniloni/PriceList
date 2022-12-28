using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LP
{
    /// <summary>
    /// Класс формы для регистрации нового пользователя в системе
    /// </summary>
    public partial class Registration : Form 
    {
        /// <summary>
        /// Конструктор класса
        /// </summary>
        public Registration() 
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
        /// Поле, использующееся для подключения к базе данных
        /// </summary>
        Connection con;
        /// <summary>
        /// Метод, запускающийся при загрузке страницы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Registration_Load(object sender, EventArgs e)  
        {
            con = new Connection();
            con.OpenConnection();
        }
        /// <summary>
        /// Метод, запускающийся при нажатии кнопки "Регистрация", добавляет нового пользователя в базу данных
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void button2_Click(object sender, EventArgs e) 
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
        /// <summary>
        /// Метод, проверяющий существование id пользователя
        /// </summary>
        /// <returns></returns>
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
        /// <summary>
        /// Метод, запускающийся при нажатии на текстбокс textBox1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void textBox1_Enter(object sender, EventArgs e) 
        {
            if (textBox1.Text == "Логин")
                textBox1.Text = "";
        }
        /// <summary>
        /// Метод, запускающийся при нажатии на текстбокс textBox2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void textBox2_Enter(object sender, EventArgs e) 
        {
            if (textBox2.Text == "Пароль")
                textBox2.Text = "";
        }
        /// <summary>
        /// Метод, запускающийся при выходе из поля текстбокса textBox1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void textBox1_Leave(object sender, EventArgs e) 
        {
            if (textBox1.Text == "")
                textBox1.Text = "Логин";
        }
        /// <summary>
        /// Метод, запускающийся при выходе из поля текстбокса textBox2
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
