using System;
using System.Collections.Generic;
using System.Text;

namespace Employee_Management_System
{
    public class PartTimeEmployee : Employee, IWorkable
    {

        public int HourWork { get; set; }
        public int SalaryPerHour { get; set; }
        public PartTimeEmployee(int id, string name, string employeeType, int hourWork, int salaryPerHour) : base(id, name, employeeType)
        {
            HourWork = hourWork;
            SalaryPerHour = salaryPerHour; 
        }

        public override int CalculateSalary()
        {
            return HourWork * SalaryPerHour;
        }

        public string Work()
        {
            return $"{Name} is working part-time.";
        }
    }
}
