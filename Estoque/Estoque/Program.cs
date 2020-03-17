using System;
using System.Collections.Generic;

namespace Estoque
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto produto = new Produto("teste", 10.0, 0);

            while (!Console.ReadLine().Equals("0"))
            {
                Console.WriteLine("adicionar produtos");
                produto.AdicionarProdutos(int.Parse(Console.ReadLine()));

                Console.WriteLine(produto);

                Console.WriteLine("continuar? 0 para sair");
            }
        }
    }
}
