using System;

class Program
{
    static void Main(string[] args)
    {
        //Create new assignment 
        Assignment assignment = new Assignment("Samuel Bennet", "Multiplication");
        //Print summary
        Console.WriteLine(assignment.GetSummary());
        Console.WriteLine();

        //Create new math assignment
        MathAssignment math = new MathAssignment("Roberto Rodriguez", "Fractions",
        "7.3", "8-19");
        Console.WriteLine(math.GetSummary());
        Console.WriteLine(math.GetHomeworkList());

    }
}