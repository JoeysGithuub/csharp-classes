using System;
using System.Collections.Generic;

namespace classes
{
    class Program
    {
        public class Employee
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Title { get; set; }
            public DateTime StartDate { get; set; }
        }

        public class Company
        {
            public DateTime DateFounded { get; set; }
            public string CompanyName { get; set; }
            public List<Employee> Employees = new List<Employee>();

            public void ListEmployees() {

                foreach (Employee employee in Employees)
                {
                    Console.WriteLine($"{employee.FirstName} {employee.LastName}: {employee.Title}");
                }
            }
        }
        static void Main(string[] args)
        {
            Company SomeCompany = new Company() {
                DateFounded = DateTime.Now,
                CompanyName = "That Company"
            };

            Employee Howard = new Employee() {
                FirstName = "Howard",
                LastName = "Trice",
                Title = "A person",
                StartDate = DateTime.Now,
            };

            Employee Jack = new Employee() {
                FirstName = "Jack",
                LastName = "Snow",
                Title = "Programmer",
                StartDate = DateTime.Now,
            };

            Employee Fred = new Employee() {
                FirstName = "Fred",
                LastName = "Hill",
                Title = "Maid",
                StartDate = DateTime.Now,
            };

            SomeCompany.Employees.Add(Howard);
            SomeCompany.Employees.Add(Jack);
            SomeCompany.Employees.Add(Fred);

            SomeCompany.ListEmployees();
        }
    }
}