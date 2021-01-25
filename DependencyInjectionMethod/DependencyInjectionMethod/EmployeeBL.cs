using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionMethod
{
    public class EmployeeBL
    {
        public IEmployeeDAL employeeDAL;

        public IEmployeeDAL employeeDataObject
        {
            set
            {
                this.employeeDAL = value;
            }
            get
            {
                if (employeeDAL == null)
                {
                    throw new Exception("Employee is not initialized");
                }
                else
                {
                    return employeeDAL;
                }
            }
        }

        public List<Employee> GetAllEmployees(IEmployeeDAL _employeeDAL)
        {
            employeeDAL = _employeeDAL;
            return employeeDAL.SelectAllEmployees();
        }
    }
}
