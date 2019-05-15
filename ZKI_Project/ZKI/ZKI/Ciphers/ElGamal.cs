using System;
using System.Collections.Generic;
using System.Numerics;

namespace ZKI.Ciphers
{
    static class ElGamalHelper
    {
        static public long Calculate_g(long p)
        {
            Random rand = new Random((int)DateTime.Now.Ticks);
            long g = rand.Next(1, (int)p);
            return g;
        }
        static public long Calculate_x(long p)
        {
            while (true)
            {
                Random rand = new Random((int)DateTime.Now.Ticks);
                long x = rand.Next(1, (int)p);
                if (x != p)
                {
                    return x;
                }
            }
        }
        static public int GetInt()
        {
            int last = 0;
            bool simple = false;
            int a = 0;
            while (simple == false)
            {
                Random rand = new Random((int)DateTime.Now.Ticks);
                a = rand.Next(100, 150);
                for (int i = 2; i <= Math.Sqrt(a); i++)
                {
                    if (a % i == 0)
                    {
                        simple = false;
                        break;
                    }
                    else if (last == 0)
                    {
                        last = a;
                        simple = true;
                    }
                    if (last != 0)
                    {
                        if (last != a)
                        {
                            last = a;
                            simple = true;
                        }
                    }
                }
            }
            return a;
        }
    }
    class ElGamal
    {
        private string mainString = "";
        private BigInteger buf_A;

        private char[] alphabit = new char[] { '.', ',', '!', '?', ' ', 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о',
        'п', 'р', 'с', 'т', 'у', 'ф', 'х','ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь','э', 'ю', 'я', '0', '1', '2', '3','4', '5', '6', '7', '8', '9', 'А', 'Б',  'В', 'Г',
         'Д', 'Е', 'Ё', 'Ж', 'З', 'И', 'Й', 'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С', 'Т', 'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ъ', 'Ы', 'Ь', 'Э', 'Ю', 'Я', 'a', 'b', 'c', 'd', 'e',
         'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M',
        'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'};
        public ElGamal(string mainString)
        {
            this.mainString = mainString;
        }
        public ElGamal()
        { }

        public string Encrypt(long p, long g, BigInteger y)
        {
            string result = null;
            List<string> resultList = new List<string>();
            BigInteger bi_a;
            long k = Calculate_k(p);
            BigInteger buf;
            buf = BigInteger.Pow(g, (int)k);
            bi_a = buf % p;
            buf_A = bi_a;
            BigInteger bi_b;
            buf = BigInteger.Pow(y, (int)k);
            for (int i = 0; i < mainString.Length; i++)
            {
                int index = Array.IndexOf(alphabit, mainString[i]);
                bi_b = (buf * index) % p;
                Console.Write(bi_b.ToString() + " ");
                resultList.Add(bi_b.ToString());
            }
            foreach (var item in resultList)
            {
                result += item + " ";
            }
            return result;
        }

        public string Decrypt(List<string> input, long x, long p, BigInteger buf_a)
        {
            this.buf_A = buf_a;
            string result = null;
            BigInteger bi;
            BigInteger A;
            BigInteger buf_b;
            foreach (string item in input)
            {
                buf_b = new BigInteger(Convert.ToDouble(item));
                A = BigInteger.Pow(buf_A, (int)(p - 1 - x));
                BigInteger p_ = new BigInteger((int)p);
                bi = (buf_b * A) % p_;
                int M = Convert.ToInt32(bi.ToString());
                result += alphabit[M].ToString();
            }
            return result;
        }


        private long Calculate_k(long p)
        {
            Random rand = new Random((int)DateTime.Now.Ticks);
            long k = rand.Next(1, (int)p - 1);
            return k;
        }

        public BigInteger GetBufA()
        {
            return buf_A;
        }
    }
}