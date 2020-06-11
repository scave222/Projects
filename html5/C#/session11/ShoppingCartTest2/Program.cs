using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingCartTest2
{
   
    class Program
    {
        static ShoppingCart cart = new ShoppingCart();
        static void Main(string[] args)
        {
            Console.WriteLine("Cart Items summary\n____________________________");
            
            PopulateCart(); //Call populate cart to insert items into shopping cart productItems with someitems.
            foreach(var item in cart.ProductItems)
            {
                Console.WriteLine($"{item.ProductName} \t {item.ProductPrice:C}");
            }
            //Get total price of all items after discount has been applied by passing Applydiscount method as parameter to shhoppingCart 
            //GenerateTotal method through our knowledge of delegat.... Note that  a method can be passed as argument to another method 
            // but it must done through a delegate

            decimal TotalPrice = cart.GenerateTotalPrice(ApplyDiscount, NotifyUserPrice, NotifyUserOfDiscount);
            Console.WriteLine($"Total price \t {TotalPrice:C}\nThank you for your patronage");
        }

        static decimal ApplyDiscount(decimal subTotal)
        {
            if (subTotal > 3000)
            {
                return subTotal * 0.85M;
            }else if(subTotal > 2000)
            {
                return subTotal * 0.9M;
            }
            else if(subTotal > 1000)
            {
                return subTotal * 0.95M;
            }
            else {return subTotal;}
        }
        static void PopulateCart()
        {
            cart.ProductItems.Add(new Product{ProductName = "Indomie", ProductPrice = 1000M});
            cart.ProductItems.Add(new Product{ProductName = "Kiwi Polish", ProductPrice = 200M});
            cart.ProductItems.Add(new Product{ProductName = "5KG Rice", ProductPrice = 2000M});
            cart.ProductItems.Add(new Product{ProductName = "T-Shirt", ProductPrice = 1500M});
        }

        static void NotifyUserPrice(decimal subTotal)
        {
            Console.WriteLine($"____________________________\nSub total \t {subTotal:C2}");
        }

        static void NotifyUserOfDiscount()
        {
            Console.WriteLine($"We are applying discount to your order");
        }
    }
}
