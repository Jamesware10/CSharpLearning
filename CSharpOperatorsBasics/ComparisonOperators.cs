using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOperatorsBasics
{
    class ComparisonOperators
    {
        static void Main(string[] args)
        {
            //Comparsion operators compare values

            //Declares and intiaizalize variables
            int a = 10, b = 9;

            //CONSOLE SHOWCASE
            Console.WriteLine($"'a' is equal to {a}, while 'b' equal to {b}");

            Console.WriteLine(" ");

            Console.WriteLine("is 'a' equal to 'b' ?");
            Console.WriteLine(a == b);      /* '==' checks if two values are equal
                                            *returns false since 'a' is not equal to 'b' */

            Console.WriteLine(" ");

            Console.WriteLine("is 'a' not equal to 'b' ?");
            Console.WriteLine(a != b);      /* '!=' checks if two values are not equal
                                            *returns true since 'a' is not equal to 'b' */

            Console.WriteLine(" ");

            Console.WriteLine("is 'a' greater than 'b' ?");
            Console.WriteLine(a > b);      /* '>' checks if first value is greater than second value
                                            *returns true since 'a' is larger than 'b' */

            Console.WriteLine(" ");

            Console.WriteLine("is 'a' less than than 'b' ?");
            Console.WriteLine(a < b);      /* '<' checks if first value is lesser than second value
                                            *returns false since 'a' is not smaller to 'b' */

            Console.WriteLine(" ");

            Console.WriteLine("is 'a' greater than or equal to 'b' ?");
            Console.WriteLine(a >= b);      /* '>=' checks if first value is greater than or equal second value
                                            *returns true since 'a' is larger than 'b' */

            Console.WriteLine(" ");

            Console.WriteLine($"is 'a' less than or equal to 'b' ?");
            Console.WriteLine(a <= b);      /* '<=' checks if first value is lesser than or equal second value
                                            *returns false since 'a' is not smaller than 'b'*/

            Console.WriteLine(" ");     //spacing

            //prevents Console from closing until user presses enter key
            Console.WriteLine("Press enter to close...");
            Console.ReadLine();
        }
        
    }
}
