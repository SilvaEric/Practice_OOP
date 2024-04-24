
namespace ExMembrosEstaticos
{
    class ConversorDeMoeda
    {
        public static double Iof = 6.0;
        public static double ConverterMoeda(double cota, double quantia){
            double total = quantia * cota;
            return total + total * Iof / 100;
        }
    }
}