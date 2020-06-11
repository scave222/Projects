using System;
using System.Collections;
using System.Collections.Generic;

namespace Dic
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, object> dictionary = new Dictionary<string, object>();
            dictionary.Add("Name", "Caleb");
            dictionary.Add("Email", "okogbecaleb@gmail.com");
            dictionary.Add("ID", "546");
            dictionary.Add("Age", 45);

            Console.WriteLine(dictionary["Name"]);     
            Console.WriteLine(dictionary["Email"]);  
            Console.WriteLine(dictionary["ID"]);     
            Console.WriteLine(dictionary["Age"]);   

            // Console.WriteLine("\n Showing the keys");
            // foreach(object key in dictionary.Keys)
            // {
            //     Console.WriteLine(key  + ":"+ dictionary[key]);
            // }

            ArrayList list = new ArrayList(5);
            list.Add("Caleb");
            list.Add("john");
            list.Add("James");

            list.Remove("john");
            foreach(var item in list)
            {
                Console.WriteLine(item);
            }

            list.RemoveAt(1);
             foreach(var item in list)
            {
                Console.WriteLine(item);
            }   

            string[] newNames = new string[]{"Bill Gates", "Steve Jobs", "Elon Mark","Caleb Okogbe" };

            list.AddRange(newNames);
            foreach(var item in list)
            {
                Console.WriteLine(item);
            }

            bool result = list.Contains("Bill Gates");
            Console.WriteLine($"The array list contains an item called Bill Gate {result}");

            Console.WriteLine($"The capacity of ArrayList is {list.Capacity}\nThe number of elements in the array list is {list.Count}");
            
        }
    }
}
