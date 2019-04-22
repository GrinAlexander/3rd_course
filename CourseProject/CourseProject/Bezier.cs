using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;

namespace CourseProject
{
    [Serializable]
    public class Bezier
    {
        Point point1;
        Point point2;
        Point point3;
        Path pathCurves = new Path();
        Path pathLines = new Path();

        public Bezier(Point point1, Point point2, Point point3)
        {
            this.point1 = point1;
            this.point2 = point2;
            this.point3 = point3;
        }
        public Bezier()
        {
            this.point1.X = 0;
            this.point1.Y = 0;
            this.point2.X = 0;
            this.point2.Y = 0;
            this.point3.X = 0;
            this.point3.Y = 0;
        }

        public Path DrawBezier()
        {
            pathCurves.Stroke = new SolidColorBrush(Colors.Red);
            pathCurves.StrokeThickness = 1.5;
            BezierSegment bezier = new BezierSegment(point1, point2, point3, true);
            PathFigure figure = new PathFigure();
            figure.StartPoint = point1;
            figure.Segments.Add(bezier);
            pathCurves.Data = new PathGeometry(new PathFigure[] { figure });
            return pathCurves;
        }

        public Path DrawLines()
        {
            pathLines.Stroke = new SolidColorBrush(Colors.Black);
            pathLines.StrokeThickness = 0.5;
            LineSegment line_1 = new LineSegment(point1, true);
            LineSegment line_2 = new LineSegment(point2, true);
            LineSegment line_3 = new LineSegment(point3, true);
            PathFigure figure = new PathFigure();
            figure.StartPoint = point1;
            figure.Segments.Add(line_1);
            figure.Segments.Add(line_2);
            figure.Segments.Add(line_3);
            pathLines.Data = new PathGeometry(new PathFigure[] { figure });
            return pathLines;
        }
    }
}
