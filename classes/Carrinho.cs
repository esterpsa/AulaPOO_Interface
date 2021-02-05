using System;
using System.Collections.Generic;

namespace Interface.classes
{
    public class Carrinho : Icarrinho
    {
        List<Produto> carrinho = new List<Produto>();
        public void Alterar(int cod, Produto produto)
        {
           //Lambda

           carrinho.Find(x => x.Codigo == cod).Nome = produto.Nome;
           carrinho.Find(x => x.Codigo == cod).Preco = produto.Preco;

        }

        public void Cadastrar(Produto produto)
        {
            carrinho.Add(produto);
        }

        public void Deletar(Produto produto)
        {
            carrinho.Remove(produto);
        }

        public void listar()
        {
           foreach (Produto itemCarrinho in carrinho)
           {
               Console.WriteLine($"Produto {itemCarrinho.Nome} \n Preço: R${itemCarrinho.Preco}\n Código: {itemCarrinho.Codigo}");
               
           }
        }
    }
}