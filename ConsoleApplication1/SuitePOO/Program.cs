using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuitePOO
{
    class Program
    {
        static void Main(string[] args)
        {
            ////********!debut:version1
            //Console.WriteLine("Création de l'animal");
            //Animal animal = new Animal { nombrePates = 4 };
            //animal.Respirer();
            //Console.WriteLine();

            //Console.WriteLine("Création d'un chien");
            //Chien chien = new Chien { nombrePates = 4 };
            //chien.Respirer();
            //chien.Aboyer();

            //// il est possible d'écrire 
            ////Animal animals = new Chien() { nombrePates = 4 };
            ////mais animals aura les propriétés de animal seulement

            ////********!fin:version1

            ////********!debut:version2
            //List<Animal> animaux = new List<Animal>();
            //Animal milou = new Chien("milou");
            //Animal dingo = new Chien("dingo");
            //Animal idefix = new Chien("idefix");
            //Animal tom = new Chat("tom");
            //Animal felix = new Chat("felix");

            //animaux.Add(milou);
            //animaux.Add(dingo);
            //animaux.Add(idefix);
            //animaux.Add(tom);
            //animaux.Add(felix);

            //foreach (Animal anim in animaux)
            //{
            //    anim.Respirer();
            //}
            ////********!fin:version2

            //********!debut:version3
            List<Animal> animaux = new List<Animal>();
            Animal chien = new Chien(); //n'ayant pas de constructeur, il appellera automatiquement le constructeur de la classe mère
            Animal tom = new Chat("tom");
            Animal felix = new Chat("felix");
            animaux.Add(chien);
            animaux.Add(tom);
            animaux.Add(felix);

            foreach (Animal anim in animaux)
            {
                anim.Respirer();
            }


            Console.ReadLine();
        }
    }
}
