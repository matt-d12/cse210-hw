using System;

//Sub-class of Avtivity
public class ListingActivity : Activity
{
    //Establish attributes
    private List<string> _prompts;

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
    }

    //Method for getting a random prompt
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    //Method to run actual activity
    public void Run()
    {
        //Display start message from Activity
        DisplayStart();
        //Get duration from user
        int duration = GetUserDuration();


        //ADD PROMPT
        //ADD LOOP TO KEEP ALLOWING INPUTS
        //ADD COUNTER FOR REPONSES TO BE DISPLAYED AT END


        //Display end message from Activity
        DisplayEnd();
    }
}