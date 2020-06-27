using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPadaria.PADARIA.BLL
{
    class ProdutoBLL
    {
        public List<MODEL.Produto> select()
        {
            DAL.ProdutoDAL dalProd = new DAL.ProdutoDAL();
            return dalProd.select();
        }

        public MODEL.Produto selectByID(int id)
        {
            DAL.ProdutoDAL dalProd = new DAL.ProdutoDAL();
            return dalProd.selectByID(id);
        }


        public void insert(MODEL.Produto produto)
        {
            DAL.ProdutoDAL dalProd = new DAL.ProdutoDAL();
            dalProd.insert(produto);
        }

        public void update(MODEL.Produto produto)
        {
            DAL.ProdutoDAL dalProd = new DAL.ProdutoDAL();
            dalProd.update(produto);
        }
        public void delete(int idproduto)
        {
            DAL.ProdutoDAL dalProd = new DAL.ProdutoDAL();
            dalProd.delete(idproduto);
        }
    }
}
