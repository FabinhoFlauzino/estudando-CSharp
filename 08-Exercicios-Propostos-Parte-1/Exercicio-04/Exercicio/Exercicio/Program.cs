using System.Globalization;

namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Fazer um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe por
            hora e calcula o salário desse funcionário. A seguir, mostre o número e o salário do funcionário, com duas casas
            decimais.

            Exemplos:
            Entrada:        Saída:
            25
            100
            5.50
                            NUMBER = 25
                            SALARY = U$ 550.00

            Entrada:        Saída:
            1
            200
            20.50
                            NUMBER = 1
                            SALARY = U$ 4100.00

            Entrada:        Saída:
            6
            145
            15.55
                            NUMBER = 6
                            SALARY = U$ 2254.75
            */

            Console.WriteLine("Calculando salário de funcionário");

            Console.WriteLine();

            Console.WriteLine("Digite o código do funcionário");
            
            Console.WriteLine();

            int codFuncionario = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite quantidade de horas trabalhadas");
            int horaTrabalhadas = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Digite o valor da hora");
            double valorHoraTrabalhada = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();

            double salarioFuncionario = (horaTrabalhadas * valorHoraTrabalhada);

            Console.WriteLine();

            Console.WriteLine("NUMBER = {0}", codFuncionario);
            Console.WriteLine("SALARY = U$ {0}", salarioFuncionario.ToString("F2", CultureInfo.InvariantCulture));  
        }
    }
}
