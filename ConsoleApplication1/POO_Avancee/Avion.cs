using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Avancee
{
    class Avion : IVolant
    {
        public int nombrePropulseur { get; set; }
        public string nomCommandant { get; set; }

        public void Voler()
        {
            Console.WriteLine("Je vole grâce à " + this.nombrePropulseur + " moteurs avec " + nomCommandant+" au commande");
        }
    }
}
