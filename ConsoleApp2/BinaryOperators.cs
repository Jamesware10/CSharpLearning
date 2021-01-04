using System;

namespace CSharpOperatorsBasics {
    class BinaryOperators {
        /// <summary>
        /// Showcase of Binary Operators in C#
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args) {
            //Binary operators use two or values to perform operations
            int addition = 4 + 1;           // '+' adds two values
            int subtract = 9 - 7;           // '-' finds the difference between two values
            int multiply = 7 * 5;           // '*' multiplies two values
            int divide = 8 / 2;             // '/' divides first value by the second
            int modulus = 10 % 6;           // '%' finds the division remainder

            //Console demo
            int num1 = 10;
            int num2 = 6;

            //results of operation
            int sum = num1 + num2;
            int difference = num1 - num2;
            int product = num1 * num2;
            int division = num1 / num2;
            int remainder = num1 % num2;

            Console.WriteLine("Binary Operators showcase");

            Console.WriteLine(" ");
            //note: '+' can also be used to concactenate strings
            Console.WriteLine(num1 + " + " + num2 + " = " + sum);
            Console.WriteLine(num1 + " - " + num2 + " = " + difference);
            Console.WriteLine(num1 + " * " + num2 + " = " + product);
            Console.WriteLine(num1 + " / " + num2 + " = " + division);
            Console.WriteLine(num1 + " % " + num2 + " = " + remainder);

            Console.WriteLine(" ");     //spacing

            //prevents Console from closing until user presses enter key
            Console.WriteLine("Press enter to close...");
            Console.ReadLine();
        }
    }
}