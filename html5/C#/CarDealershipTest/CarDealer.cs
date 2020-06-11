using System;

namespace CarDealershipTest
{
    class CarDealer
    {
        public string CarMake { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        private decimal salesPrice; 
         
        public CarDealer(string carmake, string model, int year, decimal salespr)
        {
            CarMake = carmake;
            Model = model;
            Year = year;
            SalesPrice = salespr;
        }

        public decimal SalesPrice
        {
            get{ return salesPrice; }

            set
            {
                if(value > 0)
                {
                    salesPrice = value;
                }
            }
        }

         public override string ToString()
        {
           return $"{Year} {CarMake} {Model} {SalesPrice}";
        }
    }
}
