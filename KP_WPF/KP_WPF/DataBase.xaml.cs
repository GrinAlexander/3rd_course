using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace KP_WPF
{
    /// <summary>
    /// Логика взаимодействия для DataBase.xaml
    /// </summary>
    public partial class DataBase : Window
    {
        private static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Alexander\Documents\GitHub\3rd_course\KP_WPF\KP_WPF\Database.mdf;Integrated Security = True";
        private SqlConnection connection = new SqlConnection(connectionString); 
        public DataBase()
        {
            InitializeComponent();
            ShowData();
        }
        private void Button_back_Click(object sender, RoutedEventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Close();
        }

        private void ShowData()
        {
            try
            {
                connection.Open();
                string query = "SELECT * FROM Bills";
                SqlCommand sqlCommand = new SqlCommand(query, connection);
                sqlCommand.ExecuteNonQuery();
                SqlDataAdapter sqlData = new SqlDataAdapter(sqlCommand);
                DataTable dt = new DataTable("Bills");
                sqlData.Fill(dt);
                main_dataGrid.ItemsSource = dt.DefaultView;
                sqlData.Update(dt);
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " " + ex.Source);
            }
        }

        private void Button_add_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                connection.Open();
                string query = "SELECT * FROM Bills";
                
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " " + ex.Source);
            }
        }

        private void Button_delete_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                connection.Open();
                string query = "SELECT * FROM Bills";

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " " + ex.Source);
            }
        }
    }
}
