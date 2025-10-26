using System;

public class Product
{
    //Establish attributes
    private string _name;
    private string _productId;
    private double _price;
    private int _quantity;

    //Constructor
    public Product(string name, string productId, double price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

}