using System;

public class Customer
{
    //Establish attributes
    private string _name;
    private Address _address;

    //Constructor
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    //Method to show if someone is living in USA for shipping
    public bool LivesInUSA()
    {
        return _address.IsInUSA();
    }

    //Method to get customer name
    public string GetName()
    {
        return _name;
    }

    //Method to get address string
    public string GetAddressString()
    {
        return _address.GetFullAddress();
    }

}