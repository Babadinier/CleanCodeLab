using System;
using System.Linq;
using System.Collections.Generic;

namespace soft.demo.structure
{
    class Program
    {
        static void Main(string[] args)
        {
            var alfred = new Employee("Alfred", Company.ALFRED_CORPORATION);
            var alvaro = new Employee("Alvaro", Company.SOFTFLUENT);

            var employees = new List<Employee> { alfred, alvaro };

            SetSalary(employees);

            foreach(var employee in employees)
            {
                System.Console.WriteLine($"{employee.Name}: {employee.Salary}");
            }
        }

        private static void SetSalary(List<Employee> employees)
        {
            if (!employees.Any()) {
                return;
            }

            foreach (var employee in employees)
            {
                if (employee.Company == Company.ALFRED_CORPORATION)
                {
                    employee.Salary = 150_000m;
                }
                else if (employee.Company == Company.SOFTFLUENT)
                {
                    employee.Salary = 350_000m;
                }
                else if (employee.Company == Company.SONYYY)
                {
                    employee.Salary = 1_000_000m;
                }
            }
        }

        public class Employee
        {
            public string Name { get; set; }
            public Company Company { get; set; }
            public decimal Salary { get; set; }

            public Employee(string name, Company company)
            {
                Name = name;
                Company = company;
                Salary = 0m;
            }
        }

        public enum Company
        {
            ALFRED_CORPORATION,
            SOFTFLUENT,
            SONYYY
        }
    }
}
