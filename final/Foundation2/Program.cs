using System;

class Program
{
    static void Main(string[] args)
    {
        //Customer 1
        Address address1 = new Address("123 Main St", "Rexburg", "ID", "USA");
        Customer customer1 = new Customer("John Smith", address1);
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Phone", "A1001", 499.99, 1));
        order1.AddProduct(new Product("Case", "B2001", 49.99, 2));

        //Customer 2

        //Display Order 1
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost():0.00}\n");

        //Display Order 2

    }
}