using System;

class Program
{
    static void Main(string[] args)
    {
        //Declare variables
        int guess = -1;   //Set to -1 at start so won't match user number
        int guesses = 0;   
        string response = "yes";   //Default to yes so runs loop

        while (response == "yes")
        {
            //Get magic number from random generator
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(1, 101);

            //Use do-while loop to get first guess before checking
            do
            {
                //Get guess number from user and convert
                Console.Write("What is you guess? ");
                string userGuess = Console.ReadLine();
                guess = int.Parse(userGuess);

                //Add one to guess counter
                guesses++;

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
            Console.WriteLine($"You guessed it! This took {guesses} tries.");
            
            //Ask if they want to play again and loop back to beginning
            Console.Write("Would you like to play again? ");
            response = Console.ReadLine();
        }
    }
}