using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursivelyReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "John Hennessy";
            name = RecursivelyReverseString(name);
            Console.WriteLine(name);
            Console.ReadLine();
        }

        static string RecursivelyReverseString(string word)
        {

            if (word.Length > 0)
            {
                return word[word.Length - 1] + RecursivelyReverseString(word.Substring(0, word.Length - 1));
            }
            else
            {
                return word;
            }
        }

        
    }
}
