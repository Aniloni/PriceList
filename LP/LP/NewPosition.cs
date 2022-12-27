using NUnit.Framework;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace LP
{
    public partial class NewPosition : Form // Класс формы для добавления новой позиции в прайс-лист
    {
        [TestFixture]
        public class NewPositionTest : NewPosition // Тесты для класса NewPosition
        {
            [Test] // Тест на проверку цвета текстбокса Type
            [TestCase("Color [A=255, R=80, G=111, B=154]")]
            public void TestTypeColor(string actual)
            {
                Assert.AreEqual(Type.BackColor.ToString(), actual);
            }
            [Test] // Тест на проверку цвета текстбокса Color
            [TestCase("Color [A=255, R=50, G=80, B=110]")]
            public void TestbuttonBackColor(string actual)
            {
                Assert.AreEqual(buttonBack.BackColor.ToString(), actual);
            }
            [Test] // Тест на проверку цвета текстбокса Articule
            [TestCase("Color [A=255, R=80, G=111, B=154]")]
            public void TestArticuleColor(string actual)
            {
                Assert.AreEqual(Articule.BackColor.ToString(), actual);
            }
            [Test] // Тест на проверку цвета текстбокса NameP
            [TestCase("Color [A=255, R=80, G=111, B=154]")]
            public void TestNamePColor(string actual)
            {
                Assert.AreEqual(NameP.BackColor.ToString(), actual);
            }
        }
        public NewPosition() //Конструктор класса
        {
            InitializeComponent();
        }

        private void buttonExit2_Click(object sender, EventArgs e) //Метод, запускающийся при нажатии кнопки выход и завершающий работу программы
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

        Connection con = new Connection(); //Поле, использующееся для подключения к базе данных

        private void NewPosition_Load(object sender, EventArgs e) //Метод, запускающийся при загрузке страницы
        {
            con.OpenConnection();
        }

        private void Add_Click(object sender, EventArgs e) //Метод,запускающийся при нажатии на кнопку добавления позиции
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

            if (IsPosExists())
                return;

            SqlCommand command = new SqlCommand("INSERT INTO [dbo].[Pricelist] ([Тип мебели], [Артикул], [Название], [Наличие], [Цена в розницу], [Цена оптом]) VALUES (@uT, @uA, @uN, @uNal, @uP, @uPo)", con.connection);

            command.Parameters.AddWithValue("uT", Type.Text);
            command.Parameters.AddWithValue("uA", Articule.Text);
            command.Parameters.AddWithValue("uN", NameP.Text);
            command.Parameters.AddWithValue("uNal", Nalichie.Text);
            command.Parameters.AddWithValue("uP", Price.Text);
            command.Parameters.AddWithValue("uPo", PriceO.Text);

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Позиция добавлена");                
            }
            else
                MessageBox.Show("Позиция не добавлена");
        }
        public bool IsPosExists() //Метод, проверяющий существование позиции
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
                MessageBox.Show("Такая позиция уже существует, введите другой артикул");
                return true;
            }
            else
            {
                return false;
            }
        }

        private void Articule_KeyPress(object sender, KeyPressEventArgs e) // Метод, накладывающий условия на вводимые значения в текстбокс Articule
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }

        private void Nalichie_KeyPress(object sender, KeyPressEventArgs e) // Метод, накладывающий условия на вводимые значения в текстбокс Nalichie
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }

        private void Price_KeyPress(object sender, KeyPressEventArgs e) // Метод, накладывающий условия на вводимые значения в текстбокс Price
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }

        private void PriceO_KeyPress(object sender, KeyPressEventArgs e) // Метод, накладывающий условия на вводимые значения в текстбокс PriceO
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }

        private void Type_Enter(object sender, EventArgs e) //Метод, запускающийся при нажатии на текстбокс Type
        {
            if (Type.Text == "Тип мебели")
                Type.Text = "";
        }

        private void Articule_Enter(object sender, EventArgs e)//Метод, запускающийся при нажатии на текстбокс Articule
        {
            if (Articule.Text == "Артикул")
                Articule.Text = "";
        }

        private void NameP_Enter(object sender, EventArgs e)//Метод, запускающийся при нажатии на текстбокс NameP
        {
            if (NameP.Text == "Название")
                NameP.Text = "";
        }

        private void Nalichie_Enter(object sender, EventArgs e)//Метод, запускающийся при нажатии на текстбокс Nalichie
        {
            if (Nalichie.Text == "Количество позиций")
                Nalichie.Text = "";
        }

        private void Price_Enter(object sender, EventArgs e)//Метод, запускающийся при нажатии на текстбокс Price
        {
            if (Price.Text == "Цена в розницу")
                Price.Text = "";
        }

        private void PriceO_Enter(object sender, EventArgs e)//Метод, запускающийся при нажатии на текстбокс PriceO
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