using NUnit.Framework;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LP
{
    public partial class Sofas : Form // Класс формы для добавления новой позиции типа "Диван" в прайс-лист
    {
        [TestFixture]
        public class SofasTest : Sofas // Тесты для класса Sofas
        {
            [Test]// Тест на проверку размеров элемента panel1
            [TestCase(160, 1106)]
            public void TestPanel1Params(int actualH, int actualW)
            {
                Assert.AreEqual(panel1.Height, actualH);
                Assert.AreEqual(panel1.Width, actualW);
            }
            [Test] // Тест на проверку цвета формы Sofas
            [TestCase("Color [Control]")]
            public void SofasLoadColor(string actual)
            {
                Assert.AreEqual(BackColor.ToString(), actual);
            }
            [Test]// Тест на проверку надписи на элементе button1
            [TestCase("Назад")]
            public void Testbutton1Color(string actual)
            {
                Assert.AreEqual(button1.Text, actual);
            }
            [Test]// Тест на проверку размеров элемента button1
            [TestCase(35, 136)]
            public void Testbutton1Params(int actualH, int actualW)
            {
                Assert.AreEqual(button1.Height, actualH);
                Assert.AreEqual(button1.Width, actualW);
            }
        }
        public Sofas() //Конструктор класса
        {
            InitializeComponent();
        }

        private void Sofas_Load(object sender, EventArgs e) //Метод, запускающийся при загрузке страницы
        {
            Connection con = new Connection();
            con.OpenConnection();

            DataTable table = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter();

            SqlCommand command = new SqlCommand("SELECT * FROM [dbo].[Pricelist] WHERE [Тип мебели] = N'Диван'", con.connection);

            adapter.SelectCommand = command;
            adapter.Fill(table);

            dataGridView1.DataSource = table;

            con.CloseConnection();

        }

        private void button1_Click(object sender, EventArgs e) //Метод, запускающийся при нажатии кнопки назад и открывающий форму FurnitureType
        {
            FurnitureType f = new FurnitureType();
            f.Show();
            this.Hide();
        }
    }
}
