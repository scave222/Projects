using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace SystemCollections
{
    public class Employee : DictionaryBase
    {
        public void Add(int id, string name)
        {
            Dictionary.Add(id, name);
        }
        public void OnRemove(int id)
        {
            Console.WriteLine("You are going to delete record containing ID: " + id);
            Dictionary.Remove(id);
        }
        public void GetDetails()
        {
            IDictionaryEnumerator objEnumerate = Dictionary.GetEnumerator();
            while (objEnumerate.MoveNext())
            {
                Console.WriteLine(objEnumerate.Key.ToString() + "\t\t" + objEnumerate.Value);
            }
        }
        
    }
}