using System.Globalization;

namespace _21_Exercicios_Orientacao_Objetos_Metodos_Estaticos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual a cotação do dólar? ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantos dólares você vai comprar? ");
            double qtdeDolaresComprado = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double valor = ConversorDeMoeda.ConverterDolarParaReal(cotacao, qtdeDolaresComprado);

            Console.WriteLine($"Valor a ser pago em reais = {valor.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
