using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace imple_interface_explicite
{
    public class Homme : ICarnivor, IFrugivore
    {
        ////********!debut:version1
      
        //public void Manger()
        //{
        //    Console.WriteLine("je mange");
        //}
        ////********!fin:version1

        //********!debut:version2
        public void Manger()
        {
            Console.WriteLine("je mange");
        }
        //implémentation explicite des interfaces: on spécifie les méthodes manger pour chaque interface
        void ICarnivor.Manger()
        {
            Console.WriteLine("Je mange au tant que ICarnivor");
        }

        void IFrugivore.Manger()
        {
            Console.WriteLine("Je mange au tant que IFrugivore");
        }

        //********!fin:version2
    }
}
