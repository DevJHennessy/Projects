using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewInsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myNumbers = { 40, 30, 15, 17, 22 };
            var sort = new InsertionSort();

            myNumbers = sort.InsertionSortAlg(myNumbers);

            foreach (var number in myNumbers)
            {
                Console.Write($"{number}" + " ");
            }
            Console.ReadLine();
        }
    }
}
