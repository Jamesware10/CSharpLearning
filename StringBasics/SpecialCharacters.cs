using System;
using System.Collections.Generic;
using System.Text;

namespace StringManipulationBasics
{
    class SpecialCharacters
    {
        static void Main(string[] args)
        {
            //Escape characters, prints double quotes, single quotes and forward slashes without confusing C#
            //     \" prints double quote - '"'
            //     \' prints apostrophe - '''
            //     \\ prints backslash - '\'

            //Other useful characters in C# include:
            //     \n - newline character
            //     \t - tab character
            //     \b - backslash character

            //string variables
            string proverb = "\"Wine and children speak the truth\"";
            string quote = "\"Never say you can\'t.\"";

            //Console showcase of special characters
            Console.WriteLine("Proverb: ");
            Console.WriteLine(proverb);

            Console.WriteLine(" ");     //spacing

            Console.WriteLine("Quote: ");
            Console.WriteLine(quote);

            Console.WriteLine(" ");     //spacing
            Console.WriteLine(" ");     //spacing

            Console.WriteLine("A little paragraph: ");
            string paragraph = $"\t Ancient greek proverb such as {proverb} \n " +
                $"were thought up by, people, people who introspectively and retrospectively \n " +
                $"reflect on different aspects of humanity, normal people like you and I are \n " +
                $"capable of deep thinking as well, so reflect, and remember what she once said,\n  \b{quote}";

            Console.WriteLine(paragraph);

            Console.WriteLine(" ");     //spacing

            //prevents Console from closing until user presses enter key
            Console.WriteLine("Press enter to close...");
            Console.ReadLine();
        }
    }
}