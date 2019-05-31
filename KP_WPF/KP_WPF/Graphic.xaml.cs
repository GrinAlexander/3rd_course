using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows;
using System.Windows.Media;

namespace KP_WPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class Graphic : Window
    {
        const int countDot = 10;
        List<double[]> dataList = new List<double[]>();
        DrawingGroup drawingGroup = new DrawingGroup();
        public Graphic()
        {
            InitializeComponent();
            DataFill();
            Execute();
            image1.Source = new DrawingImage(drawingGroup);
        }
        void DataFill()
        {
            List<double> func = new List<double>();
            for (double i = -3; i < 3; i += 0.6)
            {
                func.Add(Math.Sign(Math.Pow(i, 2) * (i + 1)) * Math.Pow(Math.Abs(Math.Pow(i, 2) * (i + 1)), 1 / 3.0));
            }
            dataList.Add(func.ToArray());
        }
        void Execute()
        {
            BackgroundFun();
            GridFun();
            Fun();
            MarkerFun();
        }

        private void BackgroundFun()
        {
            GeometryDrawing geometryDrawing = new GeometryDrawing();
            RectangleGeometry rectGeometry = new RectangleGeometry();
            rectGeometry.Rect = new Rect(0, 0, 1, 1.6);
            geometryDrawing.Geometry = rectGeometry;
            geometryDrawing.Pen = new Pen(Brushes.Red, 0.005);
            geometryDrawing.Brush = Brushes.Beige;
            drawingGroup.Children.Add(geometryDrawing);
        }
        private void GridFun()
        {
            GeometryGroup geometryGroup = new GeometryGroup();
            for (int i = 0; i < 17; i++)
            {
                LineGeometry line = new LineGeometry(new Point(1.0, i * 0.1),
                new Point(-0.1, i * 0.1));
                geometryGroup.Children.Add(line);
            }
            GeometryDrawing geometryDrawing = new GeometryDrawing();
            geometryDrawing.Geometry = geometryGroup;
            geometryDrawing.Pen = new Pen(Brushes.Gray, 0.003);
            double[] dashes = { 1, 1, 1, 1, 1 };
            geometryDrawing.Pen.DashStyle = new DashStyle(dashes, -.1);
            geometryDrawing.Brush = Brushes.Beige;
            drawingGroup.Children.Add(geometryDrawing);
        }
        private void Fun()
        {

            GeometryGroup geometryGroup = new GeometryGroup();
            for (int i = 0; i < dataList[0].Length - 1; i++)
            {
                LineGeometry line = new LineGeometry(
                new Point((double)i / (double)countDot,
                .8 - (dataList[0][i] / 4.0)),
                new Point((double)(i + 1) / (double)countDot,
                .8 - (dataList[0][i + 1] / 4.0)));
                geometryGroup.Children.Add(line);
            }
            GeometryDrawing geometryDrawing = new GeometryDrawing();
            geometryDrawing.Geometry = geometryGroup;
            geometryDrawing.Pen = new Pen(Brushes.Blue, 0.005);
            drawingGroup.Children.Add(geometryDrawing);
        }
        private void MarkerFun()
        {
            GeometryGroup geometryGroup = new GeometryGroup();

            for (int i = 0; i <= 10; i++)
            {
                FormattedText formattedText = new FormattedText((((10 - i) * 0.1).ToString()), CultureInfo.InvariantCulture, FlowDirection.LeftToRight, new Typeface("Verdana"), 0.05, Brushes.Black);
                formattedText.SetFontWeight(FontWeights.Bold);
                Geometry geometry = formattedText.BuildGeometry(new Point(-0.15, i * 0.15));
                geometryGroup.Children.Add(geometry);
            }
            GeometryDrawing geometryDrawing = new GeometryDrawing();
            geometryDrawing.Geometry = geometryGroup;
            geometryDrawing.Brush = Brushes.LightGray;
            geometryDrawing.Pen = new Pen(Brushes.Gray, 0.003);
            drawingGroup.Children.Add(geometryDrawing);
        }
    }
}
