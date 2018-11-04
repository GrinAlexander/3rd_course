using System;
using System.Collections.Generic;

namespace Test_2
{
	class Trapezium
	{
		private double area;
		private double height;
		private double midLine;
		private double perimeter;
		private double a;
		private double b;
		private double c;
		private double d;

		public double Height { get { return height; } set { height = value; } }
		public double Area { get { return area; } set { area = value; } }
		public double MidLine { get { return midLine; } set { midLine = value; } }
		public double Perimeter { get { return perimeter; } set { perimeter = value; } }

		public Trapezium(double a, double b, double c, double d, double height)
		{
			this.a = a; this.b = b; this.c = c; this.d = d; Height = height; Area = 0; MidLine = 0; Perimeter = 0;
		}

		private void CalcPerimeter()
		{
			Perimeter = a + b + c + d;
		}

		private void CalcArea()
		{
			Area = MidLine * Height;
		}

		private void CalcMidLine()
		{
			MidLine = (a + b) / 2;
		}

		public void Calculation()
		{
			CalcPerimeter();
			CalcMidLine();
			CalcArea();
		}

		public void GetInfo()
		{
			Console.WriteLine("\n\nДанные: \nПериметр: {0:0.##} \nПлощадь: {1:0.##} \nВысота: {2:0.##} \nСредняя линия: {3:0.##}", Perimeter, Area, Height, MidLine);
			Console.ReadKey();
		}
	}

	class NoteBook
	{
		private Dictionary<string, string> people = new Dictionary<string, string>();

		public void Search(string key)
		{
			if (people.ContainsKey(key))
			{
				Console.WriteLine(key + " - " + people[key]);
			}
			else
			{
				Console.WriteLine("Такого у нас нету!");
			}
		}

		public void AddNote(string name, string age)
		{
			people.Add(name, age);
			Console.WriteLine("Успешно добавлен!");
		}

		public void RemoveNote(string key)
		{
			if (people.ContainsKey(key))
			{
				people.Remove(key);
				Console.WriteLine("Успешно удалён!");
			}
			else
			{
				Console.WriteLine("Такого у нас и так нету!");
			}
		}

		public void ShowAll()
		{
			foreach (KeyValuePair<string, string> keyValue in people)
			{
				Console.WriteLine(keyValue.Key + " - " + keyValue.Value);
			}
		}
		public void ShowInstruction()
		{
			Console.WriteLine("\n0. Вывод инструкции \n1. Искать запись \n2. Добавить запись \n3. Удалить запись \n4. Вывести все записи \n5. Выйти \n");
		}
	}
	class MainClass
	{
		static void Main()
		{
			First();
			Second();
		}

		public static void First()
		{
			Console.Write("Введите длину сторон и высоты трапеции:\n");
			double a, b, c, d, height;
			try
			{
				Console.Write("Сторона a: "); a = Convert.ToDouble(Console.ReadLine());
				Console.Write("Сторона b: "); b = Convert.ToDouble(Console.ReadLine());
				Console.Write("Сторона c: "); c = Convert.ToDouble(Console.ReadLine());
				Console.Write("Сторона d: "); d = Convert.ToDouble(Console.ReadLine());
				Console.Write("Высота: "); height = Convert.ToDouble(Console.ReadLine());
				Trapezium trapezium = new Trapezium(a, b, c, d, height);
				trapezium.Calculation();
				trapezium.GetInfo();
			}
			catch (Exception)
			{

			}
		}

		public static void Second()
		{
			try
			{
				NoteBook note = new NoteBook();
				Console.WriteLine("Что вы хотите сделать?");
				note.ShowInstruction();
				int choice = Convert.ToInt32(Console.ReadLine());
				string key;
				string name, age;
				while (choice != 5)
				{
					if (choice == 0)
					{
						note.ShowInstruction();
					}
					else if (choice == 1)
					{
						Console.Write("Введите имя для поиска: "); key = Console.ReadLine();
						note.Search(key);
					}
					else if (choice == 2)
					{
						Console.Write("Имя: "); name = Console.ReadLine();
						Console.Write("Возраст: "); age = Console.ReadLine();
						note.AddNote(name, age);
					}
					else if (choice == 3)
					{
						Console.Write("Введите имя для удаления: "); key = Console.ReadLine();
						note.RemoveNote(key);
					}
					else if (choice == 4)
					{
						note.ShowAll();
					}
					choice = Convert.ToInt32(Console.ReadLine());
				}
			}
			catch (Exception)
			{
				Console.WriteLine("Возникло исключение! Попробуйте снова.");
			}

		}
	}
}
