using System;

namespace Test_2
{
	class MainClass
	{

		public static void Main(string[] args)
		{
			//1st
			Console.WriteLine("1st exercise");
			OutputOptions('\n');
			Console.ReadKey();

			//2nd
			Console.WriteLine("2nd exercise");
			Console.WriteLine("Площадь треугольника с катетами 5 и 7 равна " + TriangleArea(5, 7, 0.5) + "\n");
			Console.ReadKey();

			//3rd
			Console.WriteLine("3rd exercise");
			double r = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Длина окружности с заданным радиусом равна {0}\n", CircleLength(r));
			Console.ReadKey();

			//4th
			Console.WriteLine("4th exercise");
			Console.Write("Количество углов: ");
			int n = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Sum of angles is = {0}\n", SumOfAngles(n));
			Console.ReadKey();

			//5th
			Console.WriteLine("5th exercise");
			double a = Convert.ToDouble(Console.ReadLine());
			double b = Convert.ToDouble(Console.ReadLine());
			double c = Convert.ToDouble(Console.ReadLine());
			TrigonomQuantities(a, b, c, out double sin, out double cos, out double tan, out double cot);
			Console.WriteLine("Sinus is {0}", (a / c));
			Console.WriteLine("Cosine is {0}", (b / c));
			Console.WriteLine("Tanget is {0}", (a / b));
			Console.WriteLine("Cotangent is {0} \n", (b / a));
			Console.ReadKey();

			//6th
			Console.WriteLine("6th exercise");
			Console.WriteLine("Введите длины сторон параллелепипеда:");
			a = Convert.ToDouble(Console.ReadLine());
			b = Convert.ToDouble(Console.ReadLine());
			c = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Объём половины заданного параллелепипеда " + Amount(a, b, c) + "\n");
			Console.ReadKey();

			//7th
			Console.WriteLine("7th exercise");
			int x = Convert.ToInt32(Console.ReadLine());
			int y = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Радиусы: ");
			int r1 = Convert.ToInt32(Console.ReadLine());
			int r2 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Ответ 7го задания при заданных значениях: " + Area7th(x, y, r1, r2));
			Console.ReadKey();

			//8th
			Console.WriteLine("\n8th exercise");
			Console.WriteLine("Введите значения:");
			a = Convert.ToDouble(Console.ReadLine());
			b = Convert.ToDouble(Console.ReadLine());
			c = Convert.ToDouble(Console.ReadLine());
			QadraticEquat(a, b, c);
			Console.ReadKey();

			//9th
			Console.WriteLine("\n9th exercise");
			Console.WriteLine("Введите значения сторон треугольника:");
			a = Convert.ToDouble(Console.ReadLine());
			b = Convert.ToDouble(Console.ReadLine());
			c = Convert.ToDouble(Console.ReadLine());
			Console.Write("Площадь такого треугольника " + TriangleExistNoIF(a, b, c) + "\n");
			Console.ReadKey();

			//10th
			Console.WriteLine("\n10th exercise");
			Console.WriteLine("Введите число для проверки чётности:");
			a = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Число чётное: " + Parity(a));
			Console.ReadKey();

			//11th
			Console.WriteLine("\n11th exercise");
			Console.WriteLine("Имя пользователя " + Environment.MachineName);
			Console.WriteLine("Введите своё имя!");
			string name = Console.ReadLine();
			Console.WriteLine(HelloAndBye(name));
			Console.ReadKey();

			//12th
			Console.WriteLine("\n12th exercise");
			double t = Convert.ToDouble(Console.ReadLine());
			Console.Write("Ответ: " + Example1(t) + "\n");
			Console.ReadKey();

			//13th
			Console.WriteLine("\n13th exercise");
			a = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Ответ: " + Example2(a));
			Console.ReadKey();

			//14th
			Console.WriteLine("\n14th exercise");
			a = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Ответ: " + Example3(a));
			Console.ReadKey();

			//15th 9var
			Console.WriteLine("\n15th exercise and 9th variant");
			a = Convert.ToDouble(Console.ReadLine());
			b = Convert.ToDouble(Console.ReadLine());
			Example4(a, b);
			Console.ReadKey();

			//16th 9var
			Console.WriteLine("\n16th exercise and 9th variant");
			const double fi = 1.2131;
			Example5(fi, out double res1, out double res2);
			Console.WriteLine("Fi по умолчанию равно " + fi);
			Console.WriteLine("Fi после расчётов " + (res1 + res2));
			Console.ReadKey();
		}

