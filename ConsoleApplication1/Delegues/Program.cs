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
            //appel de la classe qui contient un delgué
            int[] tableau = new int[] { 4, 2, 9, 8, 3 };
            new TrieurDeTableau().DemoTri(tableau);
            Console.WriteLine("utilisation du multicast");
            new TrieurDeTableau2().DemoTri(tableau);

            //utilisation de la classe Operation
            new Operations().DemoOperation();

            //********!debut:version3 : utilisation des expression lambda (classe TrieurDeTableau2)
            Console.WriteLine("Avant utilisation d'une expression lambda");
            new TrieurDeTableau2().TriAvantLambda(tableau);
            Console.WriteLine("utilisation d'une expression lambda");
            new TrieurDeTableau2().TriApresLambda(tableau);
            Console.WriteLine("utilisation de deux expressions lambda");
            new TrieurDeTableau2().TriApresDoubleLambda(tableau);
            Console.ReadLine();
        }
    }
}
