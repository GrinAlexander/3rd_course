using System;

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
		}

		public static void First()
		{
			Console.WriteLine("---------------------------");
			Console.WriteLine("1st exercise");
			int n = 1;
			int m = 1;
			int moreThan0 = 0;
			int lessThan0 = 0;
			Console.Write("n = "); n = Convert.ToInt32(Console.ReadLine());
			Console.Write("m = "); m = Convert.ToInt32(Console.ReadLine());
			int[,] matrix = new int[n, m];
			Random random = new Random();
			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < m; j++)
				{
					matrix[i, j] = random.Next(-5, 5);
					Console.WriteLine("[{0}]:[{1}] = {2}", i, j, matrix[i, j]);
					if (matrix[i, j] < 0)
					{
						lessThan0++;
					}
					else if (matrix[i, j] > 0)
					{
						moreThan0++;
					}
					else
					{
						Console.WriteLine("Элемент с координатами [{0}]:[{1}] равен 0", i, j);
					}
				}
			}
			Console.WriteLine("Больше нуля: {1} \nМеньше нуля: {0}", lessThan0, moreThan0);
			Console.ReadKey();
		}

		public static void Second()
		{
			unsafe
			{
				Console.WriteLine("---------------------------");
				Console.WriteLine("2nd exercise");
				int* arr_A = stackalloc int[19];
				int* arr_B = stackalloc int[19];
				int j = 0;
				Random random = new Random();
				for (int i = 0; i < 19; i++)
				{
					arr_A[i] = random.Next(500, 2000);
					Console.WriteLine("[{0}] = {1}", i, arr_A[i]);
					if (arr_A[i] <= 999)
					{
						arr_B[j] = arr_A[i];
						j++;
					}
				}

				int tmp = 0;
				for (int i = 18; i >= 0; i--)
				{
					for (j = 0; j < i; j++)
					{
						if (arr_B[j] < arr_B[j + 1])
						{
							tmp = arr_B[j];
							arr_B[j] = arr_B[j + 1];
							arr_B[j + 1] = tmp;
						}
					}

				}
				Console.WriteLine("\nМассив В:");
				for (int i = 0; i < 19; i++)
				{
					if (arr_B[i] != 0)
					{
						Console.Write(" " + arr_B[i]);
					}

				}
				Console.ReadKey();
			}
		}

		public static void Third()
		{
			Console.WriteLine("\n---------------------------");
			Console.WriteLine("3rd exercise");
			int[,] arr = new int[19, 19];
			double result_sum = 0;
			double result_mul = 1;
			Random random = new Random();
			for (int i = 0; i < 19; i++)
			{
				for (int j = 0; j < 19; j++)
				{
					arr[i, j] = random.Next(1, 3);
					//Console.WriteLine("[{0}]:[{1}] = {2}", i, j, arr[i, j]);
					result_mul *= arr[i, j];
					result_sum += arr[i, j];
				}
			}
			/*for (int i = 0; i < 19; i++)
			{
				for (int j = 0; j < 19; j++)
				{
					Console.Write(" " + arr[i,j]);
				}
			}*/
			Console.WriteLine("\nResult of sum is {0}", result_sum);
			Console.WriteLine("Result of multiplication is {0}", result_mul);
			Console.ReadKey();
		}

		public static void Fourth()
		{
			unsafe
			{
				Console.WriteLine("---------------------------");
				Console.Write("4th exercise\nВведите кол-во треугольников: ");  int n = Convert.ToInt32(Console.ReadLine());
				int[,] matrix = new int[n, 3];
				double* area = stackalloc double[n];
				for (int i = 0; i < n; i++)
				{
					for (int j = 0; j < 3; j++)
					{
						matrix[i, j] = Convert.ToInt32(Console.ReadLine());
					}
				}
				double p = 1;
				for (int i = 0; i < n; i++)
				{
					p = 0.5 * (matrix[i, 0] + matrix[i, 1] + matrix[i, 2]);
					area[i] = Math.Sqrt(p * (p - matrix[i, 0]) * (p - matrix[i, 1]) * (p - matrix[i, 2]));
					if (area[i] == 0)
					{
						Console.WriteLine("Треугольник с индексом {0} не существует!", i);
					}

				}
				double max = area[0], maxIndex = 0;
				for (int i = 0; i < n; i++)
				{
					if (max < area[i])
					{
						max = area[i];
						maxIndex = i;
					}

				}
				Console.WriteLine("\nПлощади треугольников: ");

				for (int i = 0; i < n; i++)
				{
					Console.WriteLine($"[{i}] - {area[i]}");
				}
				Console.WriteLine("\nMax = {0}, Max index = {1}", max, maxIndex);
				Console.ReadKey();
			}
			
		}

		public static void Fifth()
		{
			Console.WriteLine("---------------------------");
			Console.WriteLine("5th exercise");
			double result = 1;
			for (double x = 0.1; x < 1; x += 0.09)
			{
				result = Math.Pow(((x * x) / 4) + (x / 2) + 1, Math.Pow(Math.E, (x / 2)));
				Console.WriteLine("Result {1} is {0}", result, (x));
			}
			Console.ReadKey();
		}

		public static void Sixth()
		{
			unsafe
			{
				Console.WriteLine("---------------------------");
				Console.WriteLine("6th exercise");
				int* arr = stackalloc int[5];
				Console.WriteLine("Введите 5 чисел!");
				for (int i = 0; i < 5; i++)
				{
					arr[i] = Convert.ToInt32(Console.ReadLine());
				}
				int size = 0;
				for (int i = 0; i < 5; i++)
				{
					if ((arr[i] % 100 != ((arr[i] % 10) / 10)) && (arr[i] % 10 != (arr[i] / 100)))
					{
						size++;
					}
				}

				int[] arr_B = new int[size];
				int j = 0;
				for (int i = 0; i < 5; i++)
				{
					if (((arr[i] % 100) != ((arr[i] % 10) / 10)) && ((arr[i] % 10) != (arr[i] / 100)))
					{
						arr_B[j] = arr[i];
						j++;
					}
				}
				Array.Sort(arr_B);
				for (int i = 0; i < size; i++)
				{
					Console.WriteLine($"[{i}] - {arr_B[i]}");
				}
				Console.ReadKey();
			}
			
		}

		public static void Seventh()
		{
			unsafe
			{
				Console.WriteLine("---------------------------");
				Console.WriteLine("7th exercise");
				int* arr = stackalloc int[10];
				int* pointer = arr;
				int sum_1 = 0, sum_2 = 0;
				Random random = new Random();
				for (int i = 0; i < 10; i++)
				{
					*pointer = random.Next(-5, 5);
					if (*pointer > 0)
					{
						sum_1 += *pointer;
					}
					else
					{
						sum_2 += *pointer;
					}
					Console.WriteLine($"{*pointer}");
					pointer++;
				}
				Console.WriteLine("7-е задание первым способом: {0}, {1}", sum_1, sum_2);
				Console.ReadKey();
			}
			
		}

		public static void Eighth()
		{
			unsafe
			{
				Console.WriteLine("---------------------------");
				Console.WriteLine("8th exercise");
				int n = 0;
				int* arr = stackalloc int[10];
				int lastZeroIndex = 0;
				int sumAfterZeroElement = 0;
				for (int i = 0; i < 10; i++)
				{ 
					arr[i] = Convert.ToInt32(Console.ReadLine());
					if (arr[i] == 0)
					{
						lastZeroIndex = i;
					}
				}
				for (int i = lastZeroIndex + 1; i < 10; i++)
				{
					sumAfterZeroElement += arr[i];
				}
				Console.WriteLine("8-е задание первым способом: {0}", sumAfterZeroElement);
				Console.ReadKey();
			}
		}
	}
}
