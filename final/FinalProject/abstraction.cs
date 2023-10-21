
//This code defines an abstract class Animal with an abstract method animalSound() 
//and a regular method sleep(). The Pig class inherits from the Animal class and implements the animalSound() method.
 //The Main() method creates a new instance of the Pig class and calls its methods.



abstract class Animal {
    public abstract void animalSound();
    public void sleep() {
        Console.WriteLine("Zzz");
    }
}

class Pig : Animal {
    public override void animalSound() {
        Console.WriteLine("The pig says: wee wee");
    }
}

class Program {
    static void Main(string[] args) {
        Pig myPig = new Pig();
        myPig.animalSound();
        myPig.sleep();
    }
}
