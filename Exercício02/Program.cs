using System.Globalization;

namespace Exercício02{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Funcionario x, y;
            double media;

            x = new Funcionario();
            y = new Funcionario();

            Console.WriteLine("Dados do primeiro funcionário:");
            Console.Write("Nome: ");
            x.nome = Console.ReadLine();
            Console.Write("Salário: ");
            x.salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine("Dados do segundo funcionário:");
            Console.Write("Nome: ");
            y.nome = Console.ReadLine();
            Console.Write("Salário: ");
            y.salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            
            media = (y.salario + x.salario)/ 2.0;

            Console.WriteLine($"Salário médio = {media.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}