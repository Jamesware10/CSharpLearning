using System;

namespace MethodsAndProperties {

    internal class MethodsAndProperties {

        private static void Main(string[] args) {
            //A string contains an array of chars, string literals are always surrounded by double quote
            string example = "This is a string";

            //Some useful methods and properties that can be used on strings
            Console.WriteLine(" ");     //spacing
            string example2 = "Supercalifragilisticexpialidocious";

            //prints the length of the word using length property
            Console.WriteLine($"The length of example2 is: {example2.Length}.");

            Console.WriteLine(" ");     //spacing

            //<!-------------Convert Strings to upper-case and lower-case letters--------->

            string example3 = "sHeIlD";
            Console.WriteLine($"example3 has mixed casing: {example3}");
            Console.WriteLine($"example3 to uppercase: {example3.ToUpper()}");
            Console.WriteLine($"example3 to lowercase: {example3.ToLower()}");

            Console.WriteLine(" ");     //spacing

            //<!--------------------------Concatenating strings--------------------------->

            string firstName = "Bill";
            string lastName = "Nightingale";

            Console.WriteLine("Concatenating strings using '+'");
            Console.WriteLine(firstName + " " + lastName);

            Console.WriteLine(" ");     //spacing

            Console.WriteLine("Concatenating strings using string.Concat()");
            Console.WriteLine(string.Concat(firstName, " ", lastName));

            Console.WriteLine(" ");     //spacing

            Console.WriteLine("Concatenating strings using string interpolation");
            Console.WriteLine($"{firstName} {lastName}");

            Console.WriteLine(" ");     //spacing

            //<!-----------------------Accessing Strings---------------------------------->

            string example5 = "Flamingo";

            Console.WriteLine("char at index 0 is: ");
            Console.WriteLine(example5[0]);

            Console.WriteLine(" ");     //spacing

            Console.WriteLine("index location of o is: ");
            Console.WriteLine(example5.IndexOf("o"));

            Console.WriteLine(" ");     //spacing

            Console.WriteLine("substring from index 3 onwards: ");
            Console.WriteLine(example5.Substring(3));

            Console.WriteLine("substring from index 1 to 5: ");
            Console.WriteLine(example5.Substring(1, 5));

            Console.WriteLine(" ");     //spacing

            //<!-------------------------Special Characters---------------------------------->

            //Escape characters, prints '"', ''' without confusing C#
            string proverb = "\"Wine and children speak the truth\"";
            string quote = "\"Never say you can\'t.\"";

            Console.WriteLine(proverb);
            Console.WriteLine(quote);

            Console.WriteLine(" ");     //spacing

            //prevents Console from closing until user presses enter key
            Console.WriteLine("Press enter to close...");
            Console.ReadLine();
        }
    }
}