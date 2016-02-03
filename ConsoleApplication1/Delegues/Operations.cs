using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegues
{
    public class Operations
    {
        public void DemoOperation()
        {
            //double division = Calcul(4, 5, delegate (int a, int b)
            //{
            //    return (double)a / (double)b;
            //});

            //utilisation d'une expression lambda
            double division = Calcul(4, 5, (a,b)=>
            {
                return (double)a / (double)b;
            });
            //ce qui est équivalent à 
            double divisionMieux = Calcul(4, 5, (a, b) => (double)a / (double)b);


            double puissance = Calcul(4, 5, delegate (int a, int b)
            {
                return Math.Pow((double)a, (double)b);
            });

            Console.WriteLine("Division : " + division);
            Console.WriteLine("Division : " + divisionMieux);
            Console.WriteLine("puissance : " + puissance);
        }

        public double Calcul(int a, int b, Func<int, int, double> maMethodeDelegue)
        {
            return maMethodeDelegue(a, b);
        }

        ////sans optimisation de méthode
        //private delegate double DelegOperation(int aa, int bb);
        //public double Division(int a, int b)
        //{
        //    return (double)a / (double)b;
        //}

        //public double Puissance(int a, int b)
        //{
        //    return Math.Pow((double)a, (double)b);
        //}

        //public void DemoOperation()
        //{
        //    DelegOperation delegue = Division;
        //    delegue(4, 5);
        //    double division = delegue(4, 5);

        //    delegue = Puissance;
        //    delegue(4, 5);
        //    double puissance = delegue(4, 5);

        //    Console.WriteLine("Division : " + division);
        //    Console.WriteLine("puissance : " + puissance);
        //}


    }
}
