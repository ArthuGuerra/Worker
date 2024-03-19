using System.Diagnostics.Contracts;
using System.Globalization;
using WorkerEnum.Models;
using WorkerEnum.Models.Enum;

Console.WriteLine($"");
Console.ReadLine();

Console.WriteLine($"Enter Department: ");
string deptName = Console.ReadLine();


Console.WriteLine($"Enter Worker Data: ");
Console.WriteLine($"Name: ");
string name = Console.ReadLine();

Console.WriteLine($"Level:  ");
WorkerLevel wl = Enum.Parse<WorkerLevel>(Console.ReadLine());

Console.WriteLine($"BaseSalary: ");
double baseSalary = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

Console.WriteLine($"How many contracts do you want my Morker ? ");

int n = int.Parse(Console.ReadLine());

Departament departament = new Departament(deptName);
Worker worker = new Worker(name,wl,baseSalary,departament);

for(int i = 1; i <= n; i++)
{
    Console.WriteLine($"Enter Data Contract-{i} ");

    Console.WriteLine($"Enter Data: (dd/MM/yyyy) ");
    DateTime date = DateTime.Parse(Console.ReadLine());

    Console.WriteLine("Value per Hour: ");
    double valuePerHour = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture );

    Console.WriteLine("Hours: ");
    int hour = int.Parse(Console.ReadLine());


    HourContract contract = new HourContract(date,valuePerHour,hour);
    worker.AddContract(contract);

    
}

Console.WriteLine("Enter month and year to Calculate Income (MM/yyyy):");

Console.WriteLine($"Enter month/year:  ");
string monthAndYear = Console.ReadLine();

int month = int.Parse(monthAndYear.Substring(0,2));
int year = int.Parse(monthAndYear.Substring(3));


Console.WriteLine($"Name: {worker.Name}");
Console.WriteLine($"Department: {worker.Departament.Name}");
Console.WriteLine($"Income for: {worker.Income(year,month)}");



