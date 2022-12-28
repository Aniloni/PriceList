using NUnit.Framework;
using System;
using System.Windows.Forms;

namespace LP
{
    /// <summary>
    /// Класс формы для всех типов позиций в прайс-лист
    /// </summary>
    public partial class FurnitureType : Form 
    {
        /// <summary>
        /// Тесты для класса FurtitureType
        /// </summary>
        [TestFixture]
        public class FurnitureTypeTest : FurnitureType 
        {
            /// <summary>
            /// Тест на проверку цвета элемента button1
            /// </summary>
            /// <param name="actual"></param>
            [Test] 
            [TestCase("Color [A=255, R=80, G=111, B=154]")]
            public void Testbutton12Color(string actual)
            {
                Assert.AreEqual(button12.BackColor.ToString(), actual);
            }
            /// <summary>
            /// Тест на проверку надписи на элементе button4
            /// </summary>
            /// <param name="actual"></param>
            [Test] 
            [TestCase("Диваны")]
            public void Testbutton4Color(string actual)
            {
                Assert.AreEqual(button4.Text, actual);
            }
            /// <summary>
            /// Тест на проверку надписи на элементе button8
            /// </summary>
            /// <param name="actual"></param>
            [Test] 
            [TestCase("Кресла")]
            public void Testbutton8Color(string actual)
            {
                Assert.AreEqual(button8.Text, actual);
            }
            /// <summary>
            /// Тест на проверку цвета элемента Change
            /// </summary>
            /// <param name="actual"></param>
            [Test] 
            [TestCase("Color [A=255, R=50, G=80, B=110]")]
            public void TestChangeColor(string actual)
            {
                Assert.AreEqual(Change.BackColor.ToString(), actual);
            }
        }
        /// <summary>
        /// Конструктор класса
        /// </summary>
        public FurnitureType() 
        {
            InitializeComponent();
        }
        /// <summary>
        /// Метод, запускающийся при нажатии кнопки назад и открывающий форму NewPosition
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void button1_Click(object sender, EventArgs e) 
        {
            NewPosition f = new NewPosition();
            f.Show();
            this.Hide();
        }
        /// <summary>
        /// Метод, запускающийся при нажатии кнопки выход и завершающий работу программы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void buttonExit_Click(object sender, EventArgs e) 
        {
            Application.Exit();
        }
        /// <summary>
        /// Метод, запускающийся при нажатии кнопки назад и открывающий форму Beds
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void button9_Click(object sender, EventArgs e) 
        {
            Beds f = new Beds();
            f.Show();
            this.Hide();
        }
        /// <summary>
        /// Метод, запускающийся при нажатии кнопки назад и открывающий форму Chair
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void button10_Click(object sender, EventArgs e) 
        {
            Chairs f = new Chairs();
            f.Show();
            this.Hide();
        }
        /// <summary>
        /// Метод, запускающийся при нажатии кнопки назад и открывающий форму Tables
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void button3_Click(object sender, EventArgs e) 
        {
            Tables f = new Tables();
            f.Show();
            this.Hide();
        }
        /// <summary>
        /// Метод, запускающийся при нажатии кнопки назад и открывающий форму Wardrobes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void button2_Click(object sender, EventArgs e) 
        {
            Wardrobes f = new Wardrobes();
            f.Show();
            this.Hide();
        }
        /// <summary>
        /// Метод, запускающийся при нажатии кнопки назад и открывающий форму Armchairs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void button8_Click(object sender, EventArgs e) 
        {
            Armchairs f = new Armchairs();
            f.Show();
            this.Hide();
        }
        /// <summary>
        /// Метод, запускающийся при нажатии кнопки назад и открывающий форму Sofas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void button4_Click(object sender, EventArgs e) 
        {
            Sofas f = new Sofas();
            f.Show();
            this.Hide();
        }
        /// <summary>
        /// Метод, запускающийся при нажатии кнопки назад и открывающий форму Shelves
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void button11_Click(object sender, EventArgs e) 
        {
            Shelves f = new Shelves();
            f.Show();
            this.Hide();
        }
        /// <summary>
        /// Метод, запускающийся при нажатии кнопки назад и открывающий форму AllPositions
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void button12_Click(object sender, EventArgs e) 
        {
            AllPositions f = new AllPositions();
            f.Show();
            this.Hide();
        }
        /// <summary>
        /// Метод, запускающийся при нажатии кнопки назад и открывающий форму DeletePosition
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void delete_Click(object sender, EventArgs e) 
        {
            DeletePosition f = new DeletePosition();
            f.Show();
            this.Hide();
        }
        /// <summary>
        /// Метод, запускающийся при нажатии кнопки назад и открывающий форму ChangePosition
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Change_Click(object sender, EventArgs e) 
        {
            ChangePosition f = new ChangePosition();
            f.Show();
            this.Hide();
        }
    }
}