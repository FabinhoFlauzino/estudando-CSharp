namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Leia 2 valores inteiros (A e B). Após, o programa deve mostrar uma mensagem "Sao Multiplos" ou "Nao sao
                Multiplos", indicando se os valores lidos são múltiplos entre si. Atenção: os números devem poder ser digitados em
                ordem crescente ou decrescente.
                Exemplos:
                Entrada:        Saída:
                6 24            Sao Multiplos
                Entrada:        Saída:
                6 25            Nao sao Multiplos
                Entrada:        Saída:
                24 6            Sao Multiplos
            */

            string[] valores = Console.ReadLine().Split(" ");
            
            int valor1 = int.Parse(valores[0]);
            int valor2 = int.Parse(valores[1]);

            if (valor1 % valor2 == 0 || valor2 % valor1 == 0)
            {
                Console.WriteLine("Sao Multiplos");
            } else
            {
                Console.WriteLine("Nao sao Multiplos");
            }
        }
    }
}
