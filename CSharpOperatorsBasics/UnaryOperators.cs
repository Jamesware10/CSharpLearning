using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOperatorsBasics {
    class UnaryOperators {
        static void Main(string[] args) {
            //Unary operators perform operations on a single value at a time

            //Pre-increment operators
            int i = 0;
            ++i;            // adds 1 to i then assign new value (pre-incrementing)

            int j = 3;
            --j;            // takes 1 from j then assigns new value(pre-decrementing)

            //Post-increment operators
            int k = 0;
            k++;            // assigns old value then adds 1 (post-incrementing)

            int m = 3;
            m--;            // assigns old value then takes 1 (post-decrementing)

            //Unary operators Console showcase
            int num1 = 5;
            int num2 = 5;
            Console.WriteLine("Pre-increment example");
            Console.WriteLine("num1 was equal to so, ++num1 = " + ++num1);

            Console.WriteLine("");

            Console.WriteLine("Post-increment example");
            Console.WriteLine("num2 was also equal to 5 but, num2++ = " + num2++);
            //IMPORTANT
            Console.WriteLine("NOTE: that in the end num2++ will be equal to 6");

            Console.WriteLine(" ");     //spacing

            //prevents Console from closing until user presses enter key
            Console.WriteLine("Press enter to close...");
            Console.ReadLine();
        }
    }
}