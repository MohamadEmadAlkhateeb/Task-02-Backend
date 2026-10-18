using System;
using System.Collections.Generic;
using System.Text;

namespace Employee_Management_System
{
    public class FullTimeEmployee : Employee, IWorkable
    {
        public int MonthlySalary { get; set; }
        public FullTimeEmployee(int id, string name, string employeeType, int monthlySalary) : base(id, name, employeeType)
        {
            MonthlySalary = monthlySalary;
        }

        public override int CalculateSalary()
        {
            return MonthlySalary;
        }

        public string Work()
        {
            return $"{Name} is working full-time.";
        }
    }
}
