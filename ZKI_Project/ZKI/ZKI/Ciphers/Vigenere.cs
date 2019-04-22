namespace ZKI
{
    class Vigenere
    {
        private string mainString;
        private string result = "";
        private string keyTB;
        private string key;

        public Vigenere(string mainString, string keyTB)
        {
            this.mainString = mainString;
            this.keyTB = keyTB;
        }

        public string Encrypt()
        {
            result = null;
            KeyFormation();
            for (int i = 0; i < mainString.Length; i++)
            {
                if (mainString[i] >= 'а' && mainString[i] <= 'я')
                {
                    result += (char)((mainString[i] + key[i]) % 32 + 'а');
                }
                else
                {
                    result += mainString[i];
                }
            }
            return result;
        }

        public string Decrypt()
        {
            result = null;
            KeyFormation();
            for (int i = 0; i < mainString.Length; i++)
            {
                if (mainString[i] >= 'а' && mainString[i] <= 'я')
                {
                    result += (char)((mainString[i] - key[i]) % 32 + 'а');
                }
                else
                {
                    result += mainString[i];
                }
            }
            return result.ToLower();
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
