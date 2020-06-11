using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace StandardQuery
{
    class Program
    {
        static void Main(string[] args)
        {
            ShoppingCart cart = new ShoppingCart();
            cart.ProductItems.Add(new ShoppingCart.Product{ProductName = "Kiwi", ProductPrice = 200M, Category = "Household Item"});
            cart.ProductItems.Add(new ShoppingCart.Product{ProductName = "Wristwatch", ProductPrice = 200M, Category = "Fashion"});
            cart.ProductItems.Add(new ShoppingCart.Product{ProductName = "Fan", ProductPrice = 200M, Category = "Household Item"});
            cart.ProductItems.Add(new ShoppingCart.Product{ProductName = "HTC Phone", ProductPrice = 5000M, Category = "Electronics"});
            cart.ProductItems.Add(new ShoppingCart.Product{ProductName = "HP Laptop", ProductPrice = 15000M, Category = "Electronics"});
            cart.ProductItems.Add(new ShoppingCart.Product{ProductName = "Charger", ProductPrice = 600M, Category = "Electronics"});
            cart.ProductItems.Add(new ShoppingCart.Product{ProductName = "Indomie Park", ProductPrice = 1200M, Category = "Fashion"});
            

            var TotalPrice = cart.ProductItems.Sum(p => p.ProductPrice);

             Console.WriteLine($"Product Name\tProduct Price");

            //  var a= cart.ProductItems.OrderByDescending(p => p.ProductPrice).ToList();
            //  foreach(var s in a){
            //      Console.WriteLine($"{s.ProductName} \t{s.ProductPrice}");
            //  }
             
             

            foreach(var product in cart.ProductItems.OrderBy(p => p.Category)) //Orderby like sort it by
            {
                Console.WriteLine($"{product.ProductName, -18}{product.ProductPrice:C2}");
            }

            Console.WriteLine($"The total price of {cart.ProductItems.Count} items is {TotalPrice:C2}");

            var householdItems = from p in cart.ProductItems   //IEnumerable<>
                    where p.Category == "Household Item"
                    select p;

            Console.WriteLine($"=====Executing Linq using Query Syntax======");
            foreach(var product in householdItems)
            {
                Console.WriteLine($"{product.ProductName, -18}{product.ProductPrice:C2}");
            }

            Console.WriteLine($"=====Executing Linq using Method Syntax======");
            foreach(var product in cart.ProductItems.Where(p => p.Category == "Household Item"))
            {
                Console.WriteLine($"{product.ProductName, -18}{product.ProductPrice:C2}");
            }
        }

    }
}
