using System;

namespace ConditionStatementsBasics {

    internal class IfStatements {

        private static void Main(string[] args) {
            /*'If statements' are used to check whether certain conditions
            *return true or false and executes a block of code if the condition
            *specified returns true.
            *
            *'Else statements' would execute if the condition of the previous statement
            *is false.
            *
            *'Else if' statements specifies an alternate block of code to be execute if the
            *previous 'if condition' and/or if the previous 'Else if conditions' return false
            *and the current 'Else if' condition is true.
            */

            int a = 10, b = 9;

            //If a is equal to b, execute first block of code
            //If a is not equal to b, execute second block
            if (a == b) {
                Console.WriteLine("a is equal to b");
                Console.WriteLine(" ");
            } else {
                Console.WriteLine("a is not equal to b");
                Console.WriteLine(" ");
            }

            //If a is greater than b, execute first block of code
            //If a is lesser than b, execute second block
            if (a > b) {
                Console.WriteLine("a is greater than b");
                Console.WriteLine(" ");
            } else if (a < b) {
                Console.WriteLine("is a less than b");
                Console.WriteLine(" ");
            }

            Console.WriteLine("<--------------------------------------------------------------------->");

            //<!--------------------Second section-------------------------->

            Console.WriteLine(" ");

            Random randomNum1 = new Random(), randomNum2 = new Random();

            int x = randomNum1.Next(0, 11);
            int y = randomNum2.Next(0, 11);

            if (x == y) {
                Console.WriteLine("x is equal to y");
                Console.WriteLine(" ");
            } else {
                Console.WriteLine("x is not equal to y");
                Console.WriteLine(" ");
            }

            //If a is greater than b, execute first block of code
            //If a is lesser than b, execute second block
            if (x > y) {
                Console.WriteLine("x is greater than y");
                Console.WriteLine(" ");
            } else if (x < y) {
                Console.WriteLine("x is a less than y");
                Console.WriteLine(" ");
            }
            Console.WriteLine(" ");
            Console.WriteLine($"x was {x}, and y was {y}");

            Console.WriteLine(" ");     //spacing

            //prevents Console from closing until user presses enter key
            Console.WriteLine("Press enter to close...");
            Console.ReadLine();
        }
    }
}