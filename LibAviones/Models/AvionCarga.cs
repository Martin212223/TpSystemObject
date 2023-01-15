using LibAviones.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibAviones.Models
{
    public class AvionCarga : Avion
    {
        public double Peso { get; set; }

        public string TipoMercaderia { get; set; }

        public override string ToString()
        {
            return "Piloto: " + Piloto + "\nCopiloto: " + Copiloto + "\nAzafata: " + Azafata + "\nTipo de mercadería: " + TipoMercaderia + "\nPeso: " + Peso + " kg.";
        }
    }
}
