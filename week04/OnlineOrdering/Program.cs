using System;

class Program
{
    static void Main(string[] args)
    {
        // Order 1
        Address addr1 = new Address("123 Main St", "Springfield", "IL", "USA");
        Customer cust1 = new Customer("John Doe", addr1);
        Order order1 = new Order(cust1);
        order1.AddProduct(new Product("Book", "B001", 12.99m, 2));
        order1.AddProduct(new Product("Pen", "P100", 1.50m, 5));

        // Order 2
        Address addr2 = new Address("456 King St", "Toronto", "ON", "Canada");
        Customer cust2 = new Customer("Jane Smith", addr2);
        Order order2 = new Order(cust2);
        order2.AddProduct(new Product("Notebook", "N200", 5.99m, 3));
        order2.AddProduct(new Product("Backpack", "BP400", 39.99m, 1));

        // Display order1 info
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalPrice():0.00}\n");

        // Display order2 info
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalPrice():0.00}");
    }
}
