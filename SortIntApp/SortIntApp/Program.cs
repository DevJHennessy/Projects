using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortIntApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] intArray = { 53, 32, 19, 48, 56, 25 };

            //using sort helper method:

            //Array.Sort(intArray);

            //foreach (var number in intArray)
            //{
            //    Console.Write(number + " ");
            //}

            //Console.ReadLine();

            //Not using sort helper method:

            //int[] intArray = { 53, 32, 19, 48, 56, 25 };

            //bool didSwap;
            //do
            //{
            //    didSwap = false;
            //    for (int i = 0; i < intArray.Length - 1; i++)
            //    {
            //        if (intArray[i] > intArray[i + 1])
            //        {
            //            int temp = intArray[i + 1];
            //            intArray[i + 1] = intArray[i];
            //            intArray[i] = temp;
            //            didSwap = true;
            //        }
            //    }
            //} while (didSwap);
            //for (int i = 0; i != intArray.Length; i++)
            //{
            //    Console.Write(intArray[i] + " ");
            //}
            //Console.ReadLine();



            int[] intArray = { 53, 32, 19, 48 };
            int temp;

            for (int i = 0; i < intArray.Length - 1; i++)
            {
                for (int j = i + 1; j < intArray.Length; j++)
                {
                    if (intArray[i] > intArray[j]) 
                    {
                        temp = intArray[i];
                        intArray[i] = intArray[j];
                        intArray[j] = temp;
                      }
                }
            }

            foreach (var item in intArray)
            {
                Console.Write(item + " ");
            }
            Console.ReadLine();

        }


    }
}
