using System;
using System.Text.RegularExpressions;

namespace Test_2
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			First();
			Second();
		}

		//проверка url
		public static void First()
		{
			Console.WriteLine("-------------------------");
			string url = Console.ReadLine();
			string pattern = @"^(http|https|ftp|)\://|[a-zA-Z0-9\-\.]+\.[a-zA-Z](:[a-zA-Z0-9]*)?/?([a-zA-Z0-9\-\._\?\,\'/\\\+&amp;%\$#\=~])*[^\.\,\)\(\s]$";
			Regex reg = new Regex(pattern, RegexOptions.Compiled | RegexOptions.IgnoreCase);
			Console.WriteLine(reg.IsMatch(url));
			Console.ReadKey();
		}

		//вывод ФИО формата Фамилия И.О.
		public static void Second()
		{
			Console.WriteLine("-------------------------");
			string[] arr_fio = { "Иванов П.П.", "Петров", "Иванов Иван", "Гринь А.М." };
			string pattern = @"^[А-Я][а-я]+\s[А-Я]\.+[А-Я]\.$";
			Regex reg = new Regex(pattern, RegexOptions.Compiled | RegexOptions.IgnoreCase);
			for (int i = 0; i < arr_fio.Length; i++)
			{
				if (reg.IsMatch(arr_fio[i]))
				{
					Console.WriteLine(arr_fio[i]);
				}
			}
			Console.ReadKey();
		}
	}
}