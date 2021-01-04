using System;
using System.Linq;

namespace ArraysBasics {

    /// <summary>
    /// Explains what Arrays are and some demonstrates its use cases. A few useful methods
    /// and properties also explained and demostrated as well
    /// </summary>
    internal class Program {

        private static void Main(string[] args) {
            //Arrays are a special type that holds a collection of values

            //<-----------------------------------MAKING ARRAYS---------------------------------->

            //empty array
            char[] alphabet;

            //array of numbers
            int[] numbers = { 12, 4, 376, 9, 24, 454, 283, 9230, 56 };

            //array of strings
            string[] progLangs = { "Java", "C#", "JavaScript", "Python" };

            //<-----------------------------------USING ARRAYS---------------------------------->

            //accessing values from array (uses zero based indexing)
            Console.WriteLine(progLangs[0]);

            //change value within an array
            Console.WriteLine(progLangs[2]);
            progLangs[2] = "TypeScript";
            Console.WriteLine(progLangs[2]);

            //display the length of an array
            Console.WriteLine(numbers.Length);

            Console.WriteLine(" ");

            //loop through an array using forloop
            for (int i = 0; i < numbers.Length; i++) {
                Console.Write(numbers[i] + ", ");
            }

            Console.WriteLine(" ");

            //loop through an array using foreach loop
            foreach (string i in progLangs) {
                Console.Write(i + ", ");
            }

            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("Sorting Arrays");
            Console.WriteLine(" ");

            //sorting an array
            Array.Sort(progLangs);
            foreach (string i in progLangs) {
                Console.Write(i + ", ");
            }

            Console.WriteLine(" ");

            Array.Sort(numbers);
            foreach (int i in numbers) {
                Console.Write(numbers[i] + ", ");
            }

            Console.WriteLine(" ");
            Console.WriteLine(" ");

            //Other useful array methods
            Console.Write("Smallest value is: ");
            Console.Write(numbers.Min());
            Console.WriteLine(" ");     //spacing
            Console.Write("Largest value is: ");
            Console.Write(numbers.Max());
            Console.WriteLine(" ");     //spacing
            Console.Write("Sum of values in number array is: ");
            Console.Write(numbers.Sum());

            Console.WriteLine(" ");     //spacing
            Console.WriteLine(" ");     //spacing

            //prevents Console from closing until user presses enter key
            Console.WriteLine("Press enter to close...");
            Console.ReadLine();
        }
    }
}