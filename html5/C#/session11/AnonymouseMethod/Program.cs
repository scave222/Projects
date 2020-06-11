using System;

namespace AnonymouseMethod
{
    public delegate void MyAnonymouseDelegate();
    public delegate void AnonymouseDelegate(string name);
    class Program
    {
        static void Main(string[] args)
        {
            string myName = "James Stuart";
            MyAnonymouseDelegate sendGreetings = delegate(){
                Console.WriteLine(myName + ":Hi there, this is getting interesting!");

            };

            sendGreetings();

            string message = "this is getting interesting!";
             AnonymouseDelegate sendGreet = delegate(string name){
                Console.WriteLine($"{name}! {message}");
                
            };

            sendGreet("Caleb");
        }
    }
}
