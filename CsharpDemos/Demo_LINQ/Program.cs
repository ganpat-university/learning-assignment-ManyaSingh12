using System;
using System.Collections.Generic;
namespace Demo_LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
           List<Product> products = new List<Product>()
            {
                new Product { ProductID = 3, ProductName = "wheat", Price = 25.75M, Quantity = 30 },
                new Product { ProductID = 1, ProductName = "rice", Price = 20.75M, Quantity = 70 },
                new Product { ProductID = 2, ProductName = "salt", Price = 12.75M, Quantity = 20 }
            };
            Console.WriteLine("List of products");
            Console.WriteLine("{0:000}{1,-20} {2,15}",
                "ID", "Name", "Price", "Quantity", "Cost");

            foreach (Product p in products)
            {
               Console .WriteLine("{0:000}{1,-20} {2,15}",p.ProductID,p.ProductName,p.Quantity,p.Price,p.Price*p.Quantity);
            }
            products.Sort();
            Console.WriteLine("List of products");
            Console.WriteLine("{0:000}{1,-20} {2,15}", "ID", "Name", "Price", "Quantity", "Cost");

            foreach (Product p in products)
            {
                Console.WriteLine("{0:000}{1,-20} {2,15}", 
                    p.ProductID, p.ProductName, p.Quantity, p.Price, p.Price * p.Quantity);
            }
           
        }
    }
}
