using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPadaria.PADARIA.BLL
{
    class CategoriaBLL
    {
        public List<MODEL.Categoria> select()
        {
            DAL.CategoriaDAL dalCat = new DAL.CategoriaDAL();
            return dalCat.select();
        }

        public MODEL.Categoria selectByID(int id)
        {
            DAL.CategoriaDAL dalCat = new DAL.CategoriaDAL();
            return dalCat.selectByID(id);
        }


        public void insert(MODEL.Categoria categoria)
        {
            DAL.CategoriaDAL dalCat = new DAL.CategoriaDAL();
            dalCat.insert(categoria);
        }

        public void update(MODEL.Categoria categoria)
        {
            DAL.CategoriaDAL dalCat = new DAL.CategoriaDAL();
            dalCat.update(categoria);
        }
        public void delete(int idCategoria)
        {
            DAL.CategoriaDAL dalCat = new DAL.CategoriaDAL();
            dalCat.delete(idCategoria);
        }
    }
}
