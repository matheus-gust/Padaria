using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPadaria.PADARIA.BLL
{
    class ClienteBLL
    {
        public List<MODEL.Cliente> select()
        {
            DAL.ClienteDAL dalCli = new DAL.ClienteDAL();
            return dalCli.select();
        }

        public MODEL.Cliente selectByID(int id)
        {
            DAL.ClienteDAL dalCli = new DAL.ClienteDAL();
            return dalCli.selectByID(id);
        }

        public MODEL.Cliente selectByNome(string nome)
        {
            DAL.ClienteDAL dalCli = new DAL.ClienteDAL();
            return dalCli.selectByNome(nome);
        }


        public void insert(MODEL.Cliente cliente)
        {
            DAL.ClienteDAL dalCli = new DAL.ClienteDAL();
            dalCli.insert(cliente);
        }

        public void update(MODEL.Cliente cliente)
        {
            DAL.ClienteDAL dalCli = new DAL.ClienteDAL();
            dalCli.update(cliente);
        }
        public void delete(int idCliente)
        {
            DAL.ClienteDAL dalCli = new DAL.ClienteDAL();
            dalCli.delete(idCliente);
        }
    }
}
