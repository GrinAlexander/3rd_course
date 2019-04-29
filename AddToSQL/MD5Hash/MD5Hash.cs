using System;
using System.Text;
using System.Security.Cryptography;

namespace MD5Lib
{
    public static class MD5Hash
    {

        /// <summary>
        /// Метод преобразует приходящую строку в хеш-строку
        /// </summary>
        /// <param name="input">Строка, которую нужно хешировать</param>
        /// <returns></returns>
        public static string GetHash(string input)
        {
            MD5 md5 = MD5.Create();
            return Convert.ToBase64String(md5.ComputeHash(Encoding.UTF8.GetBytes(input)));
        }
    }
}