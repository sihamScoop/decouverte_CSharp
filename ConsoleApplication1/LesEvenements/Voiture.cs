using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesEvenements
{
    class Voiture
    {
        //définition du délégué qui ne retourne rien et qui prend en paramètre un décimal
        public delegate void DelegChangementPrix(decimal nouveauPrix);
        //définition d'un événement basé sur ce délégué
        public event DelegChangementPrix EventChangementPrix;
        public decimal prix { get; set; }

        //définition d'une méthode qui après changement de prix, notifie les éventuels objets qui se serait abonné
        //a cet événement en invoquant l'événement et lui fournissant le nouveau prix
        //sachant qu'on test d'abord s'il y a un abonné à l'événement, avec ChangementPrix != null, avant de le lever
        public void PromoPrix()
        {
            prix = prix / 2;
            if (EventChangementPrix != null)
            {
                EventChangementPrix(prix);//déclenchement
            }
        }

    }
}
