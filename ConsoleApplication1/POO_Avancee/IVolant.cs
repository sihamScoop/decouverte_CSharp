using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Avancee
{
    interface IVolant
    {
        int nombrePropulseur { get; set; }
        void Voler();
    }
}
