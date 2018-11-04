using System;
using System.Collections.Generic;
using System.Text;

namespace Test_2
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			First();
			Second();
			Third();
			Fourth();
			Fifth();
			Sixth();
			Seventh();
			Eighth();
			Nineth();
			Tenth();
		}

		public static void First()
		{
			Console.WriteLine("-------------------------");
			string str = "Он нахмурился: его подарок, с которым он явился, памятуя о традициях довоенных лет, принят не был.";
			char[] arr = str.ToCharArray();
			for (int i = 0; i < arr.Length; i++)
			{
				if (arr[i] == ' ' || arr[i] == ':' || arr[i] == ',' || arr[i] == '.')
				{
					arr[i - 1] = '%';
				}

			}
			Console.WriteLine(arr);
			Console.ReadKey();
		}

		public static void Second()
		{
			Console.WriteLine("-------------------------");
			string str = "Вот география моей действительности: у меня никогда не было и в мыслях, " +
			   "что люди хорошие, что человек способен измениться, или что мир можно сделать лучше, " +
   "если получать удовольствие от чувств, взглядов и жестов, от любви и доброты другого человека." +
" Не было ничего положительного, термин великодушие ничего не значил, был своего рода избитым анекдотом.";
			char[] arr = str.ToCharArray();
			for (int i = 0; i < arr.Length; i++)
			{
				if (arr[i] == ' ' || arr[i] == ':' || arr[i] == ',' || arr[i] == '.')
				{
					arr[i - 1] = '%';
				}

			}
			Console.WriteLine(arr);
			Console.ReadKey();
		}

		public static void Third()
		{
			Console.WriteLine("-------------------------");
			string str = "Вот география моей действительности: у меня никогда не было и в мыслях, " +
			   "что люди хорошие, что человек способен измениться, или что мир можно сделать лучше, " +
   "если получать удовольствие от чувств, взглядов и жестов, от любви и доброты другого человека." +
" Не было ничего положительного, термин великодушие ничего не значил, был своего рода избитым анекдотом.";
			char[] arr = str.ToCharArray();
			int count_y = 0;
			int count_Y = 0;
			for (int i = 0; i < str.Length; i++)
			{
				if (arr[i] == 'У')
				{
					count_Y++;
				}
				if (arr[i] == 'у')
				{
					count_y++;
				}

			}
			Console.WriteLine("Кол-во 'у' = {0}\nКол-во 'У' = {1}", count_y, count_Y);
			Console.ReadKey();
		}

		public static void Fourth()
		{
			Console.WriteLine("-------------------------");
			string str = "слово";
			str = "волос";
			Console.WriteLine(str);
			Console.ReadKey();
		}

		public static void Fifth()
		{
			Console.WriteLine("-------------------------");
			string str = "ТепПерь толпПа пПроходила пПочти напПротив того места," +
				" где я находился — воздух был запПолнен их хрипПлым гавканьем, " +
	"а земля, казалось, пПодрагивала от нелепПых, чуждых всему человеческому шагов." +
 " Я пПочти не дышал и собрал всю свою волю в кулак, лишь бы — не дай Бог! — не размежить веки." +
 " Я и до настоящего времени не в состоянии точно опПределить, были ли пПоследовавшие за этим события реальностью или всего лишь кошмарной галлюцинацией." +
 " Недавние действия властей, пПредпПринятые пПосле моих отчаянных пПризывов и ходатайств, скорее всего пПодтвердят то, что это все же было чудовищной пПравдой," +
 " но не мог ли я в те минуты и в самом деле увидеть галлюцинации, пПорожденные пПсевдогипПнотическим воздействием атмосферы древнего, околдованного," +
 " одурманенного города? ППодобные города обычно обладают странной, неведомой нам силой, и мистическое наследство безумных легенд впПолне спПособно " +
 "пПовлиять на пПсихику отнюдь не одного человека, оказавшегося среди тех мертвых, пПропПитавшихся омерзительной вонью улиц, нагромождений пПрогнивших" +
 " крыш и рассыпПающихся колоколен.";

			for (int i = 0; i < str.Length; i++)
			{
				if ((str[i] == 'п') && (str[i + 1] == 'П'))
				{
					str = str.Remove(i + 1, 1);
				}
			}
			Console.WriteLine(str);
			Console.ReadKey();
		}

		public static void Sixth()
		{
			Console.WriteLine("-------------------------");
			string str = "Он нахмурился: его подарок, с которым он явился, памятуя о традициях довоенных лет, принят не был.";
			Console.Write("Длина слова: ");
			int n = Convert.ToInt32(Console.ReadLine());
			float wordCount = 0;
			float wordShort = 0;
			str = str.ToLower();
			str = str.Replace(".", string.Empty);
			str = str.Replace(",", string.Empty);
			str = str.Replace(":", string.Empty);
			Console.WriteLine(str);
			string temp_str = str;
			string temp = null;
			for (int i = 0; i < str.Length; i++)
			{
				if ((str[i] >= 'а') && (str[i] <= 'я'))
				{
					temp += str[i];
				}
				else if (str[i] == ' ')
				{
					if (temp.Length == 1)
					{
						temp_str = temp_str.Replace(" " + temp + " ", " ");
					}
					if (temp.Length <= n)
					{
						Console.Write(temp + " ");
					}
					if ((temp.Length <= 3) && (temp.Length >= 1))
					{
						wordShort++;
					}
					if (temp.Length >= 1)
					{
						wordCount++;
					}
					temp = string.Empty;
				}
			}
			Console.WriteLine("\nПроцент коротких слов (<3) " + ((wordShort / wordCount) * 100) + "%");
			Console.WriteLine($"Строка без минимальных слов: {temp_str} ");
			Console.ReadKey();
		}

		public static void Seventh()
		{
			Console.WriteLine("-------------------------");
			string LongStr1;
			Int64 sum = 0;
			Console.Write("Введите число: ");
			LongStr1 = Console.ReadLine();
			List<int> numbers = new List<int> { };
			for (int i = 0; i < LongStr1.Length; i++)
			{
				numbers.Add(int.Parse(LongStr1[i].ToString()));
			}
			numbers.Reverse();

			for (int i = 0; i < numbers.Count; i++)
			{
				sum += numbers[i];
			}
			Console.WriteLine($"Сумма цифр:{sum}");
			Console.ReadKey();
		}

		public static void Eighth()
		{
			Console.WriteLine("-------------------------");
			string str = Console.ReadLine();
			str = str.ToLower();
			float freq = 0;
			for (char ch = 'а'; ch <= 'я'; ch++)
			{
				for (int i = 0; i < str.Length; i++)
				{
					if (ch == str[i])
					{
						freq++;
					}
				}
				if (freq != 0)
				{
					Console.WriteLine($"Частота символа {ch} в строке равна {freq} и составляет {freq / str.Length} от общего числа символов");
					freq = 0;
				}
			}
			Console.ReadKey();
		}

		public static void Nineth()
		{
			Console.WriteLine("-------------------------");
			Console.Write("Введите строку: ");
			string str = Console.ReadLine();
			StringBuilder str_B = new StringBuilder(str);
			String str_Ob = new String(str.ToCharArray());
			Console.Write("Введите число: ");
			int n = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("1-й способ: ");
			if (n > str.Length)
			{
				Console.WriteLine(str.PadLeft(n, '.'));
			}
			else if (n < str.Length)
			{
				Console.WriteLine(str.Remove(n));
			}

			Console.WriteLine("2-й способ: ");
			if (n > str_B.Length)
			{
				while (n > str_B.Length)
				{
					str_B = str_B.Insert(0, '.');
				}
				Console.WriteLine(str_B);
			}
			else if (n < str_B.Length)
			{
				Console.WriteLine(str_B.Remove(n, (str_B.Length - n)));
			}

			Console.WriteLine("3-й способ: ");
			if (n > str_Ob.Length)
			{
				Console.WriteLine(str_Ob.PadLeft(n, '.'));
			}
			else if (n < str_Ob.Length)
			{
				Console.WriteLine(str_Ob.Remove(n));
			}

			Console.ReadKey();
		}

		public static void Tenth()
		{
			Console.WriteLine("-------------------------");
			Console.WriteLine("Введите строки: ");
			string str_1 = Console.ReadLine();
			string str_2 = Console.ReadLine();
			Console.WriteLine("Введите числа, которые меньше длины введённых строк (ибо проверки нету): ");
				
			int n1 = Convert.ToInt32(Console.ReadLine());
			int n2 = Convert.ToInt32(Console.ReadLine());

			StringBuilder str_B1 = new StringBuilder(str_1);
			StringBuilder str_B2 = new StringBuilder(str_2);
			String str_Ob1 = new String(str_1.ToCharArray());
			String str_Ob2 = new String(str_2.ToCharArray());

			Console.Write("1-й способ: ");
			str_1 = str_1.Remove(n1);
			str_2 = str_2.Substring(str_2.Length - n2);
			Console.WriteLine(str_1.Insert(n1, str_2));
			
			Console.Write("2-й способ: ");
			str_B1 = str_B1.Remove(n1, str_B1.Length - n1);
			for (int i = str_B2.Length - n2; i < str_B2.Length; i++)
			{
				str_B1 = str_B1.Append(str_B2[i]);
			}
			Console.WriteLine(str_B1);

			Console.Write("3-й способ: ");
			str_Ob1 = str_Ob1.Remove(n1);
			str_Ob2 = str_Ob2.Substring(str_Ob2.Length - n2);
			Console.WriteLine(str_Ob1.Insert(n1, str_Ob2));

			Console.ReadKey();
		}
	}
}