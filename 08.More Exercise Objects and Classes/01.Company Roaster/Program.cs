using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Company_Roaster
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Department> departments = new List<Department>();

            int employeeCnt = int.Parse(Console.ReadLine());

            for (int i = 0; i < employeeCnt; i++)
            {
                var employeeInfo = Console.ReadLine().Split();

                string currEmployeeName = employeeInfo[0];
                decimal curEmployeeSalary = decimal.Parse(employeeInfo[1]);
                string currDepartmentName = employeeInfo[2];

                if (departments.Any(deparment => deparment.DepartmentName == currDepartmentName))
                {
                    var departmentToUpdate = departments.Find(deparment => deparment.DepartmentName == currDepartmentName);
                    
                    departmentToUpdate.Emplyees.Add(new Employee(currEmployeeName, curEmployeeSalary));
                }
                else
                {
                    var newDepartment = new Department(currDepartmentName);
                    newDepartment.Emplyees.Add(new Employee(currEmployeeName, curEmployeeSalary));
                    departments.Add(newDepartment);
                }
            }

            Department departmentMaxAvgSalary = null;
            decimal maxAvgSalary = 0;

            foreach (var department in departments)
            {
                if (department.AvarageSalary > maxAvgSalary)
                {
                    maxAvgSalary = department.AvarageSalary;
                    departmentMaxAvgSalary = department;
                }
            }

            Console.WriteLine($"Highest Average Salary: {departmentMaxAvgSalary.DepartmentName}");
            foreach (var employee in departmentMaxAvgSalary.Emplyees.OrderByDescending(employee => employee.Salary))
            {
                Console.WriteLine($"{employee.Name} {employee.Salary:f2}");
            }
        }
    }
   
    class Department
    {
        public Department(string departmentName)
        {
            this.DepartmentName = departmentName;
            this.Emplyees = new List<Employee>();
        }

        public string DepartmentName { get; set; }
        public List<Employee> Emplyees { get; set; }
        public decimal AvarageSalary { get { return this.Emplyees.Average(employee => employee.Salary ); } }
    }
    class Employee
    {
        public Employee(string name, decimal salary)
        {
            Name = name;
            Salary = salary;           
        }

        public string Name { get; set; }
        public decimal Salary { get; set; }       
    }
}