		public static void OutputOptions(char endl)
		{

			Console.WriteLine("Гринь\nАлександр\n");
			Console.WriteLine(@"Гринь
Александр
");
			Console.WriteLine("Гринь");
			Console.WriteLine("Александр\n");
			Console.WriteLine("Гринь{0}Александр{0}", endl);
		}

		public static double TriangleArea(double a, double b, double c)
		{
			return (a * b * c);
		}

		public static double CircleLength(double r)
		{
			return (r * Math.PI * 2);
		}

		public static int SumOfAngles(int n)
		{
			return (180 * (n - 2));
		}

		public static void TrigonomQuantities(double a, double b, double c, out double sin, out double cos, out double tan, out double cot)
		{	
			sin = a / c; cos = b / c; tan = a / b; cot = b / a;
		}

		public static double Amount(double a, double b, double c)
		{
			return (a * b * c) - (a * b * (c / 2));
		}

		public static double Area7th(int x, int y, int r1, int r2)
		{	
			while ((r1 >= Math.Min(x, y)) || (r2 >= Math.Min(x, y)))
			{
				Console.WriteLine("Введите корректные значение!");
				r1 = Convert.ToInt32(Console.ReadLine());
				r2 = Convert.ToInt32(Console.ReadLine());
			}
			double result = (x * y) - (Math.PI * Math.Pow(r1, 2)) - (Math.PI * Math.Pow(r2, 2));
			return result;
		}

		public static void QadraticEquat(double a, double b, double c)
		{	
			double d = Math.Pow(b, 2) - 4 * a * c;
			if (d > 0)
			{
				double x1 = (-b + Math.Sqrt(d)) / (2 * a);
				double x2 = (-b - Math.Sqrt(d)) / (2 * a);
				Console.WriteLine("1й корень уравнения:" + x1);
				Console.WriteLine("2й корень уравнения:" + x2);
			}
			else if (d == 0)
			{
				double x = (-b) / (2 * a);
				Console.WriteLine("Корень уравнения:" + x);
			}
			else
			{
				Console.WriteLine("Отрицательный дискриминант!");
			}
		}

		public static double TriangleExistNoIF(double a, double b, double c)
		{
			double p = (a + b + c) / 2;
			double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
			bool isExist = ((a + b > c) && (a + c > b) && (b + c > a)) ? true : false;
			if (isExist)
			{
				return area;
			}
			return 0;
		}

		public static bool Parity(double a)
		{

			bool isParity = (a % 2 == 0) ? true : false;
			return isParity;
		}

		public static string HelloAndBye(string name)
		{
			if (Environment.MachineName == name)
				return "HELLO!";
			else
				return "Bye";
		}

		public static double Example1(double t)
		{
			double result = (2 * (Math.Sqrt(1 + 0.25 * Math.Pow((Math.Sqrt(1 / t) - Math.Sqrt(t)), 2)))) / (Math.Sqrt(1 + 0.25 * Math.Pow(Math.Sqrt(1 / t) - Math.Sqrt(t), 2) - (0.5 * (Math.Sqrt(1 / t) - Math.Sqrt(t)))));
			
			return result;
		}

		public static double Example2(double a)
		{
			while (a == 1)
			{
				Console.WriteLine("Знаменатель равен нулю!");
				a = Convert.ToDouble(Console.ReadLine());
			}
			double first = 1 / (Math.Sqrt(a) + Math.Sqrt(a + 1));
			double second = 1 / (Math.Sqrt(a) - Math.Sqrt(a - 1));
			double third = 1 + (Math.Sqrt((a + 1) / (a - 1)));
			return (first + second) / third;
		}

		public static double Example3(double x)
		{
			double result = (2 * (Math.Pow(x, 4) + (4 * Math.Pow(x, 2) - 12)) + Math.Pow(x, 4) + (11 * Math.Pow(x, 2)) + 30) / (Math.Pow(x, 2) + 6);
			return result;
		}

		public static void Example4(double x, double y)
		{
			double result_1 = Math.Pow(Math.Cos(x), 4) + Math.Pow(Math.Sin(y), 2) + (0.25 * Math.Pow(Math.Sin(2 * x), 2)) - 1;
			double result_2 = Math.Sin(x + y) * Math.Sin(y - x);
			Console.WriteLine("Ответы:\n{0}\n{1}", result_1, result_2);

		}

		public static void Example5(double Fi, out double result_fi1, out double result_fi2)
		{
			double x = 182.5;
			double y = 18.225;
			double z = (-3.298) * 0.01;
			double fi = Fi;
			result_fi1 = Math.Abs(Math.Pow(x, 0.5) - Math.Pow((y / x), (1 / 3)));
			result_fi2 = (y - x) * ((Math.Cos(y) - ((z) / (y - x))) / (1 + Math.Pow((y - x), 2)));
		}
	}
}
