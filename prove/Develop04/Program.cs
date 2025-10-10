using System;

class Program
{
    static void Main(string[] args)
    {
        //Establish attributes
        string choice = "";

        //Loop so menu keeps coming up until user hits quit
        while (choice != "4")
        {
            //Show the menu method below that returns user input and set it to choice attribute
            choice = DisplayMenu();

            if (choice == "1")
            {
                //Start breathing activity
            }
            else if (choice == "2")
            {
                //Start reflection activity
            }
            else if (choice == "3")
            {
                //Start listing activity
            }
            else if (choice == "4")
            {
                //Quit program
            }
            else
            {
                //Invalid choice please try again
            }

        }

    }

    //Method for displaying the menu
    static string DisplayMenu()
    {
        //No attributes
        Console.Clear();
        Console.WriteLine("Menu Options:");
        Console.WriteLine("   1. Start breathing activity");
        Console.WriteLine("   2. Start reflecting activity:");
        Console.WriteLine("   3. Start listing activity");
        Console.WriteLine("   4. Quit");
        Console.Write("Select a choice from the menu: ");

        //Get user input and return to be used in if statements
        return Console.ReadLine();
    }
}