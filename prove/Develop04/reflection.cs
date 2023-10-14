using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience. By focusing on these moments, you can recognize the power you have and how you can use it in other aspects of your life.");

        Console.WriteLine("Please take a few minutes to think about a time when you faced a challenge or overcame an obstacle. Write down what happened, how you felt, and what you did to overcome the challenge.");

        List<string> items = new List<string>();

        Console.WriteLine("When you're ready, press any key to continue.");

        Console.ReadKey();

        Console.WriteLine("Now, take some time to reflect on what you learned from this experience and how it has helped you grow as a person. Write down your thoughts and feelings.");

        Console.WriteLine("When you're done, press any key to see what you've written.");

        Console.ReadKey();

        Console.WriteLine("You have written the following:");

        foreach (string item in items)
        {
            Console.WriteLine(item);
        }
    }
}
