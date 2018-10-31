using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] myWords =
            {
                "Madam",
                "nurses. run",
                "Rip City",
                "Lol",
                "rose garden"
            };

            var palindrome = new Palindrome();

            foreach (var word in myWords)
            {
                Console.WriteLine($"{word} = {palindrome.IsPalindrome(word)}");
            }
            Console.ReadLine();
        }
    }
}
