using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop04 World!");

        for (int i=5; i > 0; i--)
        {
        Console.Write(i);
        Thread.Sleep(3000);
        Console.Write("\b \b");
        }
        Console.WriteLine("Done.");
        
    }


}