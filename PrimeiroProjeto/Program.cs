namespace PrimeiroProjeto
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Pessoa x, y;

            x = new Pessoa();
            y = new Pessoa();

            Console.WriteLine("Dados da primeira pessoa:");
            Console.Write("Nome: ");
            x.nome = Console.ReadLine();
            Console.Write("Idade: ");
            x.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa:");
            Console.Write("Nome: ");
            y.nome = Console.ReadLine();
            Console.Write("Idade: ");
            y.idade = int.Parse(Console.ReadLine());

            if(x.idade > y.idade){
                Console.WriteLine($"Pessoa mais velha: {x.nome}");
            }
            else{
                Console.WriteLine($"Pessoa mais velha: {y.nome}");
            }
        }
    }
}