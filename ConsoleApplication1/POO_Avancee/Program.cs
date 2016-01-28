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

            ////********!debut:trier une liste ou tableau d'objets
            //Voiture voit1 = new Voiture { vitesse = 100 };
            //Voiture voit2 = new Voiture { vitesse = 40 };
            //Voiture voit3 = new Voiture { vitesse = 10 };
            //Voiture voit4 = new Voiture { vitesse = 40 };
            //Voiture voit5 = new Voiture { vitesse = 50 };
            //Voiture[] TabVoiture = new Voiture[] { voit1,voit2,voit3,voit4,voit5};
            ////affichage des élément du tableau
            //int i = 1;
            //foreach (Voiture car in TabVoiture)
            //{
            //    Console.WriteLine(i + " " + car.vitesse);
            //    i++;
            //}
            //Console.WriteLine("lancement du tri");
            ////lancement du comparateur  grace à l'appel de la méthode sort
            //Array.Sort(TabVoiture);
            ////affichage des élément du tableau
            //int j = 1;
            //foreach (Voiture car in TabVoiture)
            //{
            //    Console.WriteLine(j +" "+ car.vitesse);
            //    j++;
            //}
            ////********!fin:trier une liste ou tableau d'objets

            ////********!debut:version3 : implémentation d'une interface
            //IVolant oiseau = new Oiseau { nombrePropulseur = 2 };
            //oiseau.Voler();

            //Oiseau oiseau1 = new Oiseau { nombrePropulseur = 2 };
            //Avion avion1 = new Avion { nombrePropulseur = 4 , nomCommandant="nico"};

            //List<IVolant> listVolants = new List<IVolant>();
            //listVolants.Add(oiseau1);
            //listVolants.Add(avion1);
            //foreach (IVolant volant in listVolants)
            //{
            //    volant.Voler();
            //    Avion avionCast = volant as Avion;
            //    if (avionCast != null)
            //    {
            //        Console.WriteLine("nom du commandant" + avionCast.nomCommandant);
            //    }
            //}
            ////********!fin:version3

            ////********!debut:version4 : ajout d'une interface qui herite d'une interface
            //AvionMoteur avion2 = new AvionMoteur { nombrePropulseur = 3 };
            //avion2.Voler();
            //avion2.DemarrerMoteur();
            ////********!fin:version4

            //********!debut:version5
            Avion2interface avionVolanatRoulant = new Avion2interface {nombrePropulseur = 4 };
            avionVolanatRoulant.DemarrerMoteur();
            avionVolanatRoulant.Rouler();
            avionVolanatRoulant.Voler();
            //********!fin:version5

            Console.ReadLine();
        }
    }
}
