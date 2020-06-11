using System;
using System.Collections.Generic;

namespace CarDealershipTest
{
    class Program
    {
        static void Main(string[] args)
        {
           List<CarDealer> cars = new List<CarDealer>();

           Console.WriteLine("\n\nWelcome to Olusoji and Son Cool “Tokunbo” Autos!\n\n");
          
           Console.WriteLine("Enter either add/list/quit to add to catalog or view list of cars or end");
           string resp = Console.ReadLine().ToLower();

            if(resp == "quit"){

                Console.WriteLine("Thank you, Goodbye!");

            }else if (resp == "list" )
            {
                Console.WriteLine("Sorry, there are currently no car in the catalogue");

            }else if(resp == "add"){

                 while(resp == "add")
                {
                        Console.WriteLine("Enter the car's make: ");
                        string make = Console.ReadLine();

                        Console.WriteLine("Enter the car's model: ");
                        string model = Console.ReadLine();

                        Console.WriteLine("Enter the car's year of manufacture: ");
                        int year = int.Parse(Console.ReadLine());

                        Console.WriteLine("Enter the car's price: ");
                        decimal price = decimal.Parse(Console.ReadLine());

                        CarDealer cardealer = new CarDealer(make, model, year, price);
                        cars.Add(cardealer);
                        
                        Console.WriteLine("Enter either add/list/quit to add to catalog or view list of cars or end");
                        resp = Console.ReadLine().ToLower();
                        
                }
                if(resp == "list")
                {
                    decimal total = 0;
                    int counter = 0;
                    foreach (var item in cars)
                    {
                        Console.WriteLine(item);
                        counter++;
                        total += item.SalesPrice;
                    }
                    Console.WriteLine($"Number of cars: {counter}\nTotal inventory: {total:C}");
                }else if(resp == "quit"){

                    Console.WriteLine("Thank you, Goodbye!");

                }else if(resp != "add" || resp != "list" || resp != "quit")
                {
                     Console.WriteLine($"\nSorry but {resp} is not a valid command, Please try again");
                }

            } else if(resp != "add" || resp != "list" || resp != "quit")
            {
                    Console.WriteLine($"Sorry but {resp} is not a valid command, Please try again");
            }
        }
    }
}
