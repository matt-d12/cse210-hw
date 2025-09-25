using System;

class PromptGenerator
{
    //Initialize list of prompts
    public List<string> _prompts = new List<string>();
    public PromptGenerator()
    {
        {
            _prompts.Add("Who was the most interesting person I interacted with today?");
            _prompts.Add("What was the best part of my day?");
            _prompts.Add("How did I see the hand of the Lord in my life today?");
            _prompts.Add("What was the strongest emotion I felt today?");
            _prompts.Add("If I had one thing I could do over today, what would it be?");
        }
    }

    //Method for getting random prompt from list
    public string GetRandomPrompt()
    {
        //Get random number based on count of list (_prompts) entries
        Random rand = new Random();
        int index = rand.Next(_prompts.Count);
        return _prompts[index];     //Return that random prompts index number
    }

}