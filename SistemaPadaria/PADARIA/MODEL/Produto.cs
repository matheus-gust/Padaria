using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPadaria.PADARIA.MODEL
{
    public class Produto
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string categoria { get; set; }
        public int quantidade { get; set; }
        public float valor { get; set; }
        public int idCategoria { get; set; }
}
}
