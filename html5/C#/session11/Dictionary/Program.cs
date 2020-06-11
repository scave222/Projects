using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary dictionary = new Dictionary();
             dictionary.Add("Name", "Caleb");
            dictionary.Add("Email", "okogbecaleb@gmail.com");
            dictionary.Add("ID", "546");
            dictionary.Add("Age", 45);

            Console.WriteLine(dictionary["Name"]);     
            Console.WriteLine(dictionary["Email"]);  
            Console.WriteLine(dictionary["ID"]);     
            Console.WriteLine(dictionary["Age"]);   

            Console.WriteLine("\n Showing the keys");
            foreach(object key in dictionary.Keys)
            {
                Console.WriteLine(key + ":"+ dictionary[key]);
            }
        }
    }
}
