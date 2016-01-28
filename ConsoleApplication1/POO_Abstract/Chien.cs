using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Abstract
{
    class Chien : Animal
    {
        public override void SeDeplacer()
        {
            Console.WriteLine("Wouaf, je me déplace à quatre pattes");
        }

        ////********!debut:version2
        //private string prenom;
        //public static int nombreInstanceChien { get; set; }
        //public Chien(string prenomChien) {
        //    this.prenom = prenomChien;
        //    nombreInstanceChien++;
        //}     
        //public void Aboyer()
        //{
        //    Console.WriteLine("Wouaf!! je suis " + this.prenom);
        //}   

        //public static int CalculerAge(int ageChien)
        //{
        //    return ageChien * 7;
        //}
        ////********!fin:version2

        //********!debut:version3
        private Ccoeur coeur = new Ccoeur();
        public void MourirM()
        {
            coeur.Stoper();
        }
        //création d'une classe interne
        protected class Ccoeur
        {
            public void Stoper() {
                Console.WriteLine("the end");
            }
        }
        //********!fin:version3
    }
}
