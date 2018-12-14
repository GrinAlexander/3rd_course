using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace Test_2
{
    class StudyGroupEventArgs
    {
        public string Message { get; }
        public int MaleCount { get; }
        public int FemaleCount { get; }
        public StudyGroupEventArgs(string msg, int mCount, int fCount)
        {
            Message = msg;
            MaleCount = mCount;
            FemaleCount = fCount;
        }
        public StudyGroupEventArgs(string msg)
        {
            Message = msg;
        }
        public StudyGroupEventArgs()
        {

        }
    }
    class StudyGroup
    {
        public delegate void StudyGroupHandler(object sender, StudyGroupEventArgs e);
        public event StudyGroupHandler Created;
        public event StudyGroupHandler Added;
        public event StudyGroupHandler Deducted;
        private int maleCount;
        private int femaleCount;

        public StudyGroup(int mCount, int fCount)
        {
            maleCount = mCount;
            femaleCount = fCount;
        }
        public void Add(int mCount)
        {
            if (Math.Abs(maleCount + mCount - femaleCount) >= 5)
            {
                Console.WriteLine("Большая разница в количестве юношей и девушек!");
            }
            else
            {
                maleCount += mCount;
                Added?.Invoke(this, new StudyGroupEventArgs($""));
            }

        }
        public void Deduct(int mCount, int fCount)
        {
            if ((mCount <= maleCount) && (fCount <= femaleCount))
            {
                if (Math.Abs((maleCount - mCount) - (femaleCount - fCount)) >= 5)
                {
                    Console.WriteLine("Большая разница в количестве юношей и девушек!");
                }
                else
                {
                    maleCount -= mCount;
                    femaleCount -= fCount;
                    Deducted?.Invoke(this, new StudyGroupEventArgs($"Отчислено {mCount} юношей и {fCount} девушек"));
                }

            }
            else if (mCount > maleCount || fCount > femaleCount)
            {
                Console.WriteLine("Слишком мало людей в группе");
            }
        }
        public void Information()
        {
            Created?.Invoke(this, new StudyGroupEventArgs($"На курс зачислено {maleCount} юношей и {femaleCount} девушек", maleCount, femaleCount));
            Console.WriteLine($"\nЮношей: {maleCount} \nДевушек: {femaleCount} \n");

        }
    }
    class MainClass
    {
        public delegate void MessageFirst(float[] array);
        public delegate void MessageSecond(int a, int b);
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Second();
            Fourth();
        }
        public static void Second()
        {
            Console.WriteLine("----------------");
            Console.WriteLine("Задание 2");
            bool correctness = false;
            while (!correctness)
            {
                try
                {
                    Console.Write("a = "); int a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("b = "); int b = Convert.ToInt32(Console.ReadLine());
                    int temp = a > b ? a : b;
                    int nod = 1;
                    MessageSecond ms_NOK = delegate
                    {
                        for (int i = temp; i > 1; i--)
                        {
                            if ((a % i == 0) && (b % i == 0))
                            {
                                nod = i;
                                break;
                            }
                        }

                        Console.WriteLine($"НОК: {(a * b) / nod}");
                    };
                    ms_NOK(a, b);
                    MessageSecond ms_Cube = delegate
                    {
                        for (int i = 1; i < temp; i++)
                        {
                            if (i * i * i == a)
                            {
                                Console.WriteLine($"a - куб числа {i}");
                            }
                            if (i * i * i == b)
                            {
                                Console.WriteLine($"b - куб числа {i}");
                            }
                        }
                    };
                    ms_Cube(a, b);
                    correctness = true;
                }
                catch
                {
                    Console.WriteLine("Некорректные данные!");
                    correctness = false;
                }
            }
            Console.ReadLine();
        }
        public static void Fourth()
        {
            Console.WriteLine("----------------");
            Console.WriteLine("Задание 4");
            bool correctness = false;
            int choice = 0, mCount = 0, fCount = 0;
            Console.WriteLine("Создай группу студентов");

            while (!correctness)
            {
                try
                {
                    Console.Write("Юношей: "); mCount = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Девушек: "); fCount = Convert.ToInt32(Console.ReadLine());

                    if (Math.Abs(mCount - fCount) >= 5)
                    {
                        Console.WriteLine("Большая разница в количестве юношей и девушек!");
                        correctness = false;
                    }
                    else
                    {
                        correctness = true;
                    }
                }
                catch
                {
                    Console.WriteLine("Некорректные данные!");
                    correctness = false;
                }
            }
            StudyGroup studyGroup = new StudyGroup(mCount, fCount);
            studyGroup.Added += (sender, e) =>
            {
                Console.WriteLine($"Ещё зачислено {mCount} юношей (лямбда)");
            };
            studyGroup.Created += ShowMsg;
            studyGroup.Deducted += (sender, e) =>
            {
                Console.WriteLine($"Отчислено {mCount} юношей и {fCount} девушек (лямбда)");
            };
            studyGroup.Information();
            studyGroup.Created -= ShowMsg;
            Console.WriteLine("\n1. Зачислить студентов(только юношу) \n2. Отчислить студентов \n3. Показать информацию по группе \n4. Выйти");

            while (choice != 4)
            {
                try
                {
                    Console.Write("Действие: "); choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            {
                                Console.Write("Количество: ");
                                mCount = Convert.ToInt32(Console.ReadLine());
                                studyGroup.Add(mCount);
                                break;
                            }

                        case 2:
                            {
                                Console.Write("Количество юношей: "); mCount = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Количество девушек: "); fCount = Convert.ToInt32(Console.ReadLine());
                                studyGroup.Deduct(mCount, fCount);
                                break;
                            }
                        case 3:
                            {
                                studyGroup.Information();
                                break;
                            }
                        case 4:
                            {
                                Console.WriteLine("Пока!");
                                break;
                            }
                        default: Console.WriteLine("Некорректные данные!"); break;
                    }
                }
                catch
                {
                    Console.WriteLine("Некорректные данные!");
                }
            }
            Console.ReadLine();
        }
        public static void ShowMsg(object sender, StudyGroupEventArgs e)
        {
            Console.WriteLine(e.Message);
        }

    }
}