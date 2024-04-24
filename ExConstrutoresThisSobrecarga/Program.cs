using System.Globalization;

namespace ExConstrutoresThisSobrecarga{    
    internal class Program
    {
        
        private static void Main(string[] args)
        {   
            ContaBancaria conta1;
            
            Console.Write("Entre o número da conta: ");
            int conta = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)? ");
            string dInicio = Console.ReadLine();
            
            if (ContaBancaria.DepositoInicial(dInicio)){
                Console.Write("Entre o valor de depósito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                conta1 = new ContaBancaria(conta, titular, depositoInicial);
            }
            else{
                conta1 = new ContaBancaria(conta, titular);
                
            }
            
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(conta1);
            Console.WriteLine();

            Console.Write("Entre um valor para depósito: ");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta1.Deposito(valor);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta1);
            Console.WriteLine();

            Console.Write("Entre um valor para saque: ");
            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta1.Saque(valor);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta1);
            Console.WriteLine();
        }
    }
}