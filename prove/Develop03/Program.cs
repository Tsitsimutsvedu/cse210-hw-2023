using System;

namespace OPPs

class Encapsulation

{
    private string Name;
    public string EmployeeName
    { 
        //Property
        get {return Name;}
        set {Name = value;}
    }
}

    static void Main(string[] args)
    {
        string Name2 = string.Empty;
        //use properties
        Encapsulation e = new Encapsulation();
        Name2 = e.EmployeeName;
    
        Console.WriteLine("Employee Name: " + Name2);
        Console.ReadLine();
    {

}

}
