using System.Globalization;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exemplo 1 instanciando um vetor do tipo struct
            Console.WriteLine("Exemplo 1 instanciando um vetor do tipo struct.");
            Console.WriteLine();
            Console.Write("Digite quantas posições terá o vetor: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();
            double[] vect = new double[n];
            for (int i = 0; i < n; i++) {
                Console.Write($"Digite o número a posicao {i + 1} do vetor: ");
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            Console.WriteLine();
            double soma = 0.0;
            for (int i = 0;i < n; i++)
            {
                soma += vect[i];
            }
            double avg = soma / n;
            Console.WriteLine($"AVERAGE HEIGHT = " + avg.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine();
            Console.WriteLine();

            //Exemplo 2 instanciando um vetor do tipo classe
            Console.WriteLine("Exemplo 2 instanciando um vetor do tipo classe.");
            Console.Write("Digite quantas posições terá o vetor: ");
            int variavelN = int.Parse(Console.ReadLine());
            Product[] products = new Product[variavelN];
            Console.WriteLine();

            for (int i = 0; i < variavelN; i++)
            {
                Console.Write("Digite o nome do Produto: ");
                string nome = Console.ReadLine();

                Console.Write($"Digite o preco do produto {nome}: ");
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                products[i] = new Product(nome, preco);
                Console.WriteLine();
            }

            double sum = 0.0;

            for (int i = 0; i < variavelN; i++)
            {
                sum += products[i].Preco;
            }

            double valorProdutos = sum / variavelN;
            Console.WriteLine("AVERAGE PRICE = " + valorProdutos.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
