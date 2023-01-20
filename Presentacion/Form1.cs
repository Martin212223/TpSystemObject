using LibAviones.Entidades;
using LibAviones.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAvionComercial_Click(object sender, EventArgs e)
        {
            AvionComercial avion1 = new AvionComercial();
            avion1.Piloto = "Ernesto";
            avion1.Copiloto = "Federico";
            avion1.Azafata = "Juliana";
            avion1.Capacidad = 150;
            avion1.LineaAerea = "Flybondi";

            MessageBox.Show(avion1.ToString() + "\n" + avion1.Despega("Argentina") + "\n" + avion1.Aterriza("México")); 
        }

        private void avionComercial_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void avionCarga_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAvionCarga_Click(object sender, EventArgs e)
        {
            AvionCarga avion2 = new AvionCarga();

            avion2.Piloto = "Hugo";
            avion2.Copiloto = "Julio";
            avion2.Azafata = "Mariela";
            avion2.Peso = 1345.89;
            avion2.TipoMercaderia = "Aceitunas en conserva";
            
            

            MessageBox.Show(avion2.ToString() + "\n" + avion2.Despega("Argentina") + "\n" + avion2.Aterriza("Panamá"));
        }
    }
}
