using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");

        // Test Adress class or object
        Address direcctionJofre = new Address("Carlos Pellegrini Este 122", "Saint Louis", "Missouri", "USA");
        Address direcctionVelazcos = new Address("Andres Marraaspin 3960", "Lanus", "Buenos Aires", "Argentina");

        //test Customers
        Customer fliaJofre = new Customer("Ignacio", direcctionJofre);
        Customer fliaVelazcos = new Customer("Dani", direcctionVelazcos);

        //Test Products
        Product product1 = new Product("Xbox Series X", "Z7001", 599.99, 1);
        Product product2 = new Product("Laptop", "Z8002", 1000, 1);
        Product product3 = new Product("Refrigerator", "Z9000", 1999.99, 1);
        Product product4 = new Product("LED Lights", "P700", 0.50, 7);
        Product product5 = new Product("Xbox Controller", "Z8507", 61.99, 2);

        //Create orders
        Order order1 = new Order(fliaJofre);
        order1.AddProduct(product2);
        order1.AddProduct(product4);

        Order order2 = new Order(fliaVelazcos);
        order2.AddProduct(product1);
        order2.AddProduct(product3);
        order2.AddProduct(product5);

        //Print all

        Console.WriteLine("Order 1");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShipingLabel());
        Console.WriteLine($"Total: ${order1.CalculateTotalCost()}\n");
        Console.WriteLine();

        Console.WriteLine("Order 2");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShipingLabel());
        Console.WriteLine($"Total: ${order2.CalculateTotalCost()}\n");
        Console.WriteLine();



    }
}