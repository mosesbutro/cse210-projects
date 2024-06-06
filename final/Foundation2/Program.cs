using System;

class Program
{
    static void Main(string[] args)
    {
        // Create some products
        Product product1 = new Product("Widget", "W123", 15.00m, 2);
        Product product2 = new Product("Gadget", "G456", 25.00m, 1);
        Product product3 = new Product("Doodad", "D789", 10.00m, 5);

        // Create addresses
        Address address1 = new Address("123 Elm St", "Springfield", "IL", "USA");
        Address address2 = new Address("456 Maple Ave", "Toronto", "ON", "Canada");

        // Create customers
        Customer customer1 = new Customer("Jack Dayo", address1);
        Customer customer2 = new Customer("Bola Smith", address2);

        // Create orders and add products
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product3);

        // Display order details
        Console.WriteLine("Order 1:");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order1.PackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.ShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.TotalCost()}");

        Console.WriteLine();

        Console.WriteLine("Order 2:");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order2.PackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order2.ShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.TotalCost()}");
    }
}