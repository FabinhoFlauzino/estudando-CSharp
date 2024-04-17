namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Fazer um programa para ler quatro valores inteiros A, B, C e D. A seguir, calcule e mostre a diferença do produto
             de A e B pelo produto de C e D segundo a fórmula: DIFERENCA = (A * B - C * D).

            Exemplos:
            Entrada:       Saída:
            5
            6
            7
            8
                           DIFERENCA = -26


            Entrada:       Saída:
            5
            6
            -7
            8
                           DIFERENCA = 86
            */
            Console.WriteLine("Calculando diferença entre números");
            Console.WriteLine("Digite o primeiro número");
            int A = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número");
            int B = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o terceiro número");
            int C = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o quarto número");
            int D = int.Parse(Console.ReadLine());

            Console.WriteLine();
            int diferenca = (A * B) - (C * D);
            Console.WriteLine($"A diferença entre os números {A}, {B}, {C} e {D} é de {diferenca}");
        }
    }
}
