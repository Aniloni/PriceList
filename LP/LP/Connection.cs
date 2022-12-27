using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;

namespace LP
{
    public class Connection //Класс для подключения к базе данных
    {
        public SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\vasil\OneDrive\Desktop\Документы\VS\PriceList\LP\LP\Database.mdf"); //Поле типа SqlConnection, использующееся для подключения к базе данных

        public void OpenConnection() //Метод, открывающий подключение к базе данных
        {
            if (connection.State == System.Data.ConnectionState.Closed) 
            {
                connection.Open();
            }
        }

        public void CloseConnection() //Метод, закрывающий подключение к базе данных
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
}