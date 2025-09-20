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

    //Function to ask for user's favorite number
    static void PromptUserNumber(ref int number)
    {
        Console.Write("Please enter your favorite number: ");
        string textNumber = Console.ReadLine();
        number = int.Parse(textNumber);
    }

    //Function to ask user's birth year
    static void PromptUserBirthYear(out int year)
    {
        Console.Write("Please enter the year you were born: ");
        string textYear = Console.ReadLine();
        year = int.Parse(textYear);

    }

    static void Main(string[] args)
    {
        //Establish variables
        string name = "";
        int number = 0;
        int year = 0;
        
        //Call functions
        DisplayWelcome();
        PromptUserName(ref name);
        PromptUserNumber(ref number);
        PromptUserBirthYear(out year);

        //Outputs
        Console.WriteLine($"{name}, your favorite number is {number}");
        Console.WriteLine($"{name}, you were born in {year}");

    }
}