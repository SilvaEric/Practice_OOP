using System.Globalization;
using System.Reflection.Metadata.Ecma335;

namespace Ex3ClasseMetodoAtributo
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Aluno a1;
            a1 = new Aluno();
            double restante;

            Console.Write("Nome do aluno: ");
            a1.Nome = Console.ReadLine();

            Console.WriteLine("Digite as três notas do aluno: ");

            a1.Nota1Tri = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            a1.Nota2Tri = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            a1.Nota3Tri = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            a1.NotaFinal = a1.Nota1Tri + a1.Nota2Tri + a1.Nota3Tri;

            Console.WriteLine(a1);

            if (a1.ResultadoFinal() == true){
                Console.WriteLine("APROVADO");
            }
            else{
                Console.WriteLine("REPROVADO");

                restante = 60.00 - a1.NotaFinal;
                
                Console.WriteLine($"FALTARAM {restante.ToString("F2", CultureInfo.InvariantCulture)} PONTOS");
            }
        }
    }
}