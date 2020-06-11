using System;
using System.Collections.Generic;
using System.Text;

namespace IAnimal
{
    class Crocodile:IAnimal,IMarineAnimal
    {
        void IAnimal.Eat()
        {
            Console.WriteLine("i eat meat");
        }

         void IMarineAnimal.Eat()
        {
            Console.WriteLine("i eat FISH");
        }
        public void Habitat()
        {
            Console.WriteLine("I live in water");
        }

        public void Swim()
        {
            Console.WriteLine("I can swim");
        }
    }
}

    