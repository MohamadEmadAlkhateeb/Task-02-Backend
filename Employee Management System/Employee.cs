using System;
using System.Collections.Generic;
using System.Text;

namespace Employee_Management_System
{
    public abstract class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string EmployeeType { get; set; }
        private int _Salary;
        public int Salary 
        {
            get
            {
                return _Salary;
            }
            set
            {
                if(value <= 0)
                {
                    throw new Exception;
                }
                else
                {
                    _Salary = value;
                }
            }
        }
        public Employee(int id, string name, string employeeType)
        {
            Id = id;
            Name = name;
            EmployeeType = employeeType;
        }
        public abstract int CalculateSalary();
        public void DisplayInfo()
        {
            Salary = CalculateSalary();
            CalculateSalary();
            Console.WriteLine($"ID: {Id} , Name: {Name}");
            Console.WriteLine($"Employee Type: {EmployeeType}");
            Console.WriteLine($"Salary: {Salary} JOD");
        }


    }
}
