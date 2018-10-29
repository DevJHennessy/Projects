using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewPalindrome
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Palindrome palindrome = new Palindrome();
            
            string[] myWords =
            {
                "Madam",
                "Maggy",
                "Rip City",
                "nurses. run",
                "Billy"
            };

            foreach (var word in myWords)
            {
                Console.WriteLine($"{word} = {palindrome.IsPalindrome(word)}");
            }
            Console.ReadLine();

        }

    
    }
}
