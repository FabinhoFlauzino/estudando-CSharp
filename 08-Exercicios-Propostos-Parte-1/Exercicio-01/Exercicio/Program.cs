namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Faça um programa para ler dois valores inteiros, e depois mostrar na tela a soma desses números com uma
                mensagem explicativa, conforme exemplos.

                Exemplos:
                Entrada:     
                10
                30
                Saída:
                SOMA = 40

                Entrada:
                -30
                10
                Saída:
                SOMA = -20

                Entrada:
                0
                0
                Saída:
                SOMA = 0
            */

            Console.WriteLine("Somando núremos");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int soma = n1 + n2;

            Console.WriteLine($"SOMA = {soma}");

        }
    }
}
