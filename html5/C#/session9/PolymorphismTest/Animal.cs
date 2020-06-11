using System;
namespace PolymorphismTest
{
    public abstract class Animal
    {
        public string AnimalName { get; set; }
        public abstract void eat();

        public Animal(string animalName)
        {
            AnimalName = animalName;
        }

        public override string ToString()
        {
            return $"I am a {AnimalName}\n";
        }
    }

    public class Dog : Animal
    {
        public Dog(string animalName) : base(animalName)
        {

        }
        public void Bark()
        {
            Console.WriteLine("And i can also bark!!! Woop woop woop");
        }
        public override void eat()
        {
            Console.WriteLine($"{base.ToString()} I like to eat bones");
        }
    }

    public class Cow : Animal
    {
        public Cow(string animalName) : base(animalName)
        {
            
        }
        public override void eat()
        {
            Console.WriteLine($"{base.ToString()} I like to eat grass");
        }
    }

    public class Cat : Animal
    {
        public Cat(string animalName) : base(animalName)
        {
            
        }
        public override void eat()
        {
            Console.WriteLine($"{base.ToString()} I like to eat fish");
        }
    }

    public class Lion : Animal
    {
        public Lion(string animalName) : base(animalName)
        {
            
        }
        public override void eat()
        {
            Console.WriteLine($"{base.ToString()} I like to eat fresh meat");
        }
    }
}