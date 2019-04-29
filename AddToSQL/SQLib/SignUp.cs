using System.Data.SqlClient;

namespace SQLib
{
    public class SignUp
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
        public SignUp(string connection, string tableName)
        {
            this.connection = new SqlConnection(@connection);
            this.tableName = tableName;
        }

        /// <summary>
        /// Метод добавляет запись в таблицу подключенной базы данных.
        /// Возвращает true, если запись успешно добавлена, иначе - false.
        /// </summary>
        /// <param name="login"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool InsertNote(string login, string password)
        {
            string note = null;
            check = CheckLoginAvailability(login); //обращение к методу проверки наличия логина в бд
            if (check)
            {
                return false;
            }
            else
            {
                connection.Open();
                note = $"INSERT INTO [{this.tableName}] VALUES ('{login}', '{password}')";
                command = new SqlCommand(note, connection);
                if (command.ExecuteNonQuery() == 1)
                {
                    connection.Close();
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        /// <summary>
        /// Метод осуществляет проверку логина на наличие в подключенной базе данных при регистрации.
        /// Возвращает true, если такой логин зарегистрирован, иначе - false.
        /// </summary>
        /// <param name="login"></param>
        /// <returns></returns>
        private bool CheckLoginAvailability(string login)
        {
            string note = null;
            connection.Open();
            note = $"SELECT * FROM [{this.tableName}] WHERE login = '{login}'";
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