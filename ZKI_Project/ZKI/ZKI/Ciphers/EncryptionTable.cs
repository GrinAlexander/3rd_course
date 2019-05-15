using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZKI.Ciphers
{
    class EncryptionTable
    {
        private string mainString;
        private string result;
        private string key;
        private int m;
        private int n;
        private char[,] matrixOfChar;
        public EncryptionTable(string mainString, string key)
        {
            this.mainString = mainString;
            this.key = key;
            this.n = this.key.Length;
            if (this.mainString.Length % this.key.Length == 0)
            {
                this.m = (int)(this.mainString.Length / this.key.Length) + 1;
            }
            else
            {
                this.m = (int)(this.mainString.Length / this.key.Length) + 2;
            }
        }
        public string Encrypt()
        {
            string result = "";
            matrixOfChar = new char[m, n];
            FormString();
            int index = 0;
            for (int j = 0; j < n; j++)
            {
                matrixOfChar[0, j] = key[j];
            }
            for (int j = 0; j < n; j++)
            {
                for (int i = 1; i < m; i++)
                {
                    matrixOfChar[i, j] = mainString[index];
                    index++;
                }
            }

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrixOfChar[i, j]);
                }
                Console.WriteLine();
            }

            char indexCh = 'а';
            for (int i = 1; i < m; i++)
            {
                while (indexCh <= 'я')
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (indexCh == matrixOfChar[0, j] && matrixOfChar[i, j] != '1')
                        {
                            result += matrixOfChar[i, j];
                        }
                    }
                    indexCh++;
                }
                indexCh = 'а';
            }
            return result;
        }

        public string Decrypt()
        {
            string result = "";
            matrixOfChar = new char[m, n];
            FormArray();
            int index = 0;
            for (int j = 0; j < n; j++)
            {
                matrixOfChar[0, j] = key[j];
            }

            char indexCh = 'а';
            for (int i = 1; i < m; i++)
            {
                while (indexCh <= 'я')
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (indexCh == matrixOfChar[0, j] && matrixOfChar[i, j] != '1')
                        {
                            matrixOfChar[i, j] = mainString[index];
                            index++;
                        }
                    }
                    indexCh++;
                }
                indexCh = 'а';
            }

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrixOfChar[i, j]);
                }
                Console.WriteLine();
            }

            for (int j = 0; j < n; j++)
            {
                for (int i = 1; i < m; i++)
                {
                    if (matrixOfChar[i, j] != '1')
                    {
                        result += matrixOfChar[i, j];
                    }
                }
            }
            return result;
        }

        private void FormString()
        {
            for (int i = 0; i < mainString.Length; i++)
            {
                if (mainString.Length == this.m * this.n)
                {
                    break;
                }
                else
                {
                    mainString += "1";
                }
            }
        }
        private void FormArray()
        {
            int cnt = 0;
            for (int j = n - 1; j > 0; j--)
            {
                for (int i = m - 1; i > 0; i--)
                {
                    if (cnt + mainString.Length == (m - 1) * n)
                    {
                        break;
                    }
                    matrixOfChar[i, j] = '1';
                    cnt++;
                }
            }
        }
    }
}