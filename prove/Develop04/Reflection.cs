using System;

//Sub-class of Avtivity
public class ReflectionActivity : Activity
{
    //Establish attributes
    private List<string> _prompts;
    private List<string> _quesitons;


    //Constructor method (base activity is name, description)
    public ReflectionActivity()
        : base("Reflection Activity",
        "This activity will help you reflect on times in your life when you have " +
        "shown strength and resilience. This will help you recognize the power " +
        "you have and how you can use it in other aspects of your life.")
    {
        //Initialize prompts
        _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        //Initialize questions
        _quesitons = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
    }

    //Method for getting a random prompt
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    //Method for getting a random question
    public string GetRandomQuesiton()
    {
        Random random = new Random();
        int index = random.Next(_quesitons.Count);
        return _quesitons[index];
    }

    //Method to run actual activity
    public void Run()
    {
        //Display start message from Activity
        DisplayStart();
        //Get duration from user
        int duration = GetUserDuration();


        //ADD PROMPT AND QUESTION
        //ADD LOOP TO KEEP ASKING QUESTIONS UNTIL TIME RUNS OUT 


        //Display end message from Activity
        DisplayEnd();
    }
}