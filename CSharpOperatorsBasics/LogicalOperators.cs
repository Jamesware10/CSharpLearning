using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOperatorsBasics {
    class LogicalOperators {
        static void Main(string[] args) {
            //Logical Operators check a condition for true or false
            int x = 8, y = 10;

            //Console showcase of Logical Operators
            Console.WriteLine($"'x' is equal to {x}, while 'y' equal to {y}");

            Console.WriteLine(" ");

            Console.WriteLine("is 'x' greater than '5' AND less than 10?");
            Console.WriteLine(x > 5 && x < 10);         /* '&&' Logical AND (checks if both comparisons are true)
                                                         returns true since 'x' is greater than 5 and less than 10*/

            Console.WriteLine("is 'x' equal to '5' OR equal to 10?");
            Console.WriteLine(y == 5 || y == 10);       /* '||' Logical OR (checks if either/or comparisons are true)
                                                         returns true since 'y' is equal to 10*/

            Console.WriteLine("is 'y' NOT greater than '5' AND less than 10?");
            Console.WriteLine(!(y > 5 && y < 10));      /* '!' Logical NOT (checks if neither conditions are true)
                                                         returns true since 'y' is only greater than 5 but not less than 10 */

            Console.WriteLine("is 'x' NEITHER greater than '5' NOR less than 10?");
            Console.WriteLine(!(x == 5 || x == 10));    /* '!' and in this case (checks if neither/nor comparisons are true)
                                                         returns true since 'x' is indeed not equal to 5 nor 10 */

            Console.WriteLine(" ");     //spacing

            //prevents Console from closing until user presses enter key
            Console.WriteLine("Press enter to close...");
            Console.ReadLine();
        }
    }
}