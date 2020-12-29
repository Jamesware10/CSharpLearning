using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpVariablesBasics
{
    /// <summary>
    /// This class shows the basics of how variables work
    /// Nothing is printed to the console
    /// </summary>
    class VariableBasics
    {
              
 //__________________________________________DIFFERENT DATA TYPES____________________________________________________

            //Store numbers
            int myInt = 10;             //integer (32-bit whole numbers)
            long myLong = 12L;          //long (64-bit whole numbers)
            float myFloat = 9.06F;      //float (32-bit decimals)
            double myDouble = 10.28D;   //double (64-bit-decimals)

            //Store characters
            char myChar = 'F';              //char (holds a single character)
            string myString = "decadent";   //string (holds multiple characters)

            //the Boolean data type
            bool myBoolean = false;         //boolean (can either be true or false)


 //___________________________________DECLARING AND INTIALIZING VARIABLES__________________________________________________

            //string variable declared and intialized in two steps
            string welcome;       
            welcome = "Hello";     

            //string variable declared and initialized in one step
            string bye = "good bye";


//_____________________________________Declaring multiple variables at once______________________________________________

            // just declaring multiple variables
            int age, width, height, depth;

            //declaring and intializing
            double mass = 80.7, temperature = 98.6, length = 7.5;

 //_____________________________________RE-INITIAILZING and CONVERTING VARIABLES___________________________________________

            //Reinitialing variable x
            int x = 10;     //int x equals 10
            x = 20;         //now int x equals 20


            //CONVERTING VARIABLES TO DIFFERENT TYPES

            //Type casting (only works when converting smaller data types to larger ones/ does convert to string or char)
            double height = 156.7;
            int myHeight = (int) height;

            //Convert methods
            string age = "21";
            int myIntAge = Convert.ToInt32(age);
        
    }
}
