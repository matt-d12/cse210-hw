using System;
public class Job
{
    //Establish attributes
    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;

    //Display formatting
    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}