using System;

//Sub-class of Avtivity
public class BreathingActivity : Activity
{
    //No attributes to establish

    //Constructor method (base activity is name, description)
    public BreathingActivity()
        : base("Breathing Activity",
        "This activity will help you relax by walking you through breathing" +
        "in and out slowly. Clear your mind and focus on your breathing.")
    {
        //... nothing to initialize
    }

    //Method to run actual activity
    public void Run()
    {
        //Display start message from Activity
        DisplayStart();
        //Get duration from user
        int duration = GetUserDuration();

        //Clear console and show get ready
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinnner(5);

        //Take user duration and calculate end time
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);

        //Loop of asking questions until time runs out
        while (DateTime.Now < endTime)
        {
            Console.WriteLine();     //Extra line for spacing 
            //Display breath in time (4 seconds)
            Console.Write("Breathe in...");
            ShowCountdown(4);
            Console.WriteLine();

            //Display breath out time (6 seconds)
            Console.Write("Now breathe out...");
            ShowCountdown(6);
            Console.WriteLine();
        }

        //Display end message from Activity
        DisplayEnd();
    }
}