using System.Globalization;

namespace _01ImprimindoDadosBasicos
{
    class Program
    {
        static void Main(string[] args)
        {
            char genero = 'M';
            int idade = 30;
            double saldo = 10.35784;
            string nome = "Maria";

            Console.WriteLine("Bom dia");
            Console.WriteLine(genero);
            Console.WriteLine(idade);
            Console.WriteLine(saldo);
            Console.WriteLine(saldo.ToString("F2"));
            Console.WriteLine(saldo.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(nome);

        }
    }
}
