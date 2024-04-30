namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Fazer um programa para ler um número inteiro, e depois dizer se este número é negativo ou não.
            Exemplos:
            Entrada:      Saída:
            -10           NEGATIVO
            Entrada:      Saída:
            8             NAO NEGATIVO
            Entrada:      Saída:
            0             NAO NEGATIVO
             */
            Console.WriteLine("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero > 0)
            {
                Console.WriteLine($"NUMERO {numero}: NAO NEGATIVO");
            } else
            {
                Console.WriteLine($"NUMERO {numero}: NEGATIVO");
            }
        }
    }
}
