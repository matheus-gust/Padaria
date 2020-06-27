using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPadaria.RELATORIOS
{
    class RelGerais
    {
        public static void relProdutos()
        {
            PADARIA.BLL.ProdutoBLL produtoBll = new PADARIA.BLL.ProdutoBLL();
            List<PADARIA.MODEL.Produto> produtos = new List<PADARIA.MODEL.Produto>();
            produtos = produtoBll.select();

            string pasta = Funcoes.deretorioPasta();
            string arquivo = pasta + @"\RelProd.html";
            StreamWriter sw = new StreamWriter(arquivo);

            using (sw)
            {
                sw.WriteLine("<html> ");
                sw.WriteLine("<head> ");
                sw.WriteLine(" <title>Relatorio Produto</title> ");
                sw.WriteLine(" <link rel='stylesheet' href='https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/css/bootstrap.min.css' integrity='sha384-9aIt2nRpC12Uk9gS9baDl411NQApFmC26EwAOH8WgZl5MYYxFfc+NcPb1dKGj7Sk' crossorigin='anonymous'> ");
                sw.WriteLine("</head> ");
                sw.WriteLine("<body> ");
                sw.WriteLine(" <div class='container'> ");
                sw.WriteLine(" <div class='row mt-3'> ");
                sw.WriteLine(" <div class='col-12'> ");
                sw.WriteLine(" <h2 class='text-center'>Relatorio de Produtos</h2> ");
                sw.WriteLine(" </div> ");
                sw.WriteLine(" </div> ");
                sw.WriteLine(" <div class='row justify-content-center mt-3'> ");
                sw.WriteLine(" <div class='col-6'> ");
                sw.WriteLine(" <table class='table'> ");
                sw.WriteLine(" <thead> ");
                sw.WriteLine(" <tr> ");
                sw.WriteLine(" <th scope='col'>Id</th> ");
                sw.WriteLine(" <th scope='col'>Nome</th> ");
                sw.WriteLine(" <th scope='col'>Categoria</th> ");
                sw.WriteLine(" <th scope='col'>Quantidade</th> ");
                sw.WriteLine(" <th scope='col'>Valor</th> ");
                sw.WriteLine(" </tr> ");
                sw.WriteLine(" </thead> ");
                sw.WriteLine(" <tbody> ");

                foreach (PADARIA.MODEL.Produto produto in produtos)
                {
                    sw.WriteLine(" <tr> ");

                    sw.WriteLine(" <td> ");
                    sw.WriteLine(produto.id);
                    sw.WriteLine(" </td> ");

                    sw.WriteLine(" <td> ");
                    sw.WriteLine(produto.nome);
                    sw.WriteLine(" </td> ");

                    sw.WriteLine(" <td> ");
                    sw.WriteLine(produto.categoria);
                    sw.WriteLine(" </td> ");

                    sw.WriteLine(" <td> ");
                    sw.WriteLine(produto.quantidade);
                    sw.WriteLine(" </td> ");

                    sw.WriteLine(" <td> ");
                    sw.WriteLine("R$ " + produto.valor);
                    sw.WriteLine(" </td> ");

                    sw.WriteLine(" </tr> ");
                }

                sw.WriteLine(" </tbody> ");
                sw.WriteLine(" </table> ");
                sw.WriteLine(" </div> ");
                sw.WriteLine(" </div> ");
                sw.WriteLine(" </div> ");
                sw.WriteLine("</body> ");
                sw.WriteLine("</html>");
            }

            System.Diagnostics.Process.Start(arquivo);
        }


        public static void relVendas()
        {
            PADARIA.BLL.VendasBLL produtoBll = new PADARIA.BLL.VendasBLL();
            List<PADARIA.MODEL.VendaConsulta> vendas = new List<PADARIA.MODEL.VendaConsulta>();
            vendas = produtoBll.select();

            string pasta = Funcoes.deretorioPasta();
            string arquivo = pasta + @"\RelVenda.html";
            StreamWriter sw = new StreamWriter(arquivo);

            using (sw)
            {
                sw.WriteLine("<html> ");
                sw.WriteLine("<head> ");
                sw.WriteLine(" <title>Relatorio Produto</title> ");
                sw.WriteLine(" <link rel='stylesheet' href='https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/css/bootstrap.min.css' integrity='sha384-9aIt2nRpC12Uk9gS9baDl411NQApFmC26EwAOH8WgZl5MYYxFfc+NcPb1dKGj7Sk' crossorigin='anonymous'> ");
                sw.WriteLine("</head> ");
                sw.WriteLine("<body> ");
                sw.WriteLine(" <div class='container'> ");
                sw.WriteLine(" <div class='row mt-5'> ");
                sw.WriteLine(" <div class='col-12'> ");
                sw.WriteLine(" <h2 class='text-center'>Relatorio de Vendas</h2> ");
                sw.WriteLine(" </div> ");
                sw.WriteLine(" </div> ");
                sw.WriteLine(" <div class='row justify-content-center mt-3'> ");
                sw.WriteLine(" <div class='col-6'> ");
                sw.WriteLine(" <table class='table'> ");
                sw.WriteLine(" <thead> ");
                sw.WriteLine(" <tr> ");
                sw.WriteLine(" <th scope='col'>Id</th> ");
                sw.WriteLine(" <th scope='col'>Cliente</th> ");
                sw.WriteLine(" <th scope='col'>Data</th> ");
                sw.WriteLine(" <th scope='col'>Valor</th> ");
                sw.WriteLine(" </tr> ");
                sw.WriteLine(" </thead> ");
                sw.WriteLine(" <tbody> ");

                float valorTotal = 0;
                foreach (PADARIA.MODEL.VendaConsulta venda in vendas)
                {
                    sw.WriteLine(" <tr> ");

                    sw.WriteLine(" <td> ");
                    sw.WriteLine(venda.id);
                    sw.WriteLine(" </td> ");

                    sw.WriteLine(" <td> ");
                    sw.WriteLine(venda.cliente);
                    sw.WriteLine(" </td> ");

                    sw.WriteLine(" <td> ");
                    sw.WriteLine(venda.data);
                    sw.WriteLine(" </td> ");

                    sw.WriteLine(" <td> ");
                    sw.WriteLine("R$ " + venda.valor);
                    sw.WriteLine(" </td> ");
                    sw.WriteLine(" </tr> ");
                    valorTotal += venda.valor;
                }

                sw.WriteLine(" <div class='row justify - content - center'> ");
                sw.WriteLine(" <div class='col - 6'> ");
                sw.WriteLine(" <h5> ");
                sw.WriteLine(" Valor Total: R$" + valorTotal);
                sw.WriteLine(" </h5> ");
                sw.WriteLine(" </div> ");
                sw.WriteLine(" </div> ");

                sw.WriteLine(" </tbody> ");
                sw.WriteLine(" </table> ");
                sw.WriteLine(" </div> ");
                sw.WriteLine(" </div> ");
                sw.WriteLine(" </div> ");
                sw.WriteLine("</body> ");
                sw.WriteLine("</html>");
            }

            System.Diagnostics.Process.Start(arquivo);
        }
    }
}
