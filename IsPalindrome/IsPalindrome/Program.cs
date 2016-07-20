using System;
using System.Text.RegularExpressions;

namespace IsPalindrome
{
    class Program
    {
        public static bool IsPalindrome(string str)
        {
            //str = new string(str.Where(char.IsLetter).ToArray());
            str = Regex.Replace(str, "[^a-zA-Z]", string.Empty);

            var original = str.ToLower().Replace(" ", "").Replace(".", "");
            var reverse = "";
            for (var i = original.Length - 1; i >= 0; i--)
            {
                reverse += original[i];
            }

            if (original == reverse)
            {
                return true;
            }

            return false;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(IsPalindrome("Noel sees Leon."));
        }
    }
}
