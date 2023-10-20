using System;
using System.Runtime.Intrinsics.Arm;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop05 World!");
    
    GoalManager goalManager = new GoalManager;
    int selection = 1;
    while (selection !=6)

    goalManager.DisplayScore();
    Console.WriteLine("Menu options;");
    Console.WriteLine("1.Create New Goals\n 2.List Goals \n 3. save Goals \n 4. Load Goals \n 5.Record Event \n6. Quit \n 7Select a choice from the menu:");
    selection = Int32.Parse(Console.ReadLine());

      switch(selection)

      case 1:
      {
        //Create New Goal
        Console.Clear();
        goalManager.CreateGoal();
        break;
      }
      case 2:
      {
        //List Goals
         Console.Clear();
         goalManager.ListGoalDetails();
         break;
      }
      case 3:

       //save Goals
      Console.Clear();
      Console.WriteLine("What is the name of the file");
      string fileName = Console.ReadLine();
        goalManager.SaveGoals(fileName);
        break;
    
    case 4:
    {
        //load Goals
        Console.Clear();
        Console.WriteLine("What is the name of the file you are saving?");
        string fileName = Console.ReadLine();
        goalManager.LoadGoals (fileName);
        break;
    }

       case 5:
       {
        //Record event
        Console.Clear();
        goalManager.RecordEvent();
        break;
        } 
       {

     }
    {

}