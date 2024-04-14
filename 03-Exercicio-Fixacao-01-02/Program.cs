using System.Globalization;

namespace _03ExercicioFixacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Em um novo programa, inicie as seguintes variáveis:

                string produto1 = "Computador";
                string produto2 = "Mesa de escritório";
                byte idade = 30;
                int codigo = 5290;
                char genero = 'M';
                double preco1 = 2100.0;
                double preco2 = 650.50;
                double medida = 53.234567;
             
            Em seguida, usando os valores das variáveis, produza a seguinte saída na tela do console:

                Produtos:
                Computador, cujo preço é $ 2100,00
                Mesa de escritório, cujo preco é $ 650,50
                Registro: 30 anos de idade, código 5290 e gênero: M
                Medida com oito casas decimais: 53,23456700
                Arredondado (três casas decimais): 53,235
                Separador decimal invariant culture: 53.235
              
            */

            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";
            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';
            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("Produtos:");
            Console.WriteLine("{0}, cujo preço é de $ {1:F2}.", produto1, preco1);
            Console.WriteLine($"{produto2}, cujo preco é $ {preco2:F2}.");

            Console.WriteLine($"Registro: {idade} anos de idade, código {codigo} e gênero: {genero}.");

            Console.WriteLine("Medida com oito casas decimais: {0}", medida.ToString("F8"));
            Console.WriteLine("Arredondado (três casas decimais): {0}", medida.ToString("F3"));
            Console.WriteLine("Separador decimal invariant culture: {0}", medida.ToString("F3", CultureInfo.InvariantCulture));

        }
    }
}
