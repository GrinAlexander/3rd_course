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
			Console.WriteLine("---------------------------");
			int[] arr_A = new int[19];
			int size = 0;
			Random random = new Random();
			for (int i = 0; i < 19; i++)
			{
				arr_A[i] = random.Next(500, 2000);
				Console.WriteLine("[{0}] = {1}", i, arr_A[i]);
				if (arr_A[i] <= 999)
				{
					size++;
				}
			}

			int[] arr_B = new int[size];
			int j = 0;
			for (int i = 0; i < arr_A.Length; i++)
			{
				if (arr_A[i] <= 999)
				{
					arr_B[j] = arr_A[i];
					j++;
				}
			}

			int tmp = 0;
			for (int i = arr_B.Length - 1; i >= 0; i--)
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
			OutputArray(arr_B);
			Console.ReadKey();
		}

		public static void Third()
		{
			Console.WriteLine("---------------------------");
			int[,] arr = new int[19, 19];
			double result_sum = 0;
			double result_mul = 1;
			Random random = new Random();
			for (int i = 0; i < 19; i++)
			{
				for (int j = 0; j < 19; j++)
				{
					arr[i, j] = random.Next(1, 4);
					//Console.WriteLine("[{0}]:[{1}] = {2}", i, j, arr[i, j]);
					result_mul *= arr[i, j];
					result_sum += arr[i, j];
				}
			}
			//OutputArray(arr, 19, 19);
			Console.WriteLine("Result of sum is {0}", result_sum);
			Console.WriteLine("Result of multiplication is {0}", result_mul);
			Console.ReadKey();
		}

		public static void Fourth()
		{
			Console.WriteLine("---------------------------");
			int n = Convert.ToInt32(Console.ReadLine());
			int[,] matrix = new int[n, 3];
			double[] area = new double[n];
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
				if(area[i] == 0)
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

			OutputArray(area);
			Console.WriteLine("Max = {0}, Max index = {1}", max, maxIndex);
			Console.ReadKey();
		}

		public static void Fifth()
		{
			Console.WriteLine("---------------------------");
			double result = 1;
			//double x = Convert.ToDouble(Console.ReadLine());
			for (double x = 0.1; x < 1; x += 0.09)
			{
				result = Math.Pow(((x * x) / 4) + (x / 2) + 1, Math.Pow(Math.E, (x / 2)));
				Console.WriteLine("Result {1} is {0}", result, (x));
			}
			Console.ReadKey();
		}

		public static void Sixth()
		{
			Console.WriteLine("---------------------------");
			int[] arr = new int[5];
			for (int i = 0; i < 5; i++)
			{
				arr[i] = Convert.ToInt32(Console.ReadLine());
			}
			int size = 0;
			for (int i = 0; i < arr.Length; i++)
			{
				if ((arr[i] % 100 != ((arr[i] % 10) / 10)) && (arr[i] % 10 != (arr[i] / 100)))
				{
					size++;
				}
			}

			int[] arr_B = new int[size];
			int j = 0;
			for (int i = 0; i < arr.Length; i++)
			{
				if (((arr[i] % 100) != ((arr[i] % 10) / 10)) && ((arr[i] % 10) != (arr[i] / 100)))
				{
					arr_B[j] = arr[i];
					j++;
				}
			}
			Array.Sort(arr_B);
			OutputArray(arr_B);
			Console.ReadKey();
		}

		public static void Seventh()
		{
			Console.WriteLine("---------------------------");
			int[] arr = new int[10];
			int sum_1 = 0, sum_2 = 0;
			Random random = new Random();
			for (int i = 0; i < 10; i++)
			{
				arr[i] = random.Next(-5, 5);
				if (arr[i] > 0)
				{
					sum_1 += arr[i];
				}
				else
				{
					sum_2 += arr[i];
				}
				Console.WriteLine("[{0}] = {1}", i, arr[i]);
			}
			Console.WriteLine("7-е задание первым способом: {0}, {1}", sum_1, sum_2);
			sum_1 = 0;
			sum_2 = 0;
			int[] arrForSum1 = Array.FindAll(arr, n => n > 0);
			int[] arrForSum2 = Array.FindAll(arr, n => n < 0);
			for (int i = 0; i < arrForSum1.Length; i++)
			{
				sum_1 += arrForSum1[i];
			}
			for (int i = 0; i < arrForSum2.Length; i++)
			{
				sum_2 += arrForSum2[i];
			}
			Console.WriteLine("7-е задание вторым способом: {0}, {1}", sum_1, sum_2);
			Console.ReadKey();
		}

		public static void Eighth()
		{
			Console.WriteLine("---------------------------");
			int[] arr = new int[10];
			int lastZeroIndex = 0;
			int sumAfterZeroElement = 0;
			for (int i = 0; i < arr.Length; i++)
			{
				arr[i] = Convert.ToInt32(Console.ReadLine());
				if (arr[i] == 0)
				{
					lastZeroIndex = i;
				}
			}
			for (int i = lastZeroIndex + 1; i < arr.Length; i++)
			{
				sumAfterZeroElement += arr[i];
			}
			Console.WriteLine("8-е задание первым способом: {0}", sumAfterZeroElement);

			lastZeroIndex = 0;
			sumAfterZeroElement = 0;
			for (int i = 0; i < arr.Length; i++)
			{
				lastZeroIndex = Array.FindLastIndex(arr, zero => zero == 0);
			}
			for (int i = lastZeroIndex + 1; i < arr.Length; i++)
			{
				sumAfterZeroElement += arr[i];
			}
			Console.WriteLine("8-е задание первым способом: {0}", sumAfterZeroElement);
			Console.ReadKey();
		}

		public static void OutputArray(int[] arr)
		{
			for (int i = 0; i < arr.Length; i++)
			{
				Console.WriteLine("[{0}] = {1}", i, arr[i]);
			}
		}
		public static void OutputArray(double[] arr)
		{
			for (int i = 0; i < arr.Length; i++)
			{
				Console.WriteLine("[{0}] = {1}", i, arr[i]);
			}

		}
		public static void OutputArray(int[,] arr, int n, int m)
		{
			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < m; j++)
				{
					Console.WriteLine("[{0}]:[{1}] = {2}", i, j, arr[i, j]);
				}
			}
		}
	}
}