using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
namespace StandardQuery
{
    public class ShoppingCart
    {
        public List<Product> ProductItems {get;set;} = new List<Product>();

        public class Product
        {
            public string ProductName {get;set;}
            public decimal ProductPrice {get; set;}

            public string Category { get; set; }
            //public string Category {get; set;}
        }
    }
}