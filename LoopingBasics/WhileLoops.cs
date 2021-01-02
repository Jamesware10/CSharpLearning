using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopingBasics {
    class WhileLoops {
        static void Main(string[] args) {

            /* While loops executes a block of code over an over until the specified condition 
            *returns false. This is good for prompting for user input or any situation where 
            *the amount of iterations are unknown. */

            int j = 0;

            while (j < 11) {
                Console.WriteLine(j);
                j++;
            }

            Console.WriteLine("");


            Console.WriteLine(" ");     //spacing

            //prevents Console from closing until user presses enter key
            Console.WriteLine("Press enter to close...");
            Console.ReadLine();
        }
    }
}
