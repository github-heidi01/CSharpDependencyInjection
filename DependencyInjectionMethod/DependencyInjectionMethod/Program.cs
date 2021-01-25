using System;
using System.Collections.Generic;

namespace DependencyInjectionMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeBL employeeBL = new EmployeeBL();

            List<Employee> ListEmployee = employeeBL.GetAllEmployees(new EmployeeDAL());


        foreach (Employee emp in ListEmployee)
        {
            Console.WriteLine("ID = {0}, Name = {1}, Department = {2}", emp.ID, emp.Name, emp.Department);
        }
        Console.ReadKey();
        }
    }
}
