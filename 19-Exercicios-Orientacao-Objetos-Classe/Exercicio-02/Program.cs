using System.Globalization;

namespace Exercicio_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario1, funcionario2;
            funcionario1 = new Funcionario();
            funcionario2 = new Funcionario();

            Console.WriteLine("Digite os dados do primeiro funcionário!");
            Console.Write("Nome: ");
            funcionario1.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            funcionario1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite os dados do segundo funcionário!");
            Console.Write("Nome: ");
            funcionario2.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            funcionario2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salarioMedio = (funcionario1.Salario + funcionario2.Salario) / 2.0;
            Console.WriteLine("Salário médio = " + salarioMedio.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
