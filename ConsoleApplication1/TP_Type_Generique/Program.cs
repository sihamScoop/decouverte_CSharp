using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Type_Generique
{
    class Program
    {
        static void Main(string[] args)
        {
            ListeChainee<int> maListe = new ListeChainee<int>();
            maListe.Ajouter(5);
            maListe.Ajouter(10);
            maListe.Ajouter(4);
            Console.WriteLine(maListe._premier.valeur);
            Console.WriteLine(maListe._premier.suivant.valeur);
            Console.WriteLine(maListe._premier.suivant.suivant.valeur);
            Console.WriteLine("***//////////////////***");
            Console.WriteLine(maListe.ObtenirElement(0).valeur);
            Console.WriteLine(maListe.ObtenirElement(1).valeur);
            Console.WriteLine(maListe.ObtenirElement(2).valeur);
            Console.WriteLine("***//////////////////***");
            maListe.Insertion(99, 0);
            maListe.Insertion(33, 2);
            maListe.Insertion(30, 2);
            Console.WriteLine(maListe.ObtenirElement(0).valeur);
            Console.WriteLine(maListe.ObtenirElement(1).valeur);
            Console.WriteLine(maListe.ObtenirElement(2).valeur);
            Console.WriteLine(maListe.ObtenirElement(3).valeur);
            Console.WriteLine(maListe.ObtenirElement(4).valeur);
            Console.WriteLine(maListe.ObtenirElement(5).valeur);

            Console.ReadLine();
        }
    }
}
