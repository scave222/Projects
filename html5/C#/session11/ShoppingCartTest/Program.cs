using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
namespace ShoppingCartTest
{
    public delegate decimal DiscountDelegate(decimal amount);
    public delegate void AlertUserSub(decimal sub);
    class Program
    {
        static ShoppingCart cart = new ShoppingCart();
        static void Main(string[] args)
        {
            PopulateCart();

            decimal TotalP = cart.GenerateTotalPrice(ApplyDiscount, ShowUserSubTotal);

            Console.WriteLine($"The total price is {TotalP:C2}");
        }

        static private decimal ApplyDiscount(decimal subTotal)
        {
            if (subTotal > 3000M)
            {
                return subTotal * 0.85M;
            }else if (subTotal > 2000)
            {
                return subTotal * 0.90M;
            }else if(subTotal > 1000)
            {
                return subTotal * 0.95M;
            }else {
                return subTotal;
            }
        }


        static public void PopulateCart()
        {
            cart.ProductItems.Add(new Product{ProductName = "Indomie", ProductPrice = 100M});
            cart.ProductItems.Add(new Product{ProductName = "Kiwi Shoe Polish", ProductPrice = 250M});
            cart.ProductItems.Add(new Product{ProductName = "5KG Rice", ProductPrice = 2000M});
            cart.ProductItems.Add(new Product{ProductName = "3 Ltrs Power Oil", ProductPrice = 170M});
            cart.ProductItems.Add(new Product{ProductName = "Indomie", ProductPrice = 100M});
        }

        private static void ShowUserSubTotal(decimal subTotal)
        {
            Console.WriteLine($"Initial price is {subTotal:C2}");
        }
    }

    
}
