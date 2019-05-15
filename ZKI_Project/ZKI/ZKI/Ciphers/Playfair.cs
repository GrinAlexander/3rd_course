using System.Collections.Generic;
using System.Linq;

namespace ZKI.Ciphers
{
    class Playfair
    {
        private string mainString = "";
        private string result = "";
        private string keyTB_1;
        private string alphabit = "";
        private List<string> bigrams = new List<string>();

        public Playfair(string mainString, string keyTB_1)
        {
            this.mainString = mainString;
            this.keyTB_1 = keyTB_1;
        }

        public string Encrypt()
        {
            char[,] matrixAlphabit = CreateTable(keyTB_1);
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
                        result += matrixAlphabit[i_1, 0];
                        result += matrixAlphabit[i_2, j_2 + 1];
                    }
                    else if (j_2 == 7)
                    {
                        result += matrixAlphabit[i_1, j_1 + 1];
                        result += matrixAlphabit[i_2, 0];
                    }
                    else
                    {
                        result += matrixAlphabit[i_1, j_1 + 1];
                        result += matrixAlphabit[i_2, j_2 + 1];

                    }
                }
                else if (j_1 == j_2)
                {
                    if (i_1 == 3)
                    {
                        result += matrixAlphabit[0, j_1];
                        result += matrixAlphabit[i_2 + 1, j_2];
                    }
                    else if (i_2 == 3)
                    {
                        result += matrixAlphabit[i_1 + 1, j_1];
                        result += matrixAlphabit[0, j_2];
                    }
                    else
                    {
                        result += matrixAlphabit[i_1 + 1, j_1];
                        result += matrixAlphabit[i_2 + 1, j_2];

                    }
                }
                else if ((i_1 != i_2) && (j_1 != j_2))
                {
                    result += matrixAlphabit[i_1, j_2];
                    result += matrixAlphabit[i_2, j_1];
                }
                result += " ";
            }
            return result;
        }

        public string Decrypt()
        {
            char[,] matrixAlphabit = CreateTable(keyTB_1);

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
                    if (j_1 == 0)
                    {
                        result += matrixAlphabit[i_1, 7];
                        result += matrixAlphabit[i_2, j_2 - 1];
                    }
                    else if (j_2 == 0)
                    {
                        result += matrixAlphabit[i_1, j_1 - 1];
                        result += matrixAlphabit[i_2, 7];
                    }
                    else
                    {
                        result += matrixAlphabit[i_1, j_1 - 1];
                        result += matrixAlphabit[i_2, j_2 - 1];
                        
                    }
                }
                else if (j_1 == j_2)
                {
                    if (i_1 == 0)
                    {
                        result += matrixAlphabit[3, j_1];
                        result += matrixAlphabit[i_2 - 1, j_2];
                        
                        
                    }
                    else if (i_2 == 0)
                    {
                        result += matrixAlphabit[i_1 - 1, j_1];
                        result += matrixAlphabit[3, j_2];
                        
                    }
                    else
                    {
                        result += matrixAlphabit[i_1 - 1, j_1];
                        result += matrixAlphabit[i_2 - 1, j_2];
                        
                    }
                }
                else if ((i_1 != i_2) && (j_1 != j_2))
                {
                    result += matrixAlphabit[i_1, j_2];
                    result += matrixAlphabit[i_2, j_1];
                    
                }
                result += " ";
            }

            return result;
        }

        public char[,] CreateTable(string key)
        {
            char[,] matrixAlphabit = new char[4, 8];
            key = key.ToLower();
            int index = 0;
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