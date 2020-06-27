using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPadaria.PADARIA.BLL
{
    class VendasBLL
    {
        public List<MODEL.VendaConsulta> select()
        {
            DAL.VendaDAL dalVend = new DAL.VendaDAL();
            List<MODEL.Venda> vendas = new List<MODEL.Venda>();
            List<MODEL.VendaConsulta> vendaConsulta = new List<MODEL.VendaConsulta>();
            vendas = dalVend.select();
            for(int i = 0; i < vendas.Count; i++)
            {
                MODEL.VendaConsulta venda = new MODEL.VendaConsulta();
                ClienteBLL clienteBLL = new ClienteBLL();
                MODEL.Cliente cliente = clienteBLL.selectByID(vendas[i].idCliente);
                venda.cliente = cliente.nome;
                venda.id = vendas[i].id;
                venda.valor = vendas[i].valorTotal;
                venda.data = vendas[i].data;
                vendaConsulta.Add(venda);
            }
            return vendaConsulta;
        }

        public MODEL.Venda selectByID(int id)
        {
            DAL.VendaDAL dalVend = new DAL.VendaDAL();
            return dalVend.selectByID(id);
        }

        public void insert(MODEL.Venda venda, List<MODEL.ProdutoVenda> produtoVendas)
        {
            DAL.VendaDAL dalVend = new DAL.VendaDAL();
            DAL.ProdutoDAL produtoDAL = new DAL.ProdutoDAL();
            
            for(int i = 0; i < produtoVendas.Count; i++)
            {
                MODEL.Produto produto = produtoDAL.selectByID(produtoVendas[i].id);
                produto.quantidade = produto.quantidade - produtoVendas[i].quantidade;
                produtoDAL.update(produto);
            }

            dalVend.insert(venda, produtoVendas);
        }

        public void update(MODEL.Venda venda)
        {
            DAL.VendaDAL dalVend = new DAL.VendaDAL();
            dalVend.update(venda);
        }
        public void delete(int idVenda)
        {
            DAL.VendaDAL dalVend = new DAL.VendaDAL();
            dalVend.delete(idVenda);
        }

        public List<MODEL.VendaConsulta> pesquisar(string nomePesquisa)
        {
            DAL.VendaDAL dalVend = new DAL.VendaDAL();
            List<MODEL.VendaConsulta> vendaConsulta = new List<MODEL.VendaConsulta>();

            ClienteBLL clienteBLL = new ClienteBLL();
            MODEL.Cliente cliente = clienteBLL.selectByNome(nomePesquisa);
            
            
            List<MODEL.Venda> vendas = dalVend.selectByIDCliente(cliente.id);

            for (int i = 0; i < vendas.Count; i++)
            {
                MODEL.VendaConsulta venda = new MODEL.VendaConsulta();
                venda.id = vendas[i].id;
                venda.cliente = cliente.nome;
                venda.valor = vendas[i].valorTotal;
                venda.data = vendas[i].data;
                vendaConsulta.Add(venda);
            }

            return vendaConsulta;
        }

        public List<MODEL.VendaConsulta> pesquisarPorData(string data)
        {
            DAL.VendaDAL dalVend = new DAL.VendaDAL();
            List<MODEL.VendaConsulta> vendaConsulta = new List<MODEL.VendaConsulta>();

            List<MODEL.Venda> vendas = dalVend.selectByData(data);

            for (int i = 0; i < vendas.Count; i++)
            {
                ClienteBLL clienteBLL = new ClienteBLL();
                MODEL.Cliente cliente = clienteBLL.selectByID(vendas[i].idCliente);
                MODEL.VendaConsulta venda = new MODEL.VendaConsulta();
                venda.id = vendas[i].id;
                venda.cliente = cliente.nome;
                venda.valor = vendas[i].valorTotal;
                venda.data = vendas[i].data;
                vendaConsulta.Add(venda);
            }

            return vendaConsulta;
        }
    }
}
