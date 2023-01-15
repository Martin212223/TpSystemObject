using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibAviones.Entidades
{
    public abstract class Avion
    {
        public string Piloto { get; set; }

        public string Copiloto { get; set; }

        public string Azafata { get; set; }

        public string Aterriza(string destino)
        {
            return "El avión aterriza en " + destino;
        }

        public string Despega(string origen)
        {
            return "El avión despega desde " + origen;
        }
    }
}
