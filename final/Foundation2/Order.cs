using System;

public class Order
{
    //Establish attributes
    private Customer _customer;
    //Create list of product
    private List<Product> _products = new List<Product>();

    //Constructor
    public Order(Customer customer)
    {
        _customer = customer;
    }

}