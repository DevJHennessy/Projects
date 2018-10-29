using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeTest
{
    class Program
    {

        public static bool IsPalindrome(string wordValue)
        {
            int min = 0;
            int max = wordValue.Length - 1;

            //This is an infinite loop and will run as long as the program is active or
            //you exit it with a break, goto, return, or throw.

            while (true)
            {
                if (min > max)
                {
                    return true;
                }
                char a = wordValue[min];
                char b = wordValue[max];
                while (!char.IsLetterOrDigit(a))
                {
                    min++;
                    if (min > max)
                    {
                        return true;
                    }
                    a = wordValue[min];
                }

                while (!char.IsLetterOrDigit(b))
                {
                    max--;
                    if (min > max)
                    {
                        return true;
                    }
                    b = wordValue[max];
                }


                if (char.ToLower(a) != char.ToLower(b))
                {
                    return false;
                }
                min++;
                max--;
            }
        }

        static void Main()
        {
            string[] array =
            {
                //"A man, a plan, a canal: Panama.",
                //"Tod",
                "civic",
                "deified",
                "Hannah",
                "Kayak",
                "rotator",
                "Dot",
                "Net",
                "Palindrome",
                "A man, a plan, a canal: Panama."
            };

            foreach (var value in array)
            {
                Console.WriteLine($"{value} = {IsPalindrome(value)}");
            }

            Console.ReadLine();
        }


    }
}
