using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Test_2
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			First(); //+
			Second(); //+
			Third(); //+
			Fourth(); //+
			Fifth(); //+
			Sixth(); //+
			Seventh(); //+
			Eighth(); //+
			Nineth(); //+
			Tenth(); //+
		}

		public static void First()
		{
			Console.WriteLine("------------------------");
			Console.WriteLine("1st exercise");

			try
			{
				Console.WriteLine("Информация о файловой системе:");
				foreach (DriveInfo di in DriveInfo.GetDrives())
				{
					if (di.IsReady)
						Console.WriteLine($"Диск: {di.Name}; Метка тома: {di.VolumeLabel}; Файловая система: {di.DriveFormat}; Тип: {di.DriveType}; Объем: {di.TotalSize} байт; Свободно: {di.AvailableFreeSpace} байт");
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine($"Что-то пошло не так: {ex.Message}");
			}
			Console.ReadKey();
		}

		public static void Second()
		{
			Console.WriteLine("------------------------");
			Console.WriteLine("2nd exercise");
			try
			{
				string str = new StreamReader("D:\\song.txt", Encoding.Default).ReadToEnd();
				Console.WriteLine(str);
			}
			catch (Exception ex)
			{

				Console.WriteLine($"Что-то пошло не так: {ex.Message}");
			}
			Console.ReadKey();
		}

		public static void Third()
		{
			Console.WriteLine("------------------------");
			Console.WriteLine("3rd exercise");
			try
			{
				using (StreamWriter streamWriter = new StreamWriter(@"D:\3.txt"))
				{
					for (int i = -856; i < 1096; i++)
					{
						if ((i % 3 == 0) && (i % 5 == 0))
						{
							streamWriter.Write($"{i} ");
						}
					}
				}
				Console.WriteLine("Запись прошла успешно");
			}
			catch (Exception ex)
			{

				Console.WriteLine($"Что-то пошло не так: {ex.Message}");
			}
			Console.ReadKey();
		}

		public static void Fourth()
		{
			Console.WriteLine("------------------------");
			Console.WriteLine("4th exercise");
			try
			{
				StreamReader file = new StreamReader("D:\\song.txt", Encoding.Default);
				string str = file.ReadToEnd();
				str = str.ToLower();
				double freq = 0;
				double quantityOfSingleLetters = 0;
				double quantityOfLetters = 0;
				for (char c = 'а'; c <= 'я'; c++)
				{
					for (int i = 0; i < str.Length; i++)
					{
						if (str[i] == c)
						{
							freq++;
							quantityOfLetters++;
						}
					}

					if (freq == 1)
					{
						Console.WriteLine($"Буква '{c}' - встречается 1 раз.");
						quantityOfSingleLetters++;
					}
					freq = 0;
				}
				Console.WriteLine($"Всего одиночных букв: {quantityOfSingleLetters}, что равно {quantityOfSingleLetters * 100 / quantityOfLetters}% от общего числа букв");
			}
			catch (Exception ex)
			{

				Console.WriteLine($"Что-то пошло не так: {ex.Message}");
			}
			Console.ReadKey();
		}

		public static void Fifth()
		{
			Console.WriteLine("------------------------");
			Console.WriteLine("5th exercise");

			try
			{
				string str = new StreamReader("D:\\3.txt", Encoding.Default).ReadToEnd();
				int num = 0;
				string str_num = null;
				str = str.Replace("-", null);
				int temp_sum = 0;

				for (int i = 0; i < str.Length; i++)
				{
					if (str[i] >= '0' && str[i] <= '9')
					{
						str_num += str[i];
					}
					else
					{
						num = Convert.ToInt32(str_num);
						while (num != 0)
						{
							temp_sum += num % 10;
							num /= 10;
						}
						if (temp_sum % 5 == 0)
						{
							Console.Write($"{str_num} ");
						}
						temp_sum = 0;
						str_num = null;
					}
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine($"Что-то пошло не так: {ex.Message}");
			}
			Console.ReadKey();
		}

		public static void Sixth()
		{
			Console.WriteLine("------------------------");
			Console.WriteLine("6th exercise");
			try
			{
				string bdate = null;
				string fio = null;
				using (StreamReader sr = new StreamReader(@"D:\6.txt", Encoding.Default))
				{
					string line = sr.ReadLine();
					while (line != null)
					{
						line = line.ToLower();
						if ((line[0] >= 'а') && (line[0] <= 'я'))
						{
							fio = line;
						}
						else if ((line[line.Length - 1] >= '0') && (line[line.Length - 1] <= '9'))
						{
							bdate = line;
						}
						line = sr.ReadLine();
					}
				}
				Console.WriteLine(fio);
				Console.WriteLine((int)((DateTime.Now - DateTime.Parse(bdate)).TotalDays) / 365);
			}
			catch (Exception ex)
			{
				Console.WriteLine($"Что-то пошло не так: {ex.Message}");
			}
			Console.ReadKey();
		}

		public static void Seventh()
		{
			Console.WriteLine("------------------------");
			Console.WriteLine("7th exercise");

			try
			{
				int[] sides = new int[3];
				string str_num = null;
				int j = 0;
				StreamReader sr = new StreamReader(@"D:\7_1.txt", Encoding.Default);
				StreamWriter sw = new StreamWriter(@"D:\7_2.txt");
				string line = sr.ReadLine();
				while (line != null)
				{
					for (int i = 0; i < line.Length; i++)
					{
						if (line[i] >= '0' && line[i] <= '9')
						{
							str_num += line[i];
							if (i == line.Length - 1)
							{
								sides[j] = Convert.ToInt32(str_num);
							}
						}
						else
						{
							sides[j] = Convert.ToInt32(str_num);
							j++;
							str_num = null;
						}
					}
					if ((sides[0] + sides[1] > sides[2]) && (sides[0] + sides[2] > sides[1]) && (sides[1] + sides[2] > sides[0]))
					{
						sw.WriteLine("Треугольник с этими сторонами существует:");
						foreach (int item in sides)
						{
							sw.WriteLine(item);
						}
					}
					line = sr.ReadLine();
					j = 0;
				}
				sw.Close();
			}
			catch (Exception ex)
			{
				Console.WriteLine($"Что-то пошло не так: {ex.Message}");
			}
			Console.ReadKey();
		}

		public static void Eighth()
		{
			Console.WriteLine("------------------------");
			Console.WriteLine("8th exercise");
			try
			{
				List<string> cabs = new List<string>();
				StreamReader sr = new StreamReader(@"D:\8.txt", Encoding.Default);
				string line = sr.ReadLine();
				string cab = null;

				while (line != null)
				{
					line = line.ToLower();
					for (int i = 0; i < line.Length; i++)
					{
						if (line[i] >= '0' && line[i] <= '9')
						{
							cab += line[i];
						}
					}
					cabs.Add(cab);
					line = sr.ReadLine();
					cab = null;
				}

				Dictionary<string, int> freq = new Dictionary<string, int>();
				foreach (string val in cabs.Distinct())
				{
					freq.Add(val, cabs.Where(x => x == val).Count());
				}

				freq = freq.OrderByDescending(pair => pair.Value).ToDictionary(pair => pair.Key, pair => pair.Value);
				foreach (var item in freq)
				{
					Console.WriteLine(item.Key + " - " + item.Value);
				}

			}
			catch (Exception ex)
			{
				Console.WriteLine($"Что-то пошло не так: {ex.Message}");
			}
			Console.ReadKey();
		}

		public static void Nineth()
		{
			Console.WriteLine("------------------------");
			Console.WriteLine("9th exercise");

			try
			{
				//string 1 по умолчанию находится в файле 9_1
				StreamReader sr_1 = new StreamReader(@"D:\9_1.txt", Encoding.Default);
				string str_1 = sr_1.ReadToEnd();
				//string 2 по умолчанию в 9_2
				StreamReader sr_2 = new StreamReader(@"D:\9_2.txt", Encoding.Default);
				string str_2 = sr_2.ReadToEnd();
				sr_1.Close();
				sr_2.Close();
				StreamWriter sw_1 = new StreamWriter(@"D:\9_1.txt");
				StreamWriter sw_2 = new StreamWriter(@"D:\9_2.txt");
				sw_1.Write(str_2);
				sw_2.Write(str_1);
				sw_2.Close();
				sw_1.Close();
			}
			catch (Exception ex)
			{
				Console.WriteLine($"Что-то пошло не так: {ex.Message}");
			}
			Console.ReadKey();
		}

		public static void Tenth()
		{
			Console.WriteLine("------------------------");
			Console.WriteLine("10th exercise");
			try
			{
				BinaryWriter bw = new BinaryWriter(File.Open(@"D:\10.bin", FileMode.Create));

				Random rnd = new Random();
				int n = Convert.ToInt32(Console.ReadLine());
				int num = 0;
				for (int i = 0; i < n; i++)
				{
					num = rnd.Next(-50, 50);
					bw.Write(num);
					Console.Write(num + " ");
				}
				bw.Close();

				BinaryReader br = new BinaryReader(File.Open(@"D:\10.bin", FileMode.Open));
				List<int> numsPos = new List<int>();
				List<int> numsNeg = new List<int>();
				num = 0;
				while (br.BaseStream.Position != br.BaseStream.Length)
				{
					num = br.ReadInt32();
					if (num > 0)
					{
						numsPos.Add(num);
					}
					else
					{
						numsNeg.Add(num);
					}
				}

				numsPos.Sort();
				numsNeg.Sort();
				int minPos = numsPos[0];
				Console.WriteLine("\n---------------");
				for (int i = numsNeg.Count - 1; i >= 0; i--)
				{
					Console.Write(numsNeg[i] + " ");
				}
				for (int i = 0; i < numsPos.Count; i++)
				{
					Console.Write(numsPos[i] + " ");
				}

				Console.WriteLine($"Минимальный положительный: {minPos}");
				br.Close();
			}
			catch (Exception ex)
			{

				Console.WriteLine($"Что-то пошло не так: {ex.Message}");
			}
			Console.ReadKey();
		}
	}
}