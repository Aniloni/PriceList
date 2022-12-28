using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LP
{
    /// <summary>
    /// Класс формы для удаления позиции в прайс-листе
    /// </summary>
    public partial class DeletePosition : Form 
    {
        /// <summary>
        /// Конструктор класса
        /// </summary>
        public DeletePosition() 
        {
            InitializeComponent();
        }

        /// <summary>
        /// Метод, запускающийся при нажатии кнопки выход и закрывающий приложение
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void buttonExit2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Поле типа Connection, использующееся для подключения к базе данных
        /// </summary>
        Connection con = new Connection();

        /// <summary>
        /// Метод, запускающийся при нажатии кнопки назад и открывающий форму FurnitureType
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void button1_Click(object sender, EventArgs e) 
        {
            FurnitureType back = new FurnitureType();
            back.Show();
            this.Hide();
            con.CloseConnection();
        }

        /// <summary>
        /// Метод, запускающийся при загрузке формы DeletePosition
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void DeletePosition_Load(object sender, EventArgs e) 
        {
            con.OpenConnection();
        }

        /// <summary>
        /// Метод, запускающийся при нажатии кнопки удалить и удаляющий позицую в прайс-листе
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void delete_Click(object sender, EventArgs e) 
        {
            string articule = Articule.Text;

            if (articule == "Введите артикул удаляемой позиции")
            {
                MessageBox.Show("Введите артикул");
                return;
            }

            if (!IsPosExists())
                return;

            SqlCommand command = new SqlCommand("DELETE FROM Pricelist WHERE [Артикул] = @uA", con.connection);

            command.Parameters.AddWithValue("uA", Articule.Text);

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Позиция удалена");
            }
        }

        /// <summary>
        /// Метод, проверяющий наличие данной позиции в прайслисте
        /// </summary>
        /// <returns></returns>
        public bool IsPosExists() 
        {
            string articule = Articule.Text;

            DataTable table = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter();

            SqlCommand command = new SqlCommand("SELECT * FROM Pricelist WHERE [Артикул] = @uA", con.connection);

            command.Parameters.Add("uA", SqlDbType.VarChar).Value = articule;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Такой позиции не существует");
                return false;
            }
        }

        /// <summary>
        /// Метод, накладывающий условия на вводимые значения в текстбокс Аrticule
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Articule_KeyPress(object sender, KeyPressEventArgs e) 
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Метод, запускающийся при нажатии на текстбокс Articule
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Articule_Enter(object sender, EventArgs e) 
        {
            if (Articule.Text == "Введите артикул удаляемой позиции")
                Articule.Text = "";
        }

        /// <summary>
        /// Метод, запускающийся при выходе из поля текстбокса Articule
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Articule_Leave(object sender, EventArgs e) 
        {
            if (Articule.Text == "")
                Articule.Text = "Введите артикул удаляемой позиции";
        }        
    }
}
