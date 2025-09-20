using System;

class Program
{
    static void Main(string[] args)
    {   
        //Declare variables
        string letterGrade = "";
        string symbol = "";

        //Ask user input and convert to int
        Console.Write("What is your grade percentage? ");
        string userInput = Console.ReadLine();
        int grade = int.Parse(userInput);

        //Calculate grade letter
        if (grade >= 90)
        {
            letterGrade = "A";
        }
        else if (grade >= 80)
        {
            letterGrade = "B";
        }
        else if (grade >= 70)
        {
            letterGrade = "C";
        }
        else if (grade >= 60)
        {
            letterGrade = "D";
        }
        else if (grade < 60)
        {
            letterGrade = "F";
        }
        
        //Calculate remainder to see if + or -
        if (grade % 10 >= 7)
        {
            symbol = "+";
        }
        else if (grade % 10 < 3)
        {
            symbol = "-";
        }

        //Output based on input
        Console.WriteLine($"Your grade is a {letterGrade}{symbol}");

        //Tell user if they pass or fail - above 70 needed
        if (grade >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("You failed :(");
        }
    }
}