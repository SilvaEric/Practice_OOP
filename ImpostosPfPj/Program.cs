using System.Globalization;
using ImpostosPfPj.entities;

List<Person> listPersons = new List<Person>();
double sumTaxes = 0.0;

Console.Write("Enter the number of tax payers: ");
int payers = int.Parse(Console.ReadLine());

for(int i = 1; i <= payers; i++)
{
    Console.WriteLine($"Tax payer #{i} data:");

    Console.Write("Individual or company (i/c)? ");
    string type = Console.ReadLine();

    Console.Write("Name: ");
    string name = Console.ReadLine();

    Console.Write("Anual income: ");
    double annualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    if(type == "i")
    {
        Console.Write("Health expenditures: ");
        double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        listPersons.Add(new PhysicalPerson(name, annualIncome,healthExpenditures));
    }
    else
    {
        Console.Write("Number of employees: ");
        int employees = int.Parse(Console.ReadLine());

        listPersons.Add(new LegalPerson(name, annualIncome,employees));
    }
}

Console.WriteLine();
Console.WriteLine("TAXES PAID: ");

foreach(Person x in listPersons)
{
    sumTaxes += x.TaxPaid();
    Console.WriteLine($"{x.Name}: $ {x.TaxPaid().ToString("F2", CultureInfo.InvariantCulture)}");
}
Console.WriteLine();
Console.WriteLine("TOTAL TAXES: $ " + sumTaxes.ToString("F2", CultureInfo.InvariantCulture));