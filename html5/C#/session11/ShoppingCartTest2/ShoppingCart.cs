using System.Collections.Generic;
using System;
using System.Linq;
using System.Collections;
namespace ShoppingCartTest2
{
     public delegate void NotifyDiscountDelegate();
    public class ShoppingCart
    {
        public List<Product> ProductItems {get; set;} = new List<Product>();

        public decimal GenerateTotalPrice(Func<decimal, decimal> applydis, Action<decimal> notifyUserPrice,NotifyDiscountDelegate notifyDiscount )
        {
            decimal subTotal = ProductItems.Sum(p => p.ProductPrice);
            decimal TotalPrice = applydis(subTotal);
           
            // foreach(var item in ProductItems)
            // {
            //     Console.WriteLine($"{item.ProductName} \t {item.ProductPrice:C}");
            // }

            notifyUserPrice(subTotal);
            // if (subTotal != TotalPrice)
            // {
            //     notifyDiscount();
            // }

            return TotalPrice;

            
        }
    }
}