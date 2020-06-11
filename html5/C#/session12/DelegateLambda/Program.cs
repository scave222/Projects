using System;

namespace DelegateLambda
{
    public delegate void StringDel(string a);
    class Program
    {
        static void Main(string[] args)
        {
            StringDel CountPhrase = (b) => {
                int c = b.Length;
                Console.WriteLine(c);
                Console.WriteLine(b);
            };

            CountPhrase("Mathew");
        }
    }
}
