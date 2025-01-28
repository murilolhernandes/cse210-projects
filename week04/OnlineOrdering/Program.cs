using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the OnlineOrdering Project.");
        // Costumer costumer1 = new Costumer("Murilo", "872 Anne St", "Rexburg", "ID", 83440, "USA");
        // costumer1.DisplayCostumerInfo(costumer1.AddressString());
        // Order order1 = new Order(new List<Product>(), new Costumer("Murilo", "872 Anne St", "Rexburg", "ID", 83440, "USA"));
        // Console.WriteLine(order1);
        Order order1 = new Order(new Costumer("Murilo", "872 Anne St", "Rexburg", "ID", 83440, "USA"), new Product("Product Name", 480320, 99.99, 3));
        order1.DisplayOrderInfo();
    }
}

// new List<Product>("Product Name", 480320, 99.99, 3), 