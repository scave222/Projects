using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
namespace ShoppingCartTest
{
    public class ShoppingCart
    {
        public List<Product> ProductItems {get;set;} = new List<Product>();
        public decimal GenerateTotalPrice(DiscountDelegate a, AlertUserSub informUserSub)
        {
            //GetSumTotal();
            decimal subTotal = ProductItems.Sum(p => p.ProductPrice);
            informUserSub(subTotal);
            decimal TotalPrice = a(subTotal);

            return TotalPrice;
            
        }

        // private decimal GetSumTotal()
        // {
        //     decimal sum = 0M;
        //     foreach(Product product in ProductItems)
        //     {
        //         sum += product.ProductPrice;
        //     }
        //     return sum;
        // }
    }
}