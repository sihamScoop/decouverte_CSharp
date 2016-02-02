using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace imple_interface_explicite
{
    class Program
    {
        static void Main(string[] args)
        {
            ////********!debut:version1
            //Homme homme = new Homme();
            //homme.Manger();
            //((ICarnivor)homme).Manger();
            //((IFrugivore)homme).Manger();
            ////********!fin:version1

            //********!debut:version2
            Homme homme2 = new Homme();
            homme2.Manger();
            ((ICarnivor)homme2).Manger();
            ((IFrugivore)homme2).Manger();
            //********!fin:version2

            Console.ReadLine();
        }
    }
}
