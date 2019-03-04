using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZKI
{
    class Vigenere
    {
        private string mainString;
        private string decryptedString = "";
        private string keyTB;
        private string key;

        public Vigenere(string mainString, string keyTB)
        {
            this.mainString = mainString;
            this.keyTB = keyTB;
        }

        public string Encrypt()
        {
            KeyFormation();
            for (int i = 0; i < mainString.Length; i++)
            {
                if (mainString[i] >= 'а' && mainString[i] <= 'я')
                {
                    decryptedString += (char)((mainString[i] + key[i]) % 32 + 'а');
                }
                else
                {
                    decryptedString += mainString[i];
                }
            }
            return decryptedString;
        }

        private void KeyFormation()
        {
            for (int i = 0; i < keyTB.Length; i++)
            {
                if (keyTB[i] < 'а' || keyTB[i] > 'я')
                {
                    keyTB = keyTB.Remove(i, 1);
                    i--;
                }

            }
            for (int i = 0; i < mainString.Length; i++)
            {
                if (mainString[i] < 'а' || mainString[i] > 'я')
                {
                    mainString = mainString.Remove(i, 1);
                    i--;
                }

            }
            key = keyTB;
            for (int i = 0; i < key.Length; i++)
            {
                if (key.Length == mainString.Length)
                {
                    break;
                }
                else
                {
                    key += key[i];
                }
            }
        }
    }
}
