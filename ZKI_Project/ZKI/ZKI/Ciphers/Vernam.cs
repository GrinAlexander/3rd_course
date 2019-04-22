using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZKI
{
    class Vernam
    {
        private string mainString;
        private string result = "";
        private string key;

        public Vernam(string mainString, string key)
        {
            this.mainString = mainString;
            this.key = key;
        }

        public string Encrypt()
        {
            FormKey();
            for (int i = 0; i < mainString.Length; i++)
            {
                result += (char)((int)mainString[i] ^ (int)key[i]);
            }
            return result;
        }

        public string Decrypt()
        {
            FormKey();
            for (int i = 0; i < mainString.Length; i++)
            {
                result += (char)((int)mainString[i] ^ (int)key[i]);
            }
            return result;
        }

        private void FormKey()
        {
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
