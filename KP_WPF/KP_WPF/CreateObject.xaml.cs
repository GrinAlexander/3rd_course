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
    /// Логика взаимодействия для CreateObject.xaml
    /// </summary>
    public partial class CreateObject : Window
    {
        public CreateObject()
        {
            InitializeComponent();
            Background = Theme.background;
        }
        private void Button_back_Click(object sender, RoutedEventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Close();
        }

        private void button_create_Click(object sender, RoutedEventArgs e)
        {
            uint check = 0;
            try
            {
                check = uint.Parse(tb_amount.Text);
                check = uint.Parse(tb_countProgramms.Text);
                check = uint.Parse(tb_power.Text);
                if (tb_material.Text == "" || tb_color.Text == "" || tb_complect.Text== "" || tb_display.Text == "" || tb_type.Text == "" || tb_heating.Text == "" || tb_programms.Text == "" || tb_fastCooking.Text == "" || tb_evenHeating.Text == "" || tb_heatingType.Text == "" || tb_settingDeg.Text == "" || tb_settingTime.Text == "" || tb_handlingType.Text == "" || tb_startDelay.Text == "" || tb_voiceGuide.Text == "" || tb_display.Text == "" || tb_displayType.Text == "")
                {
                    MessageBox.Show("Заполните все поля!");
                    return;
                }
                MessageBox.Show("Объект может быть создан!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
