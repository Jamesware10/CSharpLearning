using System;

namespace MethodsAndClassesBasics {

    /// <summary>
    /// Explains what a method is an demonstrates and how it can be useful.
    /// </summary>
    internal class Methods {
        /* This is the main function. It is always called when running a program and serves as
         * the main entry point to a program*/

        private static void Main(string[] args) {
            Console.WriteLine("Methods are being called!");
            Console.WriteLine(" ");     //spacing

            // Methods are called by referring to their signature

            MyMethod();
            MyMethod("Jane");
            Console.WriteLine(DisplayNumber());
            Console.WriteLine(AddNumbers(35, 10));

            Console.WriteLine(" ");     //spacing

            // prevents Console from closing until user presses enter key
            Console.WriteLine("Press enter to close...");
            Console.ReadLine();
        }

        // This method does not have a parameter nor a return type
        private static void MyMethod() {
            Console.WriteLine("Cheers, mate!");
        }

        // This method has a parameter, but not a return type
        private static void MyMethod(string name) {
            Console.WriteLine($"Cheers, {name}!", name);
        }

        // This method does not have a parameter, but has a return type of int
        private static int DisplayNumber() {
            return 19;
        }

        // This method has two parameters and a return type of int
        private static int AddNumbers(int num1, int num2) {
            return num1 + num2;
        }

        /* NOTE:
         * Methods can have the same name(method name before parenthesis)
         * but not the same signature(method name and parameters within parenthesis)*/
    }
}