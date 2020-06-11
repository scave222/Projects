using System;
namespace PizzaOrderAPP
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ordersPizza = new int [4];
            double getOrders = 0.0;
            string small = "Small Pizza";
            string medium = "Medium Pizza";
            string large = "Large Pizza";
            for (int i = 0; i < ordersPizza.Length; i++)
            {
                Console.WriteLine($"Enter the Order of people that eat {i+1} Slice of Pizza:");
                double orders = Convert.ToDouble(Console.ReadLine());
                getOrders += (orders *(i+1));
            }
            double order = getOrders;
            if (order <= 4)
            {
                Console.Write($"Buy One {small}");
            }
            else if (order > 4 && order <= 6)
            {
                Console.Write($"Buy One {medium}");
            }
            else
            {
                if (order > 6 && order < 8)
                {
                    Console.Write($"Buy One {large}");
                }
                if (order >= 8)
                {
                    if (order % 8 == 0)
                    {
                        double b = order / 8;
                        Console.WriteLine($"Buy {b} {large}");
                    }
                    if (order % 8 == 7)
                    {
                        double b = order / 8;
                        double a = Math.Floor(b);
                        Console.WriteLine($"Buy {a + 1} {large} of Pizza");
                    }
                    if (order % 8 >= 5 && order % 8 <= 6)
                    {
                        double b = order / 8;
                        double a = Math.Floor(b);
                        double c = Math.Ceiling(b);
                        double e = c - a;
                        Console.WriteLine($"Buy {a} {large} and {e} {medium}");
                    }
                    if (order % 8 < 5 && order % 8 > 0)
                    {
                        double b = order / 8;
                        double a = Math.Floor(b);
                        double c = Math.Ceiling(b);
                        double e = c - a;
                        Console.WriteLine($"Buy{a} {large} and {e} {small} of Pizza");
                    }
                }
            }
        }
    }
}