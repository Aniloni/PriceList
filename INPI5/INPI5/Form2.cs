using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INPI5
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void buttonExit2_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Выход из программы
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Form1 back = new Form1();
            back.Show(); //Кнопка назад
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
