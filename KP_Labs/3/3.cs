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
        }

        public static void First()
        {
            Console.WriteLine("--------------------------");
            for (int i = -41; i < 500; i += 9)
            {
                Console.WriteLine(i + " ");
            }
        }

        public static void Second()
        {
            Console.WriteLine("--------------------------");
            double x = Convert.ToDouble(Console.ReadLine());
            double result = 0;
            if (x >= 1)
            {
                result = Math.Sqrt(Math.Pow(x, 14) + Math.Sin(19 * x));
            }
            else if (x <= 1)
            {
                result = (18 * Math.Pow(Math.Pow(x, 90) - 9000, 0)) / (Math.Sqrt(Math.Pow(x, 20) + 2 * Math.Pow(x, 18) + 1));
            }
            else
            {
                result = (Math.Tan(90 + x) * Math.Pow(Math.Tan(90 + x), -1)) / (3 * Math.Pow(x, 21) + 2 * Math.Pow(x, 19) + 1);
            }
            Console.WriteLine("Result = " + result);
        }

        public static void Third()
        {
            Console.WriteLine("--------------------------");
            double result = 0;
            double n = Convert.ToDouble(Console.ReadLine());
            for (double i = 1; i <= n; i++)
            {
                result += 1 / (9 * i);
            }
            Console.WriteLine("Result = " + result);
        }

        public static void Fourth()
        {
            Console.WriteLine("--------------------------");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
	    if (a > b)
            {
                int temp = a;
                a = b;
                b = temp;
            }
            int result = 0;
            for (int i = a; i <= b; i++)
            {
                if ((i % 2) != 0)
                {
                    result += i;
                }
            }
            Console.WriteLine("Result = " + result);
        }

        public static void Fifth()
        {
            Console.WriteLine("--------------------------");
            int x = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            double sum = 0;
            while (x != 9)
            {
                sum += x;
                count++;
                x = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Кол-во чисел = {0}\nСумма чисел = {1}\nСреднее арифметическое = {2}", count, sum, (sum / count));
        }

    }
}
