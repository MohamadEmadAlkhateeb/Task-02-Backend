namespace Task_02.Work
{
    public abstract class Employee : IWorkable
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public abstract string EmployeeType { get; set; }
        private int _Salary;
        public int Salary
        {
            get
            {
                return _Salary;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Invalid Salary");
                    return;
                }
                _Salary = value;
            }
        }
        public Employee(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public abstract void CalculateSalary();
        public void DisplayInfo()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"ID: {Id}, Name: {Name}");
            Console.WriteLine($"Employee Type: {EmployeeType}");
            Console.WriteLine($"Salary: {Salary} JOD");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("-------------------");
            Console.WriteLine();
            Console.WriteLine();
        }

        public abstract void work();

    }
}
