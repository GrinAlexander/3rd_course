using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL_9
{
    public class Student
    {
        public float[] Marks { get; set; }
        public int AbsentCount { get; set; }

        public float AverageMark()
        {
            float marksSum = 0;
            foreach (float item in Marks)
            {
                marksSum += item;
            }
            return marksSum / Marks.Length;
        }

        public void AbsentVerdict()
        {
            if (AbsentCount < 0 || AbsentCount > 333)
            {
                Console.WriteLine("Недопустимое число пропусков!");
            }
            else if (AbsentCount == 0)
            {
                Console.WriteLine("Пропусков нет.");
            }
            else if (AbsentCount > 0 && AbsentCount <= 60)
            {
                Console.WriteLine("Удовлетворительное число пропусков!");
            }
            else if (AbsentCount > 60 || AbsentCount <= 333)
            {
                Console.WriteLine("На отчисление!");
            }
        }
    }
}
