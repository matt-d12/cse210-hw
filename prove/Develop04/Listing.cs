using System;
using System.Collections.Generic;

//Sub-class of Avtivity
public class ListingActivity : Activity
{
    //Establish attributes
    private List<string> _prompts;
    //List to track used/available prompts
    private List<string> _availablePrompts;

    //Constructor method (base activity is name, description)
    public ListingActivity()
        : base("Listing Activity",
        "This activity will help you reflect on the good things in your life " +
        "by having you list as many things as you can in a certain area.")
    {
        //Initialize prompts
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

        //Initialize available prompt list
        _availablePrompts = new List<string>(_prompts);
    }

    //Method for getting a random prompt
    public string GetRandomPrompt()
    {
        //Check if used all available prompts and refill list
        if (_availablePrompts.Count == 0)
        {
            _availablePrompts = new List<string>(_prompts);
        }
        Random random = new Random();
        int index = random.Next(_availablePrompts.Count);
        //Get prompt at that index
        string selectedPrompt = _availablePrompts[index];
        //Remove that prompt from available list
        _availablePrompts.RemoveAt(index);

        return selectedPrompt;
    }

    //Method to run actual activity
    public void Run()
    {
        //Display start message from Activity
        DisplayStart();
        //Get duration from user
        int duration = GetUserDuration();

        //Get random prompt
        string prompt = GetRandomPrompt();
        //Clear console and show get ready
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinnner(5);

        //Show prompt and countdown to begin
        Console.WriteLine("List as many responses you can for the following prompt:");
        Console.WriteLine($" --- {prompt} ---");
        Console.Write($"You may begin in: ");
        ShowCountdown(5);
        Console.WriteLine();

        //Take user duration and calculate end time
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);

        //Begin & reset counter
        int count = 0;

        //Loop to keep allowing inputs for duration
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string response = Console.ReadLine();
            count++;
        }

        //Display the count
        Console.WriteLine($"You listed {count} items!");

        //Display end message from Activity
        DisplayEnd();
    }
}