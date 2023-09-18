using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("what is the magic number?");
        string rawMagicNum = Console.ReadLine();
        int magicNum = int.Parse(rawMagicNum);
        bool isGuessCorrect = false;
        while(!isGuessCorrect)
        Console.Write("What is your guess? ");
        string rawGuess = Console.ReadLine();
        int guess = int.Parse(rawGuess);

        if (magicNum > guess)

        {
            Console.WriteLine("try higher");
        }

        else if (magicNum < guess)
        {
            Console.WriteLine("try lower");
        }
        else
        {
            Console.WriteLine("Correct! Nice Job!");
        }
    }
}

        