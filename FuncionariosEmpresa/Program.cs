using System.Globalization;
using FuncionariosEmpresa.entities;

List<Employee> employees = new List<Employee>();

Console.Write("Enter the number of employees: ");
int numOfEmp = int.Parse(Console.ReadLine());
for(int i = 1; i <= numOfEmp; i++ )
{
    Console.WriteLine("Employee #" + i + " data:");
    Console.Write("Outsourced (y/n)? ");
    string outSorced = Console.ReadLine();

    Console.Write("Name: ");
    string name = Console.ReadLine();

    Console.Write("Hours: ");
    int hours = int.Parse(Console.ReadLine());

    Console.Write("Value per hour: ");
    double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    if(outSorced == "y")
    {
        Console.Write("Additional charge: ");
        double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Employee employee = new OutSourceEmployee(name, hours, valuePerHour, additionalCharge);

        employees.Add(employee);
    }
    else
    {
        Employee employee = new Employee(name, hours, valuePerHour);

        employees.Add(employee);
    }
}
Console.WriteLine("PAYMENTS:");
foreach(Employee employee in employees)
{
    Console.WriteLine(employee);
}