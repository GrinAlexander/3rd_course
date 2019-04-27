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
using System.Windows.Shapes;

namespace KP_WPF
{
    /// <summary>
    /// Логика взаимодействия для Test.xaml
    /// </summary>
    public partial class Test : Window
    {
        enum Score
        {

        }
        List<int> comboBoxes = new List<int>(20);
        int result = 0;
        public Test()
        {
            InitializeComponent();
            
        }
        private void Button_back_Click(object sender, RoutedEventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Close();
        }

        private void button_result_Click(object sender, RoutedEventArgs e)
        {
            result = 0;
            CreateCBList();
            foreach (int item in comboBoxes)
            {
                if (item == -1)
                {
                    MessageBox.Show("Ответьте на все вопросы теста!");
                    comboBoxes.Clear();
                    return;
                }
                else
                {
                    result += item;
                }
                
            }
            if (result >= 30)
            {
                label_result.Content = "Результат: У вас депресси нет.";
            }
            else
            {
                label_result.Content = "Результат: У вас депрессия";
            }
            comboBoxes.Clear();
        }

        private void CreateCBList()
        {
            comboBoxes.Add(combobox_1.SelectedIndex);
            comboBoxes.Add(combobox_2.SelectedIndex);
            comboBoxes.Add(combobox_3.SelectedIndex);
            comboBoxes.Add(combobox_4.SelectedIndex);
            comboBoxes.Add(combobox_5.SelectedIndex);
            comboBoxes.Add(combobox_6.SelectedIndex);
            comboBoxes.Add(combobox_7.SelectedIndex);
            comboBoxes.Add(combobox_8.SelectedIndex);
            comboBoxes.Add(combobox_9.SelectedIndex);
            comboBoxes.Add(combobox_10.SelectedIndex);
            comboBoxes.Add(combobox_11.SelectedIndex);
            comboBoxes.Add(combobox_12.SelectedIndex);
            comboBoxes.Add(combobox_13.SelectedIndex);
            comboBoxes.Add(combobox_14.SelectedIndex);
            comboBoxes.Add(combobox_15.SelectedIndex);
            comboBoxes.Add(combobox_16.SelectedIndex);
            comboBoxes.Add(combobox_17.SelectedIndex);
            comboBoxes.Add(combobox_18.SelectedIndex);
            comboBoxes.Add(combobox_19.SelectedIndex);
            comboBoxes.Add(combobox_20.SelectedIndex);
        }
    }
}
