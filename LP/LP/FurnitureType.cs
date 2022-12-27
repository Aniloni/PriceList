using NUnit.Framework;
using System;
using System.Windows.Forms;

namespace LP
{
    public partial class FurnitureType : Form // Класс формы для всех типов позиций в прайс-лист
    {
        [TestFixture]
        public class FurnitureTypeTest : FurnitureType // Тесты для класса FurtitureType
        {
            [Test] // Тест на проверку цвета элемента button1
            [TestCase("Color [A=255, R=80, G=111, B=154]")]
            public void Testbutton12Color(string actual)
            {
                Assert.AreEqual(button12.BackColor.ToString(), actual);
            }
            [Test] // Тест на проверку надписи на элементе button4
            [TestCase("Диваны")]
            public void Testbutton4Color(string actual)
            {
                Assert.AreEqual(button4.Text, actual);
            }
            [Test] // Тест на проверку надписи на элементе button8
            [TestCase("Кресла")]
            public void Testbutton8Color(string actual)
            {
                Assert.AreEqual(button8.Text, actual);
            }
            [Test] // Тест на проверку цвета элемента Change
            [TestCase("Color [A=255, R=50, G=80, B=110]")]
            public void TestChangeColor(string actual)
            {
                Assert.AreEqual(Change.BackColor.ToString(), actual);
            }
        }
        public FurnitureType() //Конструктор класса
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e) //Метод, запускающийся при нажатии кнопки назад и открывающий форму NewPosition
        {
            NewPosition f = new NewPosition();
            f.Show();
            this.Hide();
        }

        private void buttonExit_Click(object sender, EventArgs e) //Метод, запускающийся при нажатии кнопки выход и завершающий работу программы
        {
            Application.Exit();
        }
        private void button9_Click(object sender, EventArgs e) //Метод, запускающийся при нажатии кнопки назад и открывающий форму Beds
        {
            Beds f = new Beds();
            f.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e) //Метод, запускающийся при нажатии кнопки назад и открывающий форму Chair
        {
            Chair f = new Chair();
            f.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e) //Метод, запускающийся при нажатии кнопки назад и открывающий форму Tables
        {
            Tables f = new Tables();
            f.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e) //Метод, запускающийся при нажатии кнопки назад и открывающий форму Wardrobes
        {
            Wardrobes f = new Wardrobes();
            f.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e) //Метод, запускающийся при нажатии кнопки назад и открывающий форму Armchairs
        {
            Armchairs f = new Armchairs();
            f.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e) //Метод, запускающийся при нажатии кнопки назад и открывающий форму Sofas
        {
            Sofas f = new Sofas();
            f.Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e) //Метод, запускающийся при нажатии кнопки назад и открывающий форму Shelves
        {
            Shelves f = new Shelves();
            f.Show();
            this.Hide();
        }

        private void button12_Click(object sender, EventArgs e) //Метод, запускающийся при нажатии кнопки назад и открывающий форму AllPositions
        {
            AllPositions f = new AllPositions();
            f.Show();
            this.Hide();
        }

        private void delete_Click(object sender, EventArgs e) //Метод, запускающийся при нажатии кнопки назад и открывающий форму DeletePosition
        {
            DeletePosition f = new DeletePosition();
            f.Show();
            this.Hide();
        }

        private void Change_Click(object sender, EventArgs e) //Метод, запускающийся при нажатии кнопки назад и открывающий форму ChangePosition
        {
            ChangePosition f = new ChangePosition();
            f.Show();
            this.Hide();
        }
    }
}