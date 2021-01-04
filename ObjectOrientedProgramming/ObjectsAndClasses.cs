using System;

namespace ObjectOrientedProgramming {

    /// <summary>
    /// Basic demonstration on how Object Oriented Programming works
    /// </summary>
    internal class ObjectsAndClasses {
        // Fields(Global Variables) and methods represent attributes and behaviours of a player object

        // Player class to be instantiated.
        public class Player {

            // Attributes of a player object
            public int level = 9001;

            public string weapon;

            // Behaviours of a player
            public void attack() {
                Console.WriteLine("player attacked.");
            }
        }

        // outer test class
        public class TestPlayer {

            private static void Main(string[] args) {
                // Object of Player class
                Player p1 = new Player();

                // Attibutes an behaviours can be accessed by using '.'

                // Modifies an attribute of Player object outside of Player class
                p1.weapon = "Frying Pan";

                // Displays attributes
                Console.WriteLine(p1.level);
                Console.WriteLine(p1.weapon);
                p1.attack();

                Console.WriteLine(" ");     //spacing

                // Prevents Console from closing until user presses enter key
                Console.WriteLine("Press enter to close...");
                Console.ReadLine();
            }
        }
    }
}