using System.Data.SqlClient;

namespace SQLib
{
    public class SignIn
    {
        private SqlConnection connection;
        private SqlCommand command;
        private string tableName;
        private bool check;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="connection">Строка подключения к базе данных</param>
        /// <param name="tableName">Название таблицы, к которой требуется обращение</param>
        public SignIn(SqlConnection connection, string tableName)
        {
            this.connection = connection;
            this.tableName = tableName;
        }

        /// <summary>
        /// Метод проверяет наличие пользователя по логину и паролю.
        /// Возвращает true, если такой пользователь существует, иначе - false.
        /// </summary>
        /// <param name="login"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool CheckUserAvailability(string login, string password)
        {
            string note = null;
            connection.Open();
            note = $"SELECT * FROM [{this.tableName}] WHERE login = '{login}' AND password = '{password}'";
            command = new SqlCommand(note, connection);
            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    check = true;
                }
                else
                {
                    check = false;
                }
            }
            connection.Close();
            return check;
        } 
    }
}