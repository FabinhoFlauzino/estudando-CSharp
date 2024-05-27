using System.Globalization;

namespace _22_Construtor
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Entre os dados do produto:");

            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantidade no estoque: ");
            int quantidade = int.Parse(Console.ReadLine());

            Produto produto = new Produto(nome, preco, quantidade);

            Console.WriteLine();

            Console.WriteLine("Dados do produto: " + produto);

            Console.WriteLine();

            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            produto.AdicionarProdutos(qte);

            Console.WriteLine();

            Console.WriteLine("Dados atualizados: " + produto);

            Console.WriteLine();

            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            qte = int.Parse(Console.ReadLine());
            produto.RemoverProdutos(qte);

            Console.WriteLine();

            Console.WriteLine("Dados atualizados: " + produto);
        }
    }
}
