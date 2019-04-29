using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using MD5Lib;
using SQLib;


namespace AddToSQL
{
    public partial class MainForm : Form
    {
        private User user;
        public MainForm()
        {
            InitializeComponent();
            user = new User(new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=TestBD;Integrated Security=True"), "Person");
        }

        private void button_addNote_Click(object sender, EventArgs e)
        {
            try
            {
                user.Login = tb_loginSignUp.Text;
                user.Password = MD5Hash.GetHash(tb_passwordSignUp.Text);
                bool check = user.SignUp();
                if (check)
                {
                    label_SignUp_Notification.Text = "Пользователь зарегистрирован";
                }
                else
                {
                    label_SignUp_Notification.Text = "Такой пользователь уже существует";
                }
            }
            catch (SQLHandlerException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_showTable_Click(object sender, EventArgs e)
        {
            try
            {
                dataGrid_table.DataSource = user.ShowUsers();
            }
            catch (SQLHandlerException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_check_Click(object sender, EventArgs e)
        {
            try
            {
                user.Login = tb_loginSignIn.Text;
                user.Password = MD5Hash.GetHash(tb_passwordSignIn.Text);
                bool check = user.SignIn();
                if (check)
                {
                    label_SignIn_Notification.Text = "Пользователь существует";
                }
                else
                {
                    label_SignIn_Notification.Text = "Пользователь не существует";
                }
            }
            catch (SQLHandlerException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}