using System;

namespace Test
{
	class MainClass
	{

		public static void Main (string[] args)
		{
			OutputOptions (); //1st
			TriangleArea (); //2nd
			CircleLength (); //3rd
			SumOfAngles (); //4th
			TrigonomQuantities (); //5th
			Amount(); //6th
			Area7th (); //7th
			QadraticEquat(); //8th
			TriangleExistNoIF(); //9th
			Parity();  //10th
			HelloAndBye(); //11th
			Example1(); //12th
			Example2(); //13th
			Example3 (); //14th
			Example4 (); //15th 9var
			Example5 (); //16th 9var
			Console.ReadKey();
		}

		public static void OutputOptions()
		{
			Console.WriteLine ("1st exercise");
			char endl = '\n';
			Console.WriteLine("Гринь\nАлександр\n");
			Console.WriteLine(@"Гринь
Александр
");		
			Console.WriteLine("Гринь");
			Console.WriteLine ("Александр\n");
			Console.WriteLine ("Гринь{0}Александр{0}\n", endl);
			Console.ReadKey ();
		}

		public static void TriangleArea()
		{
			Console.WriteLine ("2nd exercise");
			Console.WriteLine ("Площадь треугольника с катетами 5 и 7 равна " + (5*7*0.5) + "\n");
			Console.ReadKey ();
		}

		public static void CircleLength()
		{
			Console.WriteLine ("3rd exercise");
			int r = Convert.ToInt32 (Console.ReadLine ());
			Console.WriteLine("Длина окружности с заданным радиусом равна {0}\n", (r * Math.PI * 2) );
			Console.ReadKey ();
		}

		public static void SumOfAngles()
		{
			Console.WriteLine ("4th exercise");
			Console.Write("Количество углов: ");
			int n = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Sum of angles is = {0}\n", (180 *(n-2)) );
			Console.ReadKey ();
		}
			
		public static void TrigonomQuantities()
		{
			Console.WriteLine ("5th exercise");
			double a = Convert.ToDouble (Console.ReadLine ());
			double b = Convert.ToDouble(Console.ReadLine ());
			double c = Convert.ToDouble (Console.ReadLine ());
			Console.WriteLine ("Sinus is {0}", (a/c));
			Console.WriteLine ("Cosine is {0}", (b/c));
			Console.WriteLine ("Tanget is {0}", (a/b));
			Console.WriteLine ("Cotangent is {0} \n", (b/a));
			Console.ReadKey ();
		}
			
		public static void Amount()
		{
			Console.WriteLine ("6th exercise");
			Console.WriteLine ("Введите длины сторон параллелепипеда:");
			int a = Convert.ToInt32 (Console.ReadLine ());
			int b = Convert.ToInt32 (Console.ReadLine ());
			int c = Convert.ToInt32 (Console.ReadLine ());
			Console.WriteLine ("Объём половины заданного параллелепипеда " + ((a*b*c) - (a*b*(c/2)))+ "\n");
			Console.ReadKey ();
		}

		public static void Area7th()
		{
			Console.WriteLine ("7th exercise");
			int x = Convert.ToInt32 (Console.ReadLine ());
			int y = Convert.ToInt32 (Console.ReadLine ());
			Console.WriteLine ("Радиусы: ");

			int r1 = Convert.ToInt32 (Console.ReadLine ());
			int r2 = Convert.ToInt32 (Console.ReadLine ());
			while ((r1 >= Math.Min (x, y)) || (r2 >= Math.Min (x, y)))
			{
				Console.WriteLine ("Введите корректные значение!");
				r1 = Convert.ToInt32 (Console.ReadLine ());
				r2 = Convert.ToInt32 (Console.ReadLine ());
			}
			double result = (x * y) - (Math.PI * Math.Pow (r1, 2)) - (Math.PI * Math.Pow (r2, 2));
			Console.WriteLine ("Ответ 7го задания при заданных значениях: " + result);
			Console.ReadKey ();
		}

		public static void QadraticEquat()
		{
			Console.WriteLine ("\n8th exercise");
			Console.WriteLine ("Введите значения:");
			double a = Convert.ToInt32 (Console.ReadLine ());
			double b = Convert.ToInt32 (Console.ReadLine ());
			double c = Convert.ToInt32 (Console.ReadLine ());
			double d = Math.Pow (b, 2) - 4 * a * c;
			if (d > 0)
			{
				double x1 = (-b + Math.Sqrt (d)) /( 2 * a);
				double x2 = (-b - Math.Sqrt (d)) /( 2 * a);
				Console.WriteLine ("1й корень уравнения:" + x1);
				Console.WriteLine ("2й корень уравнения:" + x2);
			}
			else if (d == 0)
			{
				double x = (-b) /( 2 * a);
				Console.WriteLine ("Корень уравнения:"+ x);
			}
			else
			{
				Console.WriteLine ("Отрицательный дискриминант!");
			}
			Console.ReadKey ();
		}

		public static void TriangleExistNoIF()
		{
			Console.WriteLine ("\n9th exercise");
			Console.WriteLine ("Введите значения сторон треугольника:");
			int a = Convert.ToInt32 (Console.ReadLine ());
			int b = Convert.ToInt32 (Console.ReadLine ());
			int c = Convert.ToInt32 (Console.ReadLine ());
			int p = (a + b + c) / 2;
			double area = Math.Sqrt(p * (p -a) * (p -b ) * (p -c));
			bool isExist = ((a + b > c) && (a + c > b) && (b + c > a)) ? true : false;
			switch (isExist) {
			case true:
				{
					Console.WriteLine ("Площадь такого треугольника " + area);
					break;
				}
			case false: 
				{
					Console.WriteLine ("Такой треугольник не существует!");
					break;
				}
			}
			Console.ReadKey ();
		}

		public static void Parity()
		{
			Console.WriteLine ("\n10th exercise");
			int a = Convert.ToInt32 (Console.ReadLine ());
			bool isParity = (a % 2 == 0) ? true : false;
			switch (isParity) {
			case true:
				{
					Console.WriteLine ("Число чётное");
					break;
				}
			case false: 
				{
					Console.WriteLine ("Число нечётное");
					break;
				}
			}
			Console.ReadKey ();
		}

		public static void HelloAndBye()
		{
			Console.WriteLine ("\n11th exercise");
			Console.WriteLine ("Имя пользователя " + Environment.MachineName);
			Console.WriteLine ("Введите своё имя!");
			string name = Console.ReadLine ();
			if (Environment.MachineName == name)
				Console.WriteLine ("HELLO!");
			else
				Console.WriteLine ("Bye");
			Console.ReadKey ();
		}

		public static void Example1()
		{
			Console.WriteLine ("\n12th exercise");
			double t = Convert.ToDouble (Console.ReadLine ());
			double result = (2 * (Math.Sqrt(1 + 0.25 * Math.Pow((Math.Sqrt(1/t) - Math.Sqrt(t)), 2)))) / (Math.Sqrt(1 + 0.25 * Math.Pow(Math.Sqrt(1/t) - Math.Sqrt(t), 2) - (0.5 *(Math.Sqrt(1/t) - Math.Sqrt(t)))));
			Console.WriteLine ("Ответ: " + result);
			Console.ReadKey ();
		}

		public static void Example2()
		{
			Console.WriteLine ("\n13th exercise");
			double a = Convert.ToDouble (Console.ReadLine ());
			while (a == 1)
			{
				Console.WriteLine ("Знаменатель равен нулю!");
				a = Convert.ToDouble (Console.ReadLine ());
			}
			double first = 1 / (Math.Sqrt (a) + Math.Sqrt (a + 1));
			double second = 1 / (Math.Sqrt (a) - Math.Sqrt (a - 1));
			double third = 1 + (Math.Sqrt ((a + 1) / (a - 1)));
			Console.WriteLine ("Ответ: " + ((first + second) / third) );
			Console.ReadKey ();
		}

		public static void Example3()
		{
			Console.WriteLine ("\n14th exercise");
			double x = Convert.ToDouble (Console.ReadLine ());
			double result = (2 * (Math.Pow (x, 4) + (4 * Math.Pow (x, 2) - 12)) + Math.Pow (x, 4) + (11 * Math.Pow (x, 2)) + 30) / (Math.Pow (x, 2) + 6);
			Console.WriteLine ("Ответ: " + result);
			Console.ReadKey ();
		}

		public static void Example4()
		{
			Console.WriteLine ("\n15th exercise and 9th variant");
			double x = Convert.ToDouble (Console.ReadLine ());
			double y = Convert.ToDouble (Console.ReadLine ());
			double result_1 = Math.Pow (Math.Cos (x), 4) + Math.Pow (Math.Sin (y), 2) + (0.25 * Math.Pow (Math.Sin (2 * x), 2)) - 1;
			double result_2 = Math.Sin (x + y) * Math.Sin (y - x);
			Console.WriteLine ("Ответы:\n{0}\n{1}",result_1,result_2);
			Console.ReadKey ();
		}

		public static void Example5()
		{
			Console.WriteLine ("\n16th exercise and 9th variant");
			double x = 182.5;
			double y = 18.225;
			double z = (-3.298) * 0.01;
			double fi = 1.2131;
			double result_fi1 = Math.Abs (Math.Pow (x, 0.5) - Math.Pow ((y / x), (1/3)));
			double result_fi2 = (y - x) * ((Math.Cos (y) - ((z) / (y - x))) / (1 + Math.Pow ((y - x), 2)));
			Console.WriteLine("Fi по умолчанию равно " + fi);
			Console.WriteLine("Fi после расчётов " + (result_fi1 + result_fi2));
		}
	}
}