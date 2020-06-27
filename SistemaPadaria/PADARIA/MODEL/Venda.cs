using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPadaria.PADARIA.MODEL
{
    class Venda
    {
        public int id { get; set; }
        public int idCliente { get; set; }
        public float valorTotal { get; set; }
        public string data { get; set; }
    }
}
