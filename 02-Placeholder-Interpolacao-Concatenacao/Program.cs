using System.Globalization;

namespace _02PlaceholderInterpolacaoeInterpolacao
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade = 30;
            double saldo = 10.35783;
            string nome = "Fulano de Tal";

            //Placeholder muito usado antes da versão 6 do C#
            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais.", nome, idade, saldo);

            //Interpolação incluido na versão 6 do C#
            Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:F2} reais.");

            //Concatenação é o método mais antigo em relação aos outros dois
            Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a " + saldo.ToString("F2", CultureInfo.InvariantCulture) + " reais.");
        }
    }
}
