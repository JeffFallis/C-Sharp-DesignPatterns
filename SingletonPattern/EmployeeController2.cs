using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.SingletonPattern
{
    class EmployeeController2
    {
        private EmployeeList employees;

        public EmployeeController2()
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
