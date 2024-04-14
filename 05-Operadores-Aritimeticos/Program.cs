namespace _05OperadoresAritimeticos
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                + adição
                - subtração
                * multiplicação
                / divisão
                % resto da divisão
             */

            int n1 = 3 + 4 * 2;
            int n2 = (3 + 4) * 2;
            int n3 = 17 % 3;
            double n4 = 10.0 / 8.0;

            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine();

            Console.WriteLine("Resolvendo fórmula de bascará com C");
            Console.WriteLine("-(-3) + raizQuadrada(-3² - 4 * 1 * -4) / 2 * 1");
            //-b + raizQuadrada(b² - 4ac) /2a -> dois resultados - e +
            //Valores a = -1, b = -3, c = -4

            double a = 1.0, b = -3.0, c = -4.0;
            double delta = Math.Pow(b, 2.0) - 4.0 * a * c;
            Console.WriteLine("Valor de delta = {0}", delta);

            double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);
            Console.WriteLine("Valor de x1 = {0}", x1);
            Console.WriteLine("Valor de x2 = {0}", x2);

        }
    }
}
