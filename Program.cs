/*
    Author: Tyler Wildrick
    Date: 09/26/2020
    Comments: This is TechProject3B which is a  C# Console application code that demonstrates the use of
              of a mnaual Array. 
*/

using System;

namespace TechProject3B
{
    class Program
    {
        static void Main(string[] args)
        {
            // Here is a manually populated array
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25 };

            // Iterating through the elements of the array with a Foreach Loop
            foreach (int i in numbers)
            {
                Console.Write("Elemental Value = " + i);
                Console.WriteLine(" ");
            }
            Console.WriteLine("");
            Console.WriteLine("__________________________________________________________________________");
            Console.WriteLine("Press any key to exit the program ...");
            // Pause the program and await the user to press a key to end the program
            Console.ReadKey(true); 
        }
    }
}
