using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_POO
{
    class CompteCourant2:Compte
    {

        private decimal decouvert;

        private ICalculateur_Benef calculateurBenef;
        public CompteCourant2(decimal decouvert, ICalculateur_Benef calculateurBenef)
        {
            this.decouvert = decouvert;
            this.calculateurBenef=calculateurBenef;
        }

        public override decimal _solde{
            get
            {
                return calculateurBenef.CalculBenefice(base._solde);
            }
        }
        

        public override void AfficherResumer()
        {
            Console.WriteLine("*************");
            Console.WriteLine("Le compte courant de " + this._nomProprio);
            Console.WriteLine("\t Solde : " + this._solde);
            Console.WriteLine("\t découvert autorisé : " + this.decouvert);
            Console.WriteLine("\t Taux : " + calculateurBenef.Taux);
            Console.WriteLine("\n Les opérations éféctuées sur se compte sont :");
            Outils.AffichageOperations(listeOperation); //utilisation de la méthode static présente dans la classe Outils
            Console.WriteLine("*************");
        }

    }
}
