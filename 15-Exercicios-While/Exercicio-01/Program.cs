namespace Exercicio_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                Escreva um programa que repita a leitura de uma senha até que ela seja válida. Para cada leitura de senha
                incorreta informada, escrever a mensagem "Senha Invalida". Quando a senha for informada corretamente deve ser
                impressa a mensagem "Acesso Permitido" e o algoritmo encerrado. Considere que a senha correta é o valor 2002.
                Exemplo:
                Entrada:        Saída:
                2200            Senha Invalida
                1020            Senha Invalida
                2022            Senha Invalida
                2002            Acesso Permitido                
             */

            int senha = int.Parse(Console.ReadLine());

            while (senha != 2002)
            {
                Console.WriteLine("Senha Invalida");
                senha = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Acesso Permitido");
        }
    }
}
