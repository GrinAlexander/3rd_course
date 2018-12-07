using System;

namespace Test_2
{
    interface ICalculateable
    {
        double Perimeter();
        double Area();
        double Diagonal();
        double DescribedCircle();
        double InscribedCircle();
        void Information();
    }

    interface IInputOutput
    {
        void Input(double y, double x1, double x2);
        void Output();
    }
    interface ISum
    {
        void Sum();
    }

    interface IMul
    {
        void Mul();
    }

    class Square : ICalculateable
    {
        private double Side { get; set; }

        public Square(double side)
        {
            Side = side;
        }
        public Square()
        {
            Side = 5;
        }

        public double Perimeter()
        {
            return Side * 4;
        }
        public double Area()
        {
            return Side * Side;
        }
        public double Diagonal()
        {
            return Side * Math.Sqrt(2);
        }
        public double DescribedCircle()
        {
            return Side / Math.Sqrt(2);
        }
        public double InscribedCircle()
        {
            return Side / 2;
        }
        public void Information()
        {
            Console.WriteLine("Параметры заданного квадрата:");
            Console.WriteLine($"1. Периметр: {Perimeter()}\n2. Площадь: {Area()}\n3. Диагональ: {Diagonal()}\n4. Радиус описанной окружности: {DescribedCircle()}\n5. Радиус вписанной окружности: {InscribedCircle()}");
        }
    }

    class Rectangle : ICalculateable
    {
        private double Width { get; set; }
        private double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = Width;
        }
        public Rectangle()
        {
            Width = 5;
            Height = 10;
        }
        public double Area()
        {
            return Width * Height;
        }
        public double DescribedCircle()
        {
            return Math.Sqrt(Width * Width + Height * Height) / 2;
        }
        public double Diagonal()
        {
            return Math.Sqrt((Width * Width) + (Height * Height));
        }
        public double InscribedCircle()
        {
            if (Width > Height)
            {
                return Height / 2;
            }
            else
            {
                return Width / 2;
            }
        }
        public double Perimeter()
        {
            return Width * 2 + Height * 2;
        }
        public void Information()
        {
            Console.WriteLine("Параметры заданного квадрата:");
            Console.WriteLine($"1. Периметр: {Perimeter()}\n2. Площадь: {Area()}\n3. Диагональ: {Diagonal()}\n4. Радиус описанной окружности: {DescribedCircle()}\n5. Радиус вписанной окружности: {InscribedCircle()}");
        }
    }

    class X_Class
    {
        protected double X1 { get; set; }
        protected double X2 { get; set; }

        public X_Class(double x1, double x2)
        {
            X1 = x1;
            X2 = x2;
        }
        public X_Class()
        {
            X1 = 5;
            X2 = 10;
        }
        public void OutputX()
        {
            Console.WriteLine($"X1: {X1}\nX2: {X2}");
        }
    }
    class Y_Class : X_Class, IInputOutput, ISum, IMul
    {
        public double Y { get; set; }
        public double Result { get; set; }
        public Y_Class(double y, double x1, double x2) : base(x1, x2)
        {
            Result = 1;
            Input(y, x1, x2);
        }
        public Y_Class()
        {
            Result = 1;
            Y = 8;
            X1 = 5;
            X2 = 10;
        }
        public void Input(double y, double x1, double x2)
        {
            X1 = x1;
            X2 = x2;
            Y = y;
        }
        public void Output()
        {
            OutputX();
            Console.WriteLine($"Y: {Y}");
            Console.WriteLine($"Ответ: {Calculating()}");
        }
        public void Mul()
        {
            Result = X1 * X2;
        }
        public void Sum()
        {
            Result += Y;
        }
        public double Calculating()
        {
            Mul();
            Sum();
            return Result;
        }
    }

    class MainClass
    {
        public static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("----------------");
                Console.WriteLine("Длина стороны квадрата: ");
                double a = double.Parse(Console.ReadLine());
                while (a < 0)
                {
                    Console.WriteLine("Длина стороны квадрата: ");
                    a = double.Parse(Console.ReadLine());
                }

                double b;

                Square sq = new Square(a);
                sq.Information();
                Console.WriteLine("----------------");
                Console.WriteLine("Длина сторон прямоугольника: ");
                a = double.Parse(Console.ReadLine());
                b = double.Parse(Console.ReadLine());
                while ((a < 0) || (b < 0))
                {
                    Console.WriteLine("Длина сторон прямоугольника: ");
                    a = double.Parse(Console.ReadLine());
                    b = double.Parse(Console.ReadLine());
                }
                Rectangle rect = new Rectangle(a, b);
                rect.Information();
                Console.WriteLine("----------------");
                double x1, x2;
                Console.Write("Введите X1:");
                x1 = double.Parse(Console.ReadLine());
                Console.Write("Введите X2:");
                x2 = double.Parse(Console.ReadLine());
                Console.Write("Введите Y:");
                double y = double.Parse(Console.ReadLine());
                X_Class x = new X_Class(x1, x2);
                Y_Class _y = new Y_Class(y, x1, x2);
                _y.Output();
                Console.ReadKey();
            }
            catch (Exception)
            {
                Console.WriteLine($"Произошла ошибка");
                Square sq = new Square();
                sq.Information();
                Rectangle rect = new Rectangle();
                rect.Information();
                Y_Class y = new Y_Class();
                y.Output();
                Console.ReadKey();
            }
        }

    }
}