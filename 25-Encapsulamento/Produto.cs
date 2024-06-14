using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_Encapsulamento
{
    public class Produto
    {
        // Atributos privados
        private string _nome;

        // Propriedades autoimplementadas
        public double Preco { get; private set; }
        public double Quantidade { get; set; }

        // Construtores
        public Produto() { }

        public Produto(string nome, double preco, double quantidade) // Corrigi a quantidade para double
        {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        // Propriedades customizadas usando propriedades privadas
        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }

        // Propriedade customizada usando propriedades autoimplementadas
        public double ValorTotalEmEstoque
        {
            get { return Preco * Quantidade; }
        }

        // Método público para atualizar o preço
        public void AtualizarPreco(double novoPreco)
        {
            if (novoPreco >= 0)
            {
                Preco = novoPreco;
            }
        }

        // Métodos para adicionar e remover produtos do estoque
        public void AdicionarProdutos(double quantidade)
        {
            Quantidade += quantidade;
        }

        public void RemoverProdutos(double quantidade)
        {
            if (Quantidade >= quantidade)
            {
                Quantidade -= quantidade;
            }
        }

        // Sobrescreve o método ToString para fornecer uma representação da classe Produto
        public override string ToString()
        {
            return _nome
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
