
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testUnitaire
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("mise en place d'un test");

            //arranger
            int a = 1;
            int b = 2;
            //agir
            int resultat = Addition(a, b);
            //auditer
            if (resultat !=3)
            {
                Console.WriteLine("le test est raté");
            }

            Console.WriteLine("test avec des valeurs limites");
            a = 0;
            b = 0;
            resultat = Addition(a, b);
            if (resultat != 0)
            {
                Console.WriteLine("le test est raté");
            }

            a = -5;
            b = 5;
            resultat = Addition(a, b);
            if (resultat != 0)
            {
                Console.WriteLine("le test est raté");
            }

            Console.WriteLine("\n*****************Utilisation de la méthode TDD (test avant code)****************\n");
            Console.WriteLine("écriture du test");
            int valeur = 0;
            int result = Factorielle(valeur);
            if (result !=1)
            {
                Console.WriteLine("le test est raté");
            }
            valeur = 1;
            result = Factorielle(valeur);
            if (result != 1)
            {
                Console.WriteLine("le test "+ valeur +" est raté");
            }
            valeur = 2;
            result = Factorielle(valeur);
            if (result != 2)
            {
                Console.WriteLine("le test " + valeur + " est raté");
            }
            valeur = 3;
            result = Factorielle(valeur);
            if (result != 6)
            {
                Console.WriteLine("le test " + valeur + " est raté");
            }
            valeur = 4;
            result = Factorielle(valeur);
            if (result != 24)
            {
                Console.WriteLine("le test " + valeur + " est raté");
            }


            Console.ReadLine();
        }

        private static int Factorielle(int a)
        {
            int tot = 1;
            for (int i = 1; i <= a; i++)
            {
                tot *= i;
                //tot = tot * i;
            }
            return tot;
        }

        public static int Addition(int a, int b)
        {
            return a + b;
        }
    }
}
