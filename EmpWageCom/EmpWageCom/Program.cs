using System;

namespace EmpWageCom
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Welcome to Employee Wage Program"); //main
            EmployeWageProblem EmployeeWage = new EmployeWageProblem();
            EmployeeWage.Attendance();
            Console.ReadKey();
        }
    }
}
