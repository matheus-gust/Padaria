using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPadaria.PADARIA.DAL
{
    class Conexao
    {
        public static string getConexao()
        {
            return @"Data Source=DESKTOP-FKTB8CA;Initial Catalog=PADARIA;Integrated Security=True";
        }
    }
}
