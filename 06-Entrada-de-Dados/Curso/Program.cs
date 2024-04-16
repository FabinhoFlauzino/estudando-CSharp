using System.Globalization;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            //O comando para ler os dados do teclado é o Console.ReadLine();
            string frase = Console.ReadLine();
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();
            //string s = Console.ReadLine();
            //string[] vet = s.Split(" "); ou a forma abaixo
            string[] vet = Console.ReadLine().Split(" ");
            string p1 = vet[0];
            string p2 = vet[1];
            string p3 = vet[2];

            Console.WriteLine("Você digitou ");
            Console.WriteLine(frase);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine(p3);

            //O comando ReadLine retorna uma string, logo teremos que converter usando o Parse
            var n1 = int.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            char ch = char.Parse(Console.ReadLine());

            Console.WriteLine("Você digitou: ");
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(ch);

            string[] pessoa = Console.ReadLine().Split(" ");
            string nomePessoa = pessoa[0];
            char pessoaSexo = char.Parse(pessoa[1]);
            int pessoaIdade = int.Parse(pessoa[2]);
            double pessoaAltura = double.Parse(pessoa[3], CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine($"{nomePessoa} do sexo {pessoaSexo} tem {pessoaIdade} de idade e mede {pessoaAltura.ToString("F2", CultureInfo.InvariantCulture)} de altura.");

        }
    }
}
