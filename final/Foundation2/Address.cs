using System;

public class Address
{
    //Establish attributes
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    //Constructor
    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    //Method to tell if user is in USA
    public bool IsInUSA()
    {
        //Convert to lower case to check
        return _country.Trim().ToLower() == "usa";
    }

    //Method to put full address together
    public string GetFullAddress()
    {
        return $"{_street}\n{_city}, {_state}\n{_country}";
    }
}