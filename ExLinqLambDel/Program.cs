using System.Globalization;
using ExLinqLambDel.Entities;
namespace ExlinqLambDel{
class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Enter full file path: ");
        string path = Console.ReadLine();
        Console.Write("Enter Salary: ");
        double limit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        List<Employee> list = new List<Employee>();

        using (StreamReader sr = File.OpenText(path)){
            while(!sr.EndOfStream){
                string [] fields = sr.ReadLine().Split(',');

                string name = fields[0];
                string email = fields[1];
                double salary = double.Parse(fields[2], CultureInfo.InvariantCulture);
                list.Add(new Employee(name, email, salary));
            }
        }

        var emails = list.Where(obj => obj.Salary > limit).OrderBy(obj => obj.Email).Select(obj => obj.Email);

        var sumInitialM = list.Where(obj => obj.Name[0] == 'M').Sum(obj => obj.Salary);
        
        Console.WriteLine("Email of people whose salary is more than " + limit.ToString("F2", CultureInfo.InvariantCulture)+":");
        foreach (string email in emails){
            Console.WriteLine(email);
        }


        Console.WriteLine("Sum of salary of people whose name stars with 'M' : " + sumInitialM.ToString("F2", CultureInfo.InvariantCulture));

    }
}
}