using System;

public class Entry
{
    //Establish attributes
    public string _prompt;
    public string _response;
    public string _date;

    //Display formatting
    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_prompt}");
        Console.WriteLine($"Response: {_response}");
    }
}