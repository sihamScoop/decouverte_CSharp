using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jeuPlusMoins
{
    class Program
    {
        static void Main(string[] args)
        {
            int compteur = 0;
            int valeurATrouver = new Random().Next(0, 100);
            int nombre;
            Console.WriteLine(valeurATrouver);
            bool trouver = false;

            do
            {
                Console.WriteLine("veuillez donner un nombre (entre 0 et 100)");
                string chaine = Console.ReadLine();

                if (!int.TryParse(chaine, out nombre))
                {
                    Console.WriteLine("Veuillez donner un nombre svp");
                }
                else 
                {
                    nombre = int.Parse(chaine);
                    if (nombre > 100 || nombre < 0)
                    {
                        Console.WriteLine("Erreur, veuillez donner un nombre compris entre 0 et 100");
                    }
                    else
                    if (nombre == valeurATrouver)
                    {
                        Console.WriteLine("gangné !!");
                        trouver = true;
                    }
                    else if (nombre > valeurATrouver)
                    {
                        Console.WriteLine("la valeur à trouver est inférieur");

                    }
                    else
                    {
                        Console.WriteLine("la valeur à trouver est supérieur");

                    }
                    compteur++;
                }

            } while (!trouver);

            if (compteur == 1)
            {
                Console.WriteLine(" en " + compteur + " coup");
            }
            else
            {
                Console.WriteLine(" en " + compteur + " coups");
            }
           

            Console.ReadLine();
        }



    }
}

