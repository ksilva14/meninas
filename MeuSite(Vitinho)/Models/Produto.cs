using System;

namespace MeuSite.Models
{
    public class Produto
    {
        public int ProdutoId { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int QuantidadeEstoque { get; set; }
        public string UrlImagem { get; set; }
        public decimal Preco { get; set; }
    }
}
