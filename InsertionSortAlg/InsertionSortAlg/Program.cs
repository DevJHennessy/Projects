using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSortAlg
{
    class Program
        //Iterate through a list of elements. Remove and Insert the element into the correct
        //position in the list of elements proceeding it.
    {



        static void Main(string[] args)
        {
            int[] numbersArray = { 40, 30, 18, 15, 22 };

            var insertionSort = new InsertionSort();

            Console.WriteLine("Original order of numbers:");
            foreach (var number in numbersArray)
            {
                Console.Write($"{number}" + " ");
            }
            Console.WriteLine("\nSorted order of numbers:");


            numbersArray = insertionSort.InsertionSortIntergers(numbersArray);
           
  
            foreach (var number in numbersArray)
            {
                Console.Write($"{number}" + " ");

            }

            float[] floatArray = { 4.22f, 3.25f, 1.81f, 4.18f, 3.91f };
            floatArray = insertionSort.InsertionSortFloats(floatArray);
            Console.WriteLine("\n");
            foreach (var number in floatArray)
            {
                Console.Write($"{number}" + " ");
            }


            Console.ReadLine();
        }

       
        
    }
}
