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
        public EncryptionTable(string mainString, string key)
        {
            this.mainString = mainString;
            this.key = key;
            this.m = this.key.Length;
            this.n = (int)(this.mainString.Length / this.key.Length) + 1 ;
        }
        public string Encrypt()
        {
            string result = "";
            string strDecrypted = mainString.Replace(' ', '_');
            char[,] matrixOfChar = new char[6, 8];

            int index = 0;
            for (int j = 0; j < 8; j++)
            {
                matrixOfChar[0, j] = key[j];
            }
            for (int j = 0; j < 8; j++)
            {
                for (int i = 1; i < 6; i++)
                {
                    matrixOfChar[i, j] = strDecrypted[index];
                    index++;
                }
            }

            char indexCh = 'а';
            result = null;
            while (indexCh <= 'я')
            {
                for (int j = 0; j < 8; j++)
                {
                    for (int i = 1; i < 6; i++)
                    {
                        if (indexCh == matrixOfChar[0, j])
                        {
                            result += matrixOfChar[i, j];
                        }
                    }
                }
                indexCh++;
            }
            return result;
        }
        private void FormKey()
        {
            for (int i = 0; i < key.Length; i++)
            {
                if (key.Length == 8)
                {
                    break;
                }
                else
                {
                    key += key[i];
                }
            }
        }
        private void FormString()
        {
            if (mainString.Length > 40)
            {
                mainString = mainString.Remove(40);
                return;
            }
            for (int i = 0; i < mainString.Length; i++)
            {
                if (mainString.Length == 40)
                {
                    break;
                }
                else
                {
                    mainString += mainString[i];
                }
            }
        }
    }
}
