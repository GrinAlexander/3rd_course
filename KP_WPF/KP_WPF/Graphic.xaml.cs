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
using System.Windows.Forms.DataVisualization;

namespace KP_WPF
{
    /// <summary>
    /// Логика взаимодействия для Graphic.xaml
    /// </summary>
    public partial class Graphic : Window
    {
        private List<double> xList = new List<double>();
        private List<double> yList = new List<double>();
        public Graphic()
        {
            InitializeComponent();
            chart.Series.Add("Main");
        }
        private void Button_back_Click(object sender, RoutedEventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Close();
        }

        private void Button_draw_Click(object sender, RoutedEventArgs e)
        {
            double y = 0;
            for (int i = 0; i < 1; i++)
            {
                for (double x = 0; x <= 10; x++)
                {
                    y = Math.Pow(Math.Pow(x, 2) * (x + 1), 1.0/3);
                    yList.Add(y);
                    xList.Add(x);
                }
            }
            for (int i = 0; i < xList.Count; i++)
            {
                chart.Series["Main"].Points.AddXY(xList[i], yList[i]);
            }
            
            /*Polyline polyline = new Polyline();
            polyline.Stroke = Brushes.Red;
            double y;
            for (double x = -100; x <=100 ; x++)
            {
                y = Math.Pow(Math.Pow(x,2) * (x + 1), 1.0 / 3.0);
                polyline.Points.Add(new Point(Math.Abs(x), Math.Abs(y)));
            }
            canvas_Main.Children.Add(polyline);*/
        }
        /*
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
        }*/

    }
}
