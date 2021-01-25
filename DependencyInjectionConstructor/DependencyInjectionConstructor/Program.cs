using System;
using System.Collections.Generic;

namespace DependencyInjectionConstructor
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeBL employeeBl = new EmployeeBL(new EmployeeDAL());
            List<Employee> ListEmployee = employeeBl.GetAllEmployees();
            foreach (Employee emp in ListEmployee)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Department = {2}", emp.ID, emp.Name, emp.Department);
            }
            Console.ReadKey();
        }
    }
}
