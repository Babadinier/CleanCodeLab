using System;
using System.Collections.Generic;

namespace soft.demo.ocp
{
    class Program
    {
        // todo: The senior developers should have a bonus of 20% on a salary.
        static void Main(string[] args)
        {
            var employeeReports = new List<Employee>
            {
                new Employee {Name = "Emp1", Level = "Consultant senior", HourlyRate  = 30.5, WorkingHours = 160 },
                new Employee {Name = "Emp2", Level = "Consultant junior", HourlyRate  = 20, WorkingHours = 150 },
                new Employee {Name = "Emp3", Level = "Consultant senior", HourlyRate  = 30.5, WorkingHours = 180 }
            };

            var calculator = new SalaryCalculator(employeeReports);
            Console.WriteLine($"Sum of all the employee salaries is {calculator.CalculateSalaries()} euros");
        }

        public class Employee
        {
            public string Name { get; set; }
            public string Level { get; set; }
            public int WorkingHours { get; set; }
            public double HourlyRate { get; set; }
        }

        public class SalaryCalculator
        {
            private readonly IEnumerable<Employee> employees;

            public SalaryCalculator(List<Employee> employees)
            {
                this.employees = employees;
            }

            public double CalculateSalaries()
            {
                double totalSalaries = 0D;

                foreach (var employee in this.employees)
                {
                    totalSalaries += employee.HourlyRate * employee.WorkingHours;
                }

                return totalSalaries;
            }
        }
    }
}
