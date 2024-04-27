using System;

class Program
{
    static void Main(string[] args)
    {
        // Part 1: Ask the user for the magic number
        //Console.Write("What is the magic number? ");
        //int magicNumber = int.Parse(Console.ReadLine());
        
        //Part 3: Generate a random number from 1 to 100
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);
        int guessCount = 0;

        int guess = -1;

        // Part 2: Add a loop that keeps looping as long as the guess does not match the magic number
        while (guess != magicNumber)
        {
            // Part 2: Ask the user for a guess
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());
            guessCount++;

            // Determine if the user needs to guess higher or lower next time, or tell them if they guessed it
            if (magicNumber > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }         
        // Keep track of how many guesses the user has made and inform them of it at the end of the game
        Console.WriteLine($"It took you {guessCount} guesses to find the magic number.");

    }
}