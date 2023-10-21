//This code defines two classes, Employee and Details. The Employee class has three properties, Id, Name, and City, 
//which are all publicly accessible. The Details class has a Main method that creates an instance of the Employee class and 
//sets its properties. It then prints out the values of those properties.




using System;

namespace AccessSpecifiers
{
    class Employee
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
    }

    class Details
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.Id = "10";
            employee.Name = "Tsitsi";
            employee.City = "Capetown";

            Console.WriteLine("Employee Id: " + employee.Id);
            Console.WriteLine("Employee Name: " + employee.Name);
            Console.WriteLine("Employee City: " + employee.City);
        }
    }
}
