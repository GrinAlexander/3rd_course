using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ZKI
{
    class RSA
    {
        private string mainString = "";
        private string encryptedString = "";
        private long key_1;
        private long key_2;
        private long n;
        private long m;
        private long d;
        private long e_;
        private List<string> result = new List<string>();

        char[] alphabit = new char[] { '.', ',', '!', '?', ' ', 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о',
        'п', 'р', 'с', 'т', 'у', 'ф', 'х','ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь','э', 'ю', 'я', '0', '1', '2', '3','4', '5', '6', '7', '8', '9', 'А', 'Б',  'В', 'Г',
         'Д', 'Е', 'Ё', 'Ж', 'З', 'И', 'Й', 'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С', 'Т', 'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ъ', 'Ы', 'Ь', 'Э', 'Ю', 'Я', 'a', 'b', 'c', 'd', 'e',
         'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M',
        'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'};

        private List<string> bigrams = new List<string>();
        public RSA(string mainString, long key_1, long key_2)
        {
            this.mainString = mainString;
            this.key_1 = key_1;
            this.key_2 = key_2;
            n = this.key_1 * this.key_2;
            m = (this.key_1 - 1) * (this.key_2 - 1);
            d = Calculate_d(m);
            e_ = Calculate_e(d, m);
        }
        public RSA()
        { }
        public string Encrypt()
        {
            BigInteger bi;
            for (int i = 0; i < mainString.Length; i++)
            {
                int index = Array.IndexOf(alphabit, mainString[i]);
                bi = new BigInteger(index);
                bi = BigInteger.Pow(bi, (int)e_);
                BigInteger n_ = new BigInteger((int)n);
                bi = bi % n_;
                result.Add(bi.ToString());
            }
            foreach (var item in result)
            {
                encryptedString += item + " ";
            }
            return encryptedString;
        }
        public string Decrypt(List<string> input)
        {
            string result = "";
            BigInteger bi;
            foreach (string item in input)
            {
                bi = new BigInteger(Convert.ToDouble(item));
                bi = BigInteger.Pow(bi, (int)d);
                BigInteger n_ = new BigInteger((int)n);
                bi = bi % n_;
                int index = Convert.ToInt32(bi.ToString());
                result += alphabit[index].ToString();
            }
            return result;
        }
        private long Calculate_d(long m)
        {
            long d = m - 1;
            for (long i = 2; i <= m; i++)
                if ((m % i == 0) && (d % i == 0))
                {
                    d--;
                    i = 1;
                }
            return d;
        }
        private long Calculate_e(long d, long m)
        {
            long e = 10;
            while (true)
            {
                if ((e * d) % m == 1)
                    break;
                else
                    e++;
            }
            return e;
        }
        static public bool IsTheNumberSimple(long n)
        {
            if (n == 2 || n == 1)
                return true;
            if (n < 1)
                return false;
            for (long i = 2; i < n; i++)
                if (n % i == 0)
                    return false;
            return true;
        }
    }
}