using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSortAlg
{
    public class InsertionSort
    {
        public int[] InsertionSortIntergers(int[] numbers)
        {
            for (int i = 1; i < numbers.Length; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    if (numbers[j] < numbers[j - 1])
                    {
                        int temp = numbers[j];
                        numbers[j] = numbers[j - 1];
                        numbers[j - 1] = temp;
                    }
                }
            }

            return numbers;
        }

        public float[] InsertionSortFloats(float[] numbers)
        {
            for (int i = 1; i < numbers.Length; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    if (numbers[j] < numbers[j - 1])
                    {
                        float temp = numbers[j];
                        numbers[j] = numbers[j - 1];
                        numbers[j - 1] = temp;
                    }
                }
            }

            return numbers;
        }
    }
}
