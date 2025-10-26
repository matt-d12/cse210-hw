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

    //Method to add products to list
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    //Method to get total cost
    public double GetTotalCost()
    {
        double total = 0;
        foreach (Product p in _products)
        {
            //Add total cost
        }

        //Add shipping cost

        return total;
    }

    //Method to create packing label
    public string GetPackingLabel()
    {
        string label = "Packing Label:";
        foreach (Product p in _products)
        {
            label += " - " + p.GetProductInfo();
        }
        return label;
    }

    //Method to create shipping label
    public string GetShippingLabel()
    {
        //shipping label
    }

}