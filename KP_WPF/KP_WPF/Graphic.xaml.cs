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
    /// Логика взаимодействия для Graphic.xaml
    /// </summary>
    public partial class Graphic : Window
    {
        public Graphic()
        {
            InitializeComponent();
        }
        private void Button_back_Click(object sender, RoutedEventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Close();
        }

        private void Button_draw_Click(object sender, RoutedEventArgs e)
        {
            Line line = new Line();
            Polyline polyline = new Polyline();
            polyline.Stroke = Brushes.Red;
            double y;
            for (double x = 0; x > 0; x -= 0.1)
            {
                y = Math.Pow(Math.Pow(x,2) * (x + 1), (double) 1 / 3);
                polyline.Points.Add(new Point(x, y));

            }
            canvas_Main.Children.Add(polyline);
        }

        private void DrawAxises()
        {
            line_Ox.X1 = 0;
            line_Ox.X2 = canvas_Main.ActualWidth;
            line_Ox.Y1 = canvas_Main.ActualHeight / 2;
            line_Ox.Y2 = line_Ox.Y1;

            line_Oy.X1 = canvas_Main.ActualWidth / 2;
            line_Oy.X2 = line_Oy.X1;
            line_Oy.Y1 = 0;
            line_Oy.Y2 = canvas_Main.ActualHeight;
        }

        private void Canvas_Main_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            DrawAxises();
        }
    }
}
