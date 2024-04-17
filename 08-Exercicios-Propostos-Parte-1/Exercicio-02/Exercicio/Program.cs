using System.Globalization;

namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro
                casas decimais conforme exemplos.
                Fórmula da área: area = π . raio2
                Considere o valor de π = 3.14159

                Entrada:     Saída:
                2.00         A=12.5664

                Entrada:     Saída:
                100.64       A=31819.3103

                Entrada:     Saída:
                150.00       A=70685.7750
             */

            double R, A, pi = 3.14159;

            R = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            A = pi * R * R;

            Console.WriteLine("A=" + A.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}
