using System;
using System.Windows.Forms;
using MD5Lib;
using SQLib;

namespace AddToSQL
{
    public partial class Form1 : Form
    {
        private SignIn signIn = new SignIn(@"Initial Catalog=TestBD;Integrated Security=True", "Person");
        private SignUp signUp = new SignUp(@"Initial Catalog=TestBD;Integrated Security=True", "Person");
        public Form1()
        {
            InitializeComponent();
        }

        private void button_addNote_Click(object sender, EventArgs e)
        {
            try
            {
                bool check = signUp.InsertNote(tb_loginSignUp.Text, MD5Hash.GetHash(tb_passwordSignUp.Text));
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
                dataGrid_table.DataSource = signIn.ShowNotes();
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
                bool check = signIn.CheckUserAvailability(tb_loginSignIn.Text, MD5Hash.GetHash(tb_passwordSignIn.Text));
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