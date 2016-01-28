using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            ////********!debut:version1
            //Chien max = new Chien();
            //max.SeDeplacer();
            //max.Mourir();
            ////********!fin:version1

            // //********!debut:version2
            // Chien max = new Chien("Max");
            // max.Aboyer();
            // int ageHomme = Chien.CalculerAge(3); //appel d'une méthode static
            // Console.WriteLine(ageHomme);

            // Chien chien2 = new Chien("Max2");
            //// Chien chien3 = new Chien("Max3");
            // Console.WriteLine("nombre d'instance de la classe Chien est :" + Chien.nombreInstanceChien);
            // //********!fin:version2

            //********!debut:version3
            //voir la classe Chien et la classe ChienSamois
            //********!fin:version3

            //********!debut:version4
            //utilisation du type var pour utiliser les types anonymes
            var personnanonyme = new { nom = "voe", prenom = "Jhone", age=35 };
            Console.WriteLine(personnanonyme.nom);
            Console.WriteLine(personnanonyme.prenom);
            Console.WriteLine(personnanonyme.age);
            Console.WriteLine(personnanonyme.GetType());
            //********!fin:version4
            Console.ReadLine();
            
        }
    }
}
