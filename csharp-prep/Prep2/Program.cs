using System;

class Program
{
    static void Main(string[] args)
    {
        string letterGrade = "";

        Console.Write("What is your grade percentage? ");
        string userInput = Console.ReadLine();
        int grade = int.Parse(userInput);

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

        Console.WriteLine($"Your grade is a {letterGrade}.");

        if (grade >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("You failed.");
        }
    }
}