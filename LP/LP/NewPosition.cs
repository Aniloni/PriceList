using NUnit.Framework;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace LP
{
    /// <summary>
    /// Класс формы для добавления новой позиции в прайс-лист
    /// </summary>
    public partial class NewPosition : Form 
    {
        /// <summary>
        /// Тесты для класса NewPosition
        /// </summary>
        [TestFixture]
        public class NewPositionTest : NewPosition 
        {
            /// <summary>
            /// Тест на проверку цвета текстбокса Type
            /// </summary>
            /// <param name="actual"></param>
            [Test] 
            [TestCase("Color [A=255, R=80, G=111, B=154]")]
            public void TestTypeColor(string actual)
            {
                Assert.AreEqual(Type.BackColor.ToString(), actual);
            }
            /// <summary>
            /// Тест на проверку цвета текстбокса Color
            /// </summary>
            /// <param name="actual"></param>
            [Test] 
            [TestCase("Color [A=255, R=50, G=80, B=110]")]
            public void TestbuttonBackColor(string actual)
            {
                Assert.AreEqual(buttonBack.BackColor.ToString(), actual);
            }
            /// <summary>
            /// Тест на проверку цвета текстбокса Articule
            /// </summary>
            /// <param name="actual"></param>
            [Test] 
            [TestCase("Color [A=255, R=80, G=111, B=154]")]
            public void TestArticuleColor(string actual)
            {
                Assert.AreEqual(Articule.BackColor.ToString(), actual);
            }
            /// <summary>
            /// Тест на проверку цвета текстбокса NameP
            /// </summary>
            /// <param name="actual"></param>
            [Test] 
            [TestCase("Color [A=255, R=80, G=111, B=154]")]
            public void TestNamePColor(string actual)
            {
                Assert.AreEqual(NameP.BackColor.ToString(), actual);
            }
        }
        /// <summary>
        /// Конструктор класса
        /// </summary>
        public NewPosition() 
        {
            InitializeComponent();
        }
        /// <summary>
        /// Метод, запускающийся при нажатии кнопки выход и завершающий работу программы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void buttonExit2_Click(object sender, EventArgs e) 
        {
            Application.Exit(); 
        }
        /// <summary>
        /// Метод, запускающийся при нажатии кнопки назад и открывающий форму FurnitureType
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void buttonBack_Click(object sender, EventArgs e) 
        {
            FurnitureType back = new FurnitureType();
            back.Show(); 
            this.Hide();
            con.CloseConnection();
        }
        /// <summary>
        /// Поле, использующееся для подключения к базе данных
        /// </summary>
        Connection con = new Connection();
        /// <summary>
        /// Метод, запускающийся при загрузке страницы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void NewPosition_Load(object sender, EventArgs e) 
        {
            con.OpenConnection();
        }
        /// <summary>
        /// Метод,запускающийся при нажатии на кнопку добавления позиции
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Add_Click(object sender, EventArgs e) 
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
        /// <summary>
        /// Метод, проверяющий существование позиции
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
                MessageBox.Show("Такая позиция уже существует, введите другой артикул");
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Метод, накладывающий условия на вводимые значения в текстбокс Articule
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
        /// Метод, накладывающий условия на вводимые значения в текстбокс Nalichie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Nalichie_KeyPress(object sender, KeyPressEventArgs e) 
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) 
            {
                e.Handled = true;
            }
        }
        /// <summary>
        /// Метод, накладывающий условия на вводимые значения в текстбокс Price
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Price_KeyPress(object sender, KeyPressEventArgs e) 
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) 
            {
                e.Handled = true;
            }
        }
        /// <summary>
        /// Метод, накладывающий условия на вводимые значения в текстбокс PriceO
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void PriceO_KeyPress(object sender, KeyPressEventArgs e) 
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) 
            {
                e.Handled = true;
            }
        }
        /// <summary>
        /// Метод, запускающийся при нажатии на текстбокс Type
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Type_Enter(object sender, EventArgs e) 
        {
            if (Type.Text == "Тип мебели")
                Type.Text = "";
        }
        /// <summary>
        /// Метод, запускающийся при нажатии на текстбокс Articule
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Articule_Enter(object sender, EventArgs e)
        {
            if (Articule.Text == "Артикул")
                Articule.Text = "";
        }
        /// <summary>
        /// Метод, запускающийся при нажатии на текстбокс NameP
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void NameP_Enter(object sender, EventArgs e)
        {
            if (NameP.Text == "Название")
                NameP.Text = "";
        }
        /// <summary>
        /// Метод, запускающийся при нажатии на текстбокс Nalichie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Nalichie_Enter(object sender, EventArgs e)
        {
            if (Nalichie.Text == "Количество позиций")
                Nalichie.Text = "";
        }
        /// <summary>
        /// Метод, запускающийся при нажатии на текстбокс Price
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Price_Enter(object sender, EventArgs e)
        {
            if (Price.Text == "Цена в розницу")
                Price.Text = "";
        }
        /// <summary>
        /// Метод, запускающийся при нажатии на текстбокс PriceO
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void PriceO_Enter(object sender, EventArgs e)
        {
            if (PriceO.Text == "Цена оптом")
                PriceO.Text = "";
        }
        /// <summary>
        /// Метод, запускающийся при выходе из поля текстбокса Type
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Type_Leave(object sender, EventArgs e) 
        {
            if (Type.Text == "")
                Type.Text = "Тип мебели";
        }
        /// <summary>
        /// Метод, запускающийся при выходе из поля текстбокса Articule
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Articule_Leave(object sender, EventArgs e) 
        {
            if (Articule.Text == "")
                Articule.Text = "Артикул";
        }
        /// <summary>
        /// Метод, запускающийся при выходе из поля текстбокса NameP
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void NameP_Leave(object sender, EventArgs e) 
        {
            if (NameP.Text == "")
                NameP.Text = "Название";
        }
        /// <summary>
        /// Метод, запускающийся при выходе из поля текстбокса Nalichie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Nalichie_Leave(object sender, EventArgs e) 
        {
            if (Nalichie.Text == "")
                Nalichie.Text = "Количество позиций";
        }
        /// <summary>
        /// Метод, запускающийся при выходе из поля текстбокса Price
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Price_Leave(object sender, EventArgs e) 
        {
            if (Price.Text == "")
                Price.Text = "Цена в розницу";
        }
        /// <summary>
        /// Метод, запускающийся при выходе из поля текстбокса PriceO
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void PriceO_Leave(object sender, EventArgs e) 
        {
            if (PriceO.Text == "")
                PriceO.Text = "Цена оптом";
        }
    }
}