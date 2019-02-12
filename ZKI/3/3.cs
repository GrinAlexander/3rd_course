using System;
using System.Collections.Generic;
using System.Linq;

//Гринь А.М., Т-716, Вариант 9
namespace ZKI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Шифр Виженера:");
            First();
            Console.WriteLine();
        }

        public static void First()
        {
            string strMain = "Криптосистема является криптостойкой, если предпринятые криптоаналитические атаки не достигают поставленных целей".Replace("Ё", "Е").ToLower();
            Console.WriteLine(strMain);
            string strEncrypted = string.Empty;
            char[,] matrixAlphabit = new char[4, 8];
            string alphabit = string.Empty;
            string keyWord = "КОМПЬЮТЕР".ToLower();
            List<string> bigrams = new List<string>();
            int index = 0;
            int chCounter = 0;
            //создаём таблицу для шифрования
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
            //проеряем строку, если есть повторяющиеся символы, то вставляем "Ъ"
            for (int i = 1; i < strMain.Length; i++)
            {
                if (strMain[i] == strMain[i - 1])
                {
                    strMain = strMain.Insert(i, "ъ");
                }

            }

            //находим количество букв в строке
            for (int i = 0; i < strMain.Length; i++)
            {
                if (strMain[i] >= 'а' && strMain[i] <= 'я')
                {
                    chCounter++;
                }
            }
            //проверяем количество букв на чётность, если не чётно, то вставляем "Ъ" в конец, чтобы получились полные биграммы
            if (chCounter % 2 != 0)
            {
                strMain += "ъ";
            }

            //создаём строку из биграмм
            string strBigrams = string.Empty;
            string bigram = string.Empty;
            for (int i = 0; i < strMain.Length; i++)
            {
                if (strMain[i] >= 'а' && strMain[i] <= 'я')
                {
                    bigram += strMain[i];
                }
                if (bigram.Length == 2)
                {
                    bigrams.Add(bigram + " ");
                    bigram = string.Empty;
                }
            }

            //сам алгоритм шифрования
            int i_1 = 0, i_2 = 0, j_1 = 0, j_2 = 0;
            for (int k = 0; k < bigrams.Count; k++)
            {
                bigram = bigrams[k];
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        if (matrixAlphabit[i, j] == bigram[0])
                        {
                            i_1 = i;
                            j_1 = j;
                        }
                        if (matrixAlphabit[i, j] == bigram[1])
                        {
                            i_2 = i;
                            j_2 = j;
                        }
                    }
                }
                if (i_1 == i_2)
                {
                    if (j_1 == 7)
                    {
                        strEncrypted += matrixAlphabit[i_1, 0];
                        strEncrypted += matrixAlphabit[i_2, j_2 + 1];
                    }
                    else if (j_2 == 7)
                    {
                        strEncrypted += matrixAlphabit[i_1, j_1 + 1];
                        strEncrypted += matrixAlphabit[i_2, 0];
                    }
                    else
                    {
                        strEncrypted += matrixAlphabit[i_1, j_1 + 1];
                        strEncrypted += matrixAlphabit[i_2, j_2 + 1];

                    }
                }
                else if (j_1 == j_2)
                {
                    if (i_1 == 3)
                    {
                        strEncrypted += matrixAlphabit[0, j_1];
                        strEncrypted += matrixAlphabit[i_2 + 1, j_2];
                    }
                    else if (i_2 == 3)
                    {
                        strEncrypted += matrixAlphabit[i_1 + 1, j_1];
                        strEncrypted += matrixAlphabit[0, j_2];
                    }
                    else 
                    {
                        strEncrypted += matrixAlphabit[i_1 + 1, j_1];
                        strEncrypted += matrixAlphabit[i_2 + 1, j_2];

                    }
                }
                else if((i_1 != i_2) && (j_1 != j_2))
                {
                    strEncrypted += matrixAlphabit[i_1, j_2];
                    strEncrypted += matrixAlphabit[i_2, j_1];
                }
                strEncrypted += " ";
            }

            //вывод результатов
            Console.WriteLine(strMain);
            foreach (string item in bigrams)
            {
                Console.Write(item);
            }
            Console.WriteLine("\n" + strEncrypted);
            Console.ReadLine();
        }
    }
}
