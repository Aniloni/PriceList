using System;
using System.Windows.Forms;

namespace LP
{
    public partial class StartPage : Form //Класс формы начальной страницы
    {
        public StartPage() //Конструктор класса
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e) //Метод, запускающийся при нажатии кнопки назад и открывающий форму Enterance
        {
            Enterance frm = new Enterance();
            frm.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e) //Метод, запускающийся при нажатии кнопки назад и открывающий форму Registration
        {
            Registration frm = new Registration();
            frm.Show();
            this.Hide();
        }
    }
}
