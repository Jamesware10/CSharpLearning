using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleBasics
{
    class Customization
    {

        static void Main(string[] args)
        {
            //There are a few properties of the Console that can be customized manually

            //change Console window title
            Console.Title = "Custom Title";
            Console.WriteLine("Custom console title is above the text you're reading. ");

            Console.WriteLine("");      //output spacing

            //change Console backgroud color (text background)
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Background is magenta now.");

            Console.WriteLine("");      //output spacing

            //change Console foregroud color (text color)
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Foreground is black now.");

            Console.WriteLine("");     //output spacing

            //change Console cursor color
            //Console.CursorVisible = false;
            //Console.WriteLine("Cursor is not visible now");

            Console.WriteLine("");      //output spacing

            //Reset console background and foreground color
            Console.ResetColor();
            Console.WriteLine("Console background and foreground color reset to default.");

            Console.WriteLine("");      //output spacing

            // Gets or sets the console's scrollable height (rows)
            Console.BufferHeight = 100;
            Console.WriteLine("Console is now 100 rows tall");

            Console.WriteLine("");      //output spacing

            //Testing to be done
            // Gets or sets the console's scrollable width (rows)
            //Console.BufferWidth = 50;
            //Console.WriteLine("Console is now 100 columns wide");

            Console.WriteLine("");      //output spacing

            //prevents Console from closing until user presses enter key
            Console.WriteLine("Press enter to close...");
            Console.ReadLine();
        }
        
    }
}
