using System.Collections.Generic;
using System.Linq;

namespace ZKI
{
    class Wheatstone
    {
        private string mainString = "";
        private string encryptedString = "";
        private string keyTB_1;
        private string keyTB_2;
        private string alphabit = "";
        private List<string> bigrams = new List<string>();

        public Wheatstone(string mainString, string keyTB_1, string keyTB_2)
        {
            this.mainString = mainString;
            this.keyTB_1 = keyTB_1;
            this.keyTB_2 = keyTB_2;
        }

        public string Encrypt()
        {
            char[,] matrixAlphabit_1 = CreateTable(keyTB_1);
            char[,] matrixAlphabit_2 = CreateTable(keyTB_2);
            CreateBigrams();
            string bigram = "";
            int i_1 = 0, i_2 = 0, j_1 = 0, j_2 = 0;
            for (int k = 0; k < bigrams.Count; k++)
            {
                bigram = bigrams[k];
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        if (matrixAlphabit_1[i, j] == bigram[0])
                        {
                            i_1 = i;
                            j_1 = j;
                        }
                        if (matrixAlphabit_2[i, j] == bigram[1])
                        {
                            i_2 = i;
                            j_2 = j;
                        }
                    }
                }
                if (i_1 == i_2)
                {
                    encryptedString += matrixAlphabit_2[i_1, j_1];
                    encryptedString += matrixAlphabit_1[i_2, j_2];
                }
                else
                {
                    encryptedString += matrixAlphabit_2[i_1, j_2];
                    encryptedString += matrixAlphabit_1[i_2, j_1];

                }
                encryptedString += " ";
            }
            return encryptedString;
        }

        public string Decrypt()
        {
            char[,] matrixAlphabit_1 = CreateTable(keyTB_1);
            char[,] matrixAlphabit_2 = CreateTable(keyTB_2);
            CreateBigrams();
            string bigram = "";
            int i_1 = 0, i_2 = 0, j_1 = 0, j_2 = 0;
            for (int k = 0; k < bigrams.Count; k++)
            {
                bigram = bigrams[k];
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        if (matrixAlphabit_2[i, j] == bigram[0])
                        {
                            i_2 = i;
                            j_2 = j;

                        }
                        if (matrixAlphabit_1[i, j] == bigram[1])
                        {
                            i_1 = i;
                            j_1 = j;
                        }
                    }
                }
                if (i_1 == i_2)
                {
                    encryptedString += matrixAlphabit_1[i_2, j_2];
                    encryptedString += matrixAlphabit_2[i_1, j_1];
                }
                else
                {
                    encryptedString += matrixAlphabit_1[i_2, j_1];
                    encryptedString += matrixAlphabit_2[i_1, j_2];

                }
                encryptedString += " ";
            }
            return encryptedString;
        }

        public char[,] CreateTable(string key)
        {
            char[,] matrixAlphabit = new char[4, 8];
            key = key.ToLower();
            int index = 0;
            alphabit = "";
            for (int i = 0; i < key.Length; i++)
            {
                if (!alphabit.Contains(key[i]))
                {
                    alphabit += key[i];
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
            return matrixAlphabit;
        }

        private void CreateBigrams()
        {
            int chCounter = 0;
            mainString = mainString.ToLower();
            for (int i = 1; i < mainString.Length; i++)
            {
                if (mainString[i] == mainString[i - 1])
                {
                    mainString = mainString.Insert(i, "ъ");
                }
            }
            for (int i = 0; i < mainString.Length; i++)
            {
                if (mainString[i] >= 'а' && mainString[i] <= 'я')
                {
                    chCounter++;
                }
            }
            if (chCounter % 2 != 0)
            {
                mainString += "ъ";
            }
            string strBigrams = string.Empty;
            string bigram = string.Empty;
            for (int i = 0; i < mainString.Length; i++)
            {
                if (mainString[i] >= 'а' && mainString[i] <= 'я')
                {
                    bigram += mainString[i];
                }
                if (bigram.Length == 2)
                {
                    bigrams.Add(bigram + " ");
                    bigram = string.Empty;
                }
            }
        }
    }
}