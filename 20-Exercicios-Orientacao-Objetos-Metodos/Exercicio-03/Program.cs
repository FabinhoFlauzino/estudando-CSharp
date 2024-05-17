using System.Globalization;

namespace Exercicio_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();

            Console.Write("Nota do aluno: ");
            aluno.Nome = Console.ReadLine();

            Console.WriteLine("Digite as três notas do aluno: ");
            aluno.PrimeiroTrimestre = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.SegundoTrimestre = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.TerceiroTrimestre = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine(aluno);
        }
    }
}
