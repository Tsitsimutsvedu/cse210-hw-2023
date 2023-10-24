using System;

namespace Polymorphism
{
    class Animal
    {
        public virtual void animalSound()
        {
            Console.WriteLine("The animal makes a sound");
        }
    }

    class Pig : Animal
    {
        public override void animalSound()
        {
            Console.WriteLine("The pig says: wee wee");
        }
    }

    class Dog : Animal
    {
        public override void animalSound()
        {
            Console.WriteLine("The dog says: bow wow");
        }
    }

    class Cat : Animal
    {
        public override void animalSound()
        {
            Console.WriteLine("The cat says: meow meow");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Animal myAnimal = new Animal();
            Animal myPig = new Pig();
            Animal myDog = new Dog();
            Animal myCat = new Cat();

            myAnimal.animalSound();
            myPig.animalSound();
            myDog.animalSound();
            myCat.animalSound();
        }
    }
}
