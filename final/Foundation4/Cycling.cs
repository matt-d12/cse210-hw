using System;

public class Cycling : Activity
{
    //Establish attributes
    private double _speed;

    //Constructor
    public Cycling(string date, double minutes, double speed)
        : base(date, minutes)
    {
        _speed = speed;
    }

    //Method to override distance
    public override double GetSpeed() => _speed;

    //Method to override speed
    public override double GetDistance()
    {
        return (Minutes / 60) * _speed;
    }

    //Method to override pace
    public override double GetPace()
    {
        return 60 / _speed;
    }

    //Method to override summary info
    public override string GetSummary()
    {
        return $"{Date} Cycling ({Minutes} min): Distance {GetDistance():0.0} km, " +
            $"Speed {GetSpeed():0.0} kph, Pace: {GetPace():0.00} min per km";
    }
}