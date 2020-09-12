using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.SingletonPattern
{
    class EmployeeController1
    {
        private EmployeeList employees;

        public EmployeeController1()
        {
            employees = EmployeeList.Instance();
        }

        public void AddEmployee(Employee newEmployee)
        {
            employees.AddEmployee(newEmployee);
        }

        public void PrintEmployees()
        {
            employees.PrintEmployees();
        }
    }
}
