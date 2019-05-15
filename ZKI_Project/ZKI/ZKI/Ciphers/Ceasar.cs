namespace ZKI
{
    class Ceasar
    {
        private string mainString;
        private string result = "";
        private int key;

        public Ceasar(string mainString, int key)
        {
            this.mainString = mainString;
            this.key = key;
        }

        public string Encrypt()
        {
            result = null;
            for (int i = 0; i < mainString.Length; i++)
            {
                if (mainString[i] > 1071 && mainString[i] < 1078)
                {
                    result+= (char)((mainString[i] + key - 1071) % 32 + 1071);
                }
                else if (mainString[i] >= 1078 && mainString[i] < 1104)
                {
                    result += (char)((mainString[i] + key - 1072) % 32 + 1072);
                }
            }
            return result.ToLower();
        }

        public string Decrypt()
        {
            result = null;
            for (int i = 0; i < mainString.Length; i++)
            {
                if (mainString[i] > 1071 && mainString[i] < 1078)
                {
                    result += (char)((mainString[i] - key - 1071) % 32 + 1071);
                }
                else if (mainString[i] >= 1078 && mainString[i] < 1104)
                {
                    result += (char)((mainString[i] - key - 1072) % 32 + 1072);
                }
            }
            return result.ToLower();
        }
    }
}