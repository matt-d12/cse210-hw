using System;
using System.IO;
using System.Collections.Generic;

public class Entry
{
    //Establish attributes
    public string _prompt;
    public string _date;
    public string _response;
    

    //Initialize an entry
    public Entry(string prompt, string date, string response)
    {
        _prompt = prompt;
        _date = date;
        _response = response;
    }

    //Convert entry into a string for saving
    public string StringEntry()
    {
        return $"{_prompt}|{_date}|{_response}";
    }

    //Actual display for entries to user
    public void DisplayEntry()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_prompt}");
        Console.WriteLine(_response);
    }
}