using System;

public class OutdoorGathering : Event
{
    //Establish attributes
    private string _weather;

    //Constructor
    public OutdoorGathering(string title, string description, string date, string time, Address address, string weather)
        : base(title, description, date, time, address)
    {
        _weather = weather;
    }
    
    //Method to get and override full details
    public override string GetFullDetails()
    {
        return $"{GetStandardDetails()}\nType: Outdoor Gathering\nWeather: {_weather}";
    }
}