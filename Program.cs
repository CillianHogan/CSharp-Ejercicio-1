using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Exercise 1. Create a program that displays the question "What is your name?" and then waits for the user to type their name,
            storing the input in a variable. Finally, it should display the greeting "Hello, <name>!".
            */

            // Declare a variable to store the user's name
            string name = "";

            // Ask the user for their name
            Console.WriteLine("What is your name?");

            // Read the input from the user and store it in the variable
            name = Console.ReadLine();

            // Display the greeting with the user's name
            Console.WriteLine("Hello " + name + "!");
        }
    }
}
