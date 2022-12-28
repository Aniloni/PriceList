using System;
using System.Windows.Forms;

namespace LP
{
    /// <summary>
    /// Класс формы начальной страницы
    /// </summary>
    public partial class StartPage : Form 
    {
        /// <summary>
        /// Конструктор класса
        /// </summary>
        public StartPage() 
        {
            InitializeComponent();
        }
        /// <summary>
        /// Метод, запускающийся при нажатии кнопки назад и открывающий форму Enterance
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void button1_Click_1(object sender, EventArgs e) 
        {
            Enterance frm = new Enterance();
            frm.Show();
            this.Hide();

        }
        /// <summary>
        /// Метод, запускающийся при нажатии кнопки назад и открывающий форму Registration
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void button2_Click(object sender, EventArgs e) 
        {
            Registration frm = new Registration();
            frm.Show();
            this.Hide();
        }
    }
}
