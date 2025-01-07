using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
        // for (int i = 2; i <= 20; i += 2)
        // {
        //     Console.WriteLine(i);
        // }
        string response = "yes";
        while (response == "yes")
        {
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);
            int guessNumber;
            int numberOfGuesses = 0;
            do 
            {
                Console.Write("What is your guess? ");
                string guess = Console.ReadLine();
                guessNumber = int.Parse(guess);
                if (guessNumber > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else if (guessNumber < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }
                numberOfGuesses++;
            } while (guessNumber != magicNumber); 
            Console.WriteLine($"You guessed in {numberOfGuesses} guesses.");
            Console.Write("Would you like to play again? ");
            response = Console.ReadLine();
        }
    }
}