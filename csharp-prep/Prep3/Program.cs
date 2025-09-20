using System;

class Program
{
    static void Main(string[] args)
    {
        //Get magic number from user and convert
        Console.Write("What is the magic number? ");
        string userNumber = Console.ReadLine();
        int number = int.Parse(userNumber);

        //Get guess number from user and convert
        Console.Write("What is you guess? ");
        string userGuess = Console.ReadLine();
        int guess = int.Parse(userGuess);

        //Check if guess is equal, lower or higher than magic number
        if (guess == number)
        {
            Console.WriteLine("You guessed it!");
        }
        else if (guess < number)
        {
            Console.WriteLine("Higher");
        }
        else if (guess > number)
        {
            Console.WriteLine("Lower");
        }
    }
}