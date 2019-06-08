using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace KP_WPF
{
    /// <summary>
    /// Логика взаимодействия для Report.xaml
    /// </summary>
    public partial class Article : Window
    {
        public Article()
        {
            InitializeComponent();
            Background = Theme.background;
            menu_general.Background = Theme.background;
        }

        private void Button_back_Click(object sender, RoutedEventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Close();
        }

        private void Menu_saveas_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog
            {
                InitialDirectory = "D:/",
                Filter = "JPG Files (*.jpg)|*.jpg"
            };
            if (save.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                JpegBitmapEncoder jpegBitmapEncoder = new JpegBitmapEncoder();
                jpegBitmapEncoder.Frames.Add(BitmapFrame.Create(image_main.Source as BitmapSource));
                using (FileStream fileStream = new FileStream(save.FileName, FileMode.Create))
                    jpegBitmapEncoder.Save(fileStream);
            }
        }

        private void Menu_print_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Controls.PrintDialog printDialog = new System.Windows.Controls.PrintDialog();
            if (printDialog.ShowDialog() == true)
            {
                printDialog.PrintVisual(image_main, "Page");
            }
        }

        private void Menu_exit_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}