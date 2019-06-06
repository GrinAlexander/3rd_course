using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
        private string _surname = null;
        private string _phoneNumber = null;
        private float? _tariff = 0;
        private DateTime? _date = null;
        private DateTime? _dateStart = null;
        private DateTime? _dateEnd = null;
        Regex regex = new Regex(@"(\+375)(44|25|33|29|)[0-9]{7}$", RegexOptions.Compiled | RegexOptions.IgnoreCase);
        public string Surname
        {
            get
            {
                return _surname;
            }
            set
            {
                if (value != "" && value[0] >= 'А' && value[0] <= 'Я')
                {
                    _surname = value;
                    img_surnameError.Visibility = Visibility.Collapsed;
                }
                else
                {
                    img_surnameError.Visibility = Visibility.Visible;
                }
            }
        }
        public string PhoneNumber
        {
            get
            {
                return _phoneNumber;
            }
            set
            {
                if (regex.IsMatch(value))
                {
                    _phoneNumber = value;
                    img_phoneNumberError.Visibility = Visibility.Collapsed;
                }
                else
                {
                    img_phoneNumberError.Visibility = Visibility.Visible;
                }
            }
        }
        public DateTime? Date
        {
            get
            {
                return _date;
            }
            set
            {
                if (value != null)
                {
                    _date = value;
                    img_dateError.Visibility = Visibility.Collapsed;
                }
                else
                {
                    img_dateError.Visibility = Visibility.Visible;
                }
            }
        }
        public float? Tariff
        {
            get
            {
                return _tariff;
            }
            set
            {
                if (value > 0 && value < 50)
                {
                    _tariff = value;
                    img_tariffError.Visibility = Visibility.Collapsed;
                }
                else
                {
                    img_tariffError.Visibility = Visibility.Visible;
                }
            }
        }
        public DateTime? DateStart
        {
            get
            {
                return _dateStart;
            }
            set
            {
                if (value != null)
                {
                    _dateStart = value;
                    _dateStart.Value.AddHours(value.Value.Hour);
                    _dateStart.Value.AddMinutes(value.Value.Minute);
                    img_dateStartError.Visibility = Visibility.Collapsed;
                }
                else
                {
                    img_dateStartError.Visibility = Visibility.Visible;
                }
            }
        }
        public DateTime? DateEnd
        {
            get
            {
                return _dateEnd;
            }
            set
            {
                if (_dateStart < value && value != null)
                {
                    _dateEnd = value;
                    _dateEnd.Value.AddHours(value.Value.Hour);
                    _dateEnd.Value.AddMinutes(value.Value.Minute);
                    img_dateEndError.Visibility = Visibility.Collapsed;
                }
                else
                {
                    img_dateEndError.Visibility = Visibility.Visible;
                }
            }
        }
        public bool Correctness { get; set; }

        public DataBase()
        {
            InitializeComponent();
            this.Correctness = false;
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
                Surname = tb_surname.Text;
                PhoneNumber = tb_phoneNumber.Text;
                Date = dt_date.Value;
                if (tb_tariff.Text != "")
                {
                    Tariff = float.Parse(tb_tariff.Text);
                }
                else
                {
                    Tariff = -1;
                }
                DateStart = dt_dateStart.Value;
                DateEnd = dt_dateEnd.Value;
                CheckCorrectness();
                if (Correctness)
                {
                    connection.Open();
                    string query = $"INSERT INTO [Bills] (surname, phoneNumber, date, tariff, dateStart, dateEnd) VALUES ('{_surname}', '{_phoneNumber}', '{_date}', '{_tariff}', '{_dateStart}', '{_dateEnd}') ";
                    SqlCommand sqlCommand = new SqlCommand(query, connection);
                    sqlCommand.ExecuteNonQuery();
                    connection.Close();
                    ShowData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " " + ex.GetBaseException());
            }
        }

        private void Button_delete_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                CheckCorrectness();
                if (Correctness)
                {
                    connection.Open();
                    string query = "SELECT * FROM Bills";
                    connection.Close();
                    ShowData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " " + ex.Source);
            }
        }

        private void Tb_tariff_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!float.TryParse(tb_tariff.Text, out float res))
            {
                tb_tariff.Text = null;
            }
        }

        private void CheckCorrectness()
        {
            if (img_surnameError.Visibility == Visibility.Collapsed && img_phoneNumberError.Visibility == Visibility.Collapsed &&
                img_dateError.Visibility == Visibility.Collapsed && img_tariffError.Visibility == Visibility.Collapsed &&
                img_dateStartError.Visibility == Visibility.Collapsed && img_dateEndError.Visibility == Visibility.Collapsed)
            {
                Correctness = true;
            }
            else
            {
                Correctness = false;
            }
        }
    }
}