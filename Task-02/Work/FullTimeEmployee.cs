namespace Task_02.Work
{
    public class FullTimeEmployee : Employee, IWorkable
    {
        public override string EmployeeType { get; set; }
        public int MonthSalary { get; set; }
        public FullTimeEmployee(int id, string name, int monthSalary) : base(id, name)
        {
            EmployeeType = "Full-Time";
            MonthSalary = monthSalary;
        }


        public override void CalculateSalary()
        {
            Salary = MonthSalary;
        }

        public override void work()
        {
            Console.WriteLine($"{Name} is working full-time.");
        }
    }
}
