using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPadaria.PADARIA.MODEL
{
    public class ProdutoVenda
    {
        public int id { get; set; }
        public string nome { get; set; }
        public int quantidade { get; set; }
        public float valorTotal { get; set; }

        public static ProdutoVenda Converter(Produto produto, int quantidade)
        {
            ProdutoVenda produtoVenda = new ProdutoVenda();
            produtoVenda.id = produto.id;
            produtoVenda.nome = produto.nome;
            produtoVenda.quantidade = quantidade;
            produtoVenda.valorTotal = produto.valor * quantidade;
            return produtoVenda;
        }
    }
}
