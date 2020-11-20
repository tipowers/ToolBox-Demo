using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolBoxDemo
{
    class Program
    {
        static void Main(string[] args) // Main method acts as programs .exe file
        {
            Console.WriteLine("Welcome to your Tool Box!");
            Console.WriteLine("You can either hit \"Y\" then ENTER to continue, or hit \"N\" the ENTER to Clear the Console and continue.");
            string userResponse = Console.ReadLine();

            if (userResponse == "Y" || userResponse == "y")
            {
                KeyToContinue();
            }
            else if (userResponse == "N" || userResponse == "n")
            {
                ClearConsole();
            }
            else
            {
                Console.WriteLine("Not sure my friend, but I'm gonna close the program when you hit ENTER");
                Console.ReadLine();
            }

            // Functions are methods written outside of a custom class

            // Methods are functions written inside of a custom class

            // The following are FUNCTIONS

            // Functions do not need access modifier
            void KeyToContinue()
            {
                Console.WriteLine("Hit ENTER to Clear the Console and continue with the code...");
                Console.ReadLine();
                ClearConsole();
            }

            void ClearConsole()
            {
                Console.Clear();
                Console.WriteLine("Congratulations! You've cleared the console!...hit ENTER to close the program.");
                Console.ReadLine();
            }
        }
    }
}
