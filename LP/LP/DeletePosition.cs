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
    public partial class DeletePosition : Form
    {
        public DeletePosition()
        {
            InitializeComponent();
        }

        Connection con = new Connection();

        private void button1_Click(object sender, EventArgs e)
        {
            FurnitureType back = new FurnitureType();
            back.Show(); //Кнопка назад
            this.Hide();
            con.CloseConnection();
        }

        private void DeletePosition_Load(object sender, EventArgs e)
        {
            con.OpenConnection();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            string articule = Articule.Text;

            if (articule == "Введите артикул удаляемой позиции")
            {
                MessageBox.Show("Введите артикул");
                return;
            }            

            if (!IsPosExists())
                return;

            SqlCommand command = new SqlCommand("DELETE FROM Pricelist WHERE [Артикул] = @uA", con.connection);

            command.Parameters.AddWithValue("uA", Articule.Text);

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Позиция удалена");
            }
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

        private void Articule_TextChanged(object sender, EventArgs e)
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

        private void Articule_Enter(object sender, EventArgs e)
        {
            if (Articule.Text == "Введите артикул удаляемой позиции")
                Articule.Text = "";
        }

        private void Articule_Leave(object sender, EventArgs e)
        {
            if (Articule.Text == "")
                Articule.Text = "Введите артикул удаляемой позиции";
        }
    }
}
