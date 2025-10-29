using System;

public class Event
{
    //Establish attributes
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;

    //Constructor
    public Event(string title, string description, string date, string time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    //Method to get standard details
    public string GetStandardDetails()
    {
        return $"Title: {_title}\nDescription: {_description}\nDate: {_date}nTime: {_time}\nAddress:\n{_address.GetFullAddress()}";
    }

    //Method to get short description
    public virtual string GetShortDescription()
    {
        return $"{GetType().Name} - {_title} on {_date}";     //Will be overridden by child classes
    }

    //Method to get full description
    public virtual string GetFullDetails()
    {
        return GetStandardDetails();     //Will be overridden by child classes
    }
}