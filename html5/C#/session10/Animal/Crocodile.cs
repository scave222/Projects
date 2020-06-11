using System;
namespace Animal
{
    public class Crocodile : IAnimal, IMarineAnimal
    {
        void IAnimal.Eat()
        {
            Console.Write("I eat terrestial food");
        }
        public void Habitat()
        {
            Console.WriteLine("I live in water");
        }

        
        void IMarineAnimal.Eat()
        {
            Console.WriteLine("I eat marrine food");
        }
        public void Swim()
        {
            Console.WriteLine("I can swim");
        }
    }
}