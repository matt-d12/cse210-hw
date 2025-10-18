using System;

//ADD EXCEEDING CORE REQUIREMENTS HERE

class Program
{
    static void Main(string[] args)
    {
        //Establish attribute for choice
        string choice = "";

        //Loop for user to control menu
        while (choice != "6")
        {
            //Show the menu method below that returns user input and set it to choice attribute
            choice = DisplayMenu();

            if (choice == "1")                //Create new goal
            {
                //TBD
            }
            else if (choice == "2")           //List goals
            {
                //TBD
            }
            else if (choice == "3")           //Save goals
            {
                //TBD
            }
            else if (choice == "4")           //Load goals
            {
                //TBD
            }
            else if (choice == "5")           //Record an event
            {
                //TBD
            }
            else if (choice == "6")
            {
                //Quit program
            }
            else
            {
                //Invalid choice please try again
            }
        }
    }

    //Method for the diplay menu
    static string DisplayMenu()
    {
        Console.Clear();
        //Show current points - REPLACE WITH COUNTER LATER
        Console.WriteLine("You have 0 points");
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