using System.Globalization;

namespace Ex2ClasseAtributoMetodo
{
    class Funcionario
    {
        public string Nome;
        public double SalarioBruto, Imposto;


        public double SalarioLiquido(){
            return SalarioBruto - Imposto;
        }

        public void AumentarSalario(double porcentagem){
            SalarioBruto += SalarioBruto*(porcentagem/100.00);
        }

        public override string ToString()
        {
            return $"{Nome}, $ {SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}