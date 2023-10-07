using System;
class Program
{
    static void Main(string[] args)

    {
        console WriteLine()


        Reference reference1 = new Reference ("John 3:16");
        Scripture scripture1 = new Scripture (reference1,"For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.");

        Console.WriteLine($"{reference1.GetDisplayText()} {scripture1.GetDisplayText()} ");

        Console.WriteLine();
    }
}
