using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;

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
        private int? _id = 0;
        private int? _discount = 0;
        Regex regex = new Regex(@"(\+375)(44|25|33|29|)[0-9]{7}$", RegexOptions.Compiled | RegexOptions.IgnoreCase);
        DataTable dt = new DataTable();
        public int? Discount
        {
            get
            {
                return _discount;
            }
            set
            {
                if (value >= 0 && value <= 30)
                {
                    _discount = value;
                    img_tariffError.Visibility = Visibility.Collapsed;
                }
                else
                {
                    img_tariffError.Visibility = Visibility.Visible;
                }
            }
        }

        public int? ID
        {
            get
            {
                return _id;
            }
            set
            {
                if (value != null && value > 0)
                {
                    _id = value;
                    img_idError.Visibility = Visibility.Collapsed;
                }
                else
                {
                    img_idError.Visibility = Visibility.Visible;
                }
            }
        }
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
                    _date = new DateTime(value.Value.Year, value.Value.Month, value.Value.Day, value.Value.Hour, value.Value.Minute, 0);

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
                    _dateStart = new DateTime(value.Value.Year, value.Value.Month, value.Value.Day, value.Value.Hour, value.Value.Minute, 0);
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
                    _dateEnd = new DateTime(value.Value.Year, value.Value.Month, value.Value.Day, value.Value.Hour, value.Value.Minute, 0);
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
            Background = Theme.background;
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
                dt = new DataTable("Bills");
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
                Surname = @tb_surname.Text;
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
                if (tb_discount.Text != "")
                {
                    Discount = int.Parse(tb_discount.Text);
                }
                else
                {
                    Discount = -1;
                }
                DateStart = dt_dateStart.Value;
                DateEnd = dt_dateEnd.Value;
                CheckInsertCorrectness();
                if (Correctness)
                {
                    connection.Open();
                    string query = $"INSERT INTO [Bills] (surname, phoneNumber, date, tariff, discount, dateStart, dateEnd) VALUES (N'{_surname}', '{_phoneNumber}', '{_date}', '{_tariff}', '{_discount}', '{_dateStart}', '{_dateEnd}') ";
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
                if (int.TryParse(tb_id.Text, out int res))
                {
                    ID = res;
                }
                else
                {
                    ID = 0;
                }
                CheckDeleteCorrectness();
                if (Correctness)
                {
                    connection.Open();
                    string query = $"DELETE FROM [Bills] WHERE bill_id = {_id}";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.ExecuteNonQuery();
                    connection.Close();
                    ShowData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " " + ex.Source);
            }
        }

        private void GroupBY(string table)
        {
            try
            {
                connection.Open();
                string query = $"SELECT {table}, COUNT({table}) AS [{table}Count] FROM [Bills] GROUP BY {table}";
                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
                SqlDataAdapter sqlData = new SqlDataAdapter(command);
                dt = new DataTable("Bills");
                sqlData.Fill(dt);
                main_dataGrid.ItemsSource = dt.DefaultView;
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " " + ex.Source);
            }
        }

        private void FirstEx()
        {
            try
            {
                connection.Open();
                string query = $"Select * FROM [Bills] Order BY surname, date";
                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
                SqlDataAdapter sqlData = new SqlDataAdapter(command);
                dt = new DataTable("Bills");
                sqlData.Fill(dt);
                main_dataGrid.ItemsSource = dt.DefaultView;
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " " + ex.Source);
            }
        }

        private void SecondEx()
        {
            try
            {
                connection.Open();
                string query = $"SELECT phoneNumber, COUNT(*) AS [Count] FROM [Bills] GROUP BY phoneNumber HAVING COUNT(*) > 1";
                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
                SqlDataAdapter sqlData = new SqlDataAdapter(command);
                dt = new DataTable("Bills");
                sqlData.Fill(dt);
                main_dataGrid.ItemsSource = dt.DefaultView;
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " " + ex.Source);
            }
        }

        private void ThirdEx()
        {
            try
            {
                connection.Open();
                string query = $"SELECT DATEDIFF(MINUTE, dateStart, dateEnd) AS [callLength] FROM [Bills] Order by [callLength] DESC";
                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
                SqlDataAdapter sqlData = new SqlDataAdapter(command);
                dt = new DataTable("Bills");
                sqlData.Fill(dt);
                main_dataGrid.ItemsSource = dt.DefaultView;
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " " + ex.Source);
            }
        }

        private void FourthEx()
        {
            try
            {
                connection.Open();
                string query = $"Select ROUND(MAX(tariff * CAST(discount AS float) * DATEDIFF(SECOND, dateStart, dateEnd) / 6000),2) AS [Max price] FROM [Bills]";
                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
                SqlDataAdapter sqlData = new SqlDataAdapter(command);
                dt = new DataTable("Bills");
                sqlData.Fill(dt);
                main_dataGrid.ItemsSource = dt.DefaultView;
                connection.Close();
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

        private void CheckInsertCorrectness()
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

        private void CheckDeleteCorrectness()
        {
            if (img_idError.Visibility == Visibility.Collapsed)
            {
                Correctness = true;
            }
            else
            {
                Correctness = false;
            }
        }

        private void Cb_example_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (cb_example.SelectedIndex)
            {
                case 0:
                    {
                        FirstEx();
                        break;
                    }
                case 1:
                    {
                        SecondEx();
                        break;
                    }
                case 2:
                    {
                        ThirdEx();
                        break;
                    }
                case 3:
                    {
                        FourthEx();
                        break;
                    }
            }
        }

        private void Cb_group_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (cb_group.SelectedIndex)
            {
                case 0:
                    {
                        GroupBY("surname");
                        break;
                    }
                case 1:
                    {
                        GroupBY("phoneNumber");
                        break;
                    }
                case 2:
                    {
                        GroupBY("date");
                        break;
                    }
                case 3:
                    {
                        GroupBY("tariff");
                        break;
                    }
                case 4:
                    {
                        GroupBY("discount");
                        break;
                    }
                case 5:
                    {
                        GroupBY("dateStart");
                        break;
                    }
                case 6:
                    {
                        GroupBY("dateEnd");
                        break;
                    }
                default:
                    break;
            }
        }

        private void Button_refresh_Click(object sender, RoutedEventArgs e)
        {
            ShowData();
        }

        private void Tb_discount_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!int.TryParse(tb_discount.Text, out int res))
            {
                tb_discount.Text = null;
            }
        }

        private void Button_report_Click(object sender, RoutedEventArgs e)
        {
            StreamWriter swExtLogFile = new StreamWriter("D:/report.txt", true);
            int i;
            swExtLogFile.Write(Environment.NewLine);
            foreach (DataRow row in dt.Rows)
            {
                object[] array = row.ItemArray;
                for (i = 0; i < array.Length - 1; i++)
                {
                    swExtLogFile.Write(array[i].ToString() + " | ");
                }
                swExtLogFile.WriteLine(array[i].ToString());
            }
            swExtLogFile.Write("*****END OF DATA****" + DateTime.Now.ToString());
            swExtLogFile.Flush();
            swExtLogFile.Close();
            MessageBox.Show("Отчёт создан");
        }
    }
}