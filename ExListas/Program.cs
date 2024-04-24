using System.Globalization;

namespace ExListas
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("How many employees will be registered? ");
            int n = int.Parse(Console.ReadLine());

            List<Funcionario> registros = new List<Funcionario>();
            for(int i = 0; i < n; i++){
                Console.WriteLine("Employee #" + (i+1));
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                registros.Add(new Funcionario(id, name, salary));
                Console.WriteLine();
            }
            
            Console.Write("Enter the employee id that will have salary increase : ");
            int searchId = int.Parse(Console.ReadLine());
            Funcionario exist = registros.Find(x => x.Id == searchId);
            if(exist != null){
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                exist.increaseSalary(percentage);
                }
            else {
                Console.WriteLine("This id does not exist!");
                }
            Console.WriteLine();
            Console.WriteLine("Updated list of employees:");
            foreach(Funcionario people in registros){
                Console.WriteLine(people);
            }

            
        }
    }
}