using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myNumbers = { 40, 30, 15, 18, 22 };
            myNumbers = BubbleSort(myNumbers);

            foreach (var number in myNumbers)
            {
                Console.Write($"{number}" + " ");
            }
            Console.ReadLine();
        }

        static int[] BubbleSort(int[] numbers)
        {
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] > numbers[j])
                    {
                        int temp = numbers[j];
                        numbers[j] = numbers[i];
                        numbers[i] = temp;
                    }
                }
            }

            return numbers;
        }
    }
}
