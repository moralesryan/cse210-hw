using System;
using System.Net.Http.Headers;

class Program
{
    static void Main(string[] args)
    {
        //CUSTOMER #1 
        Address address1 = new Address("882 Main St", "Wilmington", "California", "United States");
        Customer customer1 = new Customer("Armando Trujillo", address1);
        //ORDER #1
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Beats by dre", 9981, 450.00, 1));
        order1.AddProduct(new Product("Macbook Air", 1882, 900.00, 1));
        order1.AddProduct(new Product("Ipad mini", 8810, 300.00, 2));

        //CUSTOMER #2 
        Address address2 = new Address("1317 Amigo St", "Reseda", "California", "United States");
        Customer customer2 = new Customer("Carla Ponce", address2);
        //ORDER #2
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Samsung Crystal HD Smart TV '65", 1199, 1400.00, 1));
        order2.AddProduct(new Product("PlayStation 5", 4882, 300.00, 1));
        order2.AddProduct(new Product("GTA 6", 1922, 10000.00, 1));

        //CUSTOMER #3 
        Address address3 = new Address("918 Wagwan St", "South London", "London", "United Kingdom");
        Customer customer3 = new Customer("Carla Ponce", address3);
        //ORDER #3
        Order order3 = new Order(customer3);
        order3.AddProduct(new Product("Dualshock 5", 1319, 100.00, 2));
        order3.AddProduct(new Product("HP Monitor", 3123, 250.00, 1));

        //PRINT ORDER 1
        Console.WriteLine(order1._displayPackingLabel());
        Console.WriteLine(order1._displayShippingLabel());
        Console.WriteLine($"Total Cost: ${order1._calcTotalCost()}");
        Console.WriteLine("-----------------------------------------------");
        Console.WriteLine("");

        //PRINT ORDER 2
        Console.WriteLine(order2._displayPackingLabel());
        Console.WriteLine(order2._displayShippingLabel());
        Console.WriteLine($"Total Cost: ${order2._calcTotalCost()}");
        Console.WriteLine("-----------------------------------------------");
        Console.WriteLine("");

        //PRINT ORDER 3
        Console.WriteLine(order3._displayPackingLabel());
        Console.WriteLine(order3._displayShippingLabel());
        Console.WriteLine($"Total Cost: ${order3._calcTotalCost()}");
        Console.WriteLine("-----------------------------------------------");        
        Console.WriteLine("");

    

    }
}