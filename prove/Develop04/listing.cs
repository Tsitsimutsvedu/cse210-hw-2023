using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        Console.WriteLine("Please enter the area you want to list things for:");
        string area = Console.ReadLine();

        Console.WriteLine("Please enter the duration of the activity in minutes:");
        int duration = int.Parse(Console.ReadLine());

        Console.WriteLine($"You will now list as many things as you can for {duration} minutes in the area of {area}.");

        List<string> items = new List<string>();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddMinutes(duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("Enter an item: ");
            string item = Console.ReadLine();
            items.Add(item);
        }

        Console.WriteLine("You have listed the following items:");
        foreach (string item in items)
        {
            Console.WriteLine(item);
        }
    }
}
