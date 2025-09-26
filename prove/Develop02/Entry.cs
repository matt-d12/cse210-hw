using System;

public class Entry
{
    //Establish attributes
    public string _prompt;
    public string _response;
    public string _date;

    //Initialize an entry
    public Entry(string prompt, string response, string date)
    {
        _prompt = prompt;
        _response = response;
        _date = date;
    }

    //Convert entry into a string for saving
    public string StringEntry()
    {
        return $"{_date}|{_prompt}|{_response}";
    }
}