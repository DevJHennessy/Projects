using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCount
{
    public class CharacterCount
    {
        string result;

       public string CharacterCountAlg(string words)
        {
            
            char character;

            for (character = (char)32; character  <= 128; character++)
            {
                int counter = 0;

                for (int i = 0; i < words.Length; i++)
                {
                    if (character == words[i])
                    {
                        counter++;
                    }
                }

                if (counter > 0)
                {
                    result += string.Format("{0}" + " = " + "{1}\n", character, counter);
                    //return result;
                    //Console.WriteLine(character + " = " + counter);
                }
            }
            return result;


        }

    }
}
