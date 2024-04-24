
using System.Globalization;

namespace ExConstrutoresThisSobrecarga
{
    public class ContaBancaria
    {
        // Atributos
        
        private string _nomeTitular;
        

        // AutoProps
        public int NumberConta {get ; private set; }
        public double Saldo {get ; private set; }

        // Construtores
        public ContaBancaria(int numberConta, string nomeTitular ){
            NumberConta = numberConta;
            _nomeTitular = nomeTitular;
        }

        public ContaBancaria(int numberConta, string nomeTitular, double depositoInicial) : this (numberConta, nomeTitular){
            Deposito(depositoInicial);
        }

        // CustomProps 
        public string NomeTitular{
            get {return _nomeTitular; }
            set { 
                if (value != null && value.Length > 1){
                    _nomeTitular = value;
                } 
             }
        }

        // Métodos

        public static bool DepositoInicial(string x){
            return x == "s";
        }

        public void Deposito(double valor){
            Saldo += valor;
        } 

        public void Saque(double valor){
            Saldo -= valor + 5;
        }

        public override string ToString()
        {
            return $"Conta {NumberConta}, Titular {_nomeTitular}, Saldo: $ {Saldo.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}