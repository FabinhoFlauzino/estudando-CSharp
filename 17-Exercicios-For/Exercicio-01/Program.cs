namespace Exercicio_01
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Tabuada - Leia um valor inteiro N (2< N < 1000)
                a seguir mostre a tabuada de N:
                1XN ...
             */
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                int resultado = i * N;
                Console.WriteLine($"{i} X {N} = {resultado}");
            }
        }
    }
}
