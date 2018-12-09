using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace Test_2
{
    class MainClass
    {
        struct Products
        {
            public string name;
            public int amount;
            public int workshopNumber;
            public Products(string name, int amount, int workshopNumber)
            {
                this.name = name;
                this.amount = amount;
                this.workshopNumber = workshopNumber;
            }
            public void DisplayInfo()
            {
                Console.WriteLine($"{name} - {amount} шт.");
            }
        }
        public static void Main(string[] args)
        {
            First();
            Second();
        }

        public static void First()
        {
            Console.WriteLine("----------------");
            Console.WriteLine("Задание 1:");
            List<Products> products = new List<Products>();
            products.Add(new Products("Гвозди", 300, 3));
            products.Add(new Products("Саморез", 900, 3));
            products.Add(new Products("ДВП", 40, 2));
            products.Add(new Products("Фанера", 50, 3));
            foreach (var item in products)
            {
                item.DisplayInfo();
            }
            Console.ReadLine();
        }
        public static void Second()
        {
            Console.WriteLine("----------------");
            Console.WriteLine("Задание 2:");
            List<Products> products = new List<Products>();
            StreamReader sr = new StreamReader("D:\\14_1.txt", Encoding.Default);
            StreamWriter sw = new StreamWriter("D:\\14_2.txt");

            string name = string.Empty;
            int amount = 0;
            int num = 0;
            int counter = 0;
            int length = 0;
            int startIndex = 0;
            string strLine = sr.ReadLine();
            while (strLine != null)
            {
                for (int i = 0; i < strLine.Length; i++)
                {
                    length++;
                    if (strLine[i] == ';')
                    {
                        counter++;
                        if (counter == 1)
                        {
                            name = strLine.Substring(startIndex, length - 1);
                        }
                        else if (counter == 2)
                        {
                            amount = Convert.ToInt32(strLine.Substring(startIndex + 1, length - 1));
                        }
                        else if (counter == 3)
                        {
                            num = Convert.ToInt32(strLine.Substring(startIndex + 1, length - 1));
                        }
                        startIndex = i;
                        length = 0;
                    }
                }
                startIndex = 0;
                products.Add(new Products(name, amount, num));
                counter = 0;
                strLine = sr.ReadLine();
            }
            foreach (var item in products)
            {
                item.DisplayInfo();
                sw.Write($"{item.name};{item.amount};{item.workshopNumber};\n");
            }

            bool correctness = true;
            int choice = 1;
            Console.WriteLine("\n1. Добавить продукцию \n2. Выйти");
            Console.WriteLine("Что делаем?"); choice = Convert.ToInt32(Console.ReadLine());
            while (choice != 2)
            {
                correctness = true;
                if (choice == 1)
                {
                    Console.WriteLine("\nДобавь продукцию!");
                    Console.Write("Название: "); name = Console.ReadLine();
                    while (name.Length < 3)
                    {
                        Console.Write("Название: "); name = Console.ReadLine();
                    }
                    try
                    {
                        Console.Write("Количество: "); amount = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Цех: "); num = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Неправильные данные!");
                        correctness = false;
                    }
                    if (correctness)
                    {
                        products.Add(new Products(name, amount, num));
                        sw.Write($"{name};{amount};{num};\n");
                        foreach (var item in products)
                        {
                            item.DisplayInfo();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Введите корректные данные!");
                    }
                }
                else
                {
                    Console.WriteLine("Введите корректные данные!");
                }
                Console.WriteLine("Что делаем?"); choice = Convert.ToInt32(Console.ReadLine());

            }
            sw.Close();
            Console.ReadLine();
        }
    }
}