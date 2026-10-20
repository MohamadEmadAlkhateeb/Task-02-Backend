using Task_02.Work;




Console.Write("What is your id: ");
int id = Convert.ToInt32(Console.ReadLine() ?? "0");
Console.Write("What is your name: ");
string name = Console.ReadLine() ?? "null";
Console.Write("What is your Employee Type: (1- Full-Time, 2- Part-Time): ");
int EmployeeTypeInt = Convert.ToInt32(Console.ReadLine() ?? "0");
Employee employee;
if (EmployeeTypeInt == 1)
{
    Console.Write("What is your monthly salary: ");
    int monthlySalary = Convert.ToInt32(Console.ReadLine() ?? "0");
    employee = new FullTimeEmployee(id, name, monthlySalary);
}
else if (EmployeeTypeInt == 2)
{
    Console.Write("What is the hour you work: ");
    int hourOfWork = Convert.ToInt32(Console.ReadLine() ?? "0");
    Console.Write("What is the salry they pay to you per hour: " );
    int salaryPerHour = Convert.ToInt32(Console.ReadLine() ?? "0");
    employee = new PartTimeEmployee(id, name, hourOfWork, salaryPerHour);
}
else
{
    throw new Exception("Invalid Employee Type sorry restart the program");
}
employee.CalculateSalary();
employee.DisplayInfo();
employee.work();

// ?? "0" --> this is mean when i don't write any value the initial value or the backup value is 0 