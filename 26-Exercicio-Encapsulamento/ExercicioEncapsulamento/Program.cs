using System.Globalization;

namespace ExercicioEncapsulamento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Conta Bancária");
            Console.WriteLine();

            Console.WriteLine("Entre o número da conta: ");
            int numeroConta = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre o titular da conta: ");
            string titularConta = Console.ReadLine();

            Console.WriteLine("Haverá depósito inicial (s/n)");
            string perguntaDepositoInicial = Console.ReadLine();

            double depositoInicial = 0.00;

            if (perguntaDepositoInicial.ToLower() == "s")
            {
                Console.WriteLine("Entre o valor de depósito inicial: ");
                depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            }
            
            ContaBancaria conta = new ContaBancaria(numeroConta, titularConta, depositoInicial);

            Console.WriteLine();
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.WriteLine("Entre um valor de depósito: ");
            double valorDeposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(valorDeposito);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.WriteLine("Entre um valor para saque: ");
            double valorSaque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(valorSaque);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta);
        }
    }
}
