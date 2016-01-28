using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Avancee
{
    class Avion2interface : IVolantMotorise, IRoulant
    {
        public int nombrePropulseur { get; set; }

        public void DemarrerMoteur()
        {
            Console.WriteLine("le moteur est en marche");
        }

        public void Rouler()
        {
            Console.WriteLine("Je roule" );
        }

        public void Voler()
        {
            Console.WriteLine("Je vole grâce à " + this.nombrePropulseur + " ailes.");
        }
    }
}
