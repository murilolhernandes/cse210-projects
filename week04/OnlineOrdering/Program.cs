using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");
        Console.WriteLine();
        List<Order> orders = new List<Order>();
        Order order1 = new Order(new Custumer("John Doe", "271 R. Yolanda Ramiro Brilho", "São Pedro", "SP", 13520-000, "Brasil"));
        order1.GetProduct(new Product("Product A", 480320, 99.99, 3));
        order1.GetProduct(new Product("Product B", 480325, 50.50, 2));
        orders.Add(order1);

        Order order2 = new Order(new Custumer("Jane Doe", "123 Main St", "Springfield", "IL", 62701, "USA"));
        order2.GetProduct(new Product("Product C", 480330, 20.00, 5));
        order2.GetProduct(new Product("Product D", 480335, 15.75, 4));
        orders.Add(order2);

        foreach (Order order in orders)
        {
            Console.WriteLine("Order Details:\n");
            order.DisplayOrderInfo();
            Console.WriteLine();
        }
    }
}