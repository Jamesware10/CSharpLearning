using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOperatorsBasics {
    /// <summary>
    /// Assignment operators examples and results
    /// <seealso cref="BinaryOperators"/>
    /// <seealso cref="UnaryOperators"/>
    /// </summary>
    class AssignmentOperators {
        //Assignment Operators assign values to variables (usually matching datatypes)
        string word = "word";     // '=' assigns a value to a variable

        int a = 20;
        a += 2;         // a = a +2

        int b = 14;
        b -= 3;         // b = b -3

        int c = 12;
        c *= 4;         // c = c * 4

        int d = 15;
        d /= 5;         // d = d / 5

        int e = 53;
        e %= 6;         // e = 3 % 6

        int f = 32;
        f &= 7;         // f = f & 7 (new)

        int g = 34;
        g |= 8;         // g = g | 8 (new)

        int x = 24;
        x ^= 9;         // x = x ^ 9 (new)

        int y = 45;
        y <<= 10;       // y = y <<= 10 (new)

        int z = 22;
        z >>= 11;       // z = z >>= 11 (new)

        /*since we did basic Arithmetic operators in BinaryOperators
         * and Unary Operators i dont feel the need to put examples*/
    }
}