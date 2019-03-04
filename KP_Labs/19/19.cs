using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DLL_9;

namespace KPLab
{
    class Program
                
    {
        static void Main(string[] args)
        {
            try
            {
                float[] marks = new float[5];
                for (int i = 0; i < marks.Length; i++)
                {
                    Console.Write($"Отметка {i + 1} = ");
                    marks[i] = float.Parse(Console.ReadLine());
                    if (marks[i] < 0 || marks[i] > 10)
                    {
                        Console.WriteLine($"Отметка {i + 1} некорректна!");
                        i--;
                    }
                }

                int absentCount = 0;
                Console.Write("Количество пропусков = ");
                absentCount = int.Parse(Console.ReadLine());

                Student student = new Student
                {
                    Marks = marks,
                    AbsentCount = absentCount
                };

                Console.WriteLine($"Средняя отметка = {student.AverageMark()}");
                student.AbsentVerdict();
            }
            catch (Exception)
            {
                Console.WriteLine("Проверьте введённые данные!");
            }
            Console.ReadLine();
        }
    }
}
