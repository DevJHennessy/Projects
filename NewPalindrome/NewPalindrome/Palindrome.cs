using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewPalindrome
{
    public class Palindrome
    {
        public bool IsPalindrome(string wordOrPhrase)
        {
            int min = 0;
            int max = wordOrPhrase.Length - 1;

            while (true)
            {
                if (min > max)
                {
                    return true;
                }

                char a = wordOrPhrase[min];
                char b = wordOrPhrase[max];

                while (!char.IsLetterOrDigit(a))
                {
                    min++;
                    if (min > max)
                    {
                        return true;
                    }
                }

                while (!char.IsLetterOrDigit(b))
                {
                    max--;
                    if (min > max)
                    {
                        return true;
                    }
                }

                if (char.ToLower(a) != char.ToLower(b))
                {
                    return false;
                }

                min++;
                max--;

            }
        }
    }
}
