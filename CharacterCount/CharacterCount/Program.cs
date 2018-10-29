using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCount
{
    class Program
    {
        static void Main(string[] args)
        {


            var characterCount = new CharacterCount();

            string phrase = "cat calls with 4dogSs.....";


            //characterCount.CharacterCountAlg(phrase);
            //foreach (var item in phrase)
            //{
            //    Console.WriteLine(characterCount.CharacterCountAlg(phrase));
            //}
            Console.WriteLine(characterCount.CharacterCountAlg(phrase));
            Console.ReadLine();

        }
    }
}
