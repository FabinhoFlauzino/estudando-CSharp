namespace Exercicio_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Leia um valor inteiro X (1 <= X <= 1000). Em seguida mostre os ímpares de 1 até X, um valor por linha, 
            inclusive o X, se for o caso.
             */

            int X = int.Parse(Console.ReadLine());

            if (X <= 1000)
            {
                for (int i = 1; i <= X; i++)
                {
                    if (i % 2 != 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }
    }
}
