using System;

namespace Invoices
{
    class Program
    {
        static void Main(string[] args)
        {

            
            Console.Write($"Enter a part number : ");
            string partnumber = Console.ReadLine();
            
            Console.Write($"Enter the price : ");
            int price =Convert.ToInt32(Console.ReadLine());
            
            Console.Write($"What do you want to buy? : ");
            string partdescription = Console.ReadLine();
            Console.Write($"How many? : ");
            int quantity = Convert.ToInt32(Console.ReadLine());
            

            Invoice details = new Invoice( partnumber, partdescription, quantity, price);

            Console.WriteLine ($" Invoice: {details.PartNumber} \nItem purchased {details.PartDescription}\nQuantity: {details.Qty} \nPrice for each: {details.Priz} \nTotal cost is: {details.GetInvoiceAmount():C}");
        }
    }
}
