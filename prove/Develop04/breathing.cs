
using System;
using System.Threading;

class BreathingActivity
{
    static void Main(string[] args)

    {
      Console.WriteLine("Hello Develop04 World!");  
    }
    {
     StartBreathing(60);
    }

    static void StartBreathing(int duration)
    {
        Console.WriteLine("Welcome to the breathing activity!");
        Console.WriteLine("Please breathe in and out slowly for {0} seconds.", duration);

        for (int i = 0; i < duration; i++)
        {
        Console.WriteLine("Breathe in...");
        Thread.Sleep(3000);
        Console.WriteLine("Breathe out...");
        Thread.Sleep(3000);
        }

         Console.WriteLine("The breathing activity is complete.");
    }
}
