using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace KP_WPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class String23 : Window
    {
        public String23()
        {
            InitializeComponent();
        }
        private void Button_Check_click(object sender, RoutedEventArgs e)
        {
            tblock_result.Text = CheckForPalindrome(tb_input.Text);
        }

        private string CheckForPalindrome(string input)
        {
            bool check = false;
            for (int i = 0, j = input.Length - 1; i < j; i++, j--)
            {
                if (input[i] == input[j])
                {
                    check = true;
                }
                    
                else
                {
                    check = false;
                    break;
                }
            }
            if (check)
            {
                return "Это палиндром";
            }
            else
            {
                return "Это не палиндром";
            }
        }

        private void Button_back_Click(object sender, RoutedEventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Close();
        }
    }
}