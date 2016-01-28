using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuitePOO
{
    public class Animal
    {
        ////********!debut:version1
        //protected bool estVivant;
        //public int age;

        //public int nombrePates { get; set; }

        //public void Respirer()
        //{
        //    Console.WriteLine("je respire");
        //}
        ////********!fin:version1

        ////********!debut:version2
        //protected string prenom;

        ////ajout d'un constructeur
        //public Animal(string prenomAnimal)
        //{
        //    this.prenom = prenomAnimal;
        //}
        //public void Respirer()
        //{
        //    Console.WriteLine("Je suis " + prenom + " et je respire");
        //}
        ////********!fin:version2

        ////********!debut:version3
        //protected string prenom;
        //public Animal()
        //{
        //    prenom = "Marcel";
        //}
        //public void Respirer()
        //{
        //    Console.WriteLine("Je suis " + prenom + " et je respire");
        //}
        ////********!fin:version3

        ////********!debut:version4
        //public virtual void Manger()
        //{
        //    Console.WriteLine("Mettre les aliments dans la bouche");
        //    Console.WriteLine("Mastiquer");
        //    Console.WriteLine("Avaler");
        //    Console.WriteLine("...");
        //}
        ////********!fin:version4

        //********!debut:test des variables objet
        public void Respirer()
        {
            Console.WriteLine("je respire");
        }
       



    }
}
