using System.Globalization;

namespace Exercicio_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Salário Liquido de um funcionário");
            Console.WriteLine();

            Funcionario funcionario = new Funcionario();

            Console.Write("Nome: ");
            funcionario.Nome = Console.ReadLine();
            Console.Write("Salário bruto: ");
            funcionario.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Valor do Imposto: ");
            funcionario.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();

            Console.WriteLine($"Funcionário: {funcionario}");
            Console.WriteLine();

            Console.Write($"Digite a porcentagem para aumentar o salário do funcionario {funcionario.Nome}: ");
            double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            funcionario.AumentarSalario(porcentagem);

            Console.WriteLine($"Dados atualizados: {funcionario}");
        }
    }
}
