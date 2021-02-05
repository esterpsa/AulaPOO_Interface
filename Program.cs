using System;
using Interface.classes;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Carrinho carrinho = new Carrinho();

            Produto p1 = new Produto();

            p1.Codigo = 123;
            p1.Nome = "Kimono";
            p1.Preco = 100f;

            carrinho.Cadastrar(p1);
            carrinho.listar();


        }
    }
}
