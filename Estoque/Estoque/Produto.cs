using System;
using System.Collections.Generic;
using System.Text;

namespace Estoque
{
    class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }

        public Produto() { }

        public Produto(string nome, double preco, int quantidade)
        {
            Nome = nome ?? throw new ArgumentNullException(nameof(nome));
            Preco = preco;
            Quantidade = quantidade;
        }

        public void AdicionarProdutos(int qte)
        {
            Quantidade += qte;
        }

        public override string ToString()
        {
            return "Quantidade: " + Quantidade;
        }

        public double ValorTotalEmEstoque() => Quantidade * Preco;
  
    }
}
