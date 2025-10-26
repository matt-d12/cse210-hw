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

}