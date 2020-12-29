using System;

namespace MathBasics
{
    class MethodsAndProperties
    {
        static void Main(string[] args)
        {
            //Math class and methods as well as some extras

            //returns 100
            Console.WriteLine("Highest value is: " + Math.Max(70, 100));

            //returns 70
            Console.WriteLine("Lowest value is: " + Math.Min(70, 100));

            //returns 8
            Console.WriteLine("The Square root of 64 is: " + Math.Sqrt(64));

            //returns 3
            Console.WriteLine("The cube root of 27 is: " + Math.Cbrt(27));        

            //returns 81
            Console.WriteLine("9 raised by a power of 2 is: " + Math.Pow(9,2));        

            //returns 90
            Console.WriteLine("The absolute value of -90 is: " + Math.Abs(-90));      

            //returns 12
            Console.WriteLine("12.5 rounded to the nearest int is: " + Math.Round(12.5));   

            //returns 13
            Console.WriteLine("12.2 rounded up to the nearest int is: " + Math.Ceiling(12.2)); 

            //returns 12
            Console.WriteLine("12.8 rounded down to the nearest int is: " + Math.Floor(12.8));

            //returns random value between 1 and 100
            Random rand = new Random();
            Console.WriteLine("Random number: " + rand.Next(1,101));


            Console.WriteLine(" ");     //spacing

            //prevents Console from closing until user presses enter key
            Console.WriteLine("Press enter to close...");
            Console.ReadLine();

        }
    }
}
