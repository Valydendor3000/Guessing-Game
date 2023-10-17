// A simple guessing game

using System;

namespace GuessingGame
{
    internal class GuessingGame
    {
        static void Main(string[] args)
        {
            // Set score to 0
            int score = 0;

            // Specify the number of rounds we will play
            int rounds = 3;

            // Introduction
            Console.WriteLine("A Guessing Game \nWe will play " + rounds + " rounds.\n" +
                "For each round, I will generate a random integer. \n" +
                "You will guess whether it is even or odd. \n" +
                "If you guess right, you earn 1 point.\n" +
                "If you are wrong, you get 0 point.\n");


            Console.WriteLine("Please enter your name: ");
            string name = Console.ReadLine();

            // Prepare to generate random numbers 
            Random random = new Random();

            // Loop until the rounds are over
            for (int i = 0; i < rounds; i++)
            {
                // Display round number
                Console.WriteLine("\nRound " + (i + 1));

                // Generate a random integer
                int number = random.Next(0, 100);

                // Ask the player to guess
                Console.WriteLine("I have genreated a random integer. Is it even or odd?");

                // Declare "guess" outside the loop below because we need to use "guess"
                // later
                string guess = "";

                while (true)
                {
                    Console.WriteLine("Please enter your guess: e for even, o for odd");
                    // Read player input
                    guess = Console.ReadLine();

                    if ((guess == "e") || (guess == "o"))
                    {
                        // If the player enters either e or o, get out of the loop
                        break;
                    }

                    // If the player input is not e or o, go to the top of the loop and ask again.
                    // We need to handle player errors. 
                }

                // User (number % 2) to check if the number is even or odd
                if ((number % 2) == 0)
                {
                    // It's an even number.

                    if (guess == "e")
                    {
                        Console.WriteLine("You guessed right.");
                        score++; // Don't forget to update the score
                    }
                    else if (guess == "o")
                    {
                        Console.WriteLine("You guessed wrong.");
                    }
                }
                else
                {
                    // It's an odd number.

                    if (guess == "e")
                    {
                        Console.WriteLine("You guessed wrong.");
                    }
                    else if (guess == "o")
                    {
                        Console.WriteLine("You guessed right.");
                        score++; // Update the score
                    }
                }

                // Tell the player what the random number is
                Console.WriteLine("My number is " + number);
            }

            Console.WriteLine();
            // Report the final score
            Console.WriteLine(name + ", Your score is " + score + " out of " + rounds);

            // Comment on the performance
            double percentageScore = (double)score / (double)rounds;
            if (percentageScore < 0.5)
            {
                Console.WriteLine("Better luck next time.");
            }
            else if (percentageScore <= 0.7)
            {
                Console.WriteLine("Not bad.");
            }
            else
            {
                Console.WriteLine("Wow!");
            }
        }
    }
}