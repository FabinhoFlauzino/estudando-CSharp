namespace Exercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Fazer um programa para ler um número inteiro e dizer se este número é par ou ímpar.
                Exemplos:
                Entrada:        Saída:
                12              PAR
                Entrada:        Saída:
                -27             IMPAR
                Entrada:        Saída:
                0               PAR
             
             */

            int numero = int.Parse(Console.ReadLine());

            if(numero % 2 == 0)
            {
                Console.WriteLine("PAR");
            } else
            {
                Console.WriteLine("IMPAR");
            }
        }
    }
}
