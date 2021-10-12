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


            // Exibe os produtos disponíveis da lista
            var listaProdutosDisponiveis = produtosDisponiveis.Where(produto => args.Any(arg => arg.ToUpper() == produto.Nome.ToUpper()));

            if (listaProdutosDisponiveis.Count() > 0)
            {
                Console.WriteLine("Produtos disponíveis da lista:");

                foreach (var item in listaProdutosDisponiveis)
                {
                    Console.WriteLine(item.ExibirDadosProduto());
                }
            }

            Console.WriteLine();


            // Exibe os produtos da lista que não estão disponíveis
            var listaProdutosNaoDisponiveis = args.Where(arg => !produtosDisponiveis.Any(produto => produto.Nome.ToUpper() == arg.ToUpper()));

            if (listaProdutosNaoDisponiveis.Count() > 0)
            {
                Console.WriteLine("Produtos da lista não disponíveis:");

                foreach (var item in listaProdutosNaoDisponiveis)
                {
                    Console.WriteLine($"# {item}");
                }
            }

            Console.WriteLine();


            // Exibe os produtos disponíveis ordenados por ordem nome
            var produtosOrdendosPorNome = produtosDisponiveis.OrderBy(produto => produto.Nome).ToList();

            Console.WriteLine("Produtos disponíveis ordenados por nome:");

            foreach (var item in produtosOrdendosPorNome)
            {
                Console.WriteLine(item.ExibirDadosProduto());
            }
        }
    }
}
