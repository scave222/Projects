using System;

namespace IAnimal
{
    class Program
    {
        static void Main(string[] args)
        {
            Crocodile crocodile = new Crocodile();
            crocodile.Swim();
            crocodile.Habitat();
            IMarineAnimal marineAnimal = crocodile;
            marineAnimal.Eat();
            IAnimal animal = crocodile;
            animal.Eat();
        }
    }
}
