using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = "John Hennessy";

            for (int i = name.Length - 1; i >= 0; i--)
            {
                Console.Write(name[i]);

            }

            Console.ReadLine();
        }
    }
}
