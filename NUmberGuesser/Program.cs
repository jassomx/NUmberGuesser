using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUmberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
            bool playAgain = true;

            GetAppInfo(); // Run GetAppInfo method
            GreetUser(); // Run GreetUser method


            while (playAgain)
            {
                // Create a random new object
                Random numRandom = new Random();

                int correctNumber = numRandom.Next(1, 10);

                // Init guess var
                int guess = 0;

                // Ask user for number
                Console.WriteLine("Guess a number between 1 and 10");

                // While guess is not correct do..
                while (guess != correctNumber)
                {
                    // Gets user input
                    string input = Console.ReadLine();

                    // Make sure user input is valid
                    if (!int.TryParse(input, out guess))
                    {
                        // print error message
                        PrintColorMessage(ConsoleColor.Red, "PLease use an actual number");

                        // Keep going
                        continue;
                    }

                    // Cast to int and put in guess
                    guess = Int32.Parse(input);

                    // Match guess to correct number
                    if (guess != correctNumber)
                    {
                        PrintColorMessage(ConsoleColor.Red, "Wrong number, please try again.");
                    }
                }

                // Correct message
                PrintColorMessage(ConsoleColor.Yellow, "You are correct!");

                // Asking user if he wants play again
                Console.WriteLine("Want to play again? (Y or N)");
                string userYN = Console.ReadLine().ToUpper();
                if (userYN == "N")
                {
                    playAgain = false;
                    Console.WriteLine("Thanks for playing my game!");

                    continue;
                }
            }

            Console.ReadLine();
        }

        static void GetAppInfo()
        {
            // Setting app variables
            string appName = "Number Guesser", appVersion = "1.0.0", appAuthor = "Omar Jasso";

            // Change text color to green
            Console.ForegroundColor = ConsoleColor.Green;


            // Write out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            // Reset color back to default
            Console.ResetColor();
        }

        static void GreetUser()
        {
            // Ask users name
            Console.WriteLine("What is your name?");

            // Get user input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game! Bye!", inputName);
        }

        static void PrintColorMessage(ConsoleColor color, string message)
        {
            // Change text color to green
            Console.ForegroundColor = color;


            // Write out to user that is not a number
            Console.WriteLine(message);

            // Reset color back to default
            Console.ResetColor();
        }
    }
}
