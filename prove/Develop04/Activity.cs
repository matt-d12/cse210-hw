using System;

public class Activity()
{
    //Establish attributes
    private string _name;
    private string _description;
    private int _duration;

    //Constructor method for super class
    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
        _duration = 0;
    }

    //Method for displaying start message of activity
    public void DisplayStart()
    {
        //Display welcome message 
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}");
        Console.WriteLine();
        //Display description
        Console.WriteLine(_description);
        Console.WriteLine();
        //Get duration input from user and convert to an int
        Console.Write("How long, in seconds, would like for your session? ");
        _duration = int.Parse(Console.ReadLine());
    }

    //Method for displaying end message and going back to menu
    public void DisplayEnd()
    {
        Console.WriteLine();
        Console.WriteLine("Well Done!");
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_duration} of the {_name}");
        
        //ADD GOING BACK TO MENU HERE?
    }

}