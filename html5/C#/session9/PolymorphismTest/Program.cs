using System;
using System.Collections.Generic;

namespace PolymorphismTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog("Dog");
            Cow cow = new Cow("Cow");
            Cat cat = new Cat("Cat");
            Lion lion = new Lion("Lion");

            List<Animal> animals = new List<Animal>(){dog,cow,cat,lion};

            foreach (Animal animal in animals)
            {
                animal.eat();
                if (animal is Dog)
                {
                    Dog myDog = animal as Dog;
                    myDog.Bark();
                }
            }
        }
    }
}
