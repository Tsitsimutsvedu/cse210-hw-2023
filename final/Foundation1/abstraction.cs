using System;

abstract class Animal {
    public abstract void animalSound();
    public void sleep() {
        Console.WriteLine("Zzz");
    }
}

class Sheep : Animal {
    public override void animalSound() {
        Console.WriteLine("The sheep says: wee wee");
    }
}

class Program {
    static void Main(string[] args) {
        Sheep mySheep = new Sheep();
        mySheep.animalSound();
        mySheep.sleep();
    }
}
