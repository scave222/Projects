using System;
using System.Collections;

namespace Hash
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable hashTable = new Hashtable();
            hashTable.Add("Name", "Caleb");
            hashTable.Add("Email", "okogbecaleb@gmail.com");
            hashTable.Add("ID", "546");
            hashTable.Add("Age", 45);

            Console.WriteLine(hashTable["Name"]);     
            Console.WriteLine(hashTable["Email"]);  
            Console.WriteLine(hashTable["ID"]);     
            Console.WriteLine(hashTable["Age"]);   

            Console.WriteLine("\n Showing the keys");
            foreach(object key in hashTable.Keys)
            {
                Console.WriteLine(key + ":"+ hashTable[key]);
            }

            
            
            //  Console.WriteLine("\n Showing the values");
            //  foreach(object key in hashTable.Values)
            // {
            //     Console.WriteLine(key);
            // }

        }
    }
}
