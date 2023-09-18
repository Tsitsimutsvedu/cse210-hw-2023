using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int number;
        List<int> numberList = new List<int>();

        Console.WriteLine("Enter a list of numbers, then type 0 when you are done");

        bool zero=false;
        while(!zero)

        {
            Console.WriteLine("Enter a number: ");
            number=Convert.ToInt32(Console.ReadLine());
            numberList.Add(number);
        }
        
            if (number==0)
            {
                zero=true;
        }
        
        int sumOfAllNumbers=numberList.Sum();
    
        {
            Console.WriteLine($"The sum of all numbers is: {sumOfAllNumbers} ");
            
                   
        float averageOfAllNumbers = ((float)sumOfAllNumbers/(numberList.Count-1));
        Console.WriteLine($"The average of all numbers is: {averageOfAllNumbers}");

            
        int largestNumber = numberList.Max();
        Console.WriteLine($"The largest number in the list was {largestNumber} ");
        }
    }
}

       