﻿namespace MarketList
{
    public class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }

        public string ExibirDadosProduto()
        {
            return $"Produto: { Nome } - R$: { Preco }.";
        }
    }
}
