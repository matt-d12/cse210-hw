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

    //Method for getting total cost
    public double GetTotalCost()
    {
        return _price * _quantity;
    }

    //Method to get product info
    public string GetProductInfo()
    {
        return $"{_name} (ID: {_productId})";
    }
}