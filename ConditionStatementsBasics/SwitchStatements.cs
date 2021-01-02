using System;

namespace ConditionStatementsBasics {

    internal class SwitchStatements {

        private static void Main(string[] args) {
            /* Switch statements are used to compare the value of a variable and compare it to
         various cases. The block of code associated with each case will execute if there is a match*/

            //generates a random integer
            Random rand = new Random();

            //numerical value of month is random
            int month = rand.Next(0, 13);

            Console.Write("Random month is ");

            //Prints a random month based on the value of the month variable
            switch (month) {
                case 1:
                    Console.Write("January");
                    break;

                case 2:
                    Console.Write("February");
                    break;

                case 3:
                    Console.Write("March");
                    break;

                case 4:
                    Console.Write("April");
                    break;

                case 5:
                    Console.Write("May");
                    break;

                case 6:
                    Console.Write("June");
                    break;

                case 7:
                    Console.Write("July");
                    break;

                case 8:
                    Console.Write("August");
                    break;

                case 9:
                    Console.Write("September");
                    break;

                case 10:
                    Console.Write("October");
                    break;

                case 11:
                    Console.Write("November");
                    break;

                case 12:
                    Console.Write("December");
                    break;

                default:
                    Console.Write("Undefined");
                    break;
            }
            Console.WriteLine(" ");     //spacing
            Console.WriteLine(" ");     //spacing

            //prevents Console from closing until user presses enter key
            Console.WriteLine("Press enter to close...");
            Console.ReadLine();
        }
    }
}