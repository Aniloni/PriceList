using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LP
{
    public partial class NewPosition : Form
    {
        public NewPosition()
        {
            InitializeComponent();
        }

        private void buttonExit2_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Выход из программы
            
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            FurtitureType back = new FurtitureType();
            back.Show(); //Кнопка назад
            this.Hide();
            con.CloseConnection();
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

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }       

        private void fillByChairToolStripButton_Click(object sender, EventArgs e)
        {
      

        }

        private void Articule_TextChanged(object sender, EventArgs e)
        {

        }

        Connection con = new Connection();

        private void NewPosition_Load(object sender, EventArgs e)
        {
            con.OpenConnection();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            string type = Type.Text;
            string articule = Articule.Text;
            string nameP = NameP.Text;
            string nalichie = Nalichie.Text;
            string price = Price.Text;
            string priceO = PriceO.Text;

            if (type == "")
            {
                MessageBox.Show("Введите тип мебели");
                return;
            }

            if (articule == "")
            {
                MessageBox.Show("Введите артикул");
                return;
            }

            if (nameP == "")
            {
                MessageBox.Show("Введите название позиции");
                return;
            }

            if (nalichie == "")
            {
                MessageBox.Show("Введите количество в наличии");
                return;
            }

            if (price == "")
            {
                MessageBox.Show("Введите цену в розницу");
                return;
            }

            if (priceO == "")
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

        private void Type_TextChanged(object sender, EventArgs e)
        {
        }

        private void Articule_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }

        private void Nalichie_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }

        private void Price_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }

        private void PriceO_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }
    }
}