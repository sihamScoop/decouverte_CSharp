﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuitePOO
{
    public class Chien : Animal  //la classe chien hérite de la classe animal
    {

        ////********!debut:version1
        //public void Aboyer()
        //{
        //    Console.WriteLine("Wouaf !");
        //}

        ////utilisation des variable de la classe mère
        //public void viellir()
        //{
        //    age++;
        //}

        //public void naissance()
        //{
        //    age = 0;
        //    estVivant = true;
        //}
        ////********!fin:version1

        ////********!debut:version2
        ////public Chien(string prenomChien)
        ////{
        ////    this.prenom = prenomChien;
        ////} // equivalent à 
        //public Chien(string prenomChien)
        //    : base(prenomChien)
        //{

        //}

        //public void Aboyer()
        //{
        //    Console.WriteLine("Wouaf !!");
        //}
        ////********!fin:version2

        //********!debut:version3
        public void Aboyer()
        {
            Console.WriteLine("Wouaf !!");
        }
    }
}
