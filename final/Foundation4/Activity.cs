using System;

public class Activity
{
    //Establish attributes
    private string _date;
    private double _minutes;

    //Constructor
    public Activity(string date, double minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    //Public setters to be read-only
    public string Date => _date;
    public double Minutes => _minutes;

    //Method to get distance
    public virtual double GetDistance() => 0;

    //Method to get speed
    public virtual double GetSpeed() => 0;

    //Method to get pace
    public virtual double GetPace() => 0;

    //Method to get summary info
    public virtual string GetSummary()
    {
        return $"{_date} Activity ({_minutes} min)";
    }
}