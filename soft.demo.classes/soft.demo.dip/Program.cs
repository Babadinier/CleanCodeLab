using System;

namespace soft.demo.dip
{
    class Program
    {
        static void Main(string[] args)
        {
            var employee = new Employee("Bertrand");

            var employeeService = new EmployeeService();

            employeeService.AddEmployee(employee);
        }
    }

    public class Employee {
        public string Name { get; set; }

        public Employee(string name)
        {
            Name = name;
        }
    }

    public class EmployeeService
    {
        public void AddEmployee(Employee employee)
        {
            var database = new Database();
            
            if (database.CurrentThread < database.MaxThreads)
            {
                database.Add(employee);
                database.Save();
            }
            else {
                /* business logic */
            }
        }
    }

    // this class use EntityFramework
    public class Database : DbContext
    {
        private const string connectionString = @"Server=myServerName\myInstanceName;Database=myDataBase;User Id=myUsername;Password=myPassword;";
        public int MaxThreads => 5;
        public int CurrentThread => 0;
        
        public void Add(Employee employee) { System.Console.WriteLine($"Employee {employee.Name} added"); }

        public void Save() { System.Console.WriteLine("Employee saved"); }

        private void InitContext() {
            /* init context DbContext */
        }
    }

    public class DbContext { }
}
