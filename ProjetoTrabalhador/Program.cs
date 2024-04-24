using ProjetoTrabalhador.entities;
using ProjetoTrabalhador.entities.enums;
using System.ComponentModel;
using System.Globalization;

Console.Write("Enter department's name: ");
string department = Console.ReadLine();
Department dept = new Department(department);

Console.WriteLine("Enter worker data:");

Console.Write("Name: ");
string name = Console.ReadLine();

Console.Write("Level (Junior/MidLevel/Senior): ");
WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());

Console.Write("Base salary: ");
double baseSalary = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

Worker worker = new Worker(name, level, baseSalary, dept);

Console.Write("How many contracts to this worker? ");
int numberContracts = int.Parse(Console.ReadLine());


for(int i = 1; i <= numberContracts; i++ ){
    Console.WriteLine("Enter #" + i + " contract data: ");

    Console.Write("Date (DD/MM/YYYY): ");
    DateTime date = DateTime.Parse(Console.ReadLine());

    Console.Write("Value per hour: ");
    double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    Console.Write("Duration (hours): ");
    int hours = int.Parse(Console.ReadLine());

    HourContract contract = new HourContract(date, valuePerHour, hours);

    worker.AddContract(contract);
}
Console.WriteLine();

Console.Write("Enter month and year to calculate income (MM/YYYY): ");
string monthAndYear = Console.ReadLine();
int month = int.Parse(monthAndYear.Substring(0, 2));
int year = int.Parse(monthAndYear.Substring(3));
Console.WriteLine("Name: " + worker.Name);
Console.WriteLine("Department: " + worker.Department.Name);
Console.WriteLine("Name: " + worker.Name);
Console.WriteLine("Income for " + monthAndYear + ": " + worker.Income(year,month).ToString("F2", CultureInfo.InvariantCulture));
