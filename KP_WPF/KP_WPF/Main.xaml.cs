using System.Windows;

namespace KP_WPF
{
    /// <summary>
    /// Логика взаимодействия для Main.xaml
    /// </summary>
    public partial class Main : Window
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Button_stringOpen(object sender, RoutedEventArgs e)
        {
            String23 string23 = new String23();
            string23.Show();
            this.Close();
        }

        private void Button_createObject_click(object sender, RoutedEventArgs e)
        {
            CreateObject createObject = new CreateObject();
            createObject.Show();
            this.Close();
        }

        private void Button_test_click(object sender, RoutedEventArgs e)
        {
            Test test = new Test();
            test.Show();
            this.Close();
        }

        private void Button_graphic_click(object sender, RoutedEventArgs e)
        {
            Graphic graphic = new Graphic();
            graphic.Show();
            this.Close();
        }

        private void Button_report_click(object sender, RoutedEventArgs e)
        {
            Article report = new Article();
            report.Show();
            this.Close();
        }
    }
}
