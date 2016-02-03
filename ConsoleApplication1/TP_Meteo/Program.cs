using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Meteo
{
    class Program
    {
        static void Main(string[] args)
        {
            int nombreJourSoleil=0;
            int nombreChangement=0;

            Random rand = new Random();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
                nombreJourSoleil += simulateur(rand) ;
            }

            nombreChangement = 5;

            Console.WriteLine("nombre de jour ensoleillé :" + nombreJourSoleil);
            Console.WriteLine("nombre de changement : " + nombreChangement);
            Console.ReadLine();
        }

        public static int simulateur(Random rand)
        {
            int nombreJourSoleil = 0;
            

            int valeur = rand.Next(100);
            string message;
            if (valeur < 5)
            {
                message = "le temps est au soleil";
                nombreJourSoleil++;
               
            }
            else if (valeur >= 5 && valeur < 50)
            {
                message = "nous aurons des nuages";
                

            }
            else if (valeur >= 50 && valeur < 90)
            {
                message = "nous aurons de la pluie";
               
            }
            else
            {
                message = "nous aurons de l'orage";
               
            }

            Console.WriteLine(valeur);
            Console.WriteLine("la météo du jour est : " + message);
            return nombreJourSoleil;
        }
    }
}
