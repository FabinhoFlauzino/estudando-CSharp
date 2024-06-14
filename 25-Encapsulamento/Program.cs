namespace _25_Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            //Implementação Manual
            //Produto p = new Produto("TV", 500.00, 10);
            //p.SetNome("TV 4k");
            //Console.WriteLine(p.GetNome());
            //Console.WriteLine(p.GetPreco());
            //Console.WriteLine(p.GetQuantidade());

            // Cria uma instância de Produto usando o construtor padrão
            Produto produto1 = new Produto();

            // Define o nome, preço e quantidade usando as propriedades e métodos
            produto1.Nome = "Caneta";
            produto1.AtualizarPreco(1.50);
            produto1.Quantidade = 100;

            // Exibe o produto usando o método ToString
            Console.WriteLine(produto1);

            // Cria uma instância de Produto usando o construtor parametrizado
            Produto produto2 = new Produto("Lápis", 0.80, 200);

            // Exibe o produto usando o método ToString
            Console.WriteLine(produto2);

            // Adiciona 50 lápis ao estoque
            produto2.AdicionarProdutos(50);

            // Remove 30 lápis do estoque
            produto2.RemoverProdutos(30);

            // Exibe o produto após as alterações no estoque
            Console.WriteLine(produto2);
        }
    }
}
