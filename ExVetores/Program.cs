namespace ExVetores{    
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Quantos quartos serão alugados? ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Aluguel [] quartos = new Aluguel [10];

            for( int i = 0; i < n; i++){
                Console.WriteLine("Aluguel #" + (i+1) + ": ");

                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Email: ");
                string email = Console.ReadLine();

                Console.Write("Quarto: ");
                int pos = int.Parse(Console.ReadLine());
                Console.WriteLine();

                quartos [pos] = new Aluguel{Nome = nome, Email = email };
            }

            Console.WriteLine("Quartos ocupados:");

            for(int i = 0; i < 10; i++){
                if (quartos [i] != null)
                    Console.WriteLine(i + ": " + quartos[i].Nome + ", " + quartos[i].Email);
            }
        }
    }
}