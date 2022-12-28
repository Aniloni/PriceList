using NUnit.Framework;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LP
{
    /// <summary>
    /// Класс формы для добавления новой позиции типа "Диван" в прайс-лист
    /// </summary>
    public partial class Sofas : Form 
    {
        /// <summary>
        /// Тесты для класса Sofas
        /// </summary>
        [TestFixture]
        public class SofasTest : Sofas 
        {
            /// <summary>
            /// Тест на проверку размеров элемента panel1
            /// </summary>
            /// <param name="actualH"></param>
            /// <param name="actualW"></param>
            [Test]
            [TestCase(160, 1106)]
            public void TestPanel1Params(int actualH, int actualW)
            {
                Assert.AreEqual(panel1.Height, actualH);
                Assert.AreEqual(panel1.Width, actualW);
            }
            /// <summary>
            /// Тест на проверку цвета формы Sofas
            /// </summary>
            /// <param name="actual"></param>
            [Test] 
            [TestCase("Color [Control]")]
            public void SofasLoadColor(string actual)
            {
                Assert.AreEqual(BackColor.ToString(), actual);
            }
            /// <summary>
            /// Тест на проверку надписи на элементе button1
            /// </summary>
            /// <param name="actual"></param>
            [Test]
            [TestCase("Назад")]
            public void Testbutton1Color(string actual)
            {
                Assert.AreEqual(button1.Text, actual);
            }
            /// <summary>
            /// Тест на проверку размеров элемента button1
            /// </summary>
            /// <param name="actualH"></param>
            /// <param name="actualW"></param>
            [Test]
            [TestCase(35, 136)]
            public void Testbutton1Params(int actualH, int actualW)
            {
                Assert.AreEqual(button1.Height, actualH);
                Assert.AreEqual(button1.Width, actualW);
            }
        }
        /// <summary>
        /// Конструктор класса
        /// </summary>
        public Sofas() 
        {
            InitializeComponent();
        }
        /// <summary>
        /// Метод, запускающийся при загрузке страницы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Sofas_Load(object sender, EventArgs e) 
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
        /// <summary>
        /// Метод, запускающийся при нажатии кнопки назад и открывающий форму FurnitureType
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void button1_Click(object sender, EventArgs e) 
        {
            FurnitureType f = new FurnitureType();
            f.Show();
            this.Hide();
        }
    }
}
