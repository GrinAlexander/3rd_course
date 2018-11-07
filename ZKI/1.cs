using System;

//Гринь А.М., Т-716, Вариант 9
namespace ZKI
{
	class Program
	{
		static void Main(string[] args)
		{
			//метод шифрующих таблиц
			First();

			//Магический квадрат
			Second();
		}

		public static void First()
		{
			string strDecrypted = "разума лишает не сомнение, а уверенность";
			strDecrypted = strDecrypted.Replace(' ', '_');
			Console.WriteLine($"Строка для зашифровки: {strDecrypted}");
			string strEncrypted = string.Empty;
			string key = "мысленно";
			char[,] matrixOfChar = new char[6, 8];

			int index = 0;
			for (int j = 0; j < 8; j++)
			{
				matrixOfChar[0, j] = key[j];
			}
			for (int j = 0; j < 8; j++)
			{
				for (int i = 1; i < 6; i++)
				{
					matrixOfChar[i, j] = strDecrypted[index];
					index++;
				}
			}

			Console.Write($"Зашифрованная строка: ");
			char indexCh = 'а';
			while (indexCh <= 'я')
			{
				for (int j = 0; j < 8; j++)
				{
					for (int i = 1; i < 6; i++)
					{
						if (indexCh == matrixOfChar[0, j])
						{
							Console.Write(matrixOfChar[i, j]);
						}
					}
				}
				indexCh++;
			}

			Console.WriteLine();
			Console.ReadLine();
		}

		public static void Second()
		{
			const int n = 4;
			int[,] matrixOfNums = new int[n, n] {
				{ 7, 12, 1, 14 },
				{ 2, 13, 8, 11 },
				{ 16, 3, 10, 5 },
				{ 9, 6, 15, 4 } };
			char[,] matrixOfChar = new char[n, n];
			string strEncrypted = "ЮЯВОЫТ_СОЛЕТДАГЕ";

			Console.WriteLine($"Зашифрованная строка: {strEncrypted}");

			int index = 0;
			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < n; j++)
				{
					matrixOfChar[i, j] = strEncrypted[index];
					index++;
				}
			}

			Console.Write($"Расшифрованная строка: ");
			index = 1;
			while (index < 17)
			{
				for (int i = 0; i < n; i++)
				{
					for (int j = 0; j < n; j++)
					{
						if (matrixOfNums[i, j] == index)
						{
							Console.Write(matrixOfChar[i, j]);
						}
					}
				}
				index++;
			}
			Console.WriteLine();
			Console.ReadLine();
		}
	}
}
