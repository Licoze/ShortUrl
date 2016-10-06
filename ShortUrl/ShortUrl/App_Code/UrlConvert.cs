using System;
using System.Linq;


namespace ShortUrl
{
    public static class UrlConvert
    {
        private static readonly char[] _alphabet = {'0','1','2','3','4','5','6','7','8','9',
            'A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z',
            'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z'};
        private static readonly int _target_base = _alphabet.Length;


        public static string FromDecimal(this int num)
        {
            string result = string.Empty;
            do
            {
                result = _alphabet[num % _target_base] + result;
                num = num / _target_base;
            }
            while (num > 0);
            
            return result;
        }
        public static int ToDecimal(this string str)
        {
            char[] data = str.ToCharArray();
            int data_length = data.Length;
            int result = 0;
            for (int i = 0; i < data_length; i++)
            {
                result += _alphabet.ToList().IndexOf(data[data_length - i - 1]) * (int)Math.Pow(_target_base, i);
            }
            return result;
        }
    }
}