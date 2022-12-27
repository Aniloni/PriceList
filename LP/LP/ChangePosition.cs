using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LP
{
    public partial class ChangePosition : Form //Класс формы для изменения позиции в прайс-листе
    {
        public ChangePosition() //Конструктор класса
        {
            InitializeComponent();
        }

        Connection con = new Connection(); //Поле типа Connection, использующееся для подключения к базе данных

        private void buttonExit2_Click(object sender, EventArgs e) //Метод, запускающийся при нажатии кнопки выход и закрывающий приложение
        {
            Application.Exit();
        }

        private void buttonBack_Click(object sender, EventArgs e) //Метод, запускающийся при нажатии кнопки назад и открывающий форму FurnitureType
        {
            FurnitureType back = new FurnitureType();
            back.Show();
            this.Hide();
            con.CloseConnection();
        }

        private void ChangePosition_Load(object sender, EventArgs e) //Метод, запускающийся при загрузке формы ChangePosition
        {
            con.OpenConnection();
        }

        private void Add_Click(object sender, EventArgs e) //Метод, запускающийся при нажатии кнопки изменить и изменяющий позицую в прайс-листе
        {
            string type = Type.Text;
            string articule = Articule.Text;
            string nameP = NameP.Text;
            string nalichie = Nalichie.Text;
            string price = Price.Text;
            string priceO = PriceO.Text;

            if (type == "Тип мебели")
            {
                MessageBox.Show("Введите тип мебели");
                return;
            }

            if (articule == "Артикул")
            {
                MessageBox.Show("Введите артикул");
                return;
            }

            if (nameP == "Название")
            {
                MessageBox.Show("Введите название позиции");
                return;
            }

            if (nalichie == "Количество позиций")
            {
                MessageBox.Show("Введите количество в наличии");
                return;
            }

            if (price == "Цена в розницу")
            {
                MessageBox.Show("Введите цену в розницу");
                return;
            }

            if (priceO == "Цена оптом")
            {
                MessageBox.Show("Введите цену оптом");
                return;
            }

            if (!IsPosExists())
                return;

            SqlCommand command = new SqlCommand("UPDATE Pricelist SET [Тип мебели] = @uT, [Название] = @uN, [Наличие] = @uNal, [Цена в розницу] = @uP, [Цена оптом] = @uPo WHERE [Артикул] = @uA", con.connection);

            command.Parameters.AddWithValue("uT", Type.Text);
            command.Parameters.AddWithValue("uA", Articule.Text);
            command.Parameters.AddWithValue("uN", NameP.Text);
            command.Parameters.AddWithValue("uNal", Nalichie.Text);
            command.Parameters.AddWithValue("uP", Price.Text);
            command.Parameters.AddWithValue("uPo", PriceO.Text);

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Позиция изменена");
            }
            else
                MessageBox.Show("Позиция не изменена");
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

        private void Nalichie_KeyPress(object sender, KeyPressEventArgs e) //Метод, накладывающий условия на вводимые значения в текстбокс Nalichie
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void Price_KeyPress(object sender, KeyPressEventArgs e) //Метод, накладывающий условия на вводимые значения в текстбокс Price
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void PriceO_KeyPress(object sender, KeyPressEventArgs e) //Метод, накладывающий условия на вводимые значения в текстбокс PriceO
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void Type_Enter(object sender, EventArgs e) //Метод, запускающийся при нажатии на текстбокс Type
        {
            if (Type.Text == "Тип мебели")
                Type.Text = "";
        }

        private void Articule_Enter(object sender, EventArgs e) //Метод, запускающийся при нажатии на текстбокс Articule
        {
            if (Articule.Text == "Артикул")
                Articule.Text = "";
        }
        private void NameP_Enter(object sender, EventArgs e) //Метод, запускающийся при нажатии на текстбокс NameP
        {
            if (NameP.Text == "Название")
                NameP.Text = "";
        }

        private void Nalichie_Enter(object sender, EventArgs e) //Метод, запускающийся при нажатии на текстбокс Nalichie
        {
            if (Nalichie.Text == "Количество позиций")
                Nalichie.Text = "";
        }

        private void Price_Enter(object sender, EventArgs e) //Метод, запускающийся при нажатии на текстбокс Price
        {
            if (Price.Text == "Цена в розницу")
                Price.Text = "";
        }

        private void PriceO_Enter(object sender, EventArgs e) //Метод, запускающийся при нажатии на текстбокс PriceO
        {
            if (PriceO.Text == "Цена оптом")
                PriceO.Text = "";
        }

        private void Type_Leave(object sender, EventArgs e) //Метод, запускающийся при выходе из поля текстбокса Type
        {
            if (Type.Text == "")
                Type.Text = "Тип мебели";
        }

        private void Articule_Leave(object sender, EventArgs e) //Метод, запускающийся при выходе из поля текстбокса Articule
        {
            if (Articule.Text == "")
                Articule.Text = "Артикул";
        }

        private void NameP_Leave(object sender, EventArgs e) //Метод, запускающийся при выходе из поля текстбокса NameP
        {
            if (NameP.Text == "")
                NameP.Text = "Название";
        }

        private void Nalichie_Leave(object sender, EventArgs e) //Метод, запускающийся при выходе из поля текстбокса Nalichie
        {
            if (Nalichie.Text == "")
                Nalichie.Text = "Количество позиций";
        }

        private void Price_Leave(object sender, EventArgs e) //Метод, запускающийся при выходе из поля текстбокса Price
        {
            if (Price.Text == "")
                Price.Text = "Цена в розницу";
        }

        private void PriceO_Leave(object sender, EventArgs e) //Метод, запускающийся при выходе из поля текстбокса PriceO
        {
            if (PriceO.Text == "")
                PriceO.Text = "Цена оптом";
        }
    }
}
