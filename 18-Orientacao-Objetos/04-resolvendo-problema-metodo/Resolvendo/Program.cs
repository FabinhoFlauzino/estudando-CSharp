using System.Globalization;

namespace Resolvendo
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto produto = new Produto();

            Console.WriteLine("Entre os dados do produto:");
            
            Console.Write("Nome: ");
            produto.Nome = Console.ReadLine();

            Console.Write("Preço: ");
            produto.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantidade em estoque: ");
            produto.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Dados do produto: " + produto);
            Console.WriteLine();

            Console.Write($"Digite o número de {produto.Nome} a ser adicionado no estoque: ");
            int qtde = int.Parse(Console.ReadLine());
            produto.AdicionarProdutos(qtde);
            Console.WriteLine();

            Console.WriteLine("Dados atualizados: " + produto);
            Console.WriteLine();

            Console.Write($"Digite o número de {produto.Nome} a ser removido do estoque: ");
            qtde = int.Parse(Console.ReadLine());
            produto.RemoverProduto(qtde);
            Console.WriteLine();

            Console.WriteLine("Dados atualizados: " + produto);
            Console.ReadLine();
        }
    }
}
