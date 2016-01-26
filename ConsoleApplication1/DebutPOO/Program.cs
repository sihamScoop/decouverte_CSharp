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

        }
    }
}
