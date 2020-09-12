using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DesignPatterns.SingletonPattern
{
    class EmployeeList
    {
        private List<Employee> employees;
        private static EmployeeList instance;

        public List<Employee> Employees { get; set; }

        protected EmployeeList()
        {
            Employees = new List<Employee>();
            instance = null;
        }

        public void AddEmployee(Employee newEmployee)
        {
            Employees.Add(newEmployee);
        }

        public static EmployeeList Instance()
        {
            if (instance == null)
            {
                instance = new EmployeeList();
            }
            return instance;
        }

        public void PrintEmployees()
        {
            Console.WriteLine("\n");
            foreach (Employee employee in Employees)
            {
                Console.WriteLine("ID: {0} {1} {2}", employee.Id, employee.FirstName, employee.LastName);
            }
        }
    }
}
