using System;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.Name = "Tsitsi";
            emp.Age = 45;
            emp.Salary = 50000;
            emp.DisplayEmployeeDetails();
        }
    }

    class Employee
    {
        private string name;
        private int age;
        private double salary;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public void DisplayEmployeeDetails()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Age: " + Age);
            Console.WriteLine("Salary: " + Salary);
        }
    }
}
