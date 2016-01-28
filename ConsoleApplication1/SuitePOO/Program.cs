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

            ////********!debut:version3
            //List<Animal> animaux = new List<Animal>();
            //Animal chien = new Chien(); //n'ayant pas de constructeur, il appellera automatiquement le constructeur de la classe mère
            //Animal tom = new Chat("tom");
            //Animal felix = new Chat("felix");
            //animaux.Add(chien);
            //animaux.Add(tom);
            //animaux.Add(felix);

            //foreach (Animal anim in animaux)
            //{
            //    anim.Respirer();
            //}
            ////********!fin:version3

            // //********!debut:version4
            // Chien chien = new Chien { Prenom = "Max" };
            // Console.WriteLine(chien.ToString());

            // ChienMuet pauvreChien = new ChienMuet();
            //// Console.WriteLine(pauvreChien.ToString());
            // pauvreChien.Aboyer();
            // //appel de la méthode manger défini dans la classe animal et redéfini dans la classe Chien
            // chien.Manger();

            // Chien medor = new Chien();
            // Animal anim = (Animal)medor; //on a casté (converti) l'objet chien en animal 
            // //********!fin:version4

            ////********!debut:test des variables objet
            //List<Animal> animaux = new List<Animal>();
            //Chien chien = new Chien();
            //Chat chat = new Chat();
            //animaux.Add(chien);
            //animaux.Add(chat);
            //foreach (Animal anim in animaux)
            //{
            //    ////comparaison d'objet en utilisant "is"
            //    //if (anim is Chien)
            //    //{
            //    //    Chien c1Chien = (Chien)anim;
            //    //    c1Chien.Aboyer();
            //    //}
            //    //if (anim is Chat)
            //    //{
            //    //    Chat c1Chat = (Chat)anim;
            //    //    c1Chat.Miauler();
            //    //}

            //    //comparaison d'objet en utilisant "as"
            //    Chien c1Chien = anim as Chien;
            //    if (c1Chien != null)
            //    {
            //        c1Chien.Aboyer();
            //    }
            //    Chat c1Chat = anim as Chat;
            //    if (c1Chat != null)
            //    {
            //        c1Chat.Miauler();
            //    }
            //}
            ////********!fin:test des variables objet

            //********!debut:boxing et unboxing
            int i = 5;
            object obj = i; //boxing
            
            obj = 3; //la modif de obj n'implique la modification de i
            Console.WriteLine("voici la valeur de i : " + i);
            Console.WriteLine("voici la valeur de obj : " + obj);

            int j = (int)obj; //unboxing
            j = 7;
            Console.WriteLine("voici la valeur de j : " + j);
            Console.WriteLine("voici la valeur de obj : " + obj);


            Console.ReadLine();
        }
    }
}
