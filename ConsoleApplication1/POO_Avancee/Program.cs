using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Avancee
{
    class Program
    {
        static void Main(string[] args)
        {
            ////********!debut:version1
            //Voiture voitNicolas = new Voiture();
            //voitNicolas.couleur = "bleu";
            //Voiture voitJeremie = voitNicolas;
            //voitJeremie.couleur = "verte";
            //if (voitNicolas==voitJeremie)
            //{
            //    Console.WriteLine("Les objet reférencent la même instance");
            //}
            ////********!fin:version1

            ////********!debut:version2
            //Voiture voiture1 = new Voiture { vitesse = 10, marque = "Peugeot", couleur = "grise" };
            //Voiture voiture2 = new Voiture { vitesse = 10, marque = "Peugeot", couleur = "grise" };
            ////comparaison des objets voitures par la méthode classique
            //if (voiture1.couleur == voiture2.couleur && voiture1.marque == voiture2.marque && voiture1.vitesse == voiture2.vitesse)
            //{
            //    Console.WriteLine("Méthode classique: Les deux voitures sont identiques");
            //}
            ////comparaison des objets voitures par la méthode Equals()
            //if (voiture1.Equals(voiture2))
            //{
            //    Console.WriteLine("Méthode Equals(): Les deux voitures ont les mêmes valeurs dans leurs propriétés");
            //}
            ////affichage des hashCode
            //Console.WriteLine("Affichage des hashCode");
            //Console.WriteLine(voiture1.GetHashCode());
            //Console.WriteLine(voiture2.GetHashCode());
            ////********!fin:version2

            //********!debut:version3
            //********!fin:version3

            //********!debut:version3
            //********!fin:version3

            Console.ReadLine();
        }
    }
}
