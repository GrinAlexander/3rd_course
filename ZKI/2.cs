using System;
using System.Linq;
using System.Text;

//Гринь А.М., Т-716, Вариант 9
namespace ZKI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Шифр Цезаря:");
            First();
            Console.WriteLine();

            Console.WriteLine("2. Афинная система Цезаря:");
            Second();
            Console.WriteLine();

            Console.WriteLine("3. Шифр Цезаря с ключевым словом:");
            Third();
            Console.WriteLine();

            Console.WriteLine("4. Система Трисемуса:");
            Fourth();
            Console.WriteLine();
        }

        public static void First()
        {
            string strMain = "МЫ ДОЛЖНЫ ПРИЗНАТЬ ОЧЕВИДНОЕ: ПОНИМАЮТ ЛИШЬ ТЕ, КТО ХОЧЕТ ПОНЯТЬ";
            strMain = strMain.Replace("Ё", "Е");
            strMain = strMain.ToLower();
            char[] chMain = strMain.ToCharArray();
            char[] chEncrypted = chMain;
            int key = 9;
            for (int i = 0; i < chMain.Length; i++)
            {
                if (chMain[i] > 1071 && chMain[i] < 1078)
                {
                    chEncrypted[i] = (char)((chMain[i] + key - 1072) % 32 + 1071);
                }
                else if (chMain[i] >= 1078 && chMain[i] < 1104)
                {
                    chEncrypted[i] = (char)((chMain[i] + key - 1072) % 32 + 1072);
                }

                Console.Write(chEncrypted[i]);
            }
            Console.ReadLine();
        }

        public static void Second()
        {
            string strMain = "СМЫСЛ ЖИЗНИ НАШЕЙ – НЕПРЕРЫВНОЕ ДВИЖЕНИЕ";
            char[] chMain = strMain.Replace("Ё", "Е").ToLower().ToCharArray();
            char[] chEncrypted = chMain;
            int a = 5, b = 2;
            for (int i = 0; i < chMain.Length; i++)
            {
                if (chMain[i] > 1071 && chMain[i] < 1104)
                {
                    chEncrypted[i] = (char)((a * chMain[i] + b - 1072) % 32 + 1072);
                }
                Console.Write(chEncrypted[i]);

            }
            Console.ReadLine();
        }

        public static void Third()
        {
            string rusAlphabit = "абвгдежзийклмнопрстуфхцчшщъыьэюя";
            string strMain = "РАЗУМА ЛИШАЕТ НЕ СОМНЕНИЕ, А УВЕРЕННОСТЬ".Replace("Ё", "Е").ToLower();
            string strEncrypted = string.Empty;
            string cipherAlphabit = string.Empty;
            int key = 9;
            string keyWord = "ПРОГРАММИРОВАНИЕ".ToLower();

            char ch = (char)(1104 - key);
            int index = 0;
            while (ch <= 'я')
            {
                cipherAlphabit += ch;
                index++;
                ch++;
            }
            for (int i = 0; i < keyWord.Length; i++)
            {
                if (!cipherAlphabit.Contains(keyWord[i]))
                {
                    cipherAlphabit += keyWord[i];
                }
            }
            ch = 'а';
            while (ch <= 'я')
            {
                if (!cipherAlphabit.Contains(ch))
                {
                    cipherAlphabit += ch;
                }
                ch++;
            }
            for (int i = 0; i < strMain.Length; i++)
            {
                if (strMain[i] >= 'а' && strMain[i] <= 'я')
                {
                    strEncrypted += cipherAlphabit[rusAlphabit.IndexOf(strMain[i])];
                }
                else
                {
                    strEncrypted += strMain[i];
                }
            }
            Console.WriteLine(strMain);
            Console.Write(strEncrypted);

            Console.ReadLine();
        }

        public static void Fourth()
        {
            string strMain = "УСПЕХ – ЭТО КОГДА ТЫ ДЕВЯТЬ РАЗ УПАЛ, НО ДЕСЯТЬ РАЗ ПОДНЯЛСЯ".Replace("Ё", "Е").ToLower();
            char[] strEncrypted = strMain.ToCharArray();
            char[,] matrixAlphabit = new char[4, 8];
            string alphabit = string.Empty;
            string keyWord = "ПРОГРАММИРОВАНИЕ".ToLower();
            int index = 0;
            for (int i = 0; i < keyWord.Length; i++)
            {
                if (!alphabit.Contains(keyWord[i]))
                {
                    alphabit += keyWord[i];
                }
            }
            char ch = 'а';
            while (ch <= 'я')
            {
                if (!alphabit.Contains(ch))
                {
                    alphabit += ch;
                }
                ch++;
            }
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    matrixAlphabit[i, j] = alphabit[index];
                    index++;
                }
            }
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Console.Write(matrixAlphabit[i, j] + " ");
                }
                Console.WriteLine();
            }

            for (int k = 0; k < strMain.Length; k++)
            {
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        if (strMain[k] == matrixAlphabit[i,j])
                        {
                            if (i + 1 > 3)
                            {
                                strEncrypted[k]= matrixAlphabit[0, j];
                            }
                            else if (i + 1 <= 3)
                            {
                                strEncrypted[k] = matrixAlphabit[i + 1, j];
                            }
                        }
                    }
                }
            }
            Console.WriteLine(strMain);
            Console.WriteLine(strEncrypted);
            Console.ReadLine();
        }
    }
}
