using System;

namespace BaseDerived
{
    class Program
    {
        static void Main(string[] args)
        {
            //Assigning a base-class reference to a base class variable is straight forward
            Account1 account2 = new Account1();

            //Assigning a derived-class reference to a derived class variable is straight forward
            Account2 account = new Account2();

            //Assigning a derived class reference to a base class variable is safe, because the derived class object is an object of its base class
            //How ever this reference can be used to refer only to base class members.
            Account1 bal = new Account2();

            //Attempting to assign a base class reference to a derived class variable is a compilation error, the base class reference must be cast
            //cast to a derived class type explicitly
            Account2 amount = new Account1() as Account1;

        }
    }
}
