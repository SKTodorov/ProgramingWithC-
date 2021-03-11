using System;

namespace HomeworkL1T5
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Declare a boolean variable called isFemale and
             * assign an appropriate value corresponding to your gender.*/

            bool isFemale = false;

            Console.WriteLine("Are you female?");
            Console.WriteLine("type your sex here:");
            string female = Console.ReadLine();
            if (female == "female")
            {
                Console.WriteLine(true);
            }

            else
            {
                Console.WriteLine(false);
            }
            Console.WriteLine("Press Enter to proced");
            Console.ReadLine();


            /* Declare two string variables and assign them with "Hello" and "World".
             * Declare an object variable and assign it with the concatenation of the first two variables
             * (mind adding an interval). Declare a third string variable and initialize it with the value
             * of the object variable (you should perform type casting).*/

            string hello = "Hello";
            string world = "World";

            object helloWorld = hello + " " + world;
            string worldHello = (string) helloWorld;

            Console.WriteLine(worldHello);

            Console.WriteLine("Press Enter to proced");
            Console.ReadLine();

            // u0020 space
            /* Declare two string variables and assign them with following value:
             * (The "use" of quotations causes difficulties.)
             * Do the above in two different ways: with and without using quoted strings. */
            string one = "The \"use\" of quotations causes difficulties.";
            string two = "The" + '\u0020' + '\u0022' + "use" + '\u0022' + '\u0020' + "of quotations causes difficulties.";
            
            Console.WriteLine(one);
            Console.WriteLine(two);
            Console.WriteLine("Press Enter to proced");
            Console.ReadLine();

            /* \u00A9 Copyright; \u0020 Space;  Write a program that prints an isosceles triangle of 9 copyright symbols ©.
            Use Windows Character Map to find the Unicode code of the © symbol.
            Note: the © symbol may be displayed incorrectly. */
            char copyright = '\u00A9';
            char space = '\u0020';

            Console.WriteLine("{0}{1}{0}{0}{0}{0}{0}", space, copyright);
            Console.WriteLine("{0}{1}{1}{0}{0}{0}{0}", space, copyright);
            Console.WriteLine("{0}{1}{0}{1}{0}{0}{0}", space, copyright);
            Console.WriteLine("{0}{1}{0}{0}{1}{0}{0}", space, copyright);
            Console.WriteLine("{0}{1}{0}{0}{0}{1}{0}", space, copyright);
            Console.WriteLine("{0}{1}{0}{0}{0}{0}{1}", space, copyright);
            Console.WriteLine("{0}{1}{0}{0}{0}{1}{0}", space, copyright);
            Console.WriteLine("{0}{1}{0}{0}{1}{0}{0}", space, copyright);
            Console.WriteLine("{0}{1}{0}{1}{0}{0}{0}", space, copyright);
            Console.WriteLine("{0}{1}{1}{0}{0}{0}{0}", space, copyright);
            Console.WriteLine("{0}{1}{0}{0}{0}{0}{0}", space, copyright);


        }
    }
}
