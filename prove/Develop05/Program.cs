using System;

//ADD EXCEEDING CORE REQUIREMENTS HERE

class Program
{
    static void Main(string[] args)
    {
        //Establish attribute for choice and initialize goal manager
        string choice = "";
        GoalManager manager = new GoalManager();

        //Loop for user to control menu
        while (choice != "6")
        {
            //Show the menu method below that returns user input and set it to choice attribute
            choice = DisplayMenu(manager.GetScore());

            if (choice == "1")                //Create new goal
            {
                manager.CreateGoal();
            }
            else if (choice == "2")           //List goals
            {
                manager.ListGoals();
            }
            else if (choice == "3")           //Save goals
            {
                manager.SaveGoals();
            }
            else if (choice == "4")           //Load goals
            {
                manager.LoadGoals();
            }
            else if (choice == "5")           //Record an event
            {
                manager.RecordEvent();
            }
            else if (choice == "6")
            {
                //Quit program
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
        }
    }

    //Method for the diplay menu
    static string DisplayMenu(int score)
    {
        Console.WriteLine();
        //Show current points
        Console.WriteLine($"You have {score} points");
        Console.WriteLine();
        //Show menu options
        Console.WriteLine("  1. Create New Goal");
        Console.WriteLine("  2. List Goals");
        Console.WriteLine("  3. Save Goals");
        Console.WriteLine("  4. Load Goals");
        Console.WriteLine("  5. Record Event");
        Console.WriteLine("  6. Quit");
        //Get user input and do the following
        Console.Write("Select a choice from the menu: ");
        return Console.ReadLine();
    }
}