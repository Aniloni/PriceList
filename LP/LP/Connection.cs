using System.Data.SqlClient;

namespace LP
{
    /// <summary>
    /// Класс для подключения к базе данных
    /// </summary>
    public class Connection 
    {
        /// <summary>
        /// Поле типа SqlConnection, использующееся для подключения к базе данных
        /// </summary>
        public SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\vasil\OneDrive\Desktop\Documents\VS\PriceList\LP\LP\Database.mdf"); 

        /// <summary>
        /// Метод, открывающий подключение к базе данных
        /// </summary>
        public void OpenConnection() 
        {
            if (connection.State == System.Data.ConnectionState.Closed) 
            {
                connection.Open();
            }
        }

        /// <summary>
        /// Метод, закрывающий подключение к базе данных
        /// </summary>
        public void CloseConnection() 
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
}