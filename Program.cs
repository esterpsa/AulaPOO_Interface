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
            p1.Nome = "KIMONO";
            p1.Preco = 200f;

            Produto p2 = new Produto();
            p2.Codigo = 124;
            p2.Nome = "LUVAS";
            p2.Preco = 50f;

            Produto p3 = new Produto();
            p3.Codigo = 125;
            p3.Nome = "FAIXAS";
            p3.Preco = 35f;

            carrinho.Cadastrar(p1);
            carrinho.Cadastrar(p2);
            carrinho.Cadastrar(p3);
            carrinho.listar();

            Console.ForegroundColor = ConsoleColor.Blue;

            carrinho.Alterar(p1.Codigo,p3);
            carrinho.listar();
            Console.ResetColor();


        }
    }
}
