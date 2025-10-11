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

            if (choice == "1")                //Breathing Activity
            {
                StartBreathingActivity();
            }
            else if (choice == "2")           //Reflection Activity
            {
                //Start reflection activity
            }
            else if (choice == "3")           //Listening Activity
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

    //Method for starting the breathing activity
    static void StartBreathingActivity()
    {
        //Create new breathing object and run
        BreathingActivity breathing = new BreathingActivity();
        breathing.Run();
    }

    //Method for starting the reflecting activity
    static void StartReflectingActivity()
    {
        //Create new reflection object and run
    }

    //Method for starting the listing activity
    static void StartListingActivity()
    {
        //Create new listing object and run
    }
}