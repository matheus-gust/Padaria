using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPadaria.RELATORIOS
{
    class Funcoes
    {
        public static string deretorioPasta()
        {
            string pasta = @"c:\Relatorios";
            if (!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
            }
            return pasta;
        }
    }
}
