using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_generique
{
    public static class Afficheur
    {
        ////********!debut:version1
        ////création d'une méthode da'ffichage
        //public static void Affiche(object obj)
        //{
        //    Console.WriteLine("Afficheur d'objet :");
        //    Console.WriteLine("\t Type : " + obj.GetType());
        //    Console.WriteLine("\t Représentation : " + obj.ToString());
        //}
        ////********!fin:version1

        ////********!debut:version2
        ////amélioration de la méthode précédente en utilisant une méthode générique
        //public static void Affiche<T>(T exemple)
        //{
        //    Console.WriteLine("Afficheur d'objet :");
        //    Console.WriteLine("\t Type : " + exemple.GetType());
        //    Console.WriteLine("\t Représentation : " + exemple.ToString());
        //}
        ////********!fin:version2

        //********!debut:version3
        //création d'une méthode qui prend deux variables générique en paramètres
        public static void Echanger<T> (ref T t1, ref T t2)
        {
            T temp = t1;
            t1 = t2;
            t2 = temp;
        }

        //création d'un méthode qui prends en paramètres plusieurs type génériques différents
        public static bool EstEgal<T,U>(T t, U u)
        {
            return t.Equals(u);
        }
        //********!fin:version3

        
    }
}
