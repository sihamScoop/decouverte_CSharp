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
            voiture1.couleur = "rouge vermillon ";
            Console.WriteLine(voiture1.couleur);

            

            //Voiture voiture4 = new Voiture();
            //voiture4.couleur = "violet";
            //voiture4.Marque = "peugeot";
            //voiture4.Vitesse = 50;
            //equivalence de l'écriture du dessus
            Voiture voiture4 = new Voiture { couleur = "violet", Marque = "peugeot", Vitesse = 150 };
            Console.WriteLine(voiture4.Vitesse);
            bool reponse = voiture4.VitesseAutorisee(voiture4.Vitesse);
            Console.WriteLine("vitesse autorisée : " + reponse);

            Voiture voiture3 = new Voiture();
            voiture3.couleur = "bleu";
            Console.WriteLine(voiture3.couleur);
            voiture3.Rouler();            
            voiture3.Vitesse = 60;
            voiture3.Rouler();

            Voiture voitureV = new Voiture(20);
            voitureV.Rouler();

        }
    }
}
