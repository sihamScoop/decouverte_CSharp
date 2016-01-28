using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_POO
{
    public class CompteCourant : Compte
    {

        private decimal decouvert;

        

        public CompteCourant(decimal decouvert)
        {
            this.decouvert = decouvert;
        }

        public CompteCourant()
        {
            // TODO: Complete member initialization
        }

        public override void AfficherResumer()
        {
            Console.WriteLine("*************");
            Console.WriteLine("Le compte courant de " + this._nomProprio);
            Console.WriteLine("\t Solde : " + this._solde);
            Console.WriteLine("\t découvert autorisé : " + this.decouvert);
            Console.WriteLine("\n Les opérations éféctuées sur se compte sont :");
            Outils.AffichageOperations(listeOperation); //utilisation de la méthode static présente dans la classe Outils
            Console.WriteLine("*************");
        }
    }
}
