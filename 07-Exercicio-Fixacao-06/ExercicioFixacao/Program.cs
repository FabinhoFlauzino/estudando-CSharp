using System.Globalization;

namespace ExercicioFixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Fazer um programa para executar a seguinte interação com o
                usuário, lendo os valores, e depois
                mostrar os dados na tela: 

                Entre com seu nome completo:
                    Alex Green

                Quantos quartos tem na sua casa?
                    3

                Entre com o preço de um produto:
                    500.50

                Entre seu último nome, idade e altura(mesma linha):
                    Green 21 1.73

            */
            Console.WriteLine("Entre com seu nome completo:");
            string nome = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Quantos quartos tem sua casa?");
            int qtdQuartos = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Entre com o preco de um produto");
            double precoProduto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();

            Console.WriteLine("Digite seu último nome, idade e altura (separado por espaço e na mesma linha)");
            string[] pessoa = Console.ReadLine().Split(" ");
            string pessoaUltimoNome = pessoa[0];
            int pessoaIdade = int.Parse(pessoa[1]);
            double pessoaAltura = double.Parse(pessoa[2], CultureInfo.InvariantCulture);
                        
            Console.WriteLine();
            Console.WriteLine(nome);
            Console.WriteLine(qtdQuartos);
            Console.WriteLine(precoProduto.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(pessoaUltimoNome);
            Console.WriteLine(pessoaIdade);
            Console.WriteLine(pessoaAltura.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
