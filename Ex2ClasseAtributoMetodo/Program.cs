using System.Globalization;

namespace Ex2ClasseAtributoMetodo{

    internal class Program
    {
        private static void Main(string[] args)
        {
            double aumentoPorcentagemSalario;
            Funcionario f1;
            f1 = new Funcionario();

            Console.Write("Nome: ");
            f1.Nome = Console.ReadLine();
            Console.Write("Salário bruto: ");
            f1.SalarioBruto = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            f1.Imposto = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine();
            Console.WriteLine($"Funcionário: {f1}");
            Console.WriteLine();
            Console.Write("Digite a porcentagem para aumentar o salário: ");
            aumentoPorcentagemSalario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            f1.AumentarSalario(aumentoPorcentagemSalario);
            Console.WriteLine();

            Console.WriteLine($"Dados atualizados: {f1}");

        }
    }
}