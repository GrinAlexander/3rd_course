using System;
using System.IO;
using System.Threading;

namespace KPLab
{
    class Program
    {
        static void Main(string[] args)
        {
             Thread thread_1 = new Thread(new ThreadStart(CalcFibonacci));
             Thread thread_2 = new Thread(new ThreadStart(CalcPrimeNum));
             thread_1.Start();
             thread_2.Start();
        }

        static void CalcFibonacci()
        {
            using (StreamWriter fstream = new StreamWriter(@"D:/fibonacci.txt"))
            {
                double prevNum = 0, presNum = 1, temp = 0;
                int count = 0;
                while (!double.IsInfinity(presNum + prevNum))
                {
                    temp = presNum;
                    presNum += prevNum;
                    prevNum = temp;
                    count++;
                    fstream.Write(presNum + " ");
                }
                Console.WriteLine($"Count of Fibonacci numbers: {count}");
            }
        }

        static void CalcPrimeNum()
        {
            using (StreamWriter fstream = new StreamWriter(@"D:/prime.txt"))
            {
                int primeNum = 1, count = 0, div = 0;
                while (primeNum < 100000)
                {
                    for (int i = 2; i < primeNum; i++)
                    {
                        if (primeNum % i == 0)
                        {
                            div++;
                            break;
                        }
                    }
                    if (div == 0)
                    {
                        count++;
                        fstream.Write(primeNum + "  ");
                    }
                    div = 0;
                    primeNum++;
                }
                Console.WriteLine($"Count of prime numbers: {count}");
            }
        }
    }
}