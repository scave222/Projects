using System;

namespace RestaurantProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Restaurant restaurant = new Restaurant("James Stuart", "KM 20 Austine House", 0.15);

            restaurant.GenerateReceipt();
        }
    }
}
