using LibAviones.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibAviones.Models
{
    public class AvionComercial : Avion
    {
        public int Capacidad { get; set; }

        public string LineaAerea { get; set; }

        public override string ToString()
        {
            return "Piloto: " + Piloto + "\nCopiloto: " + Copiloto + "\nAzafata: " + Azafata + "\nCapacidad: " + Capacidad + " pasajeros.\nLínea Aérea: " + LineaAerea;
        }
    }
}
