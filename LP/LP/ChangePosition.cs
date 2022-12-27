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

namespace LP
{
    public partial class ChangePosition : Form
    {
        public ChangePosition()
        {
            InitializeComponent();
        }
        Connection con = new Connection();
        private void buttonExit2_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Выход из программы
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            FurnitureType back = new FurnitureType();
            back.Show(); //Кнопка назад
            this.Hide();
            con.CloseConnection();
        }

        private void ChangePosition_Load(object sender, EventArgs e)
        {
            con.OpenConnection();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            string articule = Articule.Text;
            string nameP = NameP.Text;
            string nalichie = Nalichie.Text;
            string price = Price.Text;
            string priceO = PriceO.Text;

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

            if (!IsPosExists())
                return;

            SqlCommand command = new SqlCommand("UPDATE Pricelist SET [Название] = @uN, [Наличие] = @uNal, [Цена в розницу] = @uP, [Цена оптом] = @uPo WHERE [Артикул] = @uA", con.connection);

            command.Parameters.AddWithValue("uA", Articule.Text);
            command.Parameters.AddWithValue("uN", NameP.Text);
            command.Parameters.AddWithValue("uNal", Nalichie.Text);
            command.Parameters.AddWithValue("uP", Price.Text);
            command.Parameters.AddWithValue("uPo", PriceO.Text);

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Позиция изменена");
            }
            else
                MessageBox.Show("Позиция не изменена");
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
                return true;
            }
            else
            {
                MessageBox.Show("Такой позиции не существует");
                return false;
            }
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


        private void Articule_Enter(object sender, EventArgs e)
        {
            if (Articule.Text == "Артикул")
                Articule.Text = "";
        }
        private void NameP_Enter(object sender, EventArgs e)
        {
            if (NameP.Text == "Название")
                NameP.Text = "";
        }

        private void Nalichie_Enter(object sender, EventArgs e)
        {
            if (Nalichie.Text == "Количество позиций")
                Nalichie.Text = "";
        }

        private void Price_Enter(object sender, EventArgs e)
        {
            if (Price.Text == "Цена в розницу")
                Price.Text = "";
        }

        private void PriceO_Enter(object sender, EventArgs e)
        {
            if (PriceO.Text == "Цена оптом")
                PriceO.Text = "";
        }


        private void Articule_Leave(object sender, EventArgs e)
        {
            if (Articule.Text == "")
                Articule.Text = "Артикул";
        }

        private void NameP_Leave(object sender, EventArgs e)
        {
            if (NameP.Text == "")
                NameP.Text = "Название";
        }

        private void Nalichie_Leave(object sender, EventArgs e)
        {
            if (Nalichie.Text == "")
                Nalichie.Text = "Количество позиций";
        }

        private void Price_Leave(object sender, EventArgs e)
        {
            if (Price.Text == "")
                Price.Text = "Цена в розницу";
        }

        private void PriceO_Leave(object sender, EventArgs e)
        {
            if (PriceO.Text == "")
                PriceO.Text = "Цена оптом";
        }

    }
}
