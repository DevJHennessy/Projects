using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myNumbers = { 40, 30, 18, 15, 22 };
            myNumbers = QuickSort(myNumbers);

            foreach (var number in myNumbers)
            {
                Console.Write($"{number}" + " ");
            }
            Console.ReadLine();
        }

        public static int[] QuickSort(int[] data)
        {
            QSort(data, 0, data.Length - 1);
            return data;
        }

        private static void QSort(int[] data, int low, int high)
        {
            int i = low;
            int j = high;
            int mid = low + (high - low) / 2;
            int pivot = data[mid];

            while (i <= j)
            {
                while (data[i] < pivot)
                {
                    i++;
                }

                while (data[j] > pivot)
                {
                    j--;
                }

                if (i <= j)
                {
                    int temp = data[i];
                    data[i] = data[j];
                    data[j] = temp;

                    i++;
                    j--;
                }

            }

            if (low < j)
            {
                QSort(data, low, j);
            }
            if (i < high)
            {
                QSort(data, i, high);
            }

        }
        
    }
}
