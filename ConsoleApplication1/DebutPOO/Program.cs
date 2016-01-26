using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebutPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            //création d'une instance de la classe voiture
            Voiture voiture1 = new Voiture();
            voiture1.Klaxonner();
            voiture1.couleur = "rouge";
            Console.WriteLine(voiture1.couleur);

            Voiture voiture2 = new Voiture();
            voiture2.couleur = "noire";
            Console.WriteLine(voiture2.couleur);

            Voiture voiture3 = new Voiture();
            voiture3.couleur = "bleu";
            Console.WriteLine(voiture3.couleur);

        }
    }
}
