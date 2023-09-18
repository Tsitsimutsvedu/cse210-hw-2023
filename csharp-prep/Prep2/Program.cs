using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string answer = Console.ReadLine();
        int percent = int.Parse(answer);

        string letter = "";

        if (percent >= 90)
        {
            letter = "A";
            Console.WriteLine($"You got an {letter} in the class! Congratulations!");
        }
        else if (percent >= 80)
        {
            letter = "B";
            Console.WriteLine($"You got an {letter} in the class! Congratulations!");
        }
        else if (percent >= 70)
        {
            letter = "C";
            Console.WriteLine($"You got an {letter} in the class! Congratulations!");
        }
        else if (percent >= 60)
        {
            letter = "D";
          Console.WriteLine("Better luck. Try next time!");  
        }
        else
        {
            letter = "F";
            Console.WriteLine("Better luck. Try next time!");
        }

        Console.WriteLine($"Your grade is: {letter}");
        
        if (percent >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("You failed!");
        }
    }
}