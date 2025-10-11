using System;

public class Activity
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
        ShowSpinnner(5);
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}");
        ShowSpinnner(5);

        //ADD GOING BACK TO MENU HERE?
    }

    //Method to be used for getting duration (to be used with sub-classes)
    protected int GetUserDuration()
    {
        return _duration;
    }

    //Method for showing countdown timer
    public void ShowCountdown(int seconds)
    {
        //Loop through to show for the duration in seconds from user
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);     //Time is in milliseconds, so 1000 = 1 second
            //If to check if needing to delete one or two digits
            if (i >= 10)
            {
                Console.Write("\b \b\b \b");     //backslash b to erase and replace 2 digits
            }
            else
            {
                Console.Write("\b \b");
            }
        }
    }

    //Method for spinner countdown animation
    public void ShowSpinnner(int seconds)
    {
        //String list for animation spinner
        List<string> animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");     //Double since this is special character
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");

        //Get time and duration to know how long to show
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        //Establish attribute to be used in loop
        int i = 0;

        //Loop through and show the spinner characters and replay if hit end and still have time
        while (DateTime.Now < endTime)
        {
            string s = animationStrings[i];
            Console.Write(s);
            Thread.Sleep(500);
            Console.Write("\b \b");
            i++;

            //Check if done going through list and restart if needed
            if (i >= animationStrings.Count)
            {
                i = 0;
            }
        }
    }

}