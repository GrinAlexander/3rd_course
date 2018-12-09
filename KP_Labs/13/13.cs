using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace Test_2
{
    class Cat
    {
        private Regex regex = new Regex(@"[А-Я]\w");
        private string name;
        private string breed;
        private int feedCountInDay;
        private int daysCount;
        private int feedAmountInPackage;
        private int packageCost;
        private int feedCountInMonth;
        private int monthlyCost;
        public Cat()
        {
            name = "Кот";
            breed = "Дворовой";
            feedCountInDay = 200;
            daysCount = 30;
            feedAmountInPackage = 1400;
            packageCost = 35;
        }
        public Cat(string name, string breed, int feedCountInDay, int daysCount, int feedAmountInPackage, int packageCost)
        {
            if (regex.IsMatch(name) && regex.IsMatch(breed))
            {
                this.name = name;
                this.breed = breed;
            }
            else
            {
                throw new Exception("Кличка и порода с большой буквы!");
            }
            if ((feedCountInDay >= 50) && (feedCountInDay <= 300))
            {
                this.feedCountInDay = feedCountInDay;
            }
            else
            {
                throw new Exception("Проверьте вашего кота. Не думаю, что он в порядке от такого количества корма!");
            }
            if ((daysCount >= 28) && (daysCount <= 31))
            {
                this.daysCount = daysCount;
            }
            else
            {
                throw new Exception("В месяце не может быть столько дней!");
            }
            if ((feedAmountInPackage >= 100)&&(feedAmountInPackage <= 2000))
            {
                this.feedAmountInPackage = feedAmountInPackage;
            }
            else
            {
                throw new Exception("Какая-то нереальная пачка на месяц, проверьте кота!");
            }
            if ((packageCost >= 1) && (packageCost <= 70))
            {
                this.packageCost = packageCost;
            }
            else
            {
                throw new Exception("Проверь цену за пачку!");
            } 
        }
        private void MonthlyCostCalculating()
        {
            feedCountInMonth = daysCount * feedCountInDay;
            monthlyCost = daysCount * packageCost;
        }
        public void CostInformation()
        {
            MonthlyCostCalculating();
            Console.WriteLine($"Ваш кот требует {feedCountInMonth} грамм корма в месяц.\nВы потратите на это {monthlyCost} рублей.");
        }
    }
    class MainClass
    {
        public static void Main(string[] args)
        {
            First();
            Second();
        }
        public static void First()
        {
            Console.WriteLine("---------------");
            Console.WriteLine("Задание 1");
            try
            {
                double y, x;
                Console.Write("x = "); x = Convert.ToDouble(Console.ReadLine());
                y = (88 * x + 4) / ((-7 * Math.Pow(x, 2)));
                Console.WriteLine($"1. y = {y}");
                y = -((Math.Log(4 * Math.Pow(x, 2) + 28 * x + 49)) / (Math.Abs(x - 33)));
                Console.WriteLine($"2. y = {y}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.GetBaseException());
            }
            Console.ReadLine();
        }
        public static void Second()
        {
            Console.WriteLine("---------------");
            Console.WriteLine("Задание 2");
            try
            {
                string name, breed;
                int feedCountInDay, daysCount, feedAmountInPackage, packageCost;
                Console.Write("Кличка: "); name = Console.ReadLine();
                Console.Write("Порода: "); breed = Console.ReadLine();
                Console.Write("Количество корма в день: "); feedCountInDay = Convert.ToInt32(Console.ReadLine());
                Console.Write("Количество дней в месяце: "); daysCount = Convert.ToInt32(Console.ReadLine());
                Console.Write("Количество корма в пачке: "); feedAmountInPackage = Convert.ToInt32(Console.ReadLine());
                Console.Write("Цена пачки: "); packageCost = Convert.ToInt32(Console.ReadLine());
                Cat cat = new Cat(name, breed, feedCountInDay, daysCount, feedAmountInPackage, packageCost);
                cat.CostInformation();
                Console.WriteLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.GetBaseException());
            }
            Console.ReadLine();
        }
    }
}