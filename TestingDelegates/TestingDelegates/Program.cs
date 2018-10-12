using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingDelegates
{
    delegate double MathAction(double num);
    class Program
    {
        // Named method (Double)
        static double Double(double input)
        {
            return input * 2;
        }

        static void Main(string[] args)
        {
            // Instantiate/Encapsulating named method
            MathAction maVar = Double;

            double multByTwo = maVar(4.5);
            Console.WriteLine($"The number 4.5 multiplied by two: {multByTwo}.");

            // Instantiate/Encapsulating anonymous method
            MathAction maVar2 = delegate (double input)
            {
                return input * input;
            };
            double squareTheNumber = maVar2(10);
            Console.WriteLine($"The number 10 squared: {squareTheNumber}.");

            // Instantiate delegate with lambda expression
            MathAction maVar3 = c => c * c * c;
            double cubeTheNumber = maVar3(7.885);
            Console.WriteLine($"The number 7.885 cubed: {cubeTheNumber}.");

            Console.ReadLine();
        }
        
    }
}
