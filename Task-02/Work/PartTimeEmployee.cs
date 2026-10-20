namespace Task_02.Work
{
    public class PartTimeEmployee : Employee, IWorkable
    {
        public override string EmployeeType { get; set; }
        public int HourOfWork { get; set; }
        public int SalaryPerHour { get; set; }
        public PartTimeEmployee(int id, string name, int hourOfWork, int salaryPerHour) : base(id, name)
        {
            EmployeeType = "Part-Time";
            HourOfWork = hourOfWork;
            SalaryPerHour = salaryPerHour;
        }


        public override void CalculateSalary()
        {
            Salary = HourOfWork * SalaryPerHour;
        }

        public override void work()
        {
            Console.WriteLine($"{Name} is working part-time");
        }
    }
}
