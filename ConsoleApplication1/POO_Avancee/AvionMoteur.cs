using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Avancee
{
    class AvionMoteur : IVolantMotorise
    {
        public int nombrePropulseur { get; set; }

        public void DemarrerMoteur()
        {
            Console.WriteLine("le moteur est en marche");
        }

        public void Voler()
        {
            Console.WriteLine("Je vole grâce à " + this.nombrePropulseur + " ailes.");
        }
    }
}
