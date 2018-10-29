using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnotherPalindromeTest
{
    class Program
    {
        static void Palindrome()
        {

        }

  

        static void Main(string[] args)
        {



            Console.WriteLine(IsPalindrome("madam"));
            Console.WriteLine(IsPalindrome("ABCDEFA"));
            Console.WriteLine(IsPalindrome("abcdcba"));
            Console.WriteLine(IsPalindrome("Lepers repel"));




            //This does not work for palindromes, must compare char

            //string wordsBefore = "Delia saw I was ailed";
            //string[] wordsWorking = wordsBefore.Split(new[] { ' ' }, 2);
            //string wordsAfter = string.Format("{1} {0}", wordsWorking);
            //string result = string.Join(" ", wordsAfter.Split(' ').Select(x => new string(x.Reverse().ToArray())));
            //if (result == wordsBefore)
            //{
            //    Console.WriteLine("This is a palindrome");
            //}

            Console.ReadLine();
        }

        public static bool IsPalindrome(string text)
        {
            return isPalindrome(0, text.Length - 1, text);
        }

        private static bool isPalindrome(int indexOfFirst, int indexOfLast, string text)
        {
            if (indexOfFirst >= indexOfLast)
            {
                return true;
            }
            if (text[indexOfFirst] != text[indexOfLast])
            {
                return false;
            }

            return isPalindrome(indexOfFirst + 1, indexOfLast - 1, text);
        }
    }
}
