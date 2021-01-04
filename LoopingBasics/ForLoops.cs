using System;

namespace LoopingBasics {

    /// <summary>
    /// Explains what for loops are as well as demonstrate a use case.
    /// </summary>
    internal class ForLoops {

        private static void Main(string[] args) {
            /* For loops executes a block of code a specified number of times.*/

            Console.Write("Please enter a number: ");
            int iterations = Convert.ToInt32(Console.ReadLine());
            int n = 0;
            int n2 = 1;
            int n3 = 0;

            for (int i = 0; i <= iterations; ++i) {
                n3 = n + n2;

                Console.WriteLine(n);

                n = n2;
                n2 = n3;
            }

            Console.WriteLine(" ");     //spacing

            //prevents Console from closing until user presses enter key
            Console.WriteLine("Press enter to close...");
            Console.ReadLine();
        }
    }
}