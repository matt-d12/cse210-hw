using System;

class Program
{
    //Function to display welcome message
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    //Function to ask for user's name
    static void PromptUserName(ref string name)
    {
        Console.Write("Please enter your name: ");
        name = Console.ReadLine();
    }


    static void Main(string[] args)
    {
        //Establish variables
        string name = "";
        
        //Call functions
        DisplayWelcome();
        PromptUserName(ref name);

        //Outputs
        Console.WriteLine($"{name}, the square of your number is");

    }
}