using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LP
{
    public partial class DeletePosition : Form //Класс формы для удаления позиции в прайс-листе
    {
        public DeletePosition() //Конструктор класса
        {
            InitializeComponent();
        }

        Connection con = new Connection(); //Поле типа Connection, использующееся для подключения к базе данных

        private void button1_Click(object sender, EventArgs e) //Метод, запускающийся при нажатии кнопки назад и открывающий форму FurnitureType
        {
            FurnitureType back = new FurnitureType();
            back.Show(); //Кнопка назад
            this.Hide();
            con.CloseConnection();
        }

        private void DeletePosition_Load(object sender, EventArgs e) //Метод, запускающийся при загрузке формы DeletePosition
        {
            con.OpenConnection();
        }

        private void delete_Click(object sender, EventArgs e) //Метод, запускающийся при нажатии кнопки удалить и удаляющий позицую в прайс-листе
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

        public bool IsPosExists() //Метод, проверяющий наличие данной позиции в прайслисте
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

        private void Articule_KeyPress(object sender, KeyPressEventArgs e) //Метод, накладывающий условия на вводимые значения в текстбокс Аrticule
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void Articule_Enter(object sender, EventArgs e) //Метод, запускающийся при нажатии на текстбокс Articule
        {
            if (Articule.Text == "Введите артикул удаляемой позиции")
                Articule.Text = "";
        }

        private void Articule_Leave(object sender, EventArgs e) //Метод, запускающийся при выходе из поля текстбокса Articule
        {
            if (Articule.Text == "")
                Articule.Text = "Введите артикул удаляемой позиции";
        }

        private void buttonExit2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
