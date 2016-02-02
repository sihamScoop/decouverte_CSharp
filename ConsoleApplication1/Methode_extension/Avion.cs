using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methode_extension
{
    class Avion : IVolant
    {
        public void Voler()
        {
            Console.WriteLine("Je vole comme un avion");
        }
    }
}
