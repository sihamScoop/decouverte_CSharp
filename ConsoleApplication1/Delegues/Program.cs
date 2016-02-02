using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegues
{
    class Program
    {
        static void Main(string[] args)
        {
            ////appel de la classe qui contient un delgué
            //int[] tableau = new int[] { 4, 2, 9, 8, 3 };
            //new TrieurDeTableau().DemoTri(tableau);
            //Console.WriteLine("utilisation du multicast");
            //new TrieurDeTableau2().DemoTri(tableau);

            new Operations().DemoOperation();

            Console.ReadLine();
        }
    }
}
