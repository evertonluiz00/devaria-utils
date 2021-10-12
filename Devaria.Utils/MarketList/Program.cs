using System;
using System.Collections.Generic;
using System.Linq;

namespace MarketList
{
    class Program
    {
        /*
         * Rodar via PowerShell na pasta MarketList
         * dotnet run produto1 produto2 produto3 ...
         * 
         */

        static void Main(string[] args)
        {
            List<Produto> produtosDisponiveis = new List<Produto>();
            produtosDisponiveis.Add(new Produto() { Nome = "Pão", Preco = 0.50 });
            produtosDisponiveis.Add(new Produto() { Nome = "Carne", Preco = 49.90 });
            produtosDisponiveis.Add(new Produto() { Nome = "Leite", Preco = 3.40 });
            produtosDisponiveis.Add(new Produto() { Nome = "Cerveja", Preco = 6.29 });
            produtosDisponiveis.Add(new Produto() { Nome = "Chocolate", Preco = 4.99 });
            produtosDisponiveis.Add(new Produto() { Nome = "Arroz", Preco = 5.50 });

            if (args.Length == 0)
            {
                Console.WriteLine("Nenhum produto informado na lista.");
                return;
            }

            var listaProdutosDisponiveis = produtosDisponiveis.Where(produto => args.Any(arg => produto.Nome.ToUpper() == arg.ToUpper()));

            string msg = listaProdutosDisponiveis.Count() > 0 ? "Produtos disponíveis da lista:" : "Nenhum produto da lista está disposnível.";
            Console.WriteLine(msg);

            foreach (var item in listaProdutosDisponiveis)
            {
                Console.WriteLine(item.ExibirDadosProduto());
            }
        }
    }
}
