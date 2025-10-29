using System;

public class Swimming : Activity
{
    //Establish attributes
    private int _laps;
    private double _lapLength = 50;

    //Constructor
    public Swimming(string date, double minutes, int laps)
        : base(date, minutes)
    {
        _laps = laps;
    }

    //Method to override distance
    public override double GetDistance()
    {
        return _laps * _lapLength / 1000;
    }

    //Method to override speed
    public override double GetSpeed()
    {
        return (GetDistance() / Minutes) * 60;
    }

    //Method to override pace
    public override double GetPace()
    {
        return Minutes / GetDistance();
    }

    //Method to override summary info
    public override string GetSummary()
    {
        return $"{Date} Swimming ({Minutes} min): Distance {GetDistance():0.0} km, " +
            $"Speed {GetSpeed():0.0} kph, Pace: {GetPace():0.00} min per km";
    }
}