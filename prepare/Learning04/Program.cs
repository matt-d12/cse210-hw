using System;

class Program
{
    static void Main(string[] args)
    {
        //Create new object
        Assignment assignment = new Assignment("Samuel Bennet", "Multiplication");

        //Print summary
        Console.WriteLine(assignment.GetSummary());
    }
}