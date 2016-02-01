using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_generique
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int i = 5;
            double d = 9.5;
            string s = "abcd";
            Voiture voit = new Voiture();

            ////********!debut:version1
            //Afficheur.Affiche(i);
            //Afficheur.Affiche(d);
            //Afficheur.Affiche(s);
            //Afficheur.Affiche(voit);
            ////********!fin:version1

            ////********!debut:version2
            //Afficheur.Affiche<int>(i); //équavalent à Afficheur.Affiche(i); le compilateur comprends
            //Afficheur.Affiche<double>(d);
            //Afficheur.Affiche<string>(s);
            //Afficheur.Affiche<Voiture>(voit);
            ////équivalence
            //Afficheur.Affiche(i);
            //Afficheur.Affiche(d);
            //Afficheur.Affiche(s);
            //Afficheur.Affiche(voit);
            ////********!fin:version2

            //********!debut:version3
            int valeur1 = 5;
            int valeur2 = 10;
            Afficheur.Echanger(ref valeur1, ref valeur2);
            Console.WriteLine(valeur1);
            Console.WriteLine(valeur2);

            Voiture voiture1 = new Voiture { couleur = "rouge" };
            Voiture voiture2 = new Voiture { couleur = "verte" };
            Afficheur.Echanger(ref voiture1, ref voiture2);
            Console.WriteLine(voiture1.couleur);
            Console.WriteLine(voiture2.couleur);

            int entier1 = 5;
            int entier2 = 5;
            double doub = 5.0;
            Console.WriteLine(Afficheur.EstEgal(entier1,entier2));
            Console.WriteLine(Afficheur.EstEgal(entier1,doub));
            //********!fin:version3


            //********!debut:version4
            //utilisation de la classe générique
            MaListeGenerique<int> maListe = new MaListeGenerique<int>();
            maListe.Ajouter(25);
            maListe.Ajouter(30);
            maListe.Ajouter(5);

            Console.WriteLine(maListe.ObetnirElement(0));
            Console.WriteLine(maListe.ObetnirElement(1));
            Console.WriteLine(maListe.ObetnirElement(2));
            Console.WriteLine(maListe.ObetnirElement(3));

            for (int j = 0; j < 30; j++)
            {
                maListe.Ajouter(j); 
            }
            //********!fin:version4

            //********!debut:version5
            //utilisation de la classe Nullables
            Nullable<int> entier = null;
            if (!entier.HasValue)
            {
                Console.WriteLine("l'entier n'a pas de valeur");
            }
            entier = 5;
            if (entier.HasValue)
            {
                Console.WriteLine("La valeur de l'entier est :" + entier.Value);
            }

            //********!fin:version5

            Console.ReadLine();
        }
    }
}
