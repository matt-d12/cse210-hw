using System;

public class Running : Activity
{
    //Establish attributes
    private double _distance;

    //Constructor
    public Running(string date, double minutes, double distance)
        : base(date, minutes)
    {
        _distance = distance;
    }

    //Method to override distance
    public override double GetDistance() => _distance;

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
        return $"{Date} Running ({Minutes} min): Distance {GetDistance():0.0} km, " +
            $"Speed {GetSpeed():0.0} kph, Pace: {GetPace():0.00} min per km";
    }
}