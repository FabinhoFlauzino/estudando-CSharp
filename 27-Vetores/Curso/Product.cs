using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso
{
    class Product
    {
        public string Nome { get; set; }
        public double Preco { get; set; }

        public Product(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }   
    }
}
