using System.Globalization;
namespace Ex3ClasseMetodoAtributo
{
    class Aluno
    {
        public string Nome;
        public double Nota1Tri, Nota2Tri, Nota3Tri, NotaFinal;

        public bool ResultadoFinal(){
            return NotaFinal > 60.0;
        }

        public override string ToString()
        {
            return $"NOTA FINAL = {NotaFinal.ToString("F2",CultureInfo.InvariantCulture)}";
        }


    }
}