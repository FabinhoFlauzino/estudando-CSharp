namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade = 20;
            if (idade >= 18)
            {
                Console.WriteLine("Você é maior de idade.");
            }
            else
            {
                Console.WriteLine("Você é menor de idade.");
            }

            int nota = 85;
            if (nota >= 90)
            {
                Console.WriteLine("Você recebeu A.");
            }
            else if (nota >= 80)
            {
                Console.WriteLine("Você recebeu B.");
            }
            else if (nota >= 70)
            {
                Console.WriteLine("Você recebeu C.");
            }
            else
            {
                Console.WriteLine("Você recebeu F.");
            }

            Console.WriteLine("Entre com um número inteiro:");
            int x = int.Parse(Console.ReadLine());
            if (x % 2 == 0)
            {
                Console.WriteLine("Par!");
            }
            else
            {
                Console.WriteLine("Impar!");
            }

            Console.WriteLine("Qual a hora atual?");
            int hora = int.Parse(Console.ReadLine());
            if (hora < 12)
            {
                Console.WriteLine("Bom dia!");
            }
            else if (hora < 18)
            {
                Console.WriteLine("Boa tarde!");
            }
            else
            {
                Console.WriteLine("Boa noite!");
            }
        }
    }
}
