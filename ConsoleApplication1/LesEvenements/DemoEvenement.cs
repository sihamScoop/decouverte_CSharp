using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesEvenements
{
    public class DemoEvenement
    {
        public void Demo()
        {
            //création d'une voiture
            Voiture voiture = new Voiture { prix = 10000 };

            //création d'un délégué du même type que l'événement
            //et nous le faison pointer vers une methode qui respecte la signature du délégué
            /*
                ainsi , à chaque changement de prix, la méthode voiture_changementPrix va être appelée
                et le paramètre newPrix possèdera le nouveau pris qui vient d'être calculé            
            */
            Voiture.DelegChangementPrix delegateChangementPrix = voiture_changementPrix;
            voiture.EventChangementPrix += delegateChangementPrix; //abonnement
            //appel de la méthode qui va modifier le prix
            voiture.PromoPrix();
        }

        private void voiture_changementPrix(decimal newPrix)
        {
            Console.WriteLine("Le nouveau prix est de : " + newPrix);
        }

        //version deux: génération de Voiture_EventChangementPrix grace a l'auto-completion 
        public void Demo2()
        {
            //création d'une voiture
            Voiture voiture = new Voiture { prix = 10000 };

            Voiture.DelegChangementPrix delegateChangementPrix = Voiture_EventChangementPrix;
            voiture.EventChangementPrix += Voiture_EventChangementPrix;//abonnement
            //appel de la méthode qui va modifier le prix
            voiture.PromoPrix();
        }

        private void Voiture_EventChangementPrix(decimal nouveauPrix)
        {
            Console.WriteLine("Le nouveau prix est de : " + nouveauPrix);
        }
    }
}
