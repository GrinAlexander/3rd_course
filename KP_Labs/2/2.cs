using System;
using System.Diagnostics;

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
            Ninth();
        }

        public static void First()
        {
            Console.WriteLine("--------------------------");
            int x = Convert.ToInt32(Console.ReadLine());
            if (x == 0)
                Console.WriteLine("X == 0");
            else if (x > 0)
                Console.WriteLine("X > 0");
            else
                Console.WriteLine("X < 0");
        }

        public static void Second()
        {
            Console.WriteLine("--------------------------");
            int x = Convert.ToInt32(Console.ReadLine());
            switch (x)
            {
                case 1:
                    Console.WriteLine("Привет первокурсник!");
                    break;
                case 2:
                    Console.WriteLine("Привет второкурсник!");
                    break;
                case 3:
                    Console.WriteLine("Привет третьекурсник!");
                    break;
                case 4:
                    Console.WriteLine("Привет четверокурсник!");
                    break;
		default:
			Console.WriteLine ("Просто привет!");   
			break;
		}
        }

        public static void Third()
        {
            Console.WriteLine("--------------------------");
            int x = Convert.ToInt32(Console.ReadLine());
            if (x < -190 || x > 10)
                Console.WriteLine("Не входит промежуток [-190,10]");
            else
                Console.WriteLine("Входит промежуток [-190,10]");
        }

        public static void Fourth()
        {
            Console.WriteLine("--------------------------");
            int x = Convert.ToInt32(Console.ReadLine());
            if (x < 6 || x > 8)
            {
                Console.WriteLine("Это не каникулы");
            }
            else
            {
                Console.WriteLine("Каникулы! Скорее всего");
            }
        }

        public static void Fifth()
        {
            Console.WriteLine("--------------------------");
            double x = Convert.ToInt32(Console.ReadLine());
            double result = 0;
            if (x == 0)
            {
                result = Math.Pow(Math.E, 10 * Math.PI * x + Math.Pow(x, 90));
            }

            else if (x > 0)
            {
                result = 10 * Math.Pow(x, 2) + 9;
            }

            else
            {
                result = (Math.Pow(Math.Sin(9 * x), 2) + Math.Pow(Math.Cos(9 * x), 2)) / 90;
            }
            Console.WriteLine("Result = " + result);
        }

        public static void Sixth()
        {
            Console.WriteLine("--------------------------");
            int[] arr = new int[3];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("[{0}] - ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            int max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (max < arr[i])
                {
                    max = arr[i];
                }
            }
            Console.WriteLine("Max = " + max);
        }

        public static void Seventh()
        {
            Console.WriteLine("--------------------------");
            double[] arr_1 = new double[3];
            double[] arr_2 = new double[3];
            for (int i = 0; i < arr_1.Length; i++)
            {
                Console.WriteLine("[{0}] - ", i);
                arr_1[i] = Convert.ToDouble(Console.ReadLine());
                arr_2[i] = Convert.ToDouble(Console.ReadLine());
            }
            if (arr_1[0] == arr_2[0] && arr_1[1] == arr_2[1] && arr_1[2] == arr_2[2])
            {
                Console.WriteLine("Прямые совпадают");
            }
            else if ((arr_1[0] / arr_2[0]) == (arr_1[1] / arr_2[1]))
            {
                Console.WriteLine("Прямые параллельны!");
            }
            else
            {
                Console.WriteLine("Прямые пересекаются!");
            }
        }

        public static void Eighth()
        {
            Console.WriteLine("--------------------------");
            int[] arr = new int[3];
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("[{0}] - ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            bool vozr = false, ubyv = false;
            if ((arr[0] >= arr[1]) && (arr[1] >= arr[2]))
            {
                vozr = false;
                ubyv = true;
            }
            else if((arr[0] <= arr[1]) && (arr[1] <= arr[2]))
            {
                vozr = true;
                ubyv = false;
            }
            for (int i = 0; i < 3; i++)
            {
                if (vozr == true)
                {
                    arr[i] *= 10;
                }
                else if (ubyv == true)
                {
                    arr[i] += 9;
                }
                else
                {
                    arr[i] = -arr[i];
                }
                Console.WriteLine("[{0}] - {1}", i, arr[i]);
            }
        }

        public static void Ninth()
        {
            Console.WriteLine("--------------------------");
            string hero = Console.ReadLine();  
			switch(hero.ToLower())
                {
                    case "superman":
                        Console.WriteLine("Justice League, Man of Steel");
                        break;
                    case "batman":
                        Console.WriteLine("Justice League, Dark Knight");
                        break;
                    case "wonder woman":
                        Console.WriteLine("Justice League, Wonder Woman(2017)");
                        break;
                    case "green lantern":
                        Console.WriteLine("Justice League, Green Lantern");
                        break;
                    case "aquaman":
                        Console.WriteLine("Justice League, Aquaman");
                        break;
                }
            
        }
    }
}
