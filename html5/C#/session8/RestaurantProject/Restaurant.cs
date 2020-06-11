using System;
namespace RestaurantProject
{
    public class Restaurant
    {
        private string name;
        private string address;
        private double gratuityrate;

        public Restaurant(string name, string address, double rate)
        {
            Name = name;
            Address = address;
            GratuityRate = rate;
        }

        public string Name 
        { get{return name;}
         set{name = value;} 
         }

         
        public string Address 
        { get{return address;}
         set{address = value;} 
         }

         public double GratuityRate
         {
             get{return gratuityrate;}
            set{ if(value >= 0.0)
            {
                gratuityrate = value;
            }
            }
         }

         public void GenerateReceipt()
         {
             decimal price = 0M;
             decimal subtotal = 0M;
             decimal gratuityAmount = 0M;
             int numPeople = 0;
             decimal grandTotal = 0M;

             while(price != -1M)
             {  
                 subtotal = subtotal + price;
                 Console.Write("Please enter price for food item[-1 to quit]: ");
                 price = Convert.ToDecimal(Console.ReadLine());
                

             }
             Console.Write("Enter number of people: ");
             numPeople = Convert.ToInt32(Console.ReadLine());

             if (numPeople >= 6)
             {
                 gratuityAmount = (decimal)(GratuityRate) * subtotal;
             }
              grandTotal = subtotal + gratuityAmount;

              Console.WriteLine("=========MR BIGGS RESTAURANT=========");
              Console.WriteLine("===========Customer Details===========");
              Console.WriteLine($"Name:\t{Name}\nAddress:\t{Address}");
              Console.WriteLine("==========Receipt==========");
              Console.WriteLine($"Subtotal:\t{subtotal:C}\n{GratuityRate*100}% Gratuity:\t{gratuityAmount:C}\nGrand Total:\t{grandTotal:C}\n\n...always fresh!");
         }
    }
    }