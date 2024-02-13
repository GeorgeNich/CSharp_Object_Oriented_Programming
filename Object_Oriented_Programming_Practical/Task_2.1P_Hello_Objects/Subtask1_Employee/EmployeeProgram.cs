using System;

namespace Employee
{
    class EmployeeProgram
    {
        static void Main(string[] args)
        {
            Employeeee George = new Employeeee("raymond", 56000);

            Console.WriteLine("Name: " + George.getName() + "\nSalary: " + George.getSalary());

            George.raiseSalary(80000);

             George.getSalary();

            Console.ReadLine();

            George.Tax();

            Console.ReadLine();

        }
    }
}
