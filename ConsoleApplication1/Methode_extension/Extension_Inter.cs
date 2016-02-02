using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methode_extension
{
    public static class Extension_Inter
    {
        public static void Atterir(this IVolant vol)
        {
            Console.WriteLine("j'attéris");
        }
    }
}
