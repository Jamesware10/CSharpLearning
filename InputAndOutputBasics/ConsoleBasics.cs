using System;

namespace ConsoleBasics {

    /// <summary>
    /// The purpose of this class is to displaying information in
    /// the Console as well ass getting user Input
    /// </summary>
    internal class ConsoleBasics {

        private static void Main(string[] args) {
            //Displays information to Console
            Console.WriteLine("Please Enter Nickname: ");

            //Gets input from user and stores it in a string variable
            string userInput = Console.ReadLine();

            Console.WriteLine(" ");     //spacing

            //prints user nickname with a comment
            Console.WriteLine(userInput + " is a kewl nickname.");

            //Alternatively, you can use string interpolation
            Console.WriteLine($"Whats up, {userInput} :)");

            Console.WriteLine(" ");     //spacing

            //prevents Console from closing until user presses enter key
            Console.WriteLine("Press enter to close...");
            Console.ReadLine();
        }
    }
}