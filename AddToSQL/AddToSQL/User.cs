using System.Data;
using System.Data.SqlClient;
using SQLib;

namespace AddToSQL
{
    class User
    {
        public string Password { get; set; }
        public string Login { get; set; }
        public SqlConnection Connection { get; set; }
        public SqlCommand Command { get; set; }
        public string TableName { get; set; }
        private SignIn signIn;
        private SignUp signUp;

        public User()
        { }
        public User(string login, string password)
        {
            Login = login;
            Password = password;
        }
        public User(string login, string password, SqlConnection connection, string tableName)
        {
            Login = login;
            Password = password;
            Connection = connection;
            TableName = tableName;
        }
        public User(SqlConnection connection, string tableName)
        {
            Connection = connection;
            TableName = tableName;
        }

        public bool SignIn()
        {
            signIn = new SignIn(Connection, TableName);
            return signIn.CheckUserAvailability(Login, Password);
        }

        public bool SignUp()
        {
            signUp = new SignUp(Connection, TableName);
            return signUp.InsertNote(Login, Password);
        }

        /// <summary>
        /// Метод выводит записи подключенной таблицы
        /// </summary>
        /// <returns></returns>
        public DataTable ShowUsers()
        {
            DataTable table = new DataTable();
            Connection.Open();
            Command = new SqlCommand($"SELECT * FROM [{TableName}]", Connection);
            SqlDataAdapter adapter = new SqlDataAdapter(Command);
            adapter.Fill(table);
            Connection.Close();
            return table;
        }
    }
}