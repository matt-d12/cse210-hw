using System;

class Program
{
    static void Main(string[] args)
    {
        //Declare variable
        int guess = -1;   //Set to -1 at start so won't match user number

        //Get magic number from user and convert
        Console.Write("What is the magic number? ");
        string userNumber = Console.ReadLine();
        int number = int.Parse(userNumber);

        //Use do-while loop to get first guess before checking
        do
        {
            //Get guess number from user and convert
            Console.Write("What is you guess? ");
            string userGuess = Console.ReadLine();
            guess = int.Parse(userGuess);

            //Check if guess is higher or lower than magic number
            if (guess < number)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > number)
            {
                Console.WriteLine("Lower");
            }
        } while (guess != number);

        //Loop will exit then print statement
        Console.WriteLine("You guessed it!");
    }
}